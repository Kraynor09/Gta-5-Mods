
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GTA;
using GTA.Math;
using GTA.Native;
using GTA.NaturalMotion;

namespace gta
{
    public class Class1 : Script
    {

        public Ped Testped;
        public Vehicle Testvehicle;
        public Player playername;
        string modmaker = "kyle";
        bool firsttime = true;
        public Class1()
        {
            Tick += OnTick;
            KeyDown += OnkeyDown;
        }
        public void OnTick(object sender, EventArgs e)
        {
            OnKeyDown();
        }

        public void OnKeyDown()
        {
            if (Game.IsControlJustPressed(2, GTA.Control.Context))
            {
                Testvehicle = World.CreateVehicle(VehicleHash.Nero, Game.Player.Character.Position.Around(5));
            }
        }
        public void OnkeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                Testped = World.CreatePed(PedHash.Michael, Game.Player.Character.Position.Around(5));
            }
        }

        public void wantedlevel(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                if (Game.Player.WantedLevel == 0)
                {
                    UI.ShowSubtitle("you have no wanted level");
                }
            }
            else if (e.KeyCode == Keys.W)
            {
                Game.Player.WantedLevel = 3;
            }
            else
            {
                Game.Player.WantedLevel = 0;
            }
           
        }


        public void user_name(object sender, KeyEventArgs e)
        {
            if(firsttime)
            {
                UI.Notify(modmaker);
            }
            
        }


        public void pissof(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                UI.Notify("lolololo");
            }
          
        }



        protected override void Dispose(bool A_0)
        {
            if (A_0)
            {
                if (Testped != null)
                {
                    Testped.Delete();
                }
                if (Testvehicle != null)
                {
                    Testvehicle.Delete();
                    UI.Notify("deleted");
                }

            }
        }
    }
}



