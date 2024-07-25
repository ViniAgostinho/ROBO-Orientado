using System.ComponentModel;

namespace Becomex.Narwal.ROBO.Domain.Robos.Enumeradores
{
    public enum EnumRoboPulso
    {
        [Description("- 90º")]
        Rotacao90GrausNegativo = 1,

        [Description("- 45º")]
        Rotacao45GrausNegativo = 2,

        [Description("Em repouso")]
        EmRepouso = 3,

        [Description("45º")]
        Rotacao45GrausPositivo = 4,

        [Description("90º")]
        Rotacao90GrausPositivo = 5,

        [Description("135º")]
        Rotacao135GrausPositivo = 6,

        [Description("180º")]
        Rotacao180GrausPositivo = 7
    }
}
