namespace ChainOfResponsibility
{
    public class TenRubleHandler : RubleHandlerBase
    {
        public TenRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }

        protected override int Value => 10;
    }
}