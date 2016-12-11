namespace _209简体繁体转换
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
            this.txtCHPy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCHS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCHPy
            // 
            this.txtCHPy.Location = new System.Drawing.Point(70, 173);
            this.txtCHPy.Multiline = true;
            this.txtCHPy.Name = "txtCHPy";
            this.txtCHPy.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCHPy.Size = new System.Drawing.Size(309, 321);
            this.txtCHPy.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "繁体中文";
            // 
            // txtCHS
            // 
            this.txtCHS.Location = new System.Drawing.Point(70, 21);
            this.txtCHS.Multiline = true;
            this.txtCHS.Name = "txtCHS";
            this.txtCHS.Size = new System.Drawing.Size(309, 117);
            this.txtCHS.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "转换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "简体中文";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 514);
            this.Controls.Add(this.txtCHPy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCHS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCHPy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCHS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

