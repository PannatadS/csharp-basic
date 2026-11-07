namespace DisplayResult
{
    internal class Program
    {
        enum Color { Yellow = 1, Blue, Green};
        static void Main(string[] args)
        {
            Console.Write("Write"); // Write(ข้อความ/ตัวเลข/ตัวแปร/เมธอด/ตัวดำเนินการ) แสดงผลและไม่ขึ้นบรรทัดใหม่
            Console.WriteLine("WriteLine"); // แสดงผลแล้วขึ้นบรรทัดใหม่
            Console.WriteLine(5+10);
            Console.WriteLine(10==5);
        }
    }
}
