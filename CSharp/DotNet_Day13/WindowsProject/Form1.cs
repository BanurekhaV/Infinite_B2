using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
       
        //method that will count the number of characters in a given file
         private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("DataFile.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;  //counts the no.of characters
                Thread.Sleep(5000);
            }
            return count;
        }

        //this event is running synchronously
        //private void btn_msg_Click(object sender, EventArgs e)
        //{
        //    label2.Text = txtName.Text;
        //    label2.Visible = true;
        //    label2.Enabled = false;
        //    int ch = CountCharacters(); //calling the func
        //    label2.Text = "Processing character count, Please wait ....";
        //    label2.Text = ch.ToString();
        //}

        //asynchronously
        private async void btn_msg_Click(object sender, EventArgs e)
        {
            Task<int> mytask = new Task<int>(CountCharacters);
            mytask.Start();
            label2.Text = "Processing Character Count, please wait...";
            txtName.Text = "Waiting for count value";
            int ch = await mytask;
            label2.Text = ch.ToString() + " " + "Characters were found in the file";

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Windows..");
        }
    }
}
