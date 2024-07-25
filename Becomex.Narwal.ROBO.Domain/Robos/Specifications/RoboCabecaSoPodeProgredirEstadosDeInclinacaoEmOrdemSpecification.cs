using Becomex.Narwal.ROBO.Domain.Robos.Enumeradores;
using Becomex.Narwal.ROBO.Infra.Base.EnumHelpers;
using Becomex.Narwal.ROBO.Infra.Base.Validation;

namespace Becomex.Narwal.ROBO.Domain.Robos.Specifications
{
    public class RoboCabecaSoPodeProgredirEstadosDeInclinacaoEmOrdemSpecification : ISpecification<RoboCabeca>
    {
        private readonly EnumRoboCabecaInclinacao _inclinacao;

        public RoboCabecaSoPodeProgredirEstadosDeInclinacaoEmOrdemSpecification(EnumRoboCabecaInclinacao inclinacao)
        {
            _inclinacao = inclinacao;
        }

        public bool IsSatisfiedBy(RoboCabeca entity)
        {
            return (int)entity.Inclinacao + 1 == (int)_inclinacao || (int)entity.Inclinacao - 1 == (int)_inclinacao;
        }

        public string GetMessage(RoboCabeca entity)
        {
            return $"O R.O.B.O está com a cabeça inclinada {EnumHelper.MontaDescricaoEnum(entity.Inclinacao)}, ele só poderá se movimentado em ordem crescente ou decrescente, o movimento" +
                            $" envidado de inclinação {EnumHelper.MontaDescricaoEnum(_inclinacao)} não popde ser executado.";
        }
    }
}
