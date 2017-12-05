using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;

namespace App_Layer.DrawingComponents
{
    public class Drawing
    {
        private static readonly DataContractJsonSerializer JsonSerializer =
                new DataContractJsonSerializer(typeof(List<Element>), new[] { typeof(Element), typeof(ClassBox), typeof(Line)});

        private readonly List<Element> _elements = new List<Element>();
        private readonly List<ClassBox> _classes = new List<ClassBox>();
        private readonly List<Line> _lines = new List<Line>();
        private readonly List<Line> _binary = new List<Line>();
        private readonly List<Line> _agg_comp = new List<Line>();
        private readonly List<Line> _gen = new List<Line>();
        private readonly List<Line> _dependency = new List<Line>();
        private Color lineColor = Color.Black;
        private Brush fillColor = Brushes.White;
        private int lineThickness = 3;
        private readonly object _myLock = new object();

        public bool IsDirty { get; set; } = true;
        public Color panelColor { get; set; } = Color.White;
        
       

        public List<Element> GetCloneOfElements()
        {
            var cloneList = new List<Element>();
            lock (_myLock)
            {
                cloneList.AddRange(_elements.Select(element => element.Clone()));
            }

            return cloneList;
        }

        public void Clear()
        {
            lock (_myLock)
            {
                _elements.Clear();
                _classes.Clear();
                _dependency.Clear();
                _gen.Clear();
                _dependency.Clear();
                _agg_comp.Clear();
                IsDirty = true;
            }
        }

        public void LoadFromStream(Stream stream)
        {
            var loadedElements = JsonSerializer.ReadObject(stream) as List<Element>;

            if (loadedElements == null || loadedElements.Count == 0) return;

            lock (_myLock)
            {
                // Since only the extrinsic state is saved, recreate the full tree objects
                foreach (var element in loadedElements)
                {
                    _elements.Add(element);
                }
                IsDirty = true;
            }
        }

        public void SaveToStream(Stream stream)
        {
            lock (_myLock)
            {
                JsonSerializer.WriteObject(stream, _elements);
            }
        }

        public void Add(Element element, string eType = "")
        {
            if (element == null) return;

            lock (_myLock)
            {
                ClassBox tmp1 = new ClassBox();
                Line tmp2 = new Line();
                if(eType == "Class")
                {
                    tmp1 = (ClassBox)element;
                    
                        tmp1.fillColor = fillColor;
                        tmp1.lineColor = lineColor;
                    
                    _classes.Add(tmp1);
                    _elements.Add(tmp1);
                }
                if(eType == "Binary")
                {
                    tmp2 = (Line)element;
                    tmp2.lineColor = lineColor;
                    tmp2.lineThickness = lineThickness;
                    
                    _binary.Add(tmp2);
                    _lines.Add(tmp2);
                    _elements.Add(tmp2);
                }
                if(eType == "Aggregation" || eType == "Composition")
                {
                    tmp2 = (Line)element;
                    if (_agg_comp.Count > 0)
                    {
                        tmp2.lineColor = lineColor;
                    }
                    _agg_comp.Add(tmp2);
                    _lines.Add(tmp2);
                    _elements.Add(tmp2);
                }
                if(eType == "Genspec")
                {
                    tmp2 = (Line)element;
                    if (_gen.Count > 0)
                    {
                        tmp2.lineColor = lineColor;
                    }
                    _gen.Add(tmp2);
                    _lines.Add(tmp2);
                    _elements.Add(tmp2);
                }
                if(eType == "Dependency")
                {
                    tmp2 = (Line)element;
                    if (_dependency.Count > 0)
                    {
                        tmp2.lineColor = lineColor;
                    }
                    _dependency.Add(tmp2);
                    _lines.Add(tmp2);
                    _elements.Add(tmp2);
                }
                IsDirty = true;
            }
        }

        public void DeleteElement(Element element, string eType = "")
        {
            lock (_myLock)
            {
                _elements.Remove(element);
                IsDirty = true;
            }
        }

        public List<Element> DeleteAllSelected()
        {
            List<Element> elementsToDelete;
            lock (_myLock)
            {
                elementsToDelete = _elements.FindAll(t => t.IsSelected);
                _elements.RemoveAll(t => t.IsSelected);
                IsDirty = true;
            }

            return elementsToDelete;
        }

        public Element FindElementAtPosition(Point point)
        {
            Element result;
            lock (_myLock)
            {
                result = _elements.FindLast(t => t.ContainsPoint(point));
            }
            return result;
        }

        public List<Element> DeselectAll()
        {
            var selectedElements = new List<Element>();
            lock (_myLock)
            {
                foreach (var t in _elements)
                {
                    if (t.IsSelected)
                    {
                        selectedElements.Add(t);
                        t.IsSelected = false;
                    }
                }
                IsDirty = true;
            }
            return selectedElements;
        }
        public void ChangeClassBackgroundColor(Brush color)
        {
            fillColor = color;
            foreach(var e in _classes)
            {
                if(e is ClassBox)
                {
                    e.fillColor = color;
                }
            }
        }
        public void ChangeForegroundColor(Color color)
        {
            lineColor = color;
            foreach(var e in _elements)
            {
                e.lineColor = color;
            }
        }

        public void ChangeLineThickness(int size)
        {
            lineThickness = size;
            foreach(Line e in _lines)
            {
                e.lineThickness = size;
            }
        }

        public bool Draw(Graphics graphics, bool redrawEvenIfNotDirty = false)
        {
            lock (_myLock)
            {
                if (!IsDirty && !redrawEvenIfNotDirty) return false;

                graphics.Clear(panelColor);
                foreach (var t in _elements)
                    t.Draw(graphics);
                IsDirty = false;
            }
            return true;
        }
    }
}
