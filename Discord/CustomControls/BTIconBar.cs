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
    class BTIconBar : BTButton
    {
        bool clicked;
        private EventHandler hover;
        public BTIconBar(Image background,int id)
        {
            clicked = false;
            this.BackgroundImage = background;
            this.Size = new Size(50, 50);
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.Text = "";
            this.Anchor = AnchorStyles.Top;
            this.FlatStyle = FlatStyle.Flat;
            this.BorderRadius = 25;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BorderRadius = 20;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BorderRadius = 25;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BTIconBar
            // 
            this.FlatAppearance.BorderSize = 0;
            this.ResumeLayout(false);

        }
    }
}
