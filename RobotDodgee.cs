using SplashKitSDK;
using System.Collections.Generic;
#nullable disable

public class RobotDodgee
{

    private Player player;
    private Window gameWindow;
    private List<Robot> _Robots;
    public bool Quit { get { return player.Quit; } }

    public RobotDodgee(Window gameWindow)
    {
        this.gameWindow = gameWindow;
        player = new Player(gameWindow);
        _Robots = new List<Robot>();
    }

    public void HandleInput()
    {
        player.HandleInput();
        player.StayOnWindow(gameWindow);
    }

    public void Draw()
    {
        gameWindow.Clear(Color.Beige);

        foreach (Robot robot in _Robots)
        {
            robot.Draw();
        }

        player.Draw();
        gameWindow.Refresh(60);
    }

    public void Update()
    {
        foreach (Robot robot in _Robots)
        {
            robot.Update();
        }

        if (_Robots.Count >= 0)
        {
            _Robots.Add(RandomRobot());
        }

        CheckCollisions();

    }

    private void CheckCollisions()
    {
        List<Robot> toBeRemovedRobots = new List<Robot>();

        foreach (Robot robot in _Robots)
        {
            if (player.CollidedWith(robot) || robot.IsOffscreen(gameWindow))
            {
                toBeRemovedRobots.Add(robot);
            }

        }

        foreach (Robot bot in toBeRemovedRobots)
        {
            _Robots.Remove(bot);
        }

    }

    public Robot RandomRobot()
    {
        return new Robot(gameWindow, player);
    }

}