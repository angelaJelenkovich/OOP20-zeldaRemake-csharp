using System.Windows.Forms;
namespace ZeldaRemake
{
    partial class Lv1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(HeroController heroController)
        {
            heroBox = heroController.GetHeroBox();
            ((System.ComponentModel.ISupportInitialize)(this.heroBox)).BeginInit();
            SuspendLayout();
            // 
            // heroBox
            // 
            /*this.heroBox.BackColor = System.Drawing.Color.Transparent;
            this.heroBox.BackgroundImage = global::ZeldaRemake.Properties.Resources.adventurer_walk1;
            this.heroBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heroBox.InitialImage = null;
            this.heroBox.Location = new System.Drawing.Point(20, 225);
            this.heroBox.Name = "heroBox";
            this.heroBox.Size = new System.Drawing.Size(40, 50);*/
            heroBox.TabIndex = 0;
            heroBox.TabStop = false;
            // 
            // Lv1
            // 
            BackgroundImage = global::ZeldaRemake.Properties.Resources.lv;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(882, 603);
            Controls.Add(heroBox);
            Name = "Lv1";
            Text = "Zelda Remake";
            ResumeLayout(false);
        }

        

        #endregion

        public System.Windows.Forms.PictureBox heroBox;
    }
}