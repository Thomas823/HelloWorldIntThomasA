/*
 * Created by: Thomas Aubin
 * Created on: 5 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #5 - Hello Wolrd International
 * This program display's hello world in various languages
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldIntThomasA
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        // Display hello world in english
        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello World!";
        }

        // Display hello world in french
        private void radFrench_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Bonjour Le Monde!";
        }

        // Display hello world in chinese
        private void radChinese_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "你好，世界!";
        }

        // Display hello world in arabic
        private void radArabic_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "مرحبا بالعالم!";
        }
    }
}