using System;
using System.Windows.Forms;

namespace FSImark.UI
{
	#region IMessageService
	public interface IMessageService
	{
		void ShowMessage(string message);
		void ShowError(string message);
		void ReportException<TException>(TException ex) where TException : Exception;
		void ReportException<TException>(string header, TException ex) where TException : Exception;
		DialogResult ShowQuestion(string message);
	}
	#endregion

	public class MessageService : IMessageService
	{
		private readonly static bool isRightToLeft = Application.CurrentCulture.TextInfo.IsRightToLeft;

		public void ShowMessage(string message)
		{
			MessageBox.Show(
				message,
				Application.ProductName,
				MessageBoxButtons.OK,
				MessageBoxIcon.Information,
				MessageBoxDefaultButton.Button1,
				(isRightToLeft ? MessageBoxOptions.RtlReading : 0)
				);
		}

		public void ShowExclamation(string message)
		{
			MessageBox.Show(
				message,
				Application.ProductName,
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation,
				MessageBoxDefaultButton.Button1,
				(isRightToLeft ? MessageBoxOptions.RtlReading : 0)
				);
		}

		public void ShowError(string message)
		{
			MessageBox.Show(
				message,
				Application.ProductName,
				MessageBoxButtons.OK,
				MessageBoxIcon.Error,
				MessageBoxDefaultButton.Button1,
				(isRightToLeft ? MessageBoxOptions.RtlReading : 0)
				);
		}
		public void ReportException<TException>(TException ex) where TException : Exception
		{
#if Debug
			MessageBox.Show(
				$"Тип ошибки: {ex.GetType()}\n{ex.Message}\n{ex.InnerException}\n{ex.StackTrace}",
				Application.ProductName,
				MessageBoxButtons.OK,
				MessageBoxIcon.Error,
				MessageBoxDefaultButton.Button1,
				(isRightToLeft ? MessageBoxOptions.RtlReading : 0)
				);
#else
			var message = $"{ex.Message}\n\nВозможные решения смотрите в меню \"Справка\" раздел \"Проблемы\"";
			MessageBox.Show(
				$"Тип ошибки: {ex.GetType()}\n{message}\n{ex.InnerException}",
				Application.ProductName,
				MessageBoxButtons.OK,
				MessageBoxIcon.Error,
				MessageBoxDefaultButton.Button1,
				(isRightToLeft ? MessageBoxOptions.RtlReading : 0)
				);
#endif
		}
		public void ReportException<TException>(string header, TException ex) where TException : Exception
		{
#if Debug
			MessageBox.Show(
				$"{header}\nТип ошибки: {ex.GetType()}\n{ex.Message}\n{ex.InnerException}\n{ex.StackTrace}",
				Application.ProductName,
				MessageBoxButtons.OK,
				MessageBoxIcon.Error,
				MessageBoxDefaultButton.Button1,
				(isRightToLeft ? MessageBoxOptions.RtlReading : 0)
				);
#else
			MessageBox.Show(
				$"{header}\nТип ошибки: {ex.GetType()}\n{ex.Message}\n{ex.InnerException}",
				Application.ProductName,
				MessageBoxButtons.OK,
				MessageBoxIcon.Error,
				MessageBoxDefaultButton.Button1,
				(isRightToLeft ? MessageBoxOptions.RtlReading : 0)
				);
#endif
		}

		public DialogResult ShowQuestion(string message)
		{
			return MessageBox.Show(
				message,
				Application.ProductName,
				MessageBoxButtons.YesNoCancel,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button1,
				(isRightToLeft ? MessageBoxOptions.RtlReading : 0)
				);
		}
	}
}
