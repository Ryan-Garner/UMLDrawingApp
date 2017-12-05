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
    public partial class BinaryLabel : Form
    {
        public string LabelText { get; set; }
        public BinaryLabel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rightRadio.Checked)
            {
                LabelText = labelTextBox.Text + " ->";
                DialogResult = DialogResult.OK;
            }
            if (leftRadio.Checked)
            {
                LabelText = "<- " + labelTextBox.Text ;
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
