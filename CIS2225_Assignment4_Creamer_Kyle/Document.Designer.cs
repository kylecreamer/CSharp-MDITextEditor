namespace CIS2225_Assignment4_Creamer_Kyle
{
    partial class Document
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentText = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorStatusBar = new System.Windows.Forms.StatusBar();
            this.errorStatus = new System.Windows.Forms.StatusBarPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.closeBar = new System.Windows.Forms.ToolStripButton();
            this.saveBar = new System.Windows.Forms.ToolStripButton();
            this.openBar = new System.Windows.Forms.ToolStripButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStatus)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // documentText
            // 
            this.documentText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documentText.Location = new System.Drawing.Point(12, 52);
            this.documentText.Name = "documentText";
            this.documentText.Size = new System.Drawing.Size(637, 309);
            this.documentText.TabIndex = 1;
            this.documentText.Text = "";
            this.documentText.TextChanged += new System.EventHandler(this.documentText_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorStatusBar
            // 
            this.errorStatusBar.Location = new System.Drawing.Point(0, 377);
            this.errorStatusBar.Name = "errorStatusBar";
            this.errorStatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.errorStatus});
            this.errorStatusBar.Size = new System.Drawing.Size(649, 22);
            this.errorStatusBar.TabIndex = 2;
            this.errorStatusBar.Text = "Tester Error";
            this.errorStatusBar.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.errorStatus_PanelClick);
            // 
            // errorStatus
            // 
            this.errorStatus.Name = "errorStatus";
            this.errorStatus.Text = "Error Status";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeBar,
            this.saveBar,
            this.openBar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // closeBar
            // 
            this.closeBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeBar.Image = ((System.Drawing.Image)(resources.GetObject("closeBar.Image")));
            this.closeBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeBar.Name = "closeBar";
            this.closeBar.Size = new System.Drawing.Size(23, 22);
            this.closeBar.Text = "Close";
            this.closeBar.Click += new System.EventHandler(this.closeBar_Click);
            // 
            // saveBar
            // 
            this.saveBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBar.Image = ((System.Drawing.Image)(resources.GetObject("saveBar.Image")));
            this.saveBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBar.Name = "saveBar";
            this.saveBar.Size = new System.Drawing.Size(23, 22);
            this.saveBar.Text = "Save";
            this.saveBar.Click += new System.EventHandler(this.saveBar_Click);
            // 
            // openBar
            // 
            this.openBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openBar.Image = ((System.Drawing.Image)(resources.GetObject("openBar.Image")));
            this.openBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openBar.Name = "openBar";
            this.openBar.Size = new System.Drawing.Size(23, 22);
            this.openBar.Text = "Open";
            this.openBar.Click += new System.EventHandler(this.openBar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(233, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 399);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.errorStatusBar);
            this.Controls.Add(this.documentText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Document";
            this.Text = "Document";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStatus)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.RichTextBox documentText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusBar errorStatusBar;
        protected System.Windows.Forms.StatusBarPanel errorStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton closeBar;
        private System.Windows.Forms.ToolStripButton saveBar;
        private System.Windows.Forms.ToolStripButton openBar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}