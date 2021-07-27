using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaRemake
{ 
    public class HeroGoController
    {
        public Lv1 l;
        public HeroController heroController;
        private const int Move = 6;
        public HeroGoController()
        {
            heroController = new HeroController(40, 40);
            l = new Lv1(heroController, this);
            l.ShowDialog();
        }

        public void Up()
        {
            heroController.GetHeroView().SetPosition(heroController.GetHeroModel().Posx, heroController.GetHeroModel().Posy - Move);
            heroController.GetHeroModel().UpdateY(heroController.GetHeroModel().Posy - Move);
        }

        public void Down()
        {
            heroController.GetHeroView().SetPosition(heroController.GetHeroModel().Posx, heroController.GetHeroModel().Posy + Move);
            heroController.GetHeroModel().UpdateY(heroController.GetHeroModel().Posy + Move);
        }

        public void Right()
        {
            heroController.GetHeroView().SetPosition(heroController.GetHeroModel().Posx + Move, heroController.GetHeroModel().Posy);
            heroController.GetHeroModel().UpdateX(heroController.GetHeroModel().Posx + Move);
        }

        public void Left()
        {
            heroController.GetHeroView().SetPosition(heroController.GetHeroModel().Posx - Move, heroController.GetHeroModel().Posy);
            heroController.GetHeroModel().UpdateX(heroController.GetHeroModel().Posx - Move);
        }
    }
}
