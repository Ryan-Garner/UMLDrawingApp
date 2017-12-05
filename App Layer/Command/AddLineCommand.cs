using System.Drawing;
using App_Layer.DrawingComponents;

namespace App_Layer.Command
{
    public class AddLineCommand : Command
    {
        private readonly Point? _start;
        private readonly Point? _end;
        private readonly string _type;
        private readonly string _label;
        private Element _line;
        internal AddLineCommand() { }

        /// <summary>
        /// Constructor
        /// 
        /// </summary>
        /// <param name="commandParameters">An array of parameters, where
        ///     [1]: Point      start of the line
        ///     [2]: Point      end of the line
        /// </param>
        internal AddLineCommand(params object[] commandParameters)
        {
            if (commandParameters.Length > 0)
                _start = (Point)commandParameters[0];

            if (commandParameters.Length > 1)
                _end = (Point)commandParameters[1];

            if (commandParameters.Length > 2)
                _type = (string)commandParameters[2];

            if (commandParameters.Length > 3)
                _label = (string)commandParameters[3];
        }

        public override bool Execute()
        {
            if (_start == null || _end == null) return false;

            _line = new Line() { Start = (Point)_start, End = (Point)_end, LineType = (string)_type, label = (string)_label };
            TargetDrawing.Add(_line, _type);

            return true;
        }

        internal override void Undo()
        {
            TargetDrawing.DeleteElement(_line, _type);
        }

        internal override void Redo()
        {
            TargetDrawing.Add(_line, _type);
        }

    }
}
