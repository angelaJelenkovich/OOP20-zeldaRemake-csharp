using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZeldaRemake
{
    public class HeroView
    {
        public PictureBox HeroBox { get; }

        public HeroView()
        {
            HeroBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)HeroBox).BeginInit();
            HeroBox.Name = "heroBox";
            HeroBox.Size = new Size(40, 50);
            HeroBox.TabIndex = 0;
            HeroBox.TabStop = false;
        }


        public void SetSize(int height, int widht) => HeroBox.Size = new Size(widht, height);


        public void SetImg(string img)
        {
            HeroBox.BackColor = Color.Transparent;
            HeroBox.BackgroundImage = global::ZeldaRemake.Properties.Resources.adventurer_walk1;
            HeroBox.BackgroundImageLayout = ImageLayout.Stretch;
            HeroBox.InitialImage = null;
        }
        
        public void SetPosition(int x, int y)
        {
            HeroBox.Location = new Point(x, y);
        }

        public PictureBox GetHeroBoxView()
        {
            return HeroBox;
        }
    }
}
