using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ZeldaRemake
{
    public class HeroController
    {
        private HeroView heroView;
        private Hero heroModel;
    
        public HeroController(int initx, int inity)
        {
            heroModel = new Hero(initx, inity);
            heroView = new HeroView();
            Start();
        }

        public void Start()
        {
            heroView.SetImg(heroModel.GetImgPath());
            heroView.SetPosition(heroModel.Posx, heroModel.Posy);
            heroView.SetSize(heroModel.GetHero_height, heroModel.GetHero_widht);
        }

        public Hero GetHeroModel()
        {
            return heroModel;
        }

        
        public HeroView GetHeroView()
        {
            return heroView;
        }

        public PictureBox GetHeroBox()
        {
            return heroView.HeroBox;
        }

    }
}
