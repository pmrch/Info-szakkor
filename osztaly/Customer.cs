namespace osztaly
{
    internal class Customer
    {
        static void Main(string[] args)
        {

            Customer_CLASS c = new Customer_CLASS(10, "PAUL", "LONDON");
            
            // 10-elemű tömb Customer_CLASS típusban
            Customer_CLASS[] tomb = new Customer_CLASS[10];
            
            // Már nem is tudom
            List<Customer_CLASS> list = new List<Customer_CLASS>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(new Customer_CLASS(i, "PETER", "SZEGED"));
            }
        }
    }
}
