using Becomex.Narwal.ROBO.Domain.Robos.Enumeradores;
using Becomex.Narwal.ROBO.Infra.Base.EnumHelpers;
using Becomex.Narwal.ROBO.Infra.Base.Validation;

namespace Becomex.Narwal.ROBO.Domain.Robos.Specifications
{
    public class RoboBracoSoPodeMovimentarPulsoCasoCotoveloEstejaFortementeContraidoSpecification : ISpecification<RoboBraco>
    {
        public bool IsSatisfiedBy(RoboBraco entity)
        {
            return entity.Cotovelo == EnumRoboCotovelo.FortementeContraido;
        }

        public string GetMessage(RoboBraco entity)
        {
            return $"Cotovelo encontra - se {EnumHelper.MontaDescricaoEnum(entity.Cotovelo)}, só pode movimentar pulso com contovelo fortemente contraído.";
        }
    }
}
