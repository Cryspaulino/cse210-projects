// using Raylib_cs;
public class Player : GameObject
{

    public Player(int x, int y): base (x, y)
    {

    }

    public override void Draw()
    {
        Raylib.DrawRectangle((int)_x,(int) _y, 50, 10, Color.Blue);
    }
}



