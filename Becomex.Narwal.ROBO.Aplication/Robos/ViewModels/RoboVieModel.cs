using Becomex.Narwal.ROBO.Domain.Robos;

namespace Becomex.Narwal.ROBO.Aplication.Robos.ViewModels
{
    public class RoboVieModel
    {
        public RoboCabecaViewModel Cabeca { get; set; }
        public RoboBracoViewModel BracoDireito { get; set; }
        public RoboBracoViewModel BracoEsquerdo { get; set; }

        public static RoboVieModel Novo(Robo entidade)
        {
            return new RoboVieModel
            {
                Cabeca = RoboCabecaViewModel.Novo(entidade.Cabeca),
                BracoDireito = RoboBracoViewModel.Novo(entidade.BracoDireito),
                BracoEsquerdo = RoboBracoViewModel.Novo(entidade.BracoEsquerdo)
            };
        }
    }
}
