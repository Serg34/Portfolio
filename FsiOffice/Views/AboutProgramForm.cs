using System.Windows.Forms;

namespace FSImark.UI
{
	public partial class AboutProgramForm : NoBorderForm
	{
		public AboutProgramForm()
		{
			InitializeComponent();

			var strVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
			lbVersion.Text = $"Версия {strVersion}";
		}

		private void AboutProgramForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter) Close();
		}
	}
}
