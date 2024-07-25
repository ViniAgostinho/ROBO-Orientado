using Becomex.Narwal.ROBO.Domain.Robos.Enumeradores;
using Becomex.Narwal.ROBO.Infra.Base.Validation;

namespace Becomex.Narwal.ROBO.Domain.Robos.Specifications
{
    public class RoboCabecaSoPodeRotacionarCasoInclinacaoNaoEstejaParaBaixoSpecification : ISpecification<RoboCabeca>
    {
        public bool IsSatisfiedBy(RoboCabeca entity)
        {
            return entity.Inclinacao != EnumRoboCabecaInclinacao.ParaBaixo;
        }

        public string GetMessage(RoboCabeca entity)
        {
            return "Só poderá Rotacionar a Cabeça caso sua Inclinação da Cabeça não esteja em estado Para Baixo";
        }
    }
}
