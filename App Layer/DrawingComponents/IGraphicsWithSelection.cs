using System.Drawing;

namespace App_Layer.DrawingComponents
{
    interface IGraphicsWithSelection
    {
        void DrawSelectionBox(Point location, Size size);
        void DrawSelectionLine(Point start, Point end);
    }
}
