using Becomex.Narwal.ROBO.Domain.Robos.Enumeradores;
using Becomex.Narwal.ROBO.Domain.Robos.Validations;

namespace Becomex.Narwal.ROBO.Domain.Robos
{
    public class RoboBraco
    {
        public RoboBraco()
        {
            Cotovelo = EnumRoboCotovelo.EmRepouso;
            Pulso = EnumRoboPulso.EmRepouso;
        }

        public EnumRoboCotovelo Cotovelo { get; private set; }
        public EnumRoboPulso Pulso { get; private set; }

        public static RoboBraco Iniciar()
        {
            return new RoboBraco();
        }

        public void MovimentarCotovelo(EnumRoboCotovelo cotovelo)
        {
            Cotovelo = cotovelo;
        }

        public void MovimentarPulso(EnumRoboPulso pulso)
        { 
            Pulso = pulso;
        }

        public void AptoParaMovimentarPulso(EnumRoboPulso pulso)
        {
            new RoboBracoAptoParaMovimentarPulsoValidation(pulso).ValidateException(this);
        }

        public void AptoParaMovimentarCotovelo(EnumRoboCotovelo cotovelo)
        {
            new RoboBracoAptoParaMovimentarCotoveloValidation(cotovelo).ValidateException(this);
        }
    }
}
