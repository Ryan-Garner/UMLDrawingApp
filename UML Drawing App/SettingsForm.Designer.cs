﻿namespace UML_Drawing_App
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundColorsDrop = new System.Windows.Forms.ComboBox();
            this.foregroundColorsDrop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.classFontSizeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.classBoldDrop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lineThicknessTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.associatoinBoldDrop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.aggCompHeightBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.aggCompWidthBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.genHeightBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.genWidthBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.depArrowHeight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background Color";
            // 
            // backgroundColorsDrop
            // 
            this.backgroundColorsDrop.AllowDrop = true;
            this.backgroundColorsDrop.FormattingEnabled = true;
            this.backgroundColorsDrop.Items.AddRange(new object[] {
            "Yellow",
            "Blue",
            "Red",
            "Black",
            "Green",
            "White"});
            this.backgroundColorsDrop.Location = new System.Drawing.Point(212, 29);
            this.backgroundColorsDrop.Name = "backgroundColorsDrop";
            this.backgroundColorsDrop.Size = new System.Drawing.Size(204, 21);
            this.backgroundColorsDrop.TabIndex = 1;
            this.backgroundColorsDrop.SelectedIndexChanged += new System.EventHandler(this.backgroundColorsDrop_SelectedIndexChanged);
            // 
            // foregroundColorsDrop
            // 
            this.foregroundColorsDrop.AllowDrop = true;
            this.foregroundColorsDrop.FormattingEnabled = true;
            this.foregroundColorsDrop.Items.AddRange(new object[] {
            "Yellow",
            "Blue",
            "Red",
            "Black",
            "Green",
            "White"});
            this.foregroundColorsDrop.Location = new System.Drawing.Point(212, 93);
            this.foregroundColorsDrop.Name = "foregroundColorsDrop";
            this.foregroundColorsDrop.Size = new System.Drawing.Size(204, 21);
            this.foregroundColorsDrop.TabIndex = 3;
            this.foregroundColorsDrop.SelectedIndexChanged += new System.EventHandler(this.foregroundColorsDrop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Foreground Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class Font Size";
            // 
            // classFontSizeTextBox
            // 
            this.classFontSizeTextBox.Location = new System.Drawing.Point(212, 149);
            this.classFontSizeTextBox.Name = "classFontSizeTextBox";
            this.classFontSizeTextBox.Size = new System.Drawing.Size(58, 20);
            this.classFontSizeTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Class Font Bold";
            // 
            // classBoldDrop
            // 
            this.classBoldDrop.AllowDrop = true;
            this.classBoldDrop.FormattingEnabled = true;
            this.classBoldDrop.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.classBoldDrop.Location = new System.Drawing.Point(212, 210);
            this.classBoldDrop.Name = "classBoldDrop";
            this.classBoldDrop.Size = new System.Drawing.Size(112, 21);
            this.classBoldDrop.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "RelationShip Line Thickness";
            // 
            // lineThicknessTextBox
            // 
            this.lineThicknessTextBox.Location = new System.Drawing.Point(273, 263);
            this.lineThicknessTextBox.Name = "lineThicknessTextBox";
            this.lineThicknessTextBox.Size = new System.Drawing.Size(85, 20);
            this.lineThicknessTextBox.TabIndex = 9;
            this.lineThicknessTextBox.TextChanged += new System.EventHandler(this.lineThicknessTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Association Font Size";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 11;
            // 
            // associatoinBoldDrop
            // 
            this.associatoinBoldDrop.AllowDrop = true;
            this.associatoinBoldDrop.FormattingEnabled = true;
            this.associatoinBoldDrop.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.associatoinBoldDrop.Location = new System.Drawing.Point(212, 371);
            this.associatoinBoldDrop.Name = "associatoinBoldDrop";
            this.associatoinBoldDrop.Size = new System.Drawing.Size(112, 21);
            this.associatoinBoldDrop.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Association Font Bold";
            // 
            // aggCompHeightBox
            // 
            this.aggCompHeightBox.Location = new System.Drawing.Point(389, 424);
            this.aggCompHeightBox.Name = "aggCompHeightBox";
            this.aggCompHeightBox.Size = new System.Drawing.Size(58, 20);
            this.aggCompHeightBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(364, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Aggregation/Composition Diamond Height";
            // 
            // aggCompWidthBox
            // 
            this.aggCompWidthBox.Location = new System.Drawing.Point(389, 472);
            this.aggCompWidthBox.Name = "aggCompWidthBox";
            this.aggCompWidthBox.Size = new System.Drawing.Size(58, 20);
            this.aggCompWidthBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Aggregation/Composition Diamond Width";
            // 
            // genHeightBox
            // 
            this.genHeightBox.Location = new System.Drawing.Point(279, 517);
            this.genHeightBox.Name = "genHeightBox";
            this.genHeightBox.Size = new System.Drawing.Size(58, 20);
            this.genHeightBox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 512);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Generaliztion Triangle Height";
            // 
            // genWidthBox
            // 
            this.genWidthBox.Location = new System.Drawing.Point(279, 551);
            this.genWidthBox.Name = "genWidthBox";
            this.genWidthBox.Size = new System.Drawing.Size(58, 20);
            this.genWidthBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 547);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Generaliztion Triangle Width";
            // 
            // depArrowHeight
            // 
            this.depArrowHeight.Location = new System.Drawing.Point(259, 589);
            this.depArrowHeight.Name = "depArrowHeight";
            this.depArrowHeight.Size = new System.Drawing.Size(58, 20);
            this.depArrowHeight.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 584);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(234, 24);
            this.label12.TabIndex = 22;
            this.label12.Text = "Dependency Arrow Height";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 623);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 20);
            this.textBox2.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 618);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 24);
            this.label13.TabIndex = 24;
            this.label13.Text = "Dependency Arrow Width";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(23, 671);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 33);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(342, 674);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(105, 30);
            this.applyButton.TabIndex = 27;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 728);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.depArrowHeight);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.genWidthBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.genHeightBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.aggCompWidthBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.aggCompHeightBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.associatoinBoldDrop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lineThicknessTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.classBoldDrop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.classFontSizeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.foregroundColorsDrop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backgroundColorsDrop);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox backgroundColorsDrop;
        private System.Windows.Forms.ComboBox foregroundColorsDrop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox classFontSizeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox classBoldDrop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lineThicknessTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox associatoinBoldDrop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox aggCompHeightBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox aggCompWidthBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox genHeightBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox genWidthBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox depArrowHeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
    }
}