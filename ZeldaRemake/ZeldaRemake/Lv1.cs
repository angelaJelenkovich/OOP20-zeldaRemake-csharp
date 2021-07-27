using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZeldaRemake
{
    public partial class Lv1 : Form
    {
        private HeroGoController heroGo;
        public Lv1(HeroController heroController, HeroGoController heroGoController)
        {
            heroGo = heroGoController;
            InitializeComponent(heroController);
            KeyPress += new KeyPressEventHandler(MyKeyPressEventHandler);
        }


        private void MyKeyPressEventHandler(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('a'))
            {
                heroGo.Left();
            }
            else if (e.KeyChar.Equals('d'))
            {
                heroGo.Right();
            }
            else if (e.KeyChar.Equals('w'))
            {
                heroGo.Up();
            } else if (e.KeyChar.Equals('s'))
            {
                heroGo.Down();
            }
        }

    }
}
