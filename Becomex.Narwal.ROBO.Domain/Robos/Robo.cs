using Becomex.Narwal.ROBO.Domain.Robos.Enumeradores;

namespace Becomex.Narwal.ROBO.Domain.Robos
{
    public class Robo
    {
        public Robo()
        {
            Cabeca = RoboCabeca.Iniciar();
            BracoEsquerdo = RoboBraco.Iniciar();
            BracoDireito = RoboBraco.Iniciar();
        }

        public virtual RoboCabeca Cabeca { get; private set; }
        public virtual RoboBraco BracoEsquerdo { get; private set; }
        public virtual RoboBraco BracoDireito { get; private set; }

        public static Robo Iniciar()
        {
            return new Robo();
        }

        public void MovimentarCabecaRotacao(EnumRoboCabecaRotacao rotacao)
        {
            Cabeca.MovimentarCabecaRotacao(rotacao);
        }

        public void MovimentarCabecaInclinacao(EnumRoboCabecaInclinacao inclinacao)
        {
            Cabeca.MovimentarCabecaInclinacao(inclinacao);
        }

        public void MovimentarBracoEsquerdoCotovelo(EnumRoboCotovelo cotovelo)
        {
            BracoEsquerdo.MovimentarCotovelo(cotovelo);
        }

        public void MovimentarBracoDireitoCotovelo(EnumRoboCotovelo cotovelo)
        {
            BracoDireito.MovimentarCotovelo(cotovelo);
        }

        public void MovimentarBracoEsquerdoPulso(EnumRoboPulso pulso)
        {
            BracoEsquerdo.MovimentarPulso(pulso);
        }

        public void MovimentarBracoDireitoPulso(EnumRoboPulso pulso)
        {
            BracoDireito.MovimentarPulso(pulso);
        }
    }
}
