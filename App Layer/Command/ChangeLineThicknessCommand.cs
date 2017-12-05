using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Layer.Command
{
    public class ChangeLineThicknessCommand : Command
    {
        private int lineThickness;
        private int prevLineThickness;
        internal ChangeLineThicknessCommand(params object[] commandParameters)
        {
            if(commandParameters.Length > 0)
            {
                lineThickness = (int)commandParameters[0];
            }
            if(commandParameters.Length > 1)
            {
                prevLineThickness = (int)commandParameters[1];
            }
        }
        public override bool Execute()
        {
            TargetDrawing?.ChangeLineThickness(lineThickness);
            return true;
        }

        internal override void Undo()
        {
            TargetDrawing?.ChangeLineThickness(prevLineThickness);
        }

        internal override void Redo()
        {
            TargetDrawing?.ChangeLineThickness(lineThickness);
        }
    }
}
