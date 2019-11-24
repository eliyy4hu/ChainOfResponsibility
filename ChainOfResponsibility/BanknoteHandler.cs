using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public abstract class BanknoteHandler
    {
        private readonly BanknoteHandler _nextHandler;
        public virtual CurrencyType CurrencyType { get; }

        protected BanknoteHandler(BanknoteHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }


        public virtual HashSet<Banknote> CacheOut(int value, CurrencyType currencyType, HashSet<Banknote> banknotes)
        {
            switch (_nextHandler)
            {
                case null when value != 0:
                    return null;
                case null when value == 0:
                    return banknotes;
                default:
                    return _nextHandler?.CacheOut(value, currencyType, banknotes);
            }
        }
    }
}