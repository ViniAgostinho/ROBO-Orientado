using Becomex.Narwal.ROBO.Domain.Robos.Enumeradores;
using Becomex.Narwal.ROBO.Infra.Base.EnumHelpers;
using Becomex.Narwal.ROBO.Infra.Base.Validation;

namespace Becomex.Narwal.ROBO.Domain.Robos.Specifications
{
    public class RoboCabecaSoPodeProgredirEstadosDeRotacaoEmOrdemSpecification : ISpecification<RoboCabeca>
    {
        private readonly EnumRoboCabecaRotacao _rotacao;

        public RoboCabecaSoPodeProgredirEstadosDeRotacaoEmOrdemSpecification(EnumRoboCabecaRotacao rotacao)
        {
            _rotacao = rotacao;
        }

        public bool IsSatisfiedBy(RoboCabeca entity)
        {
            return (int)entity.Rotacao + 1 == (int)_rotacao || (int)entity.Rotacao - 1 == (int)_rotacao;
        }

        public string GetMessage(RoboCabeca entity)
        {
            return $"O R.O.B.O está com a cabeça {EnumHelper.MontaDescricaoEnum(entity.Rotacao)}, ele só poderá se movimentado em ordem crescente ou decrescente, o movimento" +
                            $" envidado de {EnumHelper.MontaDescricaoEnum(_rotacao)} não popde ser executado.";
        }
    }
}
