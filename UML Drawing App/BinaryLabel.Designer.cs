namespace UML_Drawing_App
{
    partial class BinaryLabel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.leftRadio = new System.Windows.Forms.RadioButton();
            this.rightRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rightRadio);
            this.groupBox1.Controls.Add(this.leftRadio);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arrow Direction";
            // 
            // leftRadio
            // 
            this.leftRadio.AutoSize = true;
            this.leftRadio.Location = new System.Drawing.Point(7, 42);
            this.leftRadio.Name = "leftRadio";
            this.leftRadio.Size = new System.Drawing.Size(43, 17);
            this.leftRadio.TabIndex = 0;
            this.leftRadio.TabStop = true;
            this.leftRadio.Text = "Left";
            this.leftRadio.UseVisualStyleBackColor = true;
            // 
            // rightRadio
            // 
            this.rightRadio.AutoSize = true;
            this.rightRadio.Location = new System.Drawing.Point(7, 20);
            this.rightRadio.Name = "rightRadio";
            this.rightRadio.Size = new System.Drawing.Size(50, 17);
            this.rightRadio.TabIndex = 1;
            this.rightRadio.TabStop = true;
            this.rightRadio.Text = "Right";
            this.rightRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Label";
            // 
            // labelTextBox
            // 
            this.labelTextBox.Location = new System.Drawing.Point(223, 33);
            this.labelTextBox.Name = "labelTextBox";
            this.labelTextBox.Size = new System.Drawing.Size(155, 20);
            this.labelTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(223, 65);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(65, 27);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // BinaryLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 104);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BinaryLabel";
            this.Text = "BinaryLabel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rightRadio;
        private System.Windows.Forms.RadioButton leftRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labelTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancelButton;
    }
}