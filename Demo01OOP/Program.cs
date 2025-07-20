namespace Demo01OOP
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("V01");

            Point P01;

            //Console.WriteLine(P01.x);
            //Console.WriteLine(P01.y);

            //P01.x = 12;
            //P01.y = 12;

            //Console.WriteLine(P01.x);
            //Console.WriteLine(P01.y);

            P01 = new Point(1,2); 

            //Console.WriteLine(P01.x);   
            //Console.WriteLine(P01.y);   

            //Console.WriteLine(P01);

            //P01.PrintPoint();

            Console.WriteLine(P01); 

        }
    }
}
