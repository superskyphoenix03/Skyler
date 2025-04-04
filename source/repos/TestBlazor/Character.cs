public class Character
{
    public int X { get; set; }
    public int Y { get; set; }

    public Character(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Move(string direction)
    {
        switch (direction)
        {
            case "up":
                Y--;
                break;
            case "down":
                Y++;
                break;
            case "left":
                X--;
                break;
            case "right":
                X++;
                break;
        }
    }
}
