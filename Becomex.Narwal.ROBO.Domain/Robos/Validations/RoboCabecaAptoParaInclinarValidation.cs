using Becomex.Narwal.ROBO.Domain.Robos.Enumeradores;
using Becomex.Narwal.ROBO.Domain.Robos.Specifications;
using Becomex.Narwal.ROBO.Infra.Base.Validation;

namespace Becomex.Narwal.ROBO.Domain.Robos.Validations
{
    public class RoboCabecaAptoParaInclinarValidation : Validator<RoboCabeca>
    {
        public RoboCabecaAptoParaInclinarValidation(EnumRoboCabecaInclinacao inclinacao)
        {
            Add(new Rule<RoboCabeca>(new RoboCabecaSoPodeProgredirEstadosDeInclinacaoEmOrdemSpecification(inclinacao)));
        }
    }
}
