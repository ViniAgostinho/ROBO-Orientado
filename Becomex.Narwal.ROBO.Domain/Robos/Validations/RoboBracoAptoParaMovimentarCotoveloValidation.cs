using Becomex.Narwal.ROBO.Domain.Robos.Enumeradores;
using Becomex.Narwal.ROBO.Domain.Robos.Specifications;
using Becomex.Narwal.ROBO.Infra.Base.Validation;

namespace Becomex.Narwal.ROBO.Domain.Robos.Validations
{
    public class RoboBracoAptoParaMovimentarCotoveloValidation : Validator<RoboBraco>
    {
        public RoboBracoAptoParaMovimentarCotoveloValidation(EnumRoboCotovelo cotovelo)
        {
            Add(new Rule<RoboBraco>(new RoboBracoSoPodeProgredirEstadosDoCotoveloEmOrdemSpecification(cotovelo)));
        }
    }
}
