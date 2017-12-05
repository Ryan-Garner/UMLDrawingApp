
using System.Drawing;
using System.Runtime.Serialization;

namespace App_Layer.DrawingComponents
{
    [DataContract]
    public class ClassBox : Element
    {


        [DataMember]
        public Point Corner { get; set; }
        [DataMember]
        public Size Size { get; set; }
        [DataMember]
        public string Label { get; set; }
        [DataMember]
        public float fontSize { get; set; } = 16;
        [DataMember]
        public bool isBold { get; set; } = false;
        [DataMember]
        public Brush fillColor { get; set; } = Brushes.White;
        public Pen LinePen { get; set; } = new Pen(Color.Black);
        public Font TextFont { get; set; } = new Font("Arial", 16);
        public Brush TextBrush { get; set; } = Brushes.Black;
        public Brush FillBrush { get; set; } = Brushes.White;
        public int Padding { get; set; } = 2;

        public override Element Clone()
        {
            return new ClassBox() { Corner = Corner, Size = Size, Label = Label };
        }

        public override void Draw(Graphics graphics)
        {
            LinePen = new Pen(lineColor);
            if(isBold)
            {
                TextFont = new Font("Arial", fontSize);
            }
            FillBrush = fillColor;
 
            if (graphics == null) return;

            var box = new Rectangle() { Location = Corner, Size = Size };
            graphics.FillRectangle(FillBrush, box);

            if (IsSelected)
            {
                
                var g = new GraphicsWithSelection() { MyGraphics = graphics };
                g.DrawSelectionBox(Corner, Size);
            }
            else
                graphics.DrawRectangle(LinePen, box);

            var minimumSize = graphics.MeasureString("...", TextFont);
            if (Size.Width < minimumSize.Width - Padding * 2 ||
                Size.Height < minimumSize.Height - Padding * 2) return;

            var formatter = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter
            };

            var textRectangle = new RectangleF(Corner.X + Padding, Corner.Y + Padding, Size.Width - Padding * 2, Size.Height - Padding * 2);

            graphics.DrawString(Label, TextFont, TextBrush, textRectangle, formatter);

            
        }

        public override bool ContainsPoint(Point point)
        {
            return point.X >= Corner.X &&
                   point.Y >= Corner.Y &&
                   point.X < Corner.X + Size.Width &&
                   point.Y < Corner.Y + Size.Height;
        }
    }
}
