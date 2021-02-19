
namespace SACOMaintenance.WinForms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.header1 = new SACOMaintenance.WinForms.Controls.Header();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pRequests = new System.Windows.Forms.Panel();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnRisks = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnStatus = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtEquipment = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtFactories = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnPPE = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAreasForm = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnMachineType = new System.Windows.Forms.Button();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.header1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 100);
            this.panel1.TabIndex = 0;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.header1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1082, 100);
            this.header1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pRequests);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 598);
            this.panel2.TabIndex = 1;
            // 
            // pRequests
            // 
            this.pRequests.Controls.Add(this.dgvRequests);
            this.pRequests.Controls.Add(this.panel12);
            this.pRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRequests.Location = new System.Drawing.Point(0, 129);
            this.pRequests.Name = "pRequests";
            this.pRequests.Size = new System.Drawing.Size(1082, 390);
            this.pRequests.TabIndex = 4;
            // 
            // dgvRequests
            // 
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequests.Location = new System.Drawing.Point(0, 50);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.RowTemplate.Height = 25;
            this.dgvRequests.Size = new System.Drawing.Size(1082, 340);
            this.dgvRequests.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label2);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1082, 50);
            this.panel12.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Requests";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel11.Controls.Add(this.label1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 52);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1082, 77);
            this.panel11.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "DASHBOARD";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1082, 52);
            this.panel3.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnRisks);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(918, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(152, 52);
            this.panel9.TabIndex = 9;
            // 
            // btnRisks
            // 
            this.btnRisks.Location = new System.Drawing.Point(13, 6);
            this.btnRisks.Name = "btnRisks";
            this.btnRisks.Size = new System.Drawing.Size(134, 33);
            this.btnRisks.TabIndex = 5;
            this.btnRisks.Text = "Risks";
            this.btnRisks.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnStatus);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(766, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(152, 52);
            this.panel10.TabIndex = 10;
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(12, 6);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(134, 33);
            this.btnStatus.TabIndex = 6;
            this.btnStatus.Text = "Ststus";
            this.btnStatus.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtEquipment);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(614, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(152, 52);
            this.panel6.TabIndex = 4;
            // 
            // txtEquipment
            // 
            this.txtEquipment.Location = new System.Drawing.Point(6, 6);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(134, 33);
            this.txtEquipment.TabIndex = 2;
            this.txtEquipment.Text = "Equipment";
            this.txtEquipment.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtFactories);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(459, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(155, 52);
            this.panel5.TabIndex = 3;
            // 
            // txtFactories
            // 
            this.txtFactories.Location = new System.Drawing.Point(6, 6);
            this.txtFactories.Name = "txtFactories";
            this.txtFactories.Size = new System.Drawing.Size(134, 33);
            this.txtFactories.TabIndex = 1;
            this.txtFactories.Text = "Factories";
            this.txtFactories.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnPPE);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(307, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(152, 52);
            this.panel8.TabIndex = 8;
            // 
            // btnPPE
            // 
            this.btnPPE.Location = new System.Drawing.Point(12, 6);
            this.btnPPE.Name = "btnPPE";
            this.btnPPE.Size = new System.Drawing.Size(134, 33);
            this.btnPPE.TabIndex = 4;
            this.btnPPE.Text = "PPE";
            this.btnPPE.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAreasForm);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(152, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 52);
            this.panel4.TabIndex = 2;
            // 
            // btnAreasForm
            // 
            this.btnAreasForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAreasForm.Location = new System.Drawing.Point(10, 6);
            this.btnAreasForm.Name = "btnAreasForm";
            this.btnAreasForm.Size = new System.Drawing.Size(134, 33);
            this.btnAreasForm.TabIndex = 0;
            this.btnAreasForm.Text = "Areas";
            this.btnAreasForm.UseVisualStyleBackColor = true;
            this.btnAreasForm.Click += new System.EventHandler(this.btnAreasForm_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnMachineType);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(152, 52);
            this.panel7.TabIndex = 7;
            // 
            // btnMachineType
            // 
            this.btnMachineType.Location = new System.Drawing.Point(12, 6);
            this.btnMachineType.Name = "btnMachineType";
            this.btnMachineType.Size = new System.Drawing.Size(134, 33);
            this.btnMachineType.TabIndex = 3;
            this.btnMachineType.Text = "Machine Type";
            this.btnMachineType.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Controls.Header header1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private System.Windows.Forms.Button btnAreasForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnRisks;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button txtEquipment;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button txtFactories;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnPPE;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnMachineType;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pRequests;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource requestBindingSource;
    }
}