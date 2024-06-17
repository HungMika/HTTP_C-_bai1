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
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getData_Click(object sender, EventArgs e)
        {
            var html = GetData("https://howkteam.vn/");
            TestData(html);
        }
        
        void TestData(string html)
        {
            File.WriteAllText("res.html", html);
            Process.Start("res.html");
        }
        string GetData (string url)
        {
            HttpRequest http = new HttpRequest();
            http.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36 Edg/126.0.0.0";
            string html = http.Get(url).ToString();
            return html;
        }
    }
}
