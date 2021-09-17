using System;
using Discord.CustomControls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Discord
{
    public partial class FriendList : Form
    {
        private DBConnect db = new DBConnect();
        public FriendList(int type,int id)
        {
            InitializeComponent();
            List<string[]> users = db.friendList(id, type);
            foreach (var res in users)
            {
                res[3] = UpdateTag(res[3]);
                Image profile = Image.FromStream(new MemoryStream(Convert.FromBase64String(res[1])));
                FriendButton friend = new FriendButton(profile,res[0],res[3],res[2]) { Dock = DockStyle.Top };
                panel1.Controls.Add(friend);
            }
        }
        private string UpdateTag(string tag)
        {
            while (tag.Length < 4)
            {
                tag = "0" + tag;
            }
            tag = "#" + tag;
            return tag;
        }
    }
}
