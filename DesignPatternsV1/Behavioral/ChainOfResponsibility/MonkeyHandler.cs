namespace DesignPatternsV1.Behavioral.ChainOfResponsibility
{
    public class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Banana")
            {
                return $"Monkey: I'll eat the {request}.\n";
            }
            return base.Handle(request);
        }
    }
} 