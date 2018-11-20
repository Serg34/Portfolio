using System;
using System.Windows.Forms;

namespace FSImark.Help.UI
{
	interface IHelpPanel { }

	[AttributeUsage(validOn: AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	sealed class HelpPanelAttribute : Attribute
	{
		public HelpPanelAttribute(string title)
		{
			Title = title;
		}

		public string Title { get; }
	}
	class HelpPanelItem
	{
		public HelpPanelItem(Type panelType, string title)
		{
			Title = title;
			this.panelType = panelType;
			Node = new TreeNode(title);
		}

		private Type panelType;
		private Control mControl;

		public string Title { get; private set; }
		public string Path { get { return panelType.Namespace.Replace('.', System.IO.Path.DirectorySeparatorChar); } }
		public TreeNode Node { get; private set; }

		internal Control GetControl()
		{
			return mControl ?? (mControl = (Control)Activator.CreateInstance(panelType));
		}
	}
}
