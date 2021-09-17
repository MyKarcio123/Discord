
namespace Discord.CustomControls
{
    partial class FriendButton
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btButton2 = new Discord.CustomControls.BTButton();
            this.btButton1 = new Discord.CustomControls.BTButton();
            this.Desc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tag = new System.Windows.Forms.Label();
            this.Nick = new System.Windows.Forms.Label();
            this.Icon = new Discord.CustomControls.BTButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btButton2);
            this.panel1.Controls.Add(this.btButton1);
            this.panel1.Controls.Add(this.Desc);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Icon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 38);
            this.panel1.TabIndex = 1;
            // 
            // btButton2
            // 
            this.btButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btButton2.BackgroundImage = global::Discord.Properties.Resources.messagesmall;
            this.btButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btButton2.BorderRadius = 18;
            this.btButton2.BorderSize = 0;
            this.btButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btButton2.FlatAppearance.BorderSize = 0;
            this.btButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btButton2.ForeColor = System.Drawing.Color.White;
            this.btButton2.Location = new System.Drawing.Point(439, 0);
            this.btButton2.Name = "btButton2";
            this.btButton2.Size = new System.Drawing.Size(38, 38);
            this.btButton2.TabIndex = 12;
            this.btButton2.TextColor = System.Drawing.Color.White;
            this.btButton2.UseVisualStyleBackColor = false;
            // 
            // btButton1
            // 
            this.btButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btButton1.BackgroundImage = global::Discord.Properties.Resources.dotssmall;
            this.btButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btButton1.BorderRadius = 18;
            this.btButton1.BorderSize = 0;
            this.btButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.btButton1.FlatAppearance.BorderSize = 0;
            this.btButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btButton1.ForeColor = System.Drawing.Color.White;
            this.btButton1.Location = new System.Drawing.Point(477, 0);
            this.btButton1.Name = "btButton1";
            this.btButton1.Size = new System.Drawing.Size(38, 38);
            this.btButton1.TabIndex = 11;
            this.btButton1.TextColor = System.Drawing.Color.White;
            this.btButton1.UseVisualStyleBackColor = false;
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(167)))), ((int)(((byte)(171)))));
            this.Desc.Location = new System.Drawing.Point(46, 23);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(36, 13);
            this.Desc.TabIndex = 9;
            this.Desc.Text = "Desc";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.Tag);
            this.panel2.Controls.Add(this.Nick);
            this.panel2.Location = new System.Drawing.Point(46, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 20);
            this.panel2.TabIndex = 10;
            // 
            // Tag
            // 
            this.Tag.AutoSize = true;
            this.Tag.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(167)))), ((int)(((byte)(171)))));
            this.Tag.Location = new System.Drawing.Point(35, 0);
            this.Tag.Margin = new System.Windows.Forms.Padding(0);
            this.Tag.Name = "Tag";
            this.Tag.Size = new System.Drawing.Size(35, 15);
            this.Tag.TabIndex = 4;
            this.Tag.Text = "#tag";
            // 
            // Nick
            // 
            this.Nick.AutoSize = true;
            this.Nick.Dock = System.Windows.Forms.DockStyle.Left;
            this.Nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nick.Location = new System.Drawing.Point(0, 0);
            this.Nick.Margin = new System.Windows.Forms.Padding(0);
            this.Nick.Name = "Nick";
            this.Nick.Size = new System.Drawing.Size(35, 15);
            this.Nick.TabIndex = 3;
            this.Nick.Text = "Nick";
            // 
            // Icon
            // 
            this.Icon.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Icon.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Icon.BackgroundImage = global::Discord.Properties.Resources.Icon;
            this.Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Icon.BorderRadius = 18;
            this.Icon.BorderSize = 0;
            this.Icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.Icon.FlatAppearance.BorderSize = 0;
            this.Icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Icon.ForeColor = System.Drawing.Color.White;
            this.Icon.Location = new System.Drawing.Point(0, 0);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(38, 38);
            this.Icon.TabIndex = 8;
            this.Icon.TextColor = System.Drawing.Color.White;
            this.Icon.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 1);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FriendButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FriendButton";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 6);
            this.Size = new System.Drawing.Size(525, 61);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private BTButton btButton2;
        private BTButton btButton1;
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Tag;
        private System.Windows.Forms.Label Nick;
        private BTButton Icon;
    }
}
