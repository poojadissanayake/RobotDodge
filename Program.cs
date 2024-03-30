using System;
using SplashKitSDK;

namespace RobotDodge
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("RobotDodge", 600, 600);
            Player player = new Player(window);

            window.Clear(Color.Beige);
            player.Draw();
            window.Refresh(60);
            SplashKit.Delay(60000);
            

        }
    }
}
