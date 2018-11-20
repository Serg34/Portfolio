using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace FSImark.UI
{
	public partial class MainForm : Form
	{
		private Dictionary<TreeNode, MainPanelItem> mMap;
		private MainPanelItem mLastPanelItem;

		public MainForm()
		{
			InitializeComponent();
			mMap = new Dictionary<TreeNode, MainPanelItem>();
			treeViewMenu.AfterSelect += TreeViewMenu_AfterSelect;
			mLastPanelItem = null;

			InitializeTree("FSImark.UI");
		}

		private void InitializeTree(string nameSpace)
		{
			treeViewMenu.Nodes.Clear();

			var types = Assembly.GetExecutingAssembly().GetTypes()
				.Where(x => x.GetCustomAttribute<MainPanelAttribute>() != null)
				.Where(x => x.Namespace.StartsWith(nameSpace))
				.OrderBy(x => x.Namespace)
				.ThenBy(x => x.Name)
				.Select(x => new { Type = x, Title = x.GetCustomAttribute<MainPanelAttribute>().Title })
				.ToList();

			var panels = types
				.Select(x => new MainPanelItem(x.Type, x.Title))
				.ToList();

			ILookup<string, MainPanelItem> panelsByPath = panels.ToLookup(x => x.Path);

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
				if (mMap.TryGetValue(e.Node, out var panelItem))
					SelectPanelItem(panelItem);
			}
		}

		private void SelectPanelItem(MainPanelItem panelItem)
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

		private void btAboutProgram_Click(object sender, System.EventArgs e)
		{
			using (var form = new AboutProgramForm())
				form.ShowDialog(this);
		}

		private void btHelp_Click(object sender, System.EventArgs e)
		{
			using (var form = new Help.UI.HelpForm())
				form.ShowDialog(this);
		}

		private void btAllApps_Click(object sender, System.EventArgs e)
		{
			var version = Assembly.GetExecutingAssembly().GetName().Version;
			using (var form = new Market.FSImarkAppsForm(Application.ProductName, version))
				form.ShowDialog(this);
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			if (e == null) throw new System.ArgumentNullException(nameof(e));

			base.OnKeyDown(e);
			if (e.KeyCode == Keys.F1)
				using (var form = new Help.UI.HelpForm())
					form.ShowDialog(this);
		}
	}
}
