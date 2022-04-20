//////////////////////////
//  Rectangle ///////////
/////////////////////////
// + <<property>> Length
// + <<property>> Width
//////////////////////////
// + Area() : int
// + Perimeter() : int
//

public class Rectangle
{
    public int Length { get; set; } = 10;
    public int Width { get; set; } = 10;

    public Rectangle()
    {
        Length = 0;
        Width = 0;
    }
    public Rectangle(Rectangle r)
    {
        Length = r.Length;
        Width = r.Width;
    }
    public int Area()
    {
        return Length * Width;
    }
    public int Perimeter()
    {
        return (2 * Length) + (2 * Width);
    }

    public override string ToString()
    {
        string msg = $"\n{this.GetType()}";
        msg += $"\nLength: {Length}";
        msg += $"\nWidth: {Width}";
        msg += $"\nArea: {Area()}";
        msg += $"\nPerimeter: {Perimeter()}";

        return msg;
    }

    public override bool Equals(object obj)
    {
        Rectangle rect = (Rectangle)obj;

        return this.Width == rect.Width && this.Length == rect.Length;
       
    }
}