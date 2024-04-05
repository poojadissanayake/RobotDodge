using System;
using SplashKitSDK;
#nullable disable

namespace RobotDodge
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("RobotDodge", 600, 600);
            Player player = new Player(window);

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                player.HandleInput();
                player.StayOnWindow(window);

                window.Clear(Color.Beige);
                player.Draw();
                window.Refresh(60);

                if (player.Quit)
                {
                    window.Close();
                    window = null;

                }

            }



        }
    }
}
