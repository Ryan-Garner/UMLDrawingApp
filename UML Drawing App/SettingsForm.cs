using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Drawing_App
{
    public partial class SettingsForm : Form
    {
        public string backgroundColor { get; set; }
        public string foregroundColor { get; set; }
        public int classFontSize { get; set; }
        public bool classBold { get; set; }
        public int lineThickness { get; set; }
        public int associationFontSize { get; set; }
        public bool associaitonBold { get; set; }
        public bool newBack { get; set; }
        public bool newFore { get; set; }
        public bool newlineThickness { get; set; }
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void backgroundColorsDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            newBack = true;
            backgroundColor = (string)backgroundColorsDrop.SelectedItem;
        }

        private void foregroundColorsDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            newFore = true;
            foregroundColor = (string)foregroundColorsDrop.SelectedItem;
        }

        private void lineThicknessTextBox_TextChanged(object sender, EventArgs e)
        {
            newlineThickness = true;
            lineThickness = Int32.Parse(lineThicknessTextBox.Text);
        }
    }
}
