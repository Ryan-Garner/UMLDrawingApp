
using System.Drawing;

namespace App_Layer.Command
{
    public class ChangeForegroundColorCommand : Command
    {
        private readonly Color _color;
        private readonly Color _prevColor;
        internal ChangeForegroundColorCommand(params object[] commandParameters)
        {
            if (commandParameters.Length > 0)
            {
                _color = (Color)commandParameters[0];
            }
            if (commandParameters.Length > 1)
            {
                _prevColor = (Color)commandParameters[1];
            }
        }
        public override bool Execute()
        {
            TargetDrawing?.ChangeForegroundColor(_color);
            return true;
        }

        internal override void Undo()
        {
            TargetDrawing?.ChangeForegroundColor(_prevColor);
        }

        internal override void Redo()
        {
            TargetDrawing?.ChangeForegroundColor(_color);
        }
    }
}
