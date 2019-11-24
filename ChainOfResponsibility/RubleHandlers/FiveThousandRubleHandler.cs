namespace ChainOfResponsibility
{
    public class FiveThousandRubleHandler : RubleHandlerBase
    {
        public FiveThousandRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }

        protected override int Value => 5000;
    }
}