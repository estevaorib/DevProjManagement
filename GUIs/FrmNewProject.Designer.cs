namespace DevProjectManagement.GUIs
{
    partial class FrmNewProject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbNewProject = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpEndPlanned = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginning = new System.Windows.Forms.DateTimePicker();
            this.lblEndPlanned = new System.Windows.Forms.Label();
            this.lblBeginning = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpbNewProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gpbNewProject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 206);
            this.panel1.TabIndex = 0;
            // 
            // gpbNewProject
            // 
            this.gpbNewProject.Controls.Add(this.btnAdd);
            this.gpbNewProject.Controls.Add(this.dtpEnd);
            this.gpbNewProject.Controls.Add(this.lblEnd);
            this.gpbNewProject.Controls.Add(this.dtpEndPlanned);
            this.gpbNewProject.Controls.Add(this.dtpBeginning);
            this.gpbNewProject.Controls.Add(this.lblEndPlanned);
            this.gpbNewProject.Controls.Add(this.lblBeginning);
            this.gpbNewProject.Controls.Add(this.txtName);
            this.gpbNewProject.Controls.Add(this.lblName);
            this.gpbNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNewProject.Location = new System.Drawing.Point(12, 12);
            this.gpbNewProject.Name = "gpbNewProject";
            this.gpbNewProject.Size = new System.Drawing.Size(263, 182);
            this.gpbNewProject.TabIndex = 0;
            this.gpbNewProject.TabStop = false;
            this.gpbNewProject.Text = "New Project";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(18, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(238, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Location = new System.Drawing.Point(46, 119);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(210, 22);
            this.dtpEnd.TabIndex = 8;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(6, 124);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(34, 16);
            this.lblEnd.TabIndex = 7;
            this.lblEnd.Text = "End:";
            // 
            // dtpEndPlanned
            // 
            this.dtpEndPlanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndPlanned.Location = new System.Drawing.Point(99, 91);
            this.dtpEndPlanned.Name = "dtpEndPlanned";
            this.dtpEndPlanned.Size = new System.Drawing.Size(157, 22);
            this.dtpEndPlanned.TabIndex = 6;
            // 
            // dtpBeginning
            // 
            this.dtpBeginning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBeginning.Location = new System.Drawing.Point(75, 57);
            this.dtpBeginning.Name = "dtpBeginning";
            this.dtpBeginning.Size = new System.Drawing.Size(182, 22);
            this.dtpBeginning.TabIndex = 5;
            // 
            // lblEndPlanned
            // 
            this.lblEndPlanned.AutoSize = true;
            this.lblEndPlanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndPlanned.Location = new System.Drawing.Point(6, 95);
            this.lblEndPlanned.Name = "lblEndPlanned";
            this.lblEndPlanned.Size = new System.Drawing.Size(87, 16);
            this.lblEndPlanned.TabIndex = 4;
            this.lblEndPlanned.Text = "End Planned:";
            // 
            // lblBeginning
            // 
            this.lblBeginning.AutoSize = true;
            this.lblBeginning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeginning.Location = new System.Drawing.Point(6, 62);
            this.lblBeginning.Name = "lblBeginning";
            this.lblBeginning.Size = new System.Drawing.Size(70, 16);
            this.lblBeginning.TabIndex = 2;
            this.lblBeginning.Text = "Beginning:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // FrmNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 206);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmNewProject";
            this.Text = "FrmNewProject";
            this.panel1.ResumeLayout(false);
            this.gpbNewProject.ResumeLayout(false);
            this.gpbNewProject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbNewProject;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEndPlanned;
        private System.Windows.Forms.Label lblBeginning;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpBeginning;
        private System.Windows.Forms.DateTimePicker dtpEndPlanned;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnAdd;
    }
}