using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TanksGame_V4.GameObjects;
using TanksGame_V4.Interface;

namespace TanksGame_V4
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();

        }

        private void main_locmp_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            locmpPanel.Visible = true;
            mainPanel.Enabled = false;
            locmpPanel.Enabled = true;
        }

        private void locmp_back_Click(object sender, EventArgs e)
        {
            locmpPanel.Visible = false;
            mainPanel.Visible = true;
            mainPanel.Enabled = true;
            locmpPanel.Enabled = false;
        }

        private void main_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainLANMultiplayer_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            lanmpPanel.Visible = true;
            lanmpPanel.Enabled = true;
            mainPanel.Enabled = false;
        }

        private void lanmpBack_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            lanmpPanel.Visible = false;
            lanmpPanel.Enabled = false;
            mainPanel.Enabled = true;
        }

        private void locmpPlayerNumber2_Click(object sender, EventArgs e)
        {
            GameRender gameRender = new GameRender(this, 2);
            locmpPanel.Visible = false;
            locmpPanel.Enabled = false;
            mainPanel.Enabled = false;
        }

        private void locmpPlayerNumber3_Click(object sender, EventArgs e)
        {
            GameRender gameRender = new GameRender(this, 3);
            locmpPanel.Visible = false;
            locmpPanel.Enabled = false;
            mainPanel.Enabled = false;
        }

        private void locmpPlayerNumber4_Click(object sender, EventArgs e)
        {
            GameRender gameRender = new GameRender(this, 4);
            locmpPanel.Visible = false;
            locmpPanel.Enabled = false;
            mainPanel.Enabled = false;
        }

        private void mainOptions_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            mainPanel.Enabled = false;
            optionsPanel.Enabled = true;
            optionsPanel.Visible = true;
        }

        private void optionsBack_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            mainPanel.Enabled = true;
            optionsPanel.Enabled = false;
            optionsPanel.Visible = false;
        }

        private void ContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                this.KeyPreview = true;

                switch (e.RowIndex)
                {
                    case (0):
                        {
                            kybBindingsSetting[1, 0].Value = "F";
                            break;
                        }
                }
            }
            this.KeyPreview = false;

        }

        private void HostBack_Click(object sender, EventArgs e)
        {
            lanmpPanel.Visible = true;
            lanmpPanel.Enabled = true;
            HostPanel.Visible = false;
            HostPanel.Enabled = false;
        }

        private void lanmpHost_Click(object sender, EventArgs e)
        {
            lanmpPanel.Visible = false;
            lanmpPanel.Enabled = false;
            HostPanel.Visible = true;
            HostPanel.Enabled = true;
        }
    }
}
