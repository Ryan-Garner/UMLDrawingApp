using System;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;

using App_Layer.DrawingComponents;
using App_Layer.Command;


namespace UML_Drawing_App
{
    public partial class MainForm : Form
    {
        private readonly Drawing _drawing;
        private bool _forceRedraw;
        private readonly Invoker _invoker = new Invoker();
        private bool _showRubberBand;
        private bool _eraseLastRubberBand;
        private string _lineType;
        private Brush pColor = Brushes.White;
        private Brush currColor = Brushes.White;
        private Color panelColor = Color.White;
        private Color pfColor = Color.White;
        private Color currfColor = Color.White;
        private int currLineThickness = 3;
        private int prevLineThickness = 3;
        private Point _startingPoint;
        private Point _lastRubberBandEnd;
        private Point _rubberBandStart;
        private Point _rubberBandEnd;

        private enum PossibleModes
        {
            None,
            ClassDrawing,
            Line,
            BinaryLine,
            Settings,
            Selection
        };

        private PossibleModes _mode = PossibleModes.None;

        private Bitmap _imageBuffer;
        private Graphics _imageBufferGraphics;
        private Graphics _panelGraphics;

        public MainForm()
        {
            InitializeComponent();
            _drawing = new Drawing();
            CommandFactory.Instance.TargetDrawing = _drawing;
            CommandFactory.Instance.Invoker = _invoker;

            _invoker.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayDrawing();
        }

