﻿using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HabboPicturesearcher
{

    public partial class Form1 : Form
    {
        public Form1()
        {

   
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void getPic(string habboname) // too lazy to add a hotel selection tbh
        {
            // Here we get the UniqueID of the habbo user
            WebClient c = new WebClient();
            c.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            var data = c.DownloadString("http://www.habbo.nl/api/public/users?name=" + habboname);
            JObject o = JObject.Parse(data.ToString());
          

            var myIP = c.DownloadString("http://icanhazip.com"); // ty habbo for making it a paint in the ass
            c.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            c.Headers.Add("Cookie: YPF8827340282Jdskjhfiw_928937459182JAX666=" + myIP);
            var dongs2 = c.DownloadString("http://www.habbo.nl/extradata/public/users/" + o["uniqueId"] + "/photos");

            if (dongs2 == "[]") // if the user doesnt have any images we will just show this
            {
                HabboPicture1.ImageLocation = "http://i.imgur.com/4mUSq01.png";
                HabboPicture2.ImageLocation = "http://i.imgur.com/4mUSq01.png";
            }
            else
            { 
            var parsepic = JArray.Parse(dongs2.ToString());
            var pic1 = parsepic[0]["url"].ToString();
            var pic2 = parsepic[1]["url"].ToString();

            HabboPicture1.ImageLocation = "http:" + pic1;
            HabboPicture2.ImageLocation = "http:" + pic2;
            }
        }

        private void sKoreButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))    
            {
                MessageBox.Show("Fill in a username", "Error");
            }
            else {
                getPic(textBox1.Text);
            }
         

        }
    }
}
