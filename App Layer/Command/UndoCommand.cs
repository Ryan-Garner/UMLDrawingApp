using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Layer.Command
{
    class UndoCommand : Command
    {
        public override bool Execute()
        {
            // Do Nothing, since its execution will be handled by the Invoker directly
            return false;
        }

        internal override void Undo()
        {
            // Do Nothing
        }

        internal override void Redo()
        {
            // Do Nothing
        }
    }
}
