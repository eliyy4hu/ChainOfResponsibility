namespace ChainOfResponsibility
{
    public class FiveHundredRubleHandler : RubleHandlerBase
    {
        public FiveHundredRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }

        protected override int Value => 500;
    }
}