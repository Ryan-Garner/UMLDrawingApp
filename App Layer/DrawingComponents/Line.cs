using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;

namespace App_Layer.DrawingComponents
{
    [DataContract]
    public class Line : Element
    {
        [DataMember]
        public Point Start { get; set; }
        [DataMember]
        public Point End { get; set; }
        [DataMember]
        public string LineType { get; set; }
        [DataMember]
        public string label { get; set; }
        [DataMember]
        public  int lineThickness = 3;
        [DataMember]
        public int capHeight { get; set; } = 6;
        [DataMember]
        public int capWidth { get; set; } = 3;
        public Pen RegularPen { get; set; } = new Pen(Color.Black, 3);
        public Font TextFont { get; set; } = new Font("Arial", 16);
        public Brush TextBrush { get; set; } = Brushes.Black;
        public int SelectionMargin { get; set; } = 2;


        public override Element Clone()
        {
            return new Line() { Start = Start, End = End };
        }

        public override void Draw(Graphics graphics)
        {
            GraphicsPath hPath = new GraphicsPath();
            
            // Create the outline for our custom end cap.
            /*hPath.AddLine(new Point(0, 0), new Point(0, -5));
            hPath.AddLine(new Point(0, -5), new Point(5, -1));
            hPath.AddLine(new Point(5, -1), new Point(3, -1));*/
            ; 
            if (LineType == "Aggregation")
            {
                
                Point p1 = new Point(0, 0);
                Point p2 = new Point(-capWidth, -capHeight);
                Point p3 = new Point(0, -(2*capHeight));
                Point p4 = new Point(capWidth, -capHeight);
                Point[] pD = { p1, p2, p3, p4 };
                //FillMode newFillMode = FillMode.Winding;
                
                hPath.AddPolygon(pD);
                
            }
            if(LineType == "Composition")
            {
                
                Point p1 = new Point(0, 0);
                Point p2 = new Point(-capWidth, -capHeight);
                Point p3 = new Point(0, -(2 * capHeight));
                Point p4 = new Point(capWidth, -capHeight);
                Point[] pD = { p1, p2, p3, p4 };
                //FillMode newFillMode = FillMode.Winding;
                
                hPath.AddPolygon(pD);
                

            }
            if(LineType == "Genspec")
            {
                
                Point p1 = new Point(0, 0);
                Point p2 = new Point(-capWidth, -capHeight);
                //Point p3 = new Point(0, -(2 * capHeight));
                Point p4 = new Point(capWidth, -capHeight);
                Point[] pD = { p1, p2, p4 };
                //FillMode newFillMode = FillMode.Winding;

                hPath.AddPolygon(pD);
                

            }
            if(LineType == "Dependency")
            {
                hPath.AddLine(new Point(0, 0), new Point(-capWidth, -capHeight));
                hPath.AddLine(new Point(0, 0), new Point(capWidth, -capHeight));
                

            }
            
            
            hPath.FillMode = FillMode.Winding;
            Pen customCapPen = new Pen(lineColor, lineThickness);
            CustomLineCap HookCap; 
            if (LineType == "Composition")
            {
                HookCap = new CustomLineCap(hPath, null);
                customCapPen.CustomStartCap = HookCap;
            }
            else
            {
                HookCap = new CustomLineCap(null, hPath);
                customCapPen.CustomStartCap = HookCap;
            }
            

            //CustomLineCap HookCap = new CustomLineCap(hPath, hPath);

            
            if(LineType == "Dependency")
            {
                customCapPen.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
            }

            LineCap startCap;
            LineCap endCap;
            HookCap.GetStrokeCaps(out startCap, out endCap);
            RegularPen.StartCap = startCap;
            Point[] points = { new Point(Start.X, Start.Y), new Point(End.X, End.Y) };
            //RegularPen.SetLineCap(System.Drawing.Drawing2D.LineCap.Custom, System.Drawing.Drawing2D.LineCap.NoAnchor, System.Drawing.Drawing2D.DashCap.Flat);
            if (graphics == null) return;

            if (IsSelected)
            {
                var g = new GraphicsWithSelection() { MyGraphics = graphics };
                g.DrawSelectionLine(Start, End);
            }
            else
            {
                //graphics.DrawLine(RegularPen, Start, End);
                graphics.DrawLines(customCapPen, points);
                if (LineType == "Binary")
                {
                    graphics.DrawString(label, TextFont, TextBrush, (Start.X +End.X)/2, (Start.Y+End.Y)/2);
                }

            }
        }

        public override bool ContainsPoint(Point point)
        {
            // See https://en.wikipedia.org/wiki/Distance_from_a_point_to_a_line
            
            var minX = Math.Min(Start.X, End.X) - SelectionMargin;
            var maxX = Math.Max(Start.X, End.X) + SelectionMargin;
            var minY = Math.Min(Start.Y, End.Y) - SelectionMargin;
            var maxY = Math.Max(Start.Y, End.Y) + SelectionMargin;

            if (point.X < minX || point.Y < minY || point.X > maxX || point.Y > maxY) return false;

            var distance =
                Math.Abs((End.Y - Start.Y) * point.X - (End.X - Start.X) * point.Y + End.X * Start.Y - End.Y * Start.X) /
                Math.Sqrt(Math.Pow(Convert.ToDouble(End.Y) - Convert.ToDouble(Start.Y), 2) +
                          Math.Pow(Convert.ToDouble(End.X) - Convert.ToDouble(Start.X), 2));
            if(distance <= SelectionMargin)
            {
                var t2o = 2;
            }

            return distance <= SelectionMargin;
        }

    }
}
