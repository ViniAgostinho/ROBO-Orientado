namespace Becomex.Narwal.ROBO.Infra.Base.Validation
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T entity);
        string GetMessage(T entity);
    }
}
