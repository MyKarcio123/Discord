using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord.CustomControls
{
    public class IconBar : RadioButton
    {
        private int serverID;
        public IconBar(int id)
        {
            this.serverID = id;
            this.Size = new Size(50, 50);
            this.BackgroundImage = Properties.Resources.Icon;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.Appearance = Appearance.Button;
            this.Anchor = AnchorStyles.Top;
            this.FlatStyle = FlatStyle.Flat;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            MessageBox.Show(serverID.ToString());
        }
    }
}
