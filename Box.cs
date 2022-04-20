public class Box
{
    public int Width { get; set; } 
    public int Length { get; init; }
    public int Height { get; init; }

    public Box(int l, int h, int w)
    {
        Width = w;
        Length = l;
        Height = h;
    }
    public int Volume()
    {
        return Length *  Width * Height;
    }

   
    public override string ToString()
    {
        string msg = $"\n{this.GetType()}";
        msg += $"\nLength: {Length}";
        msg += $"\nWidth: {Width}";
        msg += $"\nHeight: {Height}";

        return msg;
    }

    public override bool Equals(object obj)
    {
        Box box = (Box)obj;

        return this.Height == box.Height && this.Width == box.Width && this.Length == box.Length;
    }
}