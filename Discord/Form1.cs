using Discord.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord
{
    public partial class Form1 : Form
    {
        public Form1(int id,string username,byte[] image)
        {
            InitializeComponent();
            tableLayoutPanel1.VerticalScroll.Maximum = 0;
            tableLayoutPanel1.HorizontalScroll.Maximum = 0;
            tableLayoutPanel1.AutoScroll = true;
            for (int i = 0; i < 10; i++)
            {
                BTIconBar icon = new BTIconBar(Properties.Resources.Icon, i);
                tableLayoutPanel1.RowStyles.Clear();
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60f));
                tableLayoutPanel1.Controls.Add(icon);
            }
            BetterFriends test = new BetterFriends(id, username, image) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel3.Controls.Add(test);
            test.Show();
        }

    }
}
