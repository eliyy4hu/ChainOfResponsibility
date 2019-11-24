namespace ChainOfResponsibility
{
    public class TwoHundredRubleHandler : RubleHandlerBase
    {
        public TwoHundredRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }

        protected override int Value => 200;
    }
}