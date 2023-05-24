namespace DepthFirstSearch_Recursion_DFS;

public class Draw
{
    private int w;
    private int h;
    private int[,] map;
    private string symbols = " #<>^vx";

    private ConsoleColor[] colors =
    {
        ConsoleColor.White,
        ConsoleColor.DarkBlue,
        ConsoleColor.Yellow,
        ConsoleColor.Yellow,
        ConsoleColor.Yellow,
        ConsoleColor.Yellow,
        ConsoleColor.Cyan
    };

    public Draw(int w, int h)
    {
        this.w = w;
        this.h = h;
        this.map = new int[w, h];
    }

    public void SetMap(int x, int y, int value)
    {
        map[x, y] = value;
        Console.ForegroundColor = colors[value];
        Console.SetCursorPosition(x, y);
        Console.Write(symbols[value]);
        Console.SetCursorPosition(0, 0);
    }

    public void DepthFirstSeachRecursion(int x, int y, int v)
    {
        if (!IsEmpty(x, y))
            return;
        SetMap(x, y, v);
        Thread.Sleep(30);
        DepthFirstSeachRecursion(x - 1, y, 2);
        DepthFirstSeachRecursion(x + 1, y, 3);
        DepthFirstSeachRecursion(x, y - 1, 4);
        DepthFirstSeachRecursion(x, y + 1, 5);
        SetMap(x, y, 6);
    }

    public void AddRandomPixels(int count)
    {
        Random random = new Random(1234);
        for (int i = 0; i < count; i++)
            SetMap(random.Next(w), random.Next(h), 1);
    }

    public void Frame()
    {
        for (int x = 0; x < w; x++)
            for (int y = 0; y < h; y++)
            {
                if (x == 0 || y == 0 || x == w - 1 || y == h - 1)
                    SetMap(x, y, 1);
            }
    }

    public bool IsEmpty(int x, int y)
    {
        if (x < 0) return false;
        if (y < 0) return false;
        if (x > w - 1) return false;
        if (y > h - 1) return false;

        return map[x, y] == 0;
    }
}