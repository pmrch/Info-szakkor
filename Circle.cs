// Adattag

namespace osztaly
{
    internal class Circle
    {
        // mivel private, az osztályt használó program nem látja r-t
        // ez az adattag
        private double r;

        // Constructor, mindig public a módosítója,
        // hogy egész programban használható legyen
        public Circle(double r)
        {
            this.r = r;
        }

        // void-dal jött létre, mert nem adtunk neki paramétert
        internal void printA()
        {
            // Kör területe
            double A = (Math.Pow(r, 2) * Math.PI);
            Console.WriteLine(A);
        }

        internal void printP()
        {
            // Kör kerülete
            double P = (2 * r * Math.PI);
            Console.WriteLine(P);
        }
    }
}