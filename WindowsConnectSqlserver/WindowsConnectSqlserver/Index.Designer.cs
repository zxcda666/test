namespace WindowsConnectSqlserver
{
    partial class Index
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOperation = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.NickName,
            this.RealGender,
            this.ColOperation});
            this.dataGridView1.Location = new System.Drawing.Point(15, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(894, 452);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用户名";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.Width = 150;
            // 
            // NickName
            // 
            this.NickName.DataPropertyName = "NIckName";
            this.NickName.HeaderText = "昵称";
            this.NickName.MinimumWidth = 8;
            this.NickName.Name = "NickName";
            this.NickName.Width = 150;
            // 
            // RealGender
            // 
            this.RealGender.DataPropertyName = "RealGender";
            this.RealGender.HeaderText = "性别";
            this.RealGender.MinimumWidth = 8;
            this.RealGender.Name = "RealGender";
            this.RealGender.Width = 150;
            // 
            // ColOperation
            // 
            this.ColOperation.HeaderText = "操作";
            this.ColOperation.MinimumWidth = 8;
            this.ColOperation.Name = "ColOperation";
            this.ColOperation.Text = "编辑";
            this.ColOperation.UseColumnTextForButtonValue = true;
            this.ColOperation.Width = 150;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 513);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Index";
            this.Text = "首页";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Index_FormClosed);
            this.Load += new System.EventHandler(this.Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealGender;
        private System.Windows.Forms.DataGridViewButtonColumn ColOperation;
    }
}