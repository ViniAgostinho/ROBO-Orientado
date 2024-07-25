using Becomex.Narwal.ROBO.Aplication.Robos.Interfaces;
using Becomex.Narwal.ROBO.Domain.Robos;
using Becomex.Narwal.ROBO.Domain.Robos.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Becomex.Narwal.ROBO.Api.Controllers
{
    [Route("api/Robo")]
    public class RoboController : ControllerBase
    {
        private readonly IAplicRobo _aplicRobo;
        private static Robo _robo;

        public RoboController(IAplicRobo aplicRobo)
        {
            _aplicRobo = aplicRobo;
        }

        [HttpPost]
        public IActionResult IniciarRobo()
        {
            try
            {
                _robo = _aplicRobo.IniciarRobo();

                return Ok(_aplicRobo.RecuperarRobo(_robo));
            }
            catch (Exception e)
            {

                return BadRequest(new
                {
                    ERRO = e.Message,
                });
            }
        }

        [HttpGet]
        public IActionResult RecuperarRobo()
        {
            try
            {

                return Ok(_aplicRobo.RecuperarRobo(_robo));
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    ERRO = e.Message,
                });
            }
        }

        [Route("movimentar-cabeca-rotacao")]
        [HttpPut]
        public IActionResult MovimentarCabecaRotacao([FromBody] RoboCabecaMovimentarRotacaoDto dto) 
        {
            try
            {
                _robo = _aplicRobo.MovimentarCabecaRotacao(_robo, dto);

                return Ok(_aplicRobo.RecuperarRobo(_robo));
            }
            catch (Exception e)
            {

                return BadRequest(new
                {
                    ERRO = e.Message,
                });
            }
        }

        [Route("movimentar-cabeca-inclinacao")]
        [HttpPut]
        public IActionResult MovimentarCabecaInclinacao([FromBody] RoboCabecaMovimentarInclinacaoDto dto)
        {
            try
            {
                _robo = _aplicRobo.MovimentarCabecaInclinacao(_robo, dto);

                return Ok(_aplicRobo.RecuperarRobo(_robo));
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    ERRO = e.Message,
                });
            }
        }

        [Route("movimentar-braco-esquerdo-cotovelo")]
        [HttpPut]
        public IActionResult MovimentarBracoEsquerdoCotovelo([FromBody] RoboBracoMovimentarCotoveloDto dto)
        {
            try
            {
                _robo = _aplicRobo.MovimentarBracoEsquerdoCotovelo(_robo, dto);

                return Ok(_aplicRobo.RecuperarRobo(_robo));
            }
            catch (Exception e)
            {

                return BadRequest(new
                {
                    ERRO = e.Message,
                });
            }
        }

        [Route("movimentar-braco-direito-cotovelo")]
        [HttpPut]
        public IActionResult MovimentarBracoDireitoCotovelo([FromBody] RoboBracoMovimentarCotoveloDto dto)
        {
            try
            {
                _robo = _aplicRobo.MovimentarBracoDireitoCotovelo(_robo, dto);

                return Ok(_aplicRobo.RecuperarRobo(_robo));
            }
            catch (Exception e)
            {

                return BadRequest(new
                {
                    ERRO = e.Message,
                });
            }
        }

        [Route("movimentar-braco-esquerdo-pulso")]
        [HttpPut]
        public IActionResult MovimentarBracoEsquerdoPulso([FromBody] RoboBracoMovimentarPulsoDto dto)
        {
            try
            {
                _robo = _aplicRobo.MovimentarBracoEsquerdoPulso(_robo, dto);

                return Ok(_aplicRobo.RecuperarRobo(_robo));
            }
            catch (Exception e)
            {

                return BadRequest(new
                {
                    ERRO = e.Message,
                });
            }
        }

        [Route("movimentar-braco-direito-pulso")]
        [HttpPut]
        public IActionResult MovimentarBracoDireitoPulso([FromBody] RoboBracoMovimentarPulsoDto dto)
        {
            try
            {
                _robo = _aplicRobo.MovimentarBracoDireitoPulso(_robo, dto);

                return Ok(_aplicRobo.RecuperarRobo(_robo));
            }
            catch (Exception e)
            {

                return BadRequest(new
                {
                    ERRO = e.Message,
                });
            }
        }
    }
}
