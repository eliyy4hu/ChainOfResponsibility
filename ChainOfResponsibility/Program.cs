namespace ChainOfResponsibility
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var bankomat = new Bancomat();
            bankomat.CacheOut(9999,CurrencyType.Ruble);
            bankomat.CacheOut(27570,CurrencyType.Ruble);
            bankomat.CacheOut(3000,CurrencyType.Dollar);
            bankomat.CacheOut(3333,CurrencyType.Dollar);
        }
    }
}