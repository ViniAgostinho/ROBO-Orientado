using System.ComponentModel;

namespace Becomex.Narwal.ROBO.Domain.Robos.Enumeradores
{
    public enum EnumRoboCabecaInclinacao
    {
        [Description("Para cima")]
        ParaCima = 1,

        [Description("Em repouso")]
        EmRepouso = 2,

        [Description("Para baixo")]
        ParaBaixo = 3
    }
}
