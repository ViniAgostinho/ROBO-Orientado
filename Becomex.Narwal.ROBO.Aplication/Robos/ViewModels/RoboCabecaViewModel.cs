using Becomex.Narwal.ROBO.Domain.Robos;
using Becomex.Narwal.ROBO.Infra.Base.EnumHelpers;

namespace Becomex.Narwal.ROBO.Aplication.Robos.ViewModels
{
    public class RoboCabecaViewModel
    {
        public string Rotacao { get; set; }
        public string Inclinacao { get; set; }

        public static RoboCabecaViewModel Novo(RoboCabeca entidade)
        {
            return new RoboCabecaViewModel
            {
                Rotacao = EnumHelper.MontaDescricaoEnum(entidade.Rotacao),
                Inclinacao = EnumHelper.MontaDescricaoEnum(entidade.Inclinacao)
            };
        }
    }
}
