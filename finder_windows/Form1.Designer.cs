namespace finder_windows
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.choise_dir = new System.Windows.Forms.Button();
            this.listboxpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // choise_dir
            // 
            this.choise_dir.Dock = System.Windows.Forms.DockStyle.Top;
            this.choise_dir.Location = new System.Drawing.Point(0, 0);
            this.choise_dir.Name = "choise_dir";
            this.choise_dir.Size = new System.Drawing.Size(800, 30);
            this.choise_dir.TabIndex = 0;
            this.choise_dir.Text = "選擇資料夾";
            this.choise_dir.UseVisualStyleBackColor = true;
            this.choise_dir.Click += new System.EventHandler(this.choise_dir_Click);
            // 
            // listboxpanel
            // 
            this.listboxpanel.AutoScroll = true;
            this.listboxpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxpanel.Location = new System.Drawing.Point(0, 30);
            this.listboxpanel.Name = "listboxpanel";
            this.listboxpanel.Size = new System.Drawing.Size(800, 420);
            this.listboxpanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listboxpanel);
            this.Controls.Add(this.choise_dir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button choise_dir;
        private System.Windows.Forms.Panel listboxpanel;
    }
}

