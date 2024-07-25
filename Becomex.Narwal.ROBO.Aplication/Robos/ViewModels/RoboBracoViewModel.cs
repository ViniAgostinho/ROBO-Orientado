using Becomex.Narwal.ROBO.Domain.Robos;
using Becomex.Narwal.ROBO.Infra.Base.EnumHelpers;

namespace Becomex.Narwal.ROBO.Aplication.Robos.ViewModels
{
    public class RoboBracoViewModel
    {
        public string Cotovelo { get; set; }
        public string Pulso { get; set; }

        public static RoboBracoViewModel Novo(RoboBraco entidade)
        {
            return new RoboBracoViewModel
            {
                Cotovelo = EnumHelper.MontaDescricaoEnum(entidade.Cotovelo),
                Pulso = EnumHelper.MontaDescricaoEnum(entidade.Pulso)
            };
        }
    }
}
