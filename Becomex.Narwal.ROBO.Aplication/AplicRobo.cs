using Becomex.Narwal.ROBO.Aplication.Robos.Interfaces;
using Becomex.Narwal.ROBO.Aplication.Robos.ViewModels;
using Becomex.Narwal.ROBO.Domain.Robos;
using Becomex.Narwal.ROBO.Domain.Robos.Dtos;
using System;

namespace Becomex.Narwal.ROBO.Aplication
{
    public class AplicRobo : IAplicRobo
    {

        public Robo IniciarRobo()
        {
            return Robo.Iniciar();
        }

        public RoboVieModel RecuperarRobo(Robo robo)
        {
            if (robo == null)
                throw new Exception("R.O.B.O precisa ser iniciado.");

            return RoboVieModel.Novo(robo);
        }

        public Robo MovimentarBracoDireitoCotovelo(Robo robo, RoboBracoMovimentarCotoveloDto dto)
        {
            if (robo == null)
                throw new Exception("R.O.B.O precisa ser iniciado.");

            if ((int)dto.Cotovelo < 1 || (int)dto.Cotovelo > 4)
                Environment.FailFast("Estado enviado inválido, Sistema corrompido.");

            robo.BracoDireito.AptoParaMovimentarCotovelo(dto.Cotovelo);

            robo.MovimentarBracoDireitoCotovelo(dto.Cotovelo);

            return robo;
        }

        public Robo MovimentarBracoDireitoPulso(Robo robo, RoboBracoMovimentarPulsoDto dto)
        {
            if (robo == null)
                throw new Exception("R.O.B.O precisa ser iniciado.");

            if ((int)dto.Pulso < 1 || (int)dto.Pulso > 7)
                Environment.FailFast("Estado enviado inválido, Sistema corrompido.");

            robo.BracoDireito.AptoParaMovimentarPulso(dto.Pulso);

            robo.MovimentarBracoDireitoPulso(dto.Pulso);
            
            return robo;
        }

        public Robo MovimentarBracoEsquerdoCotovelo(Robo robo, RoboBracoMovimentarCotoveloDto dto)
        {
            if (robo == null)
                throw new Exception("R.O.B.O precisa ser iniciado.");

            if ((int)dto.Cotovelo < 1 || (int)dto.Cotovelo > 4)
                Environment.FailFast("Estado enviado inválido, Sistema corrompido.");

            robo.BracoEsquerdo.AptoParaMovimentarCotovelo(dto.Cotovelo);

            robo.MovimentarBracoEsquerdoCotovelo(dto.Cotovelo);

            return robo;
        }

        public Robo MovimentarBracoEsquerdoPulso(Robo robo, RoboBracoMovimentarPulsoDto dto)
        {
            if (robo == null)
                throw new Exception("R.O.B.O precisa ser iniciado.");

            if ((int)dto.Pulso < 1 || (int)dto.Pulso > 7)
                Environment.FailFast("Estado enviado inválido, Sistema corrompido.");

            robo.BracoDireito.AptoParaMovimentarPulso(dto.Pulso);

            robo.MovimentarBracoEsquerdoPulso(dto.Pulso);

            return robo;
        }

        public Robo MovimentarCabecaInclinacao(Robo robo, RoboCabecaMovimentarInclinacaoDto dto)
        {
            if (robo == null)
                throw new Exception("R.O.B.O precisa ser iniciado.");

            if ((int)dto.Inclinacao < 1 || (int)dto.Inclinacao > 3)
                Environment.FailFast("Estado enviado inválido, Sistema corrompido.");

            robo.Cabeca.AptoParaInclinarCabeca(dto.Inclinacao);

            robo.MovimentarCabecaInclinacao(dto.Inclinacao);

            return robo;
        }

        public Robo MovimentarCabecaRotacao(Robo robo, RoboCabecaMovimentarRotacaoDto dto)
        {
            if (robo == null)
                throw new Exception("R.O.B.O precisa ser iniciado.");

            if ((int)dto.Rotacao < 1 || (int)dto.Rotacao > 5)
                Environment.FailFast("Estado enviado inválido, Sistema corrompido.");

            robo.Cabeca.AptoParaRotacionarCabeca(dto.Rotacao);

            robo.MovimentarCabecaRotacao(dto.Rotacao);

            return robo;
        }
    }
}
