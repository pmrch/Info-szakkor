namespace osztaly
{
    internal class Customer_CLASS
    {
        // Az elnevezés elve: adattípus kezdőbetűje, követi az adat neve
        private int iID;
        private string sNAME;
        private string sCITY;

        public Customer_CLASS(int v1, string v2, string v3)
        {
            this.iID = v1;
            this.sNAME = v2;
            this.sCITY = v3;
        }
    }
}