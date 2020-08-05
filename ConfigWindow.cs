using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUNT
{
    public partial class ConfigWindow : Form
    {
        bool radar, relation, route, health;
        int radarSize;
        public ConfigWindow()
        {
            InitializeComponent();
        }
        public bool getRadar() => radar;
        public bool getRelation() => relation;
        public bool getRoute() => route;
        public bool getHealth() => health;
        public int getRadarSize() => radarSize;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            radar = radioButtonRadarYes.Checked;
            relation = radioButtonRelationYes.Checked;
            route = radioButtonRouteYes.Checked;
            health = radioButtonHealthYes.Checked;
            radarSize = trackBarRadar.Value;
        }

        private void trackBarRadar_Scroll(object sender, EventArgs e)
        {
            labelRadarSize.Text = "RADIO: " + trackBarRadar.Value + " PIXELES";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonRadarYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRadarYes.Checked == true)
            {
                trackBarRadar.Enabled = true;
                labelRadarSize.Enabled = true;
            }
            else
            {
                trackBarRadar.Enabled = false;
                labelRadarSize.Enabled = false;
            }
        }
    }
}
