using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTime
{
    public partial class Form1 : Form
    {
        private static Timer timer = new Timer();
        private DateTime start;
        private void ShowWorkTime(object sender, EventArgs e)
        {
            Text = (DateTime.Now - start).TotalMilliseconds.ToString();

        }
        public Form1()
        {
            InitializeComponent();
            start = DateTime.Now;
            timer.Tick += new EventHandler(ShowWorkTime);
            timer.Interval = 1;
            timer.Start();
        }
    }
}
