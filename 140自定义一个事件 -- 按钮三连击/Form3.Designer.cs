namespace _140自定义一个事件____按钮三连击
{
    partial class Form3
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
            this.ucTripleClickEvent1 = new _140自定义一个事件____按钮三连击.UCTripleClickEvent();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucTripleClickEvent1
            // 
            this.ucTripleClickEvent1.Location = new System.Drawing.Point(37, 12);
            this.ucTripleClickEvent1.Name = "ucTripleClickEvent1";
            this.ucTripleClickEvent1.Size = new System.Drawing.Size(182, 111);
            this.ucTripleClickEvent1.TabIndex = 0;
            this.ucTripleClickEvent1.Load += new System.EventHandler(this.ucTripleClickEvent1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucTripleClickEvent1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private UCTripleClickEvent ucTripleClickEvent1;
        private System.Windows.Forms.Button button1;
    }
}