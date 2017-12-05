using System.Drawing;
using System.Runtime.Serialization;

namespace App_Layer.DrawingComponents
{
    [DataContract]
    public abstract class Element
    {
        [DataMember]
        public Color lineColor { get; set; } = Color.Black;
        [DataMember]
        public virtual bool IsSelected { get; set; } = false;

        public abstract Element Clone();

        public virtual void Draw(Graphics graphics) { }

        public virtual bool ContainsPoint(Point point) { return false; }
    }
}
