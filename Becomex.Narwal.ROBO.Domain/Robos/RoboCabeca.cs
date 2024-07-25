using Becomex.Narwal.ROBO.Domain.Robos.Enumeradores;
using Becomex.Narwal.ROBO.Domain.Robos.Validations;

namespace Becomex.Narwal.ROBO.Domain.Robos
{
    public class RoboCabeca
    {
        public RoboCabeca()
        {
            Rotacao = EnumRoboCabecaRotacao.EmRepouso;
            Inclinacao = EnumRoboCabecaInclinacao.EmRepouso;
        }

        public EnumRoboCabecaRotacao Rotacao { get; private set; }
        public EnumRoboCabecaInclinacao Inclinacao { get; private set; }

        public static RoboCabeca Iniciar()
        {
            return new RoboCabeca();
        }

        public void MovimentarCabecaRotacao(EnumRoboCabecaRotacao rotacao)
        {
            Rotacao = rotacao;
        }

        public void MovimentarCabecaInclinacao(EnumRoboCabecaInclinacao inclinacao)
        {
            Inclinacao = inclinacao;
        }

        public void AptoParaRotacionarCabeca(EnumRoboCabecaRotacao rotacao)
        {
            new RoboCabecaAptoParaRotacionarValidation(rotacao).ValidateException(this);
        }

        public void AptoParaInclinarCabeca(EnumRoboCabecaInclinacao inclinacao)
        {
            new RoboCabecaAptoParaInclinarValidation(inclinacao).ValidateException(this);
        }
    }
}
