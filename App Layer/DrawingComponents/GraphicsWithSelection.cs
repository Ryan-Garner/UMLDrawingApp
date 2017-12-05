using System.Drawing;

namespace App_Layer.DrawingComponents
{
    class GraphicsWithSelection : IGraphicsWithSelection
    {
        public static Brush HandleBrush { get; set; } = new SolidBrush(Color.Black);
        public static int HandleHalfSize { get; set; } = 3;
        public static Pen SelectionLinePen { get; set; } = new Pen(Color.DarkGray);


        public Graphics MyGraphics { get; set; }
        public void DrawSelectionBox(Point location, Size size)
        {
            MyGraphics.DrawRectangle(SelectionLinePen, location.X, location.Y, size.Width, size.Height);

            DrawActionHandle(location.X, location.Y);
            DrawActionHandle(location.X + size.Width, location.Y);
            DrawActionHandle(location.X, location.Y + size.Height);
            DrawActionHandle(location.X + size.Width, location.Y + size.Height);
        }

        public void DrawSelectionLine(Point start, Point end)
        {
            MyGraphics.DrawLine(SelectionLinePen, start, end);
            DrawActionHandle(start.X, start.Y);
            DrawActionHandle(end.X, end.Y);
        }

        protected void DrawActionHandle(int x, int y)
        {
            MyGraphics.FillRectangle(HandleBrush, x - HandleHalfSize, y - HandleHalfSize, HandleHalfSize * 2, HandleHalfSize * 2);
        }
    }
}
