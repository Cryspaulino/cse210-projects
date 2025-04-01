// using Raylib_cs;
public abstract class GameObject
{
    protected int _x;
    protected int _y;
    protected int _width;
    protected int _height;

    public GameObject(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public abstract void Draw();

    public virtual int GetLeftEdge()
    {
        return _x;
    }

    public virtual int GetRightEdge()
    {
        return _x + _width;
    }

    public virtual int GetTopEdge()
    {
        return _y;
    }

    public virtual int GetBottomEdge()
    {
        return _y + _height;
    }
}




//