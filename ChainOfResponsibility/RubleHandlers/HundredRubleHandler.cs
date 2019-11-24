namespace ChainOfResponsibility
{
    public class HundredRubleHandler : RubleHandlerBase
    {
        public HundredRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }

        protected override int Value => 100;
    }
}