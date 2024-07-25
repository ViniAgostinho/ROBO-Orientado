using Becomex.Narwal.ROBO.Domain.Robos.Enumeradores;
using Becomex.Narwal.ROBO.Domain.Robos.Specifications;
using Becomex.Narwal.ROBO.Infra.Base.Validation;

namespace Becomex.Narwal.ROBO.Domain.Robos.Validations
{
    public class RoboBracoAptoParaMovimentarPulsoValidation : Validator<RoboBraco>
    {
        public RoboBracoAptoParaMovimentarPulsoValidation(EnumRoboPulso pulso)
        {
            Add(new Rule<RoboBraco>(new RoboBracoSoPodeMovimentarPulsoCasoCotoveloEstejaFortementeContraidoSpecification()));
            Add(new Rule<RoboBraco>(new RoboBracoSoPodeProgredirEstadosDoPulsoEmOrdemSpecification(pulso)));
        }
    }
}
