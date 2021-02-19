
namespace SACOMaintenance.WinForms.Forms
{
    partial class AreaForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.header1 = new SACOMaintenance.WinForms.Controls.Header();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbAreaListNav = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAreaComments = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFactory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewArea = new System.Windows.Forms.Button();
            this.btnSaveArea = new System.Windows.Forms.Button();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.header1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 100);
            this.panel1.TabIndex = 0;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.header1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(872, 100);
            this.header1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 60);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "AREAS";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbAreaListNav);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 398);
            this.panel3.TabIndex = 2;
            // 
            // lbAreaListNav
            // 
            this.lbAreaListNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAreaListNav.FormattingEnabled = true;
            this.lbAreaListNav.ItemHeight = 15;
            this.lbAreaListNav.Location = new System.Drawing.Point(0, 0);
            this.lbAreaListNav.Name = "lbAreaListNav";
            this.lbAreaListNav.Size = new System.Drawing.Size(210, 398);
            this.lbAreaListNav.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtAreaComments);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cboFactory);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnNewArea);
            this.panel4.Controls.Add(this.btnSaveArea);
            this.panel4.Controls.Add(this.txtAreaName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(210, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(662, 398);
            this.panel4.TabIndex = 3;
            // 
            // txtAreaComments
            // 
            this.txtAreaComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAreaComments.Location = new System.Drawing.Point(31, 178);
            this.txtAreaComments.Multiline = true;
            this.txtAreaComments.Name = "txtAreaComments";
            this.txtAreaComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAreaComments.Size = new System.Drawing.Size(599, 133);
            this.txtAreaComments.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Comments/Notes";
            // 
            // cboFactory
            // 
            this.cboFactory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFactory.FormattingEnabled = true;
            this.cboFactory.Location = new System.Drawing.Point(29, 108);
            this.cboFactory.Name = "cboFactory";
            this.cboFactory.Size = new System.Drawing.Size(304, 23);
            this.cboFactory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Factory";
            // 
            // btnNewArea
            // 
            this.btnNewArea.Location = new System.Drawing.Point(127, 334);
            this.btnNewArea.Name = "btnNewArea";
            this.btnNewArea.Size = new System.Drawing.Size(75, 42);
            this.btnNewArea.TabIndex = 3;
            this.btnNewArea.Text = "New";
            this.btnNewArea.UseVisualStyleBackColor = true;
            this.btnNewArea.Click += new System.EventHandler(this.btnNewArea_Click);
            // 
            // btnSaveArea
            // 
            this.btnSaveArea.Location = new System.Drawing.Point(29, 334);
            this.btnSaveArea.Name = "btnSaveArea";
            this.btnSaveArea.Size = new System.Drawing.Size(75, 42);
            this.btnSaveArea.TabIndex = 2;
            this.btnSaveArea.Text = "Save";
            this.btnSaveArea.UseVisualStyleBackColor = true;
            this.btnSaveArea.Click += new System.EventHandler(this.btnSaveArea_Click);
            // 
            // txtAreaName
            // 
            this.txtAreaName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAreaName.Location = new System.Drawing.Point(29, 39);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(601, 23);
            this.txtAreaName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Area Name";
            // 
            // AreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 558);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AreaForm";
            this.Text = "AreaForm";
            this.Load += new System.EventHandler(this.AreaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Controls.Header header1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lbAreaListNav;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private System.Windows.Forms.Button btnSaveArea;
        private System.Windows.Forms.Button btnNewArea;
        private System.Windows.Forms.ComboBox cboFactory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAreaComments;
        private System.Windows.Forms.Label label4;
    }
}