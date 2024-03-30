using SplashKitSDK;
#nullable disable

public class Player
{

    private Bitmap _PlayerBitmap;
    private Window _gameWindow;

    public double X { get; private set; }
    public double Y { get; private set; }

    // auto-property. Where C# adds the code and fields 
    public int Width
    {
        get
        {
            return _PlayerBitmap.Width;
        }
    }

    public int Height
    {
        get
        {
            return _PlayerBitmap.Height;
        }
    }

    public Player(Window gameWindow)
    {
        _PlayerBitmap = new Bitmap("player", "Player.png");
        _gameWindow = gameWindow;
        X = (_gameWindow.Width - Width) / 2;
        Y = (_gameWindow.Height - Height) / 2;

    }

    public void Draw()
    {
        _PlayerBitmap.Draw(X, Y);
    }
}
