using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public abstract class BanknoteHandlerBase : BanknoteHandler
    {
        protected BanknoteHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }

        public override HashSet<Banknote> CacheOut(int value, CurrencyType currencyType, HashSet<Banknote> banknotes)
        {
            if (currencyType == CurrencyType)
            {
                while (value >= Value)
                {
                    banknotes.Add(new Banknote(Value, currencyType));
                    value -= Value;
                }
            }

            return base.CacheOut(value, currencyType, banknotes);
        }

        protected abstract int Value { get; }
    }
}