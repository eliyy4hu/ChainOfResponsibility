namespace ChainOfResponsibility
{
    public class ThousandRubleHandler : RubleHandlerBase
    {
        public ThousandRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }

        protected override int Value => 1000;
    }
}