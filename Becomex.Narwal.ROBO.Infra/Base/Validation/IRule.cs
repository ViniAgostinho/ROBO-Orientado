namespace Becomex.Narwal.ROBO.Infra.Base.Validation
{
    public interface IRule<in TEntity>
    {
        void Set(TEntity entity);
        string ErrorMessage { get; }
        bool Validate();
        string GetName();
    }
}
