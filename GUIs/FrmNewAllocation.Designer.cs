namespace DevProjectManagement
{
    partial class FrmNewAllocation
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
            this.pnlNewAllocation = new System.Windows.Forms.Panel();
            this.gpbNewAllocation = new System.Windows.Forms.GroupBox();
            this.nupHoursOfWork = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRemuneration = new System.Windows.Forms.TextBox();
            this.lblRemuneration = new System.Windows.Forms.Label();
            this.lblHoursOfWork = new System.Windows.Forms.Label();
            this.lblProjectSelected = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpBeginning = new System.Windows.Forms.DateTimePicker();
            this.lblBeginning = new System.Windows.Forms.Label();
            this.lblDevSelected = new System.Windows.Forms.Label();
            this.lstDevelopers = new System.Windows.Forms.ListBox();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.pnlNewAllocation.SuspendLayout();
            this.gpbNewAllocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupHoursOfWork)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNewAllocation
            // 
            this.pnlNewAllocation.Controls.Add(this.gpbNewAllocation);
            this.pnlNewAllocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNewAllocation.Location = new System.Drawing.Point(0, 0);
            this.pnlNewAllocation.Name = "pnlNewAllocation";
            this.pnlNewAllocation.Size = new System.Drawing.Size(490, 361);
            this.pnlNewAllocation.TabIndex = 0;
            // 
            // gpbNewAllocation
            // 
            this.gpbNewAllocation.Controls.Add(this.nupHoursOfWork);
            this.gpbNewAllocation.Controls.Add(this.btnSave);
            this.gpbNewAllocation.Controls.Add(this.txtRemuneration);
            this.gpbNewAllocation.Controls.Add(this.lblRemuneration);
            this.gpbNewAllocation.Controls.Add(this.lblHoursOfWork);
            this.gpbNewAllocation.Controls.Add(this.lblProjectSelected);
            this.gpbNewAllocation.Controls.Add(this.txtProject);
            this.gpbNewAllocation.Controls.Add(this.lstProjects);
            this.gpbNewAllocation.Controls.Add(this.lblProject);
            this.gpbNewAllocation.Controls.Add(this.dtpEnd);
            this.gpbNewAllocation.Controls.Add(this.lblEnd);
            this.gpbNewAllocation.Controls.Add(this.dtpBeginning);
            this.gpbNewAllocation.Controls.Add(this.lblBeginning);
            this.gpbNewAllocation.Controls.Add(this.lblDevSelected);
            this.gpbNewAllocation.Controls.Add(this.lstDevelopers);
            this.gpbNewAllocation.Controls.Add(this.txtDeveloper);
            this.gpbNewAllocation.Controls.Add(this.lblDeveloper);
            this.gpbNewAllocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNewAllocation.Location = new System.Drawing.Point(13, 13);
            this.gpbNewAllocation.Name = "gpbNewAllocation";
            this.gpbNewAllocation.Size = new System.Drawing.Size(465, 336);
            this.gpbNewAllocation.TabIndex = 0;
            this.gpbNewAllocation.TabStop = false;
            this.gpbNewAllocation.Text = "New Allocation";
            // 
            // nupHoursOfWork
            // 
            this.nupHoursOfWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupHoursOfWork.Location = new System.Drawing.Point(349, 248);
            this.nupHoursOfWork.Name = "nupHoursOfWork";
            this.nupHoursOfWork.Size = new System.Drawing.Size(110, 22);
            this.nupHoursOfWork.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(349, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRemuneration
            // 
            this.txtRemuneration.Location = new System.Drawing.Point(290, 277);
            this.txtRemuneration.Name = "txtRemuneration";
            this.txtRemuneration.Size = new System.Drawing.Size(169, 22);
            this.txtRemuneration.TabIndex = 15;
            // 
            // lblRemuneration
            // 
            this.lblRemuneration.AutoSize = true;
            this.lblRemuneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemuneration.Location = new System.Drawing.Point(248, 282);
            this.lblRemuneration.Name = "lblRemuneration";
            this.lblRemuneration.Size = new System.Drawing.Size(36, 16);
            this.lblRemuneration.TabIndex = 14;
            this.lblRemuneration.Text = "US$:";
            // 
            // lblHoursOfWork
            // 
            this.lblHoursOfWork.AutoSize = true;
            this.lblHoursOfWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursOfWork.Location = new System.Drawing.Point(248, 250);
            this.lblHoursOfWork.Name = "lblHoursOfWork";
            this.lblHoursOfWork.Size = new System.Drawing.Size(95, 16);
            this.lblHoursOfWork.TabIndex = 12;
            this.lblHoursOfWork.Text = "Hours of Work:";
            // 
            // lblProjectSelected
            // 
            this.lblProjectSelected.AutoSize = true;
            this.lblProjectSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectSelected.Location = new System.Drawing.Point(248, 176);
            this.lblProjectSelected.Name = "lblProjectSelected";
            this.lblProjectSelected.Size = new System.Drawing.Size(0, 16);
            this.lblProjectSelected.TabIndex = 11;
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(303, 25);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(156, 22);
            this.txtProject.TabIndex = 9;
            this.txtProject.TextChanged += new System.EventHandler(this.txtProject_TextChanged);
            // 
            // lstProjects
            // 
            this.lstProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.ItemHeight = 16;
            this.lstProjects.Location = new System.Drawing.Point(248, 53);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(211, 116);
            this.lstProjects.TabIndex = 10;
            this.lstProjects.DoubleClick += new System.EventHandler(this.lstProjects_DoubleClick);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(245, 28);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(52, 16);
            this.lblProject.TabIndex = 8;
            this.lblProject.Text = "Project:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Location = new System.Drawing.Point(46, 277);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(168, 22);
            this.dtpEnd.TabIndex = 7;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(6, 282);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(34, 16);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "End:";
            // 
            // dtpBeginning
            // 
            this.dtpBeginning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBeginning.Location = new System.Drawing.Point(82, 248);
            this.dtpBeginning.Name = "dtpBeginning";
            this.dtpBeginning.Size = new System.Drawing.Size(132, 22);
            this.dtpBeginning.TabIndex = 5;
            // 
            // lblBeginning
            // 
            this.lblBeginning.AutoSize = true;
            this.lblBeginning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeginning.Location = new System.Drawing.Point(6, 248);
            this.lblBeginning.Name = "lblBeginning";
            this.lblBeginning.Size = new System.Drawing.Size(70, 16);
            this.lblBeginning.TabIndex = 4;
            this.lblBeginning.Text = "Beginning:";
            // 
            // lblDevSelected
            // 
            this.lblDevSelected.AutoSize = true;
            this.lblDevSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevSelected.Location = new System.Drawing.Point(9, 176);
            this.lblDevSelected.Name = "lblDevSelected";
            this.lblDevSelected.Size = new System.Drawing.Size(0, 16);
            this.lblDevSelected.TabIndex = 3;
            // 
            // lstDevelopers
            // 
            this.lstDevelopers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDevelopers.FormattingEnabled = true;
            this.lstDevelopers.ItemHeight = 16;
            this.lstDevelopers.Location = new System.Drawing.Point(9, 53);
            this.lstDevelopers.Name = "lstDevelopers";
            this.lstDevelopers.Size = new System.Drawing.Size(205, 116);
            this.lstDevelopers.TabIndex = 2;
            this.lstDevelopers.DoubleClick += new System.EventHandler(this.lstDevelopers_DoubleClick);
            // 
            // txtDeveloper
            // 
            this.txtDeveloper.Location = new System.Drawing.Point(86, 25);
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(128, 22);
            this.txtDeveloper.TabIndex = 1;
            this.txtDeveloper.TextChanged += new System.EventHandler(this.txtDeveloper_TextChanged);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(6, 28);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(74, 16);
            this.lblDeveloper.TabIndex = 0;
            this.lblDeveloper.Text = "Developer:";
            // 
            // FrmNewAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 361);
            this.Controls.Add(this.pnlNewAllocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmNewAllocation";
            this.Text = "FrmNewAllocation";
            this.pnlNewAllocation.ResumeLayout(false);
            this.gpbNewAllocation.ResumeLayout(false);
            this.gpbNewAllocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupHoursOfWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewAllocation;
        private System.Windows.Forms.GroupBox gpbNewAllocation;
        private System.Windows.Forms.Label lblBeginning;
        private System.Windows.Forms.Label lblDevSelected;
        private System.Windows.Forms.ListBox lstDevelopers;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpBeginning;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRemuneration;
        private System.Windows.Forms.Label lblRemuneration;
        private System.Windows.Forms.Label lblHoursOfWork;
        private System.Windows.Forms.Label lblProjectSelected;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.NumericUpDown nupHoursOfWork;
    }
}