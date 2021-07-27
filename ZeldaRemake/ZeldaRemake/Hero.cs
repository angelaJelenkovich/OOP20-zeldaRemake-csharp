using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ZeldaRemake
{
    public class Hero
    {
        private int posx;
        private int posy;
        private int life;
        private const String imgPath = "Resources/adventurer_walk1.png";
        private const int hero_widht = 40;
        private const int hero_height = 50;

        public int Posx { get => posx; set => posx = value; }
        public int Posy { get => posy; set => posy = value; }
        public int Life { get => life;}

        public int GetHero_widht => hero_widht;

        public int GetHero_height { get => hero_height; }

        public string GetImgPath() => imgPath;

        public Hero(int x, int y)
        {
            this.life = 3;
            this.posx = x;
            this.posy = y;
            _ = Image.FromFile(imgPath);
        }

        
        public void DownLife()
        {
            this.life--;
        }

        public void UpdateX (int x)
        {
            this.Posx = x;
        }

        public void UpdateY (int y)
        {
            this.Posy = y;
        }

    }
}
