namespace ChainOfResponsibility
{
    public class FiftyRubleHandler : RubleHandlerBase
    {
        public FiftyRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }

        protected override int Value => 50;
    }
}