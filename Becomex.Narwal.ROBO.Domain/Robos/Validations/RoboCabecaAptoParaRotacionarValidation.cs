using Becomex.Narwal.ROBO.Domain.Robos.Enumeradores;
using Becomex.Narwal.ROBO.Domain.Robos.Specifications;
using Becomex.Narwal.ROBO.Infra.Base.Validation;

namespace Becomex.Narwal.ROBO.Domain.Robos.Validations
{
    public class RoboCabecaAptoParaRotacionarValidation : Validator<RoboCabeca>
    {
        public RoboCabecaAptoParaRotacionarValidation(EnumRoboCabecaRotacao rotacao)
        {
            Add(new Rule<RoboCabeca>(new RoboCabecaSoPodeProgredirEstadosDeRotacaoEmOrdemSpecification(rotacao)));
            Add(new Rule<RoboCabeca>(new RoboCabecaSoPodeRotacionarCasoInclinacaoNaoEstejaParaBaixoSpecification()));
        }
    }
}
