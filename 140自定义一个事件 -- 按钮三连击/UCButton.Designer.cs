namespace _140自定义一个事件____按钮三连击
{
    partial class UCButton
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTriple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTriple
            // 
            this.btnTriple.Location = new System.Drawing.Point(0, 0);
            this.btnTriple.Name = "btnTriple";
            this.btnTriple.Size = new System.Drawing.Size(147, 57);
            this.btnTriple.TabIndex = 0;
            this.btnTriple.Text = "TripleClick";
            this.btnTriple.UseVisualStyleBackColor = true;
            this.btnTriple.Click += new System.EventHandler(this.btnTriple_Click);
            // 
            // UCButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTriple);
            this.Name = "UCButton";
            this.Size = new System.Drawing.Size(147, 57);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTriple;
    }
}
