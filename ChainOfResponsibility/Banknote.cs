namespace ChainOfResponsibility
{
    public class Banknote : IBanknote
    {
        public Banknote(int value, CurrencyType currencyType)
        {
            Value = value;
            Currency = currencyType;
        }

        public CurrencyType Currency { get; }
        public int Value { get; }
    }
}