using System;
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility
{
    public class Bancomat
    {
        private readonly BanknoteHandler _handler;

        public Bancomat()
        {
            _handler = new TenRubleHandler(null);
            _handler = new FiftyRubleHandler(_handler);
            _handler = new HundredRubleHandler(_handler);
            _handler = new TwoHundredRubleHandler(_handler);
            _handler = new FiveHundredRubleHandler(_handler);
            _handler = new ThousandRubleHandler(_handler);
            _handler = new TwoThousandRubleHandler(_handler);
            _handler = new FiveThousandRubleHandler(_handler);
            _handler = new TenDollarHandler(_handler);
            _handler = new FiftyDollarHandler(_handler);
            _handler = new HundredDollarHandler(_handler);
        }


        public void CacheOut(int value, CurrencyType currencyType)
        {
            var banknotes = _handler.CacheOut(value, currencyType, new HashSet<Banknote>());
            if (banknotes == null)
            {
                Console.WriteLine("Not valid input");
            }
            else
            {
                Console.WriteLine("Success!");
                foreach (var banknote in banknotes.ToList().OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{banknote.Value} {banknote.Currency}");
                }
            }
        }
    }
}