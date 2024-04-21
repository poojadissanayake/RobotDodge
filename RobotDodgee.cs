using SplashKitSDK;
#nullable disable

public class RobotDodgee
{

    private Player player;
    private Window gameWindow;
    private Robot testRobot;
    public bool Quit { get { return player.Quit; } }

    public RobotDodgee(Window gameWindow)
    {
        this.gameWindow = gameWindow;
        player = new Player(gameWindow);
        testRobot = RandomRobot();
    }

    public void HandleInput()
    {
        player.HandleInput();
        player.StayOnWindow(gameWindow);
    }

    public void Draw()
    {
        gameWindow.Clear(Color.Beige);
        testRobot.Draw();
        player.Draw();
        gameWindow.Refresh(60);
    }

    public void Update() { 
        if(player.CollidedWith(testRobot)) {
            testRobot = RandomRobot();
        }
    }

    public Robot RandomRobot() {
        return new Robot(gameWindow);
    }

}