
namespace Discord.CustomControls
{
    partial class UserControl1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btButton1 = new Discord.CustomControls.BTButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(167)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIRECT MESSAGES";
            // 
            // btButton1
            // 
            this.btButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btButton1.BorderRadius = 0;
            this.btButton1.BorderSize = 0;
            this.btButton1.FlatAppearance.BorderSize = 0;
            this.btButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(167)))), ((int)(((byte)(171)))));
            this.btButton1.Location = new System.Drawing.Point(208, -6);
            this.btButton1.Name = "btButton1";
            this.btButton1.Size = new System.Drawing.Size(29, 32);
            this.btButton1.TabIndex = 1;
            this.btButton1.Text = "+";
            this.btButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(167)))), ((int)(((byte)(171)))));
            this.btButton1.UseVisualStyleBackColor = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.btButton1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(237, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BTButton btButton1;
    }
}
