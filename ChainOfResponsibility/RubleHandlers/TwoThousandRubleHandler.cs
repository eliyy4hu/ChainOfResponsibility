namespace ChainOfResponsibility
{
    public class TwoThousandRubleHandler : RubleHandlerBase
    {
        public TwoThousandRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }

        protected override int Value => 2000;
    }
}