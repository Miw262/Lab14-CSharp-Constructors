var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    private int? NumOfSide;
    
    // ทำให้คอนสตรัคเตอร์ที่ไม่มีพารามิเตอร์เป็น protected
    protected Shape()
    {
    }

    // คอนสตรัคเตอร์ที่รับพารามิเตอร์
    public Shape(int NumOfSide) : this()
    {
        this.NumOfSide = NumOfSide;
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base(0)  // ค่า 0 สำหรับจำนวนข้างของวงกลม
    {
        System.Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4)  // ค่า 4 สำหรับจำนวนข้างของสี่เหลี่ยม
    {
        System.Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
   public Triangle() : base(3)  // ค่า 3 สำหรับจำนวนข้างของสามเหลี่ยม
   {
        System.Console.WriteLine("This is a triangle");
   }
}
