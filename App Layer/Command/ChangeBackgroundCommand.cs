using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace App_Layer.Command
{
    public class ChangeBackgroundCommand : Command
    {
        private readonly Brush _color;
        private readonly Brush _prevColor;
        internal ChangeBackgroundCommand(params object[] commandParameters)
        {
            if(commandParameters.Length > 0)
            {
                _color = (Brush)commandParameters[0];
            }
            if(commandParameters.Length > 1)
            {
                _prevColor = (Brush)commandParameters[1];
            }
        }
        public override bool Execute()
        {
            TargetDrawing?.ChangeClassBackgroundColor(_color);
            return true;
        }

        internal override void Undo()
        {
            TargetDrawing?.ChangeClassBackgroundColor(_prevColor);
        }

        internal override void Redo()
        {
            TargetDrawing?.ChangeClassBackgroundColor(_color);
        }
    }
}
