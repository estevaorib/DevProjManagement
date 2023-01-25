namespace DevProjectManagement
{
    partial class FrmMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutMe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDev = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddNewDev = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAllocations = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddNewAllocation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDev,
            this.mnuProject,
            this.mnuAllocations});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(583, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClose,
            this.mnuAboutMe});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(127, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // mnuAboutMe
            // 
            this.mnuAboutMe.Name = "mnuAboutMe";
            this.mnuAboutMe.Size = new System.Drawing.Size(127, 22);
            this.mnuAboutMe.Text = "About me";
            this.mnuAboutMe.Click += new System.EventHandler(this.mnuAboutMe_Click);
            // 
            // mnuDev
            // 
            this.mnuDev.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddNewDev});
            this.mnuDev.Name = "mnuDev";
            this.mnuDev.Size = new System.Drawing.Size(77, 20);
            this.mnuDev.Text = "Developers";
            // 
            // mnuAddNewDev
            // 
            this.mnuAddNewDev.Name = "mnuAddNewDev";
            this.mnuAddNewDev.Size = new System.Drawing.Size(121, 22);
            this.mnuAddNewDev.Text = "Add new";
            this.mnuAddNewDev.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // mnuProject
            // 
            this.mnuProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddNewProject});
            this.mnuProject.Name = "mnuProject";
            this.mnuProject.Size = new System.Drawing.Size(61, 20);
            this.mnuProject.Text = "Projects";
            // 
            // mnuAddNewProject
            // 
            this.mnuAddNewProject.Name = "mnuAddNewProject";
            this.mnuAddNewProject.Size = new System.Drawing.Size(180, 22);
            this.mnuAddNewProject.Text = "Add new";
            this.mnuAddNewProject.Click += new System.EventHandler(this.addNewToolStripMenuItem1_Click);
            // 
            // mnuAllocations
            // 
            this.mnuAllocations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddNewAllocation});
            this.mnuAllocations.Name = "mnuAllocations";
            this.mnuAllocations.Size = new System.Drawing.Size(78, 20);
            this.mnuAllocations.Text = "Allocations";
            // 
            // mnuAddNewAllocation
            // 
            this.mnuAddNewAllocation.Name = "mnuAddNewAllocation";
            this.mnuAddNewAllocation.Size = new System.Drawing.Size(180, 22);
            this.mnuAddNewAllocation.Text = "Add new";
            this.mnuAddNewAllocation.Click += new System.EventHandler(this.mnuAddNewAllocation_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 404);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutMe;
        private System.Windows.Forms.ToolStripMenuItem mnuDev;
        private System.Windows.Forms.ToolStripMenuItem mnuAddNewDev;
        private System.Windows.Forms.ToolStripMenuItem mnuProject;
        private System.Windows.Forms.ToolStripMenuItem mnuAddNewProject;
        private System.Windows.Forms.ToolStripMenuItem mnuAllocations;
        private System.Windows.Forms.ToolStripMenuItem mnuAddNewAllocation;
    }
}