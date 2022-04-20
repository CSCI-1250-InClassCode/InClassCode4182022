var rect = new Rectangle();

rect.Length = 100;
rect.Width = 25;

var rect1 = new Rectangle(rect);


rect1.Length = 20;

System.Console.WriteLine(rect);
System.Console.WriteLine(rect1);





