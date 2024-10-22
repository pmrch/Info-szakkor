namespace osztaly2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyData md = new MyData("Paul", "Bgy", 1234);
            string path = @"data.txt";
            List<MyData> list = new List<MyData>();

            if (File.Exists(path)) 
            {
                foreach (string line in File.ReadAllLines(path).Skip(1))
                {
                    //Console.WriteLine( line);
                    string[] tmp = line.Split(';');
                    list.Add(new MyData(tmp[0], tmp[1], int.Parse(tmp[2])));
                }
            }
            else
            {
                Console.WriteLine("A fájl nem létezik");
            }
            ;
        }
    }
}
