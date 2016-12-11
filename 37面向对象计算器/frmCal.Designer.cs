namespace _37面向对象计算器
{
    partial class frmCal
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.cboFuHao = new System.Windows.Forms.ComboBox();
            this.btnJiSuan = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(193, 38);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 21);
            this.txtNumber2.TabIndex = 0;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(12, 37);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 21);
            this.txtNumber1.TabIndex = 1;
            // 
            // cboFuHao
            // 
            this.cboFuHao.FormattingEnabled = true;
            this.cboFuHao.Items.AddRange(new object[] {
            "+",
            "-",
            "*"});
            this.cboFuHao.Location = new System.Drawing.Point(118, 38);
            this.cboFuHao.Name = "cboFuHao";
            this.cboFuHao.Size = new System.Drawing.Size(69, 20);
            this.cboFuHao.TabIndex = 2;
            // 
            // btnJiSuan
            // 
            this.btnJiSuan.Location = new System.Drawing.Point(299, 36);
            this.btnJiSuan.Name = "btnJiSuan";
            this.btnJiSuan.Size = new System.Drawing.Size(75, 23);
            this.btnJiSuan.TabIndex = 3;
            this.btnJiSuan.Text = "=";
            this.btnJiSuan.UseVisualStyleBackColor = true;
            this.btnJiSuan.Click += new System.EventHandler(this.btnJiSuan_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(380, 41);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 12);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "lblResult";
            // 
            // frmCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 116);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnJiSuan);
            this.Controls.Add(this.cboFuHao);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Name = "frmCal";
            this.Text = "FrmCal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.ComboBox cboFuHao;
        private System.Windows.Forms.Button btnJiSuan;
        private System.Windows.Forms.Label lblResult;
    }
}

