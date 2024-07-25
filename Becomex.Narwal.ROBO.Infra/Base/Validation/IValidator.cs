namespace Becomex.Narwal.ROBO.Infra.Base.Validation
{
    public interface IValidator<in TEntity>
    {
        ValidationResult Validate(TEntity entity);
    }
}