        private void DisplayDrawing()
        {
            
            if (_imageBuffer == null)
            {
                _imageBuffer = new Bitmap(drawingPanel.Width, drawingPanel.Height);
                _imageBufferGraphics = Graphics.FromImage(_imageBuffer);
                _panelGraphics = drawingPanel.CreateGraphics();
            }
            if (_drawing.Draw(_imageBufferGraphics, _forceRedraw))
                _panelGraphics.DrawImageUnscaled(_imageBuffer, 0, 0);
            drawingPanel.BackColor = panelColor;
            _forceRedraw = false;

        }

        

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            switch (_mode)
            {
                case PossibleModes.ClassDrawing:
                    {
                        var form = new ClassNameForm
                        {
                            DesktopLocation =
                                new Point(ClientRectangle.Left + e.Location.X,
                                    ClientRectangle.Top + e.Location.Y)
                        };

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var minX = Math.Min(_startingPoint.X, e.Location.X);
                            var maxX = Math.Max(_startingPoint.X, e.Location.X);
                            var minY = Math.Min(_startingPoint.Y, e.Location.Y);
                            var maxY = Math.Max(_startingPoint.Y, e.Location.Y);

                            var size = new Size() { Width = maxX - minX, Height = maxY - minY };
                            CommandFactory.Instance.CreateAndDo("addclass", form.NameText, _startingPoint, size);
                        }
                        break;
                    }
                case PossibleModes.BinaryLine:
                    {
                        var form = new BinaryLabel
                        {
                            DesktopLocation =
                                new Point(ClientRectangle.Left + e.Location.X,
                                    ClientRectangle.Top + e.Location.Y)
                        };
                        if(form.ShowDialog() == DialogResult.OK)
                        {
                            AddRelation(e.Location, form.LabelText);
                        }
                    }
                    break;
                case PossibleModes.Settings:
                    {
                        
                    }
                    break;
                case PossibleModes.Line:
                    AddRelation(e.Location);
                    //CommandFactory.Instance.CreateAndDo("addline", _startingPoint, e.Location);
                    break;
                case PossibleModes.Selection:
                    CommandFactory.Instance.CreateAndDo("select", e.Location);
                    break;
            }
            _showRubberBand = false;
            _eraseLastRubberBand = false;
        }

        private void AddRelation(Point endPoint, string label = "")
        {
            
            
            var line = new Line() { Start = (Point)_startingPoint, End = (Point)endPoint };
            ClassBox class1 = (ClassBox)_drawing.FindElementAtPosition(_startingPoint);
            ClassBox class2 = (ClassBox)_drawing.FindElementAtPosition(endPoint);
            //Find where line crosses starting box.

            Point start = FindPointOnLine(class1, line);
            Point end = FindPointOnLine(class2, line);
            CommandFactory.Instance.CreateAndDo("addline", start, end, _lineType, label);
        }

        private Point FindPointOnLine(ClassBox box, Line line)
        {
            Point point = new Point(-1000, -1000);
            if (box != null)
            {
                for (int i = box.Corner.Y; i < box.Corner.Y + box.Size.Height; i++)
                {
                    if (line.ContainsPoint(new Point(box.Corner.X, i)))
                    {
                        point = new Point(box.Corner.X, i);
                        return point;
                    }
                }
                for (int i = box.Corner.X; i < box.Corner.X + box.Size.Width; i++)
                {
                    if (line.ContainsPoint(new Point(i, box.Corner.Y)))
                    {
                        point = new Point(i, box.Corner.Y);
                        return point;
                    }
                }
                for (int i = box.Corner.Y; i < box.Corner.Y + box.Size.Height; i++)
                {
                    if (line.ContainsPoint(new Point(box.Corner.X + box.Size.Width, i)))
                    {
                        point = new Point(box.Corner.X + box.Size.Width, i);
                        return point;
                    }
                }
                for (int i = box.Corner.X; i < box.Corner.X + box.Size.Width; i++)
                {
                    if (line.ContainsPoint(new Point(i, box.Corner.Y + box.Size.Height)))
                    {
                        point = new Point(i, box.Corner.Y + box.Size.Height);
                        return point;
                    }
                }
            }
            return point;
        }
        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (_mode != PossibleModes.ClassDrawing && _mode != PossibleModes.Line) return;

            _startingPoint = e.Location;
            _rubberBandStart = ComputeAbsolutePoint(e.Location);
            _showRubberBand = true;
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_showRubberBand) return;

            _rubberBandEnd = ComputeAbsolutePoint(e.Location);

            switch (_mode)
            {
                case PossibleModes.Line:
                    DrawRubberBandLine();
                    break;
                case PossibleModes.ClassDrawing:
                    DrawRubberBandBox();
                    break;
            }

            _eraseLastRubberBand = true;
            _lastRubberBandEnd = _rubberBandEnd;
        }

        private void DrawRubberBandLine()
        {

            if (_eraseLastRubberBand)
                EraseOldRubberBandLine();

            ControlPaint.DrawReversibleLine(_rubberBandStart, _rubberBandEnd, Color.Gray);
        }

        private void EraseOldRubberBandLine()
        {
            ControlPaint.DrawReversibleLine(_rubberBandStart, _lastRubberBandEnd, Color.Gray);
        }

        private void DrawRubberBandBox()
        {
            if (_eraseLastRubberBand)
                EraseOldRubberBandFrame();

            var rectangle = new Rectangle(_rubberBandStart.X, _rubberBandStart.Y,
                                        _rubberBandEnd.X - _rubberBandStart.X, _rubberBandEnd.Y - _rubberBandStart.Y);
            ControlPaint.DrawReversibleFrame(rectangle, Color.Gray, FrameStyle.Dashed);
        }

        private void EraseOldRubberBandFrame()
        {
            var oldRectangle = new Rectangle(_rubberBandStart.X, _rubberBandStart.Y,
                                        _lastRubberBandEnd.X - _rubberBandStart.X, _lastRubberBandEnd.Y - _rubberBandStart.Y);
            ControlPaint.DrawReversibleFrame(oldRectangle, Color.Gray, FrameStyle.Dashed);
        }

        private Point ComputeAbsolutePoint(Point location)
        {
            return drawingPanel.PointToScreen(
                        new Point(drawingPanel.ClientRectangle.Left + location.X,
                        drawingPanel.ClientRectangle.Top + location.Y));
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            var button = sender as ToolStripButton;
            ClearOtherSelectedTools(button);

            if (button != null && button.Checked)
            {
                _mode = PossibleModes.ClassDrawing;
                CommandFactory.Instance.CreateAndDo("deselect");

            }
            else
            {
                CommandFactory.Instance.CreateAndDo("deselect");
                _mode = PossibleModes.None;
            }
            _mode = PossibleModes.ClassDrawing;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                CheckFileExists = true,
                DefaultExt = "json",
                Multiselect = false,
                RestoreDirectory = true,
                Filter = @"JSON files (*.json)|*.json|All files (*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CommandFactory.Instance.CreateAndDo("load", dialog.FileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                DefaultExt = "json",
                RestoreDirectory = true,
                Filter = @"JSON files (*.json)|*.json|All files (*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CommandFactory.Instance.CreateAndDo("save", dialog.FileName);
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            CommandFactory.Instance.CreateAndDo("new");
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            _invoker.Undo();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            _invoker.Redo();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ComputeDrawingPanelSize();
            refreshTimer.Start();
        }

        private void ComputeDrawingPanelSize()
        {
            var width = Width - drawingToolStrip.Width;
            var height = Height - fileToolStrip.Height;

            drawingPanel.Size = new Size(width, height);
            drawingPanel.Location = new Point(drawingToolStrip.Width, fileToolStrip.Height);

            _imageBuffer = null;

            _forceRedraw = true;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ComputeDrawingPanelSize();
        }

        private void ClearOtherSelectedTools(ToolStripButton ignoreItem)
        {
            foreach (var item in drawingToolStrip.Items)
            {
                var toolButton = item as ToolStripButton;
                if (toolButton != null && item != ignoreItem && toolButton.Checked)
                    toolButton.Checked = false;
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            var button = sender as ToolStripButton;
            ClearOtherSelectedTools(button);

            if (button != null && button.Checked)
            {
                _mode = PossibleModes.Selection;
                
            }
            else
            {
                CommandFactory.Instance.CreateAndDo("deselect");
                _mode = PossibleModes.None;
            }
        }

        private void trashButton_Click(object sender, EventArgs e)
        {
            CommandFactory.Instance.CreateAndDo("remove");
        }

        private void binaryButton_Click(object sender, EventArgs e)
        {
            var button = sender as ToolStripButton;
            ClearOtherSelectedTools(button);

            if (button != null && button.Checked)
            {
                _mode = PossibleModes.BinaryLine;
                _lineType = "Binary";

            }
            else
            {
                CommandFactory.Instance.CreateAndDo("deselect");
                _mode = PossibleModes.None;
            }
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _invoker?.Stop();
        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            var button = sender as ToolStripButton;
            ClearOtherSelectedTools(button);

            if (button != null && button.Checked)
            {
                _mode = PossibleModes.Line;
                _lineType = "Aggregation";

            }
            else
            {
                CommandFactory.Instance.CreateAndDo("deselect");
                _mode = PossibleModes.None;
            }
        }

        private void Composition_Click(object sender, EventArgs e)
        {
            var button = sender as ToolStripButton;
            ClearOtherSelectedTools(button);

            if (button != null && button.Checked)
            {
                _mode = PossibleModes.Line;
                _lineType = "Composition";

            }
            else
            {
                CommandFactory.Instance.CreateAndDo("deselect");
                _mode = PossibleModes.None;
            }
        }

        private void generalizationButton_Click(object sender, EventArgs e)
        {
            var button = sender as ToolStripButton;
            ClearOtherSelectedTools(button);

            if (button != null && button.Checked)
            {
                _mode = PossibleModes.Line;
                _lineType = "Genspec";

            }
            else
            {
                CommandFactory.Instance.CreateAndDo("deselect");
                _mode = PossibleModes.None;
            }
        }

        private void dependencyButton_Click(object sender, EventArgs e)
        {
            var button = sender as ToolStripButton;
            ClearOtherSelectedTools(button);

            if (button != null && button.Checked)
            {
                _mode = PossibleModes.Line;
                _lineType = "Dependency";

            }
            else
            {
                CommandFactory.Instance.CreateAndDo("deselect");
                _mode = PossibleModes.None;
            }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 46)
            {
                CommandFactory.Instance.CreateAndDo("remove");
            }
            if(e.KeyChar == 83)
            {
                var dialog = new SaveFileDialog
                {
                    DefaultExt = "json",
                    RestoreDirectory = true,
                    Filter = @"JSON files (*.json)|*.json|All files (*.*)|*.*"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    CommandFactory.Instance.CreateAndDo("save", dialog.FileName);
                }
            }
            if(e.KeyChar == 79)
            {
                var dialog = new OpenFileDialog
                {
                    CheckFileExists = true,
                    DefaultExt = "json",
                    Multiselect = false,
                    RestoreDirectory = true,
                    Filter = @"JSON files (*.json)|*.json|All files (*.*)|*.*"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    CommandFactory.Instance.CreateAndDo("load", dialog.FileName);
                }
            }
            if(e.KeyChar == 85)
            {
                _invoker.Undo();
            }
            if(e.KeyChar == 82)
            {
                _invoker.Redo();
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var form = new SettingsForm
            {
                DesktopLocation =
                                new Point(ClientRectangle.Left ,
                                    ClientRectangle.Top )
            };
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.newBack)
                {


                    if (form.backgroundColor == "Yellow")
                    {
                        pColor = currColor;
                        currColor = Brushes.Yellow;
                        panelColor = Color.Yellow;

                        _drawing.panelColor = Color.Yellow;
                        _drawing.IsDirty = true;

                    }
                    if (form.backgroundColor == "Red")
                    {
                        pColor = currColor;
                        currColor = Brushes.Red;
                        panelColor = Color.Red;

                        _drawing.panelColor = Color.Red;
                        _drawing.IsDirty = true;

                    }
                    if (form.backgroundColor == "Blue")
                    {
                        pColor = currColor;
                        currColor = Brushes.Blue;
                        panelColor = Color.Blue;

                        _drawing.panelColor = Color.Blue;
                        _drawing.IsDirty = true;

                    }
                    if (form.backgroundColor == "Black")
                    {
                        pColor = currColor;
                        currColor = Brushes.Black;
                        panelColor = Color.Black;

                        _drawing.panelColor = Color.Black;
                        _drawing.IsDirty = true;

                    }
                    if (form.backgroundColor == "Green")
                    {
                        pColor = currColor;
                        currColor = Brushes.Green;
                        panelColor = Color.Green;

                        _drawing.panelColor = Color.Green;
                        _drawing.IsDirty = true;

                    }
                    if (form.backgroundColor == "White")
                    {
                        pColor = currColor;
                        currColor = Brushes.White;
                        panelColor = Color.White;

                        _drawing.panelColor = Color.White;
                        _drawing.IsDirty = true;

                    }

                    CommandFactory.Instance.CreateAndDo("background", currColor, pColor);
                }
                if (form.newFore)
                {
                    if (form.foregroundColor == "Yellow")
                    {
                        pfColor = currfColor;
                        currfColor = Color.Yellow;
                        

                        
                        _drawing.IsDirty = true;

                    }
                    if (form.foregroundColor == "Red")
                    {
                        pfColor = currfColor;
                        currfColor = Color.Red;
                        

                        
                        _drawing.IsDirty = true;

                    }
                    if (form.foregroundColor == "Blue")
                    {
                        pfColor = currfColor;
                        currfColor = Color.Blue;
                        

                        
                        _drawing.IsDirty = true;

                    }
                    if (form.foregroundColor == "Black")
                    {
                        pfColor = currfColor;
                        currfColor = Color.Black;
                        

                        
                        _drawing.IsDirty = true;

                    }
                    if (form.foregroundColor == "Green")
                    {
                        pfColor = currfColor;
                        currfColor = Color.Green;
                        

                        
                        _drawing.IsDirty = true;

                    }
                    if (form.foregroundColor == "White")
                    {
                        pfColor = currfColor;
                        currfColor = Color.White;

                        _drawing.IsDirty = true;

                    }
                    CommandFactory.Instance.CreateAndDo("foreground", currfColor, pfColor);
                }
                if(form.newlineThickness)
                {
                    
                    prevLineThickness = currLineThickness;
                    currLineThickness = form.lineThickness;
                    CommandFactory.Instance.CreateAndDo("linethickness",currLineThickness, prevLineThickness);
                }
            }
        }
    }
}
