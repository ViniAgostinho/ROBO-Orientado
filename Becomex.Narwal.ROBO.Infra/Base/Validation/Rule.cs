namespace Becomex.Narwal.ROBO.Infra.Base.Validation
{
    public class Rule<TEntity> : IRule<TEntity>
    {
        private readonly ISpecification<TEntity> _specificationSpec;

        private TEntity _entity;
        public Rule(ISpecification<TEntity> spec)
        {
            this._specificationSpec = spec;

        }

        public void Set(TEntity entity)
        {

            _entity = entity;

        }

        public string ErrorMessage { get { return _specificationSpec.GetMessage(_entity); } }

        public bool Validate()
        {
            return this._specificationSpec.IsSatisfiedBy(_entity);
        }

        public string GetName()
        {
            return _specificationSpec.GetType().Name;
        }

    }
}
