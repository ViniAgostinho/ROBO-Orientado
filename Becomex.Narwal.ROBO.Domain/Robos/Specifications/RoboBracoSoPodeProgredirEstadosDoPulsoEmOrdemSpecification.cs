using Becomex.Narwal.ROBO.Domain.Robos.Enumeradores;
using Becomex.Narwal.ROBO.Infra.Base.EnumHelpers;
using Becomex.Narwal.ROBO.Infra.Base.Validation;

namespace Becomex.Narwal.ROBO.Domain.Robos.Specifications
{
    public class RoboBracoSoPodeProgredirEstadosDoPulsoEmOrdemSpecification : ISpecification<RoboBraco>
    {
        private readonly EnumRoboPulso _pulso;
        public RoboBracoSoPodeProgredirEstadosDoPulsoEmOrdemSpecification(EnumRoboPulso pulso)
        {
            _pulso = pulso;
        }

        public bool IsSatisfiedBy(RoboBraco entity)
        {
            return (int)entity.Pulso + 1 == (int)_pulso || (int)entity.Pulso - 1 == (int)_pulso;
        }

        public string GetMessage(RoboBraco entity)
        {
            return $"O R.O.B.O está com o pulso em {EnumHelper.MontaDescricaoEnum(entity.Pulso)}, ele só poderá se movimentado em ordem crescente ou decrescente, o movimento" +
                $" envidado de {EnumHelper.MontaDescricaoEnum(_pulso)} não popde ser executado.";
        }
    }
}
