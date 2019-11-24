namespace ChainOfResponsibility
{
    public abstract class DollarHandlerBase : BanknoteHandlerBase
    {
        public override CurrencyType CurrencyType => CurrencyType.Dollar;


        protected DollarHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }
    }
}