namespace UML_Drawing_App
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fileToolStrip = new System.Windows.Forms.ToolStrip();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.undoButton = new System.Windows.Forms.ToolStripButton();
            this.redoButton = new System.Windows.Forms.ToolStripButton();
            this.trashButton = new System.Windows.Forms.ToolStripButton();
            this.drawingToolStrip = new System.Windows.Forms.ToolStrip();
            this.classButton = new System.Windows.Forms.ToolStripButton();
            this.binaryButton = new System.Windows.Forms.ToolStripButton();
            this.aggregationButton = new System.Windows.Forms.ToolStripButton();
            this.Composition = new System.Windows.Forms.ToolStripButton();
            this.generalizationButton = new System.Windows.Forms.ToolStripButton();
            this.dependencyButton = new System.Windows.Forms.ToolStripButton();
            this.selectButton = new System.Windows.Forms.ToolStripButton();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.settingsButton = new System.Windows.Forms.ToolStripButton();
            this.fileToolStrip.SuspendLayout();
            this.drawingToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.AutoSize = false;
            this.fileToolStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fileToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.fileToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.openButton,
            this.saveButton,
            this.undoButton,
            this.redoButton,
            this.trashButton,
            this.settingsButton});
            this.fileToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(877, 64);
            this.fileToolStrip.TabIndex = 0;
            this.fileToolStrip.Text = "toolStrip1";
            // 
            // newButton
            // 
            this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(36, 61);
            this.newButton.Text = "New";
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(36, 61);
            this.openButton.Text = "Open";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(36, 61);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoButton.Image = ((System.Drawing.Image)(resources.GetObject("undoButton.Image")));
            this.undoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(36, 61);
            this.undoButton.Text = "Undo";
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoButton.Image = ((System.Drawing.Image)(resources.GetObject("redoButton.Image")));
            this.redoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(36, 61);
            this.redoButton.Text = "Redo";
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // trashButton
            // 
            this.trashButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.trashButton.Image = ((System.Drawing.Image)(resources.GetObject("trashButton.Image")));
            this.trashButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.trashButton.Name = "trashButton";
            this.trashButton.Size = new System.Drawing.Size(36, 61);
            this.trashButton.Text = "Trash";
            this.trashButton.Click += new System.EventHandler(this.trashButton_Click);
            // 
            // drawingToolStrip
            // 
            this.drawingToolStrip.AllowMerge = false;
            this.drawingToolStrip.AutoSize = false;
            this.drawingToolStrip.BackColor = System.Drawing.Color.SteelBlue;
            this.drawingToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.drawingToolStrip.ImageScalingSize = new System.Drawing.Size(100, 32);
            this.drawingToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classButton,
            this.binaryButton,
            this.aggregationButton,
            this.Composition,
            this.generalizationButton,
            this.dependencyButton,
            this.selectButton});
            this.drawingToolStrip.Location = new System.Drawing.Point(0, 64);
            this.drawingToolStrip.Name = "drawingToolStrip";
            this.drawingToolStrip.Size = new System.Drawing.Size(100, 602);
            this.drawingToolStrip.TabIndex = 1;
            this.drawingToolStrip.Text = "New";
            this.drawingToolStrip.UseWaitCursor = true;
            // 
            // classButton
            // 
            this.classButton.CheckOnClick = true;
            this.classButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.classButton.Image = ((System.Drawing.Image)(resources.GetObject("classButton.Image")));
            this.classButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.classButton.Name = "classButton";
            this.classButton.Size = new System.Drawing.Size(98, 36);
            this.classButton.Text = "Create Class";
            this.classButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // binaryButton
            // 
            this.binaryButton.CheckOnClick = true;
            this.binaryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.binaryButton.Image = ((System.Drawing.Image)(resources.GetObject("binaryButton.Image")));
            this.binaryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.binaryButton.Name = "binaryButton";
            this.binaryButton.Size = new System.Drawing.Size(98, 36);
            this.binaryButton.Text = "Create Binary Assaciation";
            this.binaryButton.Click += new System.EventHandler(this.binaryButton_Click);
            // 
            // aggregationButton
            // 
            this.aggregationButton.CheckOnClick = true;
            this.aggregationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aggregationButton.Image = ((System.Drawing.Image)(resources.GetObject("aggregationButton.Image")));
            this.aggregationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aggregationButton.Name = "aggregationButton";
            this.aggregationButton.Size = new System.Drawing.Size(98, 36);
            this.aggregationButton.Text = "Create Aggregation";
            this.aggregationButton.Click += new System.EventHandler(this.aggregationButton_Click);
            // 
            // Composition
            // 
            this.Composition.CheckOnClick = true;
            this.Composition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Composition.Image = ((System.Drawing.Image)(resources.GetObject("Composition.Image")));
            this.Composition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Composition.Name = "Composition";
            this.Composition.Size = new System.Drawing.Size(98, 36);
            this.Composition.Text = "Create Composition";
            this.Composition.Click += new System.EventHandler(this.Composition_Click);
            // 
            // generalizationButton
            // 
            this.generalizationButton.CheckOnClick = true;
            this.generalizationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.generalizationButton.Image = ((System.Drawing.Image)(resources.GetObject("generalizationButton.Image")));
            this.generalizationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.generalizationButton.Name = "generalizationButton";
            this.generalizationButton.Size = new System.Drawing.Size(98, 36);
            this.generalizationButton.Text = "Create Generalization/Specialization";
            this.generalizationButton.Click += new System.EventHandler(this.generalizationButton_Click);
            // 
            // dependencyButton
            // 
            this.dependencyButton.CheckOnClick = true;
            this.dependencyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dependencyButton.Image = ((System.Drawing.Image)(resources.GetObject("dependencyButton.Image")));
            this.dependencyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dependencyButton.Name = "dependencyButton";
            this.dependencyButton.Size = new System.Drawing.Size(98, 36);
            this.dependencyButton.Text = "Create Dependency";
            this.dependencyButton.Click += new System.EventHandler(this.dependencyButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.CheckOnClick = true;
            this.selectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectButton.Image = ((System.Drawing.Image)(resources.GetObject("selectButton.Image")));
            this.selectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(98, 36);
            this.selectButton.Text = "Select";
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // drawingPanel
            // 
            this.drawingPanel.Location = new System.Drawing.Point(103, 67);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(774, 599);
            this.drawingPanel.TabIndex = 2;
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseDown);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseMove);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseUp);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // settingsButton
            // 
            this.settingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(36, 61);
            this.settingsButton.Text = "Settings";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 666);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.drawingToolStrip);
            this.Controls.Add(this.fileToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "UML Drawing App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.fileToolStrip.ResumeLayout(false);
            this.fileToolStrip.PerformLayout();
            this.drawingToolStrip.ResumeLayout(false);
            this.drawingToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip fileToolStrip;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton undoButton;
        private System.Windows.Forms.ToolStripButton redoButton;
        private System.Windows.Forms.ToolStripButton trashButton;
        private System.Windows.Forms.ToolStrip drawingToolStrip;
        private System.Windows.Forms.ToolStripButton classButton;
        private System.Windows.Forms.ToolStripButton binaryButton;
        private System.Windows.Forms.ToolStripButton aggregationButton;
        private System.Windows.Forms.ToolStripButton Composition;
        private System.Windows.Forms.ToolStripButton generalizationButton;
        private System.Windows.Forms.ToolStripButton dependencyButton;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.ToolStripButton selectButton;
        private System.Windows.Forms.ToolStripButton settingsButton;
    }
}