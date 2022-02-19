using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valentýnvirus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string message = "byl vám hacknut PC :)";
            string title = "";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                message = "Můžu se tě zeptat na otázku?";
                buttons = MessageBoxButtons.OK;
                result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    message = "Will you be my valentine?";
                    buttons = MessageBoxButtons.YesNo;
                    result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("UWU");
                    }
                    else
                    {
                        for (int i = 0; i < 5;)
                        {
                            message = "PROSÍM";
                            buttons = MessageBoxButtons.YesNo;
                            result = MessageBox.Show(message, title, buttons);
                            if (result == DialogResult.No)
                            {
                                i++;
                            }else
                            {
                                MessageBox.Show("UWU");
                                return;
                            }
                        }
                        MessageBox.Show("Fuck u");
                    }
                }
            }

        }
    }
}
