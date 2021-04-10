namespace Bank
{
    class Account : IAccount
    {
        public double Balance { get; set; }

        public string Owner { get; private set; }
        private static int counter = 0;
        public int Id { get; set; }

        public Account(double openingBalance, string owner)
        {
            Balance = openingBalance;
            Owner = owner;
            Id = System.Threading.Interlocked.Increment(ref counter);
        }

        public override string ToString()
        {
            return $"Účet číslo: {Id}\nVlastník účtu: {Owner}\nZůstatek: {Balance}\n\n";
        }

    }
}
