using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai14_tinhtoantrongdayso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sodau = Convert.ToInt32(txtsodau.Text);
            int socuoi = Convert.ToInt32(txtsocuoi.Text);
            int chan = 0;
            int le = 0;
            txttongchan.Text = "";
            txttongle.Text= "";
           /* for (int i = sodau; i <= socuoi; i++)

                if (i % 2 == i)
                {
                    chan += i;
                }
                else
                {
                    le += i;
                }*/
           while (sodau <= socuoi)
            {
                if (sodau % 2 == 0)
                {
                    chan += sodau;
                }
                else
                {
                    le += sodau;
                }
                sodau++;
            }


            txttongchan.Text = chan.ToString();
                txttongle.Text = le.ToString();
                txttatca.Text = (chan + le).ToString();
           

            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
