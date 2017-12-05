using App_Layer.DrawingComponents;

namespace App_Layer.Command
{
    public class CommandFactory
    {
        private static CommandFactory _instance;
        private static readonly object MyLock = new object();

        public static CommandFactory Instance
        {
            get
            {
                lock (MyLock)
                {
                    if (_instance == null)
                        _instance = new CommandFactory();
                }
                return _instance;
            }
        }

        public Drawing TargetDrawing { get; set; }
        public Invoker Invoker { get; set; }

        public virtual void CreateAndDo(string commandType, params object[] commandParameters)
        {
            if (string.IsNullOrWhiteSpace(commandType)) return;

            if (TargetDrawing == null) return;

            Command command = null;
            switch (commandType.Trim().ToUpper())
            {
                case "NEW":
                    command = new NewCommand();
                    break;
                case "ADDCLASS":
                    command = new AddClassCommand(commandParameters);
                    break;
                case "ADDLINE":
                    command = new AddLineCommand(commandParameters);
                    break;
                case "SELECT":
                    command = new SelectCommand(commandParameters);
                    break;
                case "DESELECT":
                    command = new DeselectAllCommand();
                    break;
                case "REMOVE":
                    command = new RemoveSelectedCommand();
                    break;
                case "LOAD":
                    command = new LoadCommand(commandParameters);
                    break;
                case "SAVE":
                    command = new SaveCommand(commandParameters);
                    break;
                case "BACKGROUND":
                    command = new ChangeBackgroundCommand(commandParameters);
                    break;
                case "FOREGROUND":
                    command = new ChangeForegroundColorCommand(commandParameters);
                    break;
                case "LINETHICKNESS":
                    command = new ChangeLineThicknessCommand(commandParameters);
                    break;
            }

            if (command != null)
            {
                command.TargetDrawing = TargetDrawing;
                Invoker.EnqueueCommandForExecution(command);
            }
        }
    }
}
