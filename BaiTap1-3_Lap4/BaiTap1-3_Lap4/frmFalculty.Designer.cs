namespace BaiTap1_3_Lap4
{
    partial class frmFalculty
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbFacultyID = new System.Windows.Forms.Label();
            this.lbFacultyName = new System.Windows.Forms.Label();
            this.txtFacultyID = new System.Windows.Forms.TextBox();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddUpdateFal = new System.Windows.Forms.Button();
            this.btnDeleteFal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(425, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(284, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbFacultyID
            // 
            this.lbFacultyID.AutoSize = true;
            this.lbFacultyID.Location = new System.Drawing.Point(26, 42);
            this.lbFacultyID.Name = "lbFacultyID";
            this.lbFacultyID.Size = new System.Drawing.Size(66, 17);
            this.lbFacultyID.TabIndex = 1;
            this.lbFacultyID.Text = "FacultyID";
            // 
            // lbFacultyName
            // 
            this.lbFacultyName.AutoSize = true;
            this.lbFacultyName.Location = new System.Drawing.Point(26, 102);
            this.lbFacultyName.Name = "lbFacultyName";
            this.lbFacultyName.Size = new System.Drawing.Size(90, 17);
            this.lbFacultyName.TabIndex = 2;
            this.lbFacultyName.Text = "FacultyName";
            // 
            // txtFacultyID
            // 
            this.txtFacultyID.Location = new System.Drawing.Point(144, 42);
            this.txtFacultyID.Name = "txtFacultyID";
            this.txtFacultyID.Size = new System.Drawing.Size(129, 22);
            this.txtFacultyID.TabIndex = 3;
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Location = new System.Drawing.Point(144, 97);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(129, 22);
            this.txtFacultyName.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteFal);
            this.groupBox1.Controls.Add(this.btnAddUpdateFal);
            this.groupBox1.Controls.Add(this.lbFacultyID);
            this.groupBox1.Controls.Add(this.txtFacultyName);
            this.groupBox1.Controls.Add(this.lbFacultyName);
            this.groupBox1.Controls.Add(this.txtFacultyID);
            this.groupBox1.Location = new System.Drawing.Point(25, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 308);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // btnAddUpdateFal
            // 
            this.btnAddUpdateFal.AutoSize = true;
            this.btnAddUpdateFal.Location = new System.Drawing.Point(69, 185);
            this.btnAddUpdateFal.Name = "btnAddUpdateFal";
            this.btnAddUpdateFal.Size = new System.Drawing.Size(93, 27);
            this.btnAddUpdateFal.TabIndex = 5;
            this.btnAddUpdateFal.Text = "Add/Update";
            this.btnAddUpdateFal.UseVisualStyleBackColor = true;
            this.btnAddUpdateFal.Click += new System.EventHandler(this.btnAddUpdateFal_Click);
            // 
            // btnDeleteFal
            // 
            this.btnDeleteFal.AutoSize = true;
            this.btnDeleteFal.Location = new System.Drawing.Point(180, 185);
            this.btnDeleteFal.Name = "btnDeleteFal";
            this.btnDeleteFal.Size = new System.Drawing.Size(93, 27);
            this.btnDeleteFal.TabIndex = 6;
            this.btnDeleteFal.Text = "Delete";
            this.btnDeleteFal.UseVisualStyleBackColor = true;
            this.btnDeleteFal.Click += new System.EventHandler(this.btnDeleteFal_Click);
            // 
            // frmFalculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmFalculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFalculty";
            this.Load += new System.EventHandler(this.frmFalculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbFacultyID;
        private System.Windows.Forms.Label lbFacultyName;
        private System.Windows.Forms.TextBox txtFacultyID;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddUpdateFal;
        private System.Windows.Forms.Button btnDeleteFal;
    }
}