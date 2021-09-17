using Discord.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord
{
    public partial class BetterFriends : Form
    {
        FriendList currentFirendList;
        BTButton currentButton;
        bool microphone = true;
        bool headphone = true;
        int idGlobal;
        public BetterFriends(int id, string username, byte[] image)
        {
            InitializeComponent();
            MemoryStream mstream = new MemoryStream(image);
            btButton8.BackgroundImage = Image.FromStream(mstream, true);
            UpdateName(id.ToString(), username);
            idGlobal = id;
            currentFirendList = new FriendList(0, idGlobal) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel8.Controls.Add(currentFirendList);
            currentFirendList.Show();
        }

        private void UpdateName(string id,string username)
        {
            label1.Text = username;
            while (id.Length < 4)
            {
                id = "0" + id;
            }
            id = "#" + id;
            label2.Text = id;
        }

        private void btButton4_Click(object sender, EventArgs e)
        {
            if (microphone && headphone) 
            {
                btButton4.BackgroundImage = Properties.Resources.BBMicrophone;
                microphone = false;
            }
            else if (!microphone && !headphone)
            {
                btButton4.BackgroundImage = Properties.Resources.Microphone;
                btButton3.BackgroundImage = Properties.Resources.Headphones;
                microphone = true;
                headphone = true;
            }
            else
            {
                btButton4.BackgroundImage = Properties.Resources.Microphone;
                microphone = true;
            }
        }

        private void btButton3_Click(object sender, EventArgs e)
        {
            if(headphone)
            {
                btButton3.BackgroundImage = Properties.Resources.BHeadphones;
                btButton4.BackgroundImage = Properties.Resources.BBMicrophone;
                headphone = false;
                microphone = false;
            }
            else
            {
                btButton3.BackgroundImage = Properties.Resources.Headphones;
                btButton4.BackgroundImage = Properties.Resources.Microphone;
                headphone = true;
                microphone = true;
            }
        }

        private void btButton6_Click(object sender, EventArgs e)
        {
            listMenager(0);
        }

        private void btButton11_Click(object sender, EventArgs e)
        {
            listMenager(1);
        }

        private void btButton7_Click(object sender, EventArgs e)
        {
            listMenager(2);
        }

        private void btButton9_Click(object sender, EventArgs e)
        {
            listMenager(3);
        }
        private void listMenager(int type)
        {
            currentFirendList.Close();
            currentFirendList = new FriendList(type, idGlobal) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel8.Controls.Add(currentFirendList);
            currentFirendList.Show();
        }
    }
}
