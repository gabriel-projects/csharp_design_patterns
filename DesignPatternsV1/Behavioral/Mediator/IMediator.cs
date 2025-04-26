namespace DesignPatternsV1.Behavioral.Mediator
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
} 