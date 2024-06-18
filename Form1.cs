using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace HTTP_bai1
{
    public partial class Form1 : Form
    {
        private string GetWebsite;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_getData_Click(object sender, EventArgs e)
        {
            GetWebsite = txt_website.Text.ToString();
            if (string.IsNullOrEmpty(GetWebsite))
            {
                MessageBox.Show("Cannot read website");
            }
            else
            {
                var html = GetData(GetWebsite);
                TestData(html);
            }           
        }
        
        void TestData(string html)
        {
            File.WriteAllText("res.html", html);
            Process.Start("res.html");
        }

        void AddCookies(HttpRequest http,  string cookie)
        {
            var temp = cookie.Split(';');
            foreach (var item in temp)
            {
                var tmp = item.Split('=');
                if (tmp.Count() > 1)
                {
                    http.Cookies.Add(tmp[0], tmp[1]);
                }
            }
        }
        string GetData (string url, string cookie = null)
        {
            HttpRequest http = new HttpRequest();
            http.Cookies = new CookieDictionary();

            if (!string.IsNullOrEmpty(cookie)) {
                AddCookies(http, cookie);
            }
            
            http.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36 Edg/126.0.0.0";
            string html = http.Get(url).ToString();
            return html;
        }

        private void btn_getCookies_Click(object sender, EventArgs e)
        {
            GetWebsite = txt_website.Text.ToString();
            string cookie = txt_cookie.Text.ToString();

            if (string.IsNullOrEmpty(GetWebsite) && string.IsNullOrEmpty(cookie))
            {
                MessageBox.Show("Cannot read website and cookies!");
            }
            else
            {
                var html = GetData(GetWebsite, cookie);
                TestData(html);
            }
            
            
        }
    }
}
