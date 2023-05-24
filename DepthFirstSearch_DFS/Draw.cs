namespace DepthFirstSearch_DFS;

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

    private Queue<Coord> queue;


    public void BreathFirstSearch(int x, int y, int v)
    {
        queue = new Queue<Coord>();
        queue.Enqueue(new Coord(x, y));
        while (queue.Count() > 0)
        {
            var coord = queue.Dequeue();
            SetMap(coord.x, coord.y, 6);
            Thread.Sleep(30);
            Dequeue(coord.x - 1, coord.y, 2);
            Dequeue(coord.x + 1, coord.y, 3);
            Dequeue(coord.x, coord.y - 1, 4);
            Dequeue(coord.x, coord.y + 1, 5);
        }
    }

    private void Dequeue(int a, int b, int v)
    {
        if (!IsEmpty(a, b))
            return;

        SetMap(a, b, v);
        queue.Enqueue(new Coord(a, b));
    }

    public void DepthFirstSearch(int x, int y, int v)
    {
        stack = new Stack<Coord>();
        stack.Push(new Coord(x, y));
        while (stack.Count() > 0)
        {
            var coord = stack.Pop();
            SetMap(coord.x, coord.y, v);
            Thread.Sleep(30);
            Push(coord.x - 1, coord.y, 2);
            Push(coord.x + 1, coord.y, 3);
            Push(coord.x, coord.y - 1, 4);
            Push(coord.x, coord.y + 1, 5);
        }
    }


    private Stack<Coord> stack;
    private void Push(int a, int b, int v)
    {
        if (!IsEmpty(a, b))
            return;

        SetMap(a, b, v);
        stack.Push(new Coord(a, b));
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

struct Coord
{
    public int x;
    public int y;

    public Coord(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}