using Becomex.Narwal.ROBO.Domain.Robos.Enumeradores;
using Becomex.Narwal.ROBO.Infra.Base.EnumHelpers;
using Becomex.Narwal.ROBO.Infra.Base.Validation;

namespace Becomex.Narwal.ROBO.Domain.Robos.Specifications
{
    public class RoboBracoSoPodeProgredirEstadosDoCotoveloEmOrdemSpecification : ISpecification<RoboBraco>
    {
        private readonly EnumRoboCotovelo _cotovelo;
        public RoboBracoSoPodeProgredirEstadosDoCotoveloEmOrdemSpecification(EnumRoboCotovelo cotovelo)
        {
            _cotovelo = cotovelo;
        }

        public bool IsSatisfiedBy(RoboBraco entity)
        {
            return (int)entity.Cotovelo + 1 == (int)_cotovelo || (int)entity.Cotovelo - 1 == (int)_cotovelo;
        }

        public string GetMessage(RoboBraco entity)
        {
            return $"O R.O.B.O está com o cotovelo {EnumHelper.MontaDescricaoEnum(entity.Cotovelo)}, ele só poderá se movimentado em ordem crescente ou decrescente, o movimento" +
                $" envidado de {EnumHelper.MontaDescricaoEnum(_cotovelo)} não popde ser executado.";
        }
    }
}
