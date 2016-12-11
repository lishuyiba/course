namespace _05猜拳游戏
{
    partial class CaiQuan
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
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYou = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.btnStone = new System.Windows.Forms.Button();
            this.btnJianDao = new System.Windows.Forms.Button();
            this.btnBu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(147, 96);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "你出：";
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Location = new System.Drawing.Point(107, 43);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(0, 12);
            this.lblYou.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "电脑出：";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(293, 43);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(0, 12);
            this.lblComputer.TabIndex = 4;
            // 
            // btnStone
            // 
            this.btnStone.Location = new System.Drawing.Point(34, 169);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(75, 23);
            this.btnStone.TabIndex = 5;
            this.btnStone.Text = "石头";
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // btnJianDao
            // 
            this.btnJianDao.Location = new System.Drawing.Point(151, 169);
            this.btnJianDao.Name = "btnJianDao";
            this.btnJianDao.Size = new System.Drawing.Size(75, 23);
            this.btnJianDao.TabIndex = 6;
            this.btnJianDao.Text = "剪刀";
            this.btnJianDao.UseVisualStyleBackColor = true;
            this.btnJianDao.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // btnBu
            // 
            this.btnBu.Location = new System.Drawing.Point(276, 169);
            this.btnBu.Name = "btnBu";
            this.btnBu.Size = new System.Drawing.Size(75, 23);
            this.btnBu.TabIndex = 7;
            this.btnBu.Text = "布";
            this.btnBu.UseVisualStyleBackColor = true;
            this.btnBu.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // CaiQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 227);
            this.Controls.Add(this.btnBu);
            this.Controls.Add(this.btnJianDao);
            this.Controls.Add(this.btnStone);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblYou);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Name = "CaiQuan";
            this.Text = "猜拳游戏";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Button btnJianDao;
        private System.Windows.Forms.Button btnBu;
    }
}

