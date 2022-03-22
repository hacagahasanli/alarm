using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
        }

        private void Alarm_Load(object sender, EventArgs e)
        {
            timer_now.Start();
        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            tb_indi.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tb_indi.Text == tb_vaxt.Text)
            {
                tb_indi.Stop();
            }
        }
    }
}
