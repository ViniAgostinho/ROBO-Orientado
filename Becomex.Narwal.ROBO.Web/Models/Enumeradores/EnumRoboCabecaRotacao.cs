﻿using System.ComponentModel;

namespace Becomex.Narwal.ROBO.Web.Models.Enumeradores
{
    public enum EnumRoboCabecaRotacao
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
        Rotacao90GrausPositivo = 5
    }
}
