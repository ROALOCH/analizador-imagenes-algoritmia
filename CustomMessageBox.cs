using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iP_Etapa2
{
    public partial class CustomMessageBox : Form
    {
        private int limit;
        public CustomMessageBox(bool forInput, string t, string m, string b)
        {
            InitializeComponent();
            labelTitle.Text = t;
            labelMessage.Text = m;
            labelMessageNumeric.Text = m;
            buttonOK.Text = b;
            buttonSendNumeric.Text = b;
            if (forInput)
            {
                panelMessage.Visible = false;
                panelNumeric.Visible = true;
            }
            else
            {
                panelMessage.Visible = true;
                panelNumeric.Visible = false;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            limit = (int)baitLimitNumeric.Value;
            this.Close();
        }
        public int getLimit() => limit;

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
