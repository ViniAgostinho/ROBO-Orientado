using System;
using System.Collections.Generic;

namespace Becomex.Narwal.ROBO.Infra.Base.Validation
{
    public class Validator<TEntity> : IValidator<TEntity> where TEntity : class
    {
        private readonly Dictionary<string, IRule<TEntity>> _validations = new Dictionary<string, IRule<TEntity>>();

        public virtual ValidationResult Validate(TEntity entity)
        {
            ValidationResult validationResult = new ValidationResult();
            foreach (string key in this._validations.Keys)
            {
                IRule<TEntity> validation = this._validations[key];
                validation.Set(entity);
                if (!validation.Validate())
                    validationResult.Add(new ValidationError(validation.ErrorMessage));
            }
            return validationResult;
        }

        public void ValidateException(TEntity entity)
        {
            var validator = Validate(entity);
            if (!validator.IsValid)
                throw new Exception(validator.ToString());
        }

        protected virtual void Add(IRule<TEntity> rule)
        {
            this._validations.Add(rule.GetName(), rule);
        }
    }
}
