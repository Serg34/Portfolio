using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace FSImark.Help.UI
{
	public partial class HelpForm : Form
	{
		private Dictionary<TreeNode, HelpPanelItem> mMap;
		private HelpPanelItem mLastPanelItem;

		public HelpForm()
		{
			InitializeComponent();
			mMap = new Dictionary<TreeNode, HelpPanelItem>();
			treeViewMenu.AfterSelect += TreeViewMenu_AfterSelect;
			mLastPanelItem = null;

			InitializeTree("FSImark.Help");
		}

		private void InitializeTree(string nameSpace)
		{
			treeViewMenu.Nodes.Clear();

			var types = Assembly.GetExecutingAssembly().GetTypes()
				.Where(x => x.GetCustomAttribute<HelpPanelAttribute>() != null)
				.Where(x => x.Namespace.StartsWith(nameSpace))
				.Where(x => typeof(IHelpPanel).IsAssignableFrom(x))
				.OrderBy(x => x.Namespace)
				.ThenBy(x => x.Name)
				.Select(x => new { Type = x, Title = x.GetCustomAttribute<HelpPanelAttribute>().Title })
				.ToList();

			var panels = types
				.Select(x => new HelpPanelItem(x.Type, x.Title))
				.ToList();

			ILookup<string, HelpPanelItem> panelsByPath = panels.ToLookup(x => x.Path);

			foreach (var panel in panels)
			{
				string path = panel.Path;
				string pathTop = System.IO.Path.GetDirectoryName(path);

				foreach (var parent in panelsByPath[pathTop])
					parent.Node.Nodes.Add(panel.Node);
			}

			var rootItems = panels.Where(x => x.Node.Parent == null).ToList();
			treeViewMenu.Nodes.AddRange(rootItems.Select(x => x.Node).ToArray());

			mMap.Clear();

			foreach (var panel in panels)
				mMap.Add(panel.Node, panel);

			treeViewMenu.ExpandAll();
			treeViewMenu.SelectedNode = treeViewMenu.Nodes[0];
			SelectPanelItem(rootItems.ElementAt(0));
		}

		private void TreeViewMenu_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Action == TreeViewAction.ByKeyboard || e.Action == TreeViewAction.ByMouse)
			{
				HelpPanelItem panelItem;

				if (mMap.TryGetValue(e.Node, out panelItem))
					SelectPanelItem(panelItem);
			}
		}
		private void SelectPanelItem(HelpPanelItem panelItem)
		{
			Control controlNew = panelItem.GetControl();

			if (controlNew != null)
			{
				if (mLastPanelItem != null)
					RemovePreviousPanel();

				this.panelItem.Controls.Clear();
				this.panelItem.Controls.Add(controlNew);
				controlNew.Dock = DockStyle.Fill;
				controlNew.Visible = true;

				mLastPanelItem = panelItem;
			}
		}
		private void RemovePreviousPanel()
		{
			mLastPanelItem.GetControl().Visible = false;
		}
	}
}
