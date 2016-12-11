namespace _87简体繁体转换
{
    partial class Form1
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
            this.brnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCHS = new System.Windows.Forms.TextBox();
            this.txtCHT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brnConvert
            // 
            this.brnConvert.Location = new System.Drawing.Point(59, 134);
            this.brnConvert.Name = "brnConvert";
            this.brnConvert.Size = new System.Drawing.Size(75, 23);
            this.brnConvert.TabIndex = 0;
            this.brnConvert.Text = "转换";
            this.brnConvert.UseVisualStyleBackColor = true;
            this.brnConvert.Click += new System.EventHandler(this.brnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "简体";
            // 
            // txtCHS
            // 
            this.txtCHS.Location = new System.Drawing.Point(59, 12);
            this.txtCHS.Multiline = true;
            this.txtCHS.Name = "txtCHS";
            this.txtCHS.Size = new System.Drawing.Size(274, 107);
            this.txtCHS.TabIndex = 2;
            // 
            // txtCHT
            // 
            this.txtCHT.Location = new System.Drawing.Point(59, 174);
            this.txtCHT.Multiline = true;
            this.txtCHT.Name = "txtCHT";
            this.txtCHT.Size = new System.Drawing.Size(274, 107);
            this.txtCHT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "繁体";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 293);
            this.Controls.Add(this.txtCHT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCHS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brnConvert);
            this.Name = "Form1";
            this.Text = "简体繁体转换";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCHS;
        private System.Windows.Forms.TextBox txtCHT;
        private System.Windows.Forms.Label label2;
    }
}

