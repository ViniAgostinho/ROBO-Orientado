using Becomex.Narwal.ROBO.Aplication.Robos.ViewModels;
using Becomex.Narwal.ROBO.Domain.Robos;
using Becomex.Narwal.ROBO.Domain.Robos.Dtos;

namespace Becomex.Narwal.ROBO.Aplication.Robos.Interfaces
{
    public interface IAplicRobo
    {
        Robo IniciarRobo();
        RoboVieModel RecuperarRobo(Robo robo);
        Robo MovimentarBracoEsquerdoCotovelo(Robo robo, RoboBracoMovimentarCotoveloDto dto);
        Robo MovimentarBracoEsquerdoPulso(Robo robo, RoboBracoMovimentarPulsoDto dto);
        Robo MovimentarBracoDireitoCotovelo(Robo robo, RoboBracoMovimentarCotoveloDto dto);
        Robo MovimentarBracoDireitoPulso(Robo robo, RoboBracoMovimentarPulsoDto dto);
        Robo MovimentarCabecaRotacao(Robo robo, RoboCabecaMovimentarRotacaoDto dto);
        Robo MovimentarCabecaInclinacao(Robo robo, RoboCabecaMovimentarInclinacaoDto dto);
    }
}
