namespace ChainOfResponsibility
{
    public abstract class RubleHandlerBase : BanknoteHandlerBase
    {
        public override CurrencyType CurrencyType => CurrencyType.Ruble;


        protected RubleHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }
    }
}