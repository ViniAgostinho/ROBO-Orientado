using System.Collections.Generic;

namespace Becomex.Narwal.ROBO.Infra.Base.Validation
{
    public class ValidationResult
    {
        private readonly List<ValidationError> _errors = new List<ValidationError>();
        public string Message { get { string erro = null; _errors.ForEach(x => erro += "*" + x.Message + "<br>"); return erro; } }
        public bool IsValid { get { return _errors.Count == 0; } }
        public IEnumerable<ValidationError> Erros { get { return _errors; } }

        public void Add(ValidationError error)
        {
            _errors.Add(error);
        }

        public override string ToString()
        {
            return Message;
        }
    }
}
