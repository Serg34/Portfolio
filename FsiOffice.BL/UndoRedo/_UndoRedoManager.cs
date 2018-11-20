using System.Collections.Generic;
using System.Linq;

namespace FSImark.UndoRedo
{
	public class UndoRedoManager
	{
		private Stack<ICommand> undoStack = new Stack<ICommand>();
		private Stack<ICommand> redoStack = new Stack<ICommand>();

		public int UndoCount { get => undoStack.Count; }

		public bool CanUndo { get => undoStack.Count > 0; }
		public bool CanRedo { get => redoStack.Count > 0; }

		public IEnumerable<string> UndoItems { get => undoStack.Select(c => c.Name); }
		public IEnumerable<string> RedoItems { get => redoStack.Select(c => c.Name); }

		public void Execute(ICommand command)
		{
			undoStack.Push(command);
			redoStack.Clear();
			command.Execute();
		}

		public void Undo(int count = 1)
		{
			for (int i = 0; i < count; i++) Undo();
		}
		public void Redo(int count = 1)
		{
			for (int i = 0; i < count; i++) Redo();
		}

		private void Undo()
		{
			var command = undoStack.Pop();
			redoStack.Push(command);
			command.UnExecute();
		}
		private void Redo()
		{
			var command = redoStack.Pop();
			undoStack.Push(command);
			command.Execute();
		}
	}
}