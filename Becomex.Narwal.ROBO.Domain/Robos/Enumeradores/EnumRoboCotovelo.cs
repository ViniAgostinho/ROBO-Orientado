using System.ComponentModel;

namespace Becomex.Narwal.ROBO.Domain.Robos.Enumeradores
{
    public enum EnumRoboCotovelo
    {
        [Description("Em repouso")]
        EmRepouso = 1,

        [Description("Levemente contraído")]
        LevementeContraido = 2,

        [Description("Contraído")]
        Contraido = 3,

        [Description("Fortemente contraído")]
        FortementeContraido = 4
    }
}
