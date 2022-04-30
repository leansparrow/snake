namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1=new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sim = '*';
            p1.Draw();
            
            /*int x1 = 1;
            int y1 = 3;
            char sim1 = '*';*/

            /*Draw(p1.x,p1.y,p1.sim);*/

            Point p2=new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sim = '#';
            p2.Draw();
            /*int x2 = 4;
            int y2 = 5;
            char sim2 = '#';*/
            /*Draw(p2.x, p2.y, p2.sim);*/

            Console.ReadLine();
        }
        /*static void Draw(int x, int y, char sim)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }*/
    }
}