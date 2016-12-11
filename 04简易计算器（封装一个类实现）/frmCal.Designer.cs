namespace _04简易计算器_封装一个类实现_
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
            this.cboysf = new System.Windows.Forms.ComboBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboysf
            // 
            this.cboysf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboysf.FormattingEnabled = true;
            this.cboysf.Items.AddRange(new object[] {
            "--请选择--",
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.cboysf.Location = new System.Drawing.Point(140, 24);
            this.cboysf.Name = "cboysf";
            this.cboysf.Size = new System.Drawing.Size(91, 20);
            this.cboysf.TabIndex = 9;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(243, 23);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 21);
            this.txtNum2.TabIndex = 8;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(27, 24);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 21);
            this.txtNum1.TabIndex = 7;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(422, 27);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(41, 12);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "label1";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(365, 21);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(51, 23);
            this.btnCal.TabIndex = 5;
            this.btnCal.Text = "=";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // frmCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 72);
            this.Controls.Add(this.cboysf);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCal);
            this.Name = "frmCal";
            this.Text = "frmCal";
            this.Load += new System.EventHandler(this.frmCal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboysf;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCal;
    }
}

