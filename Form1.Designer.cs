namespace HTTP_bai1
{
    partial class Form1
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
            this.btn_getData = new System.Windows.Forms.Button();
            this.btn_getCookies = new System.Windows.Forms.Button();
            this.txt_website = new System.Windows.Forms.TextBox();
            this.txt_cookie = new System.Windows.Forms.TextBox();
            this.lb_site = new System.Windows.Forms.Label();
            this.lb_cookies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_getData
            // 
            this.btn_getData.Location = new System.Drawing.Point(111, 127);
            this.btn_getData.Name = "btn_getData";
            this.btn_getData.Size = new System.Drawing.Size(75, 23);
            this.btn_getData.TabIndex = 0;
            this.btn_getData.Text = "get data";
            this.btn_getData.UseVisualStyleBackColor = true;
            this.btn_getData.Click += new System.EventHandler(this.btn_getData_Click);
            // 
            // btn_getCookies
            // 
            this.btn_getCookies.Location = new System.Drawing.Point(195, 127);
            this.btn_getCookies.Name = "btn_getCookies";
            this.btn_getCookies.Size = new System.Drawing.Size(123, 23);
            this.btn_getCookies.TabIndex = 1;
            this.btn_getCookies.Text = "get data with cookies";
            this.btn_getCookies.UseVisualStyleBackColor = true;
            this.btn_getCookies.Click += new System.EventHandler(this.btn_getCookies_Click);
            // 
            // txt_website
            // 
            this.txt_website.Location = new System.Drawing.Point(111, 12);
            this.txt_website.Name = "txt_website";
            this.txt_website.Size = new System.Drawing.Size(148, 20);
            this.txt_website.TabIndex = 2;
            // 
            // txt_cookie
            // 
            this.txt_cookie.Location = new System.Drawing.Point(111, 49);
            this.txt_cookie.Name = "txt_cookie";
            this.txt_cookie.Size = new System.Drawing.Size(148, 20);
            this.txt_cookie.TabIndex = 3;
            // 
            // lb_site
            // 
            this.lb_site.AutoSize = true;
            this.lb_site.Location = new System.Drawing.Point(9, 15);
            this.lb_site.Name = "lb_site";
            this.lb_site.Size = new System.Drawing.Size(85, 14);
            this.lb_site.TabIndex = 4;
            this.lb_site.Text = "Nhập trang web";
            // 
            // lb_cookies
            // 
            this.lb_cookies.AutoSize = true;
            this.lb_cookies.Location = new System.Drawing.Point(9, 52);
            this.lb_cookies.Name = "lb_cookies";
            this.lb_cookies.Size = new System.Drawing.Size(72, 14);
            this.lb_cookies.TabIndex = 5;
            this.lb_cookies.Text = "Nhập cookies";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 162);
            this.Controls.Add(this.lb_cookies);
            this.Controls.Add(this.lb_site);
            this.Controls.Add(this.txt_cookie);
            this.Controls.Add(this.txt_website);
            this.Controls.Add(this.btn_getCookies);
            this.Controls.Add(this.btn_getData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getData;
        private System.Windows.Forms.Button btn_getCookies;
        private System.Windows.Forms.TextBox txt_website;
        private System.Windows.Forms.TextBox txt_cookie;
        private System.Windows.Forms.Label lb_site;
        private System.Windows.Forms.Label lb_cookies;
    }
}

