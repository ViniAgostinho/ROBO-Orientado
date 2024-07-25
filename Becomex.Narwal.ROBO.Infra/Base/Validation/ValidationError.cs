namespace Becomex.Narwal.ROBO.Infra.Base.Validation
{
    public class ValidationError
    {
        public ValidationError(string message)
        {
            this.Message = message;
        }

        public string Message { get; private set; }
    }
}
