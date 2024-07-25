using Becomex.Narwal.ROBO.Web.Models;
using Becomex.Narwal.ROBO.Web.Models.Enumeradores;
using Becomex.Narwal.ROBO.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;

namespace Becomex.Narwal.ROBO.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RoboService _roboService;

        public IndexModel(RoboService roboService)
        {
            _roboService = roboService;
        }

        [BindProperty]
        public RoboViewModel Robo { get; set; }
        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnPostInicializarAsync()
        {
            Robo = await _roboService.InicializarRoboAsync();
            ErrorMessage = null;
            return Page();
        }

        public async Task<IActionResult> OnPostMovimentarAsync(string componente, string valor)
        {
            try
            {
                switch (componente)
                {
                    case "cabeca-rotacao":
                        Robo = await _roboService.MovimentarRoboAsync("api/Robo/movimentar-cabeca-rotacao", new { Rotacao = Enum.Parse<EnumRoboCabecaRotacao>(valor) });
                        break;
                    case "cabeca-inclinacao":
                        Robo = await _roboService.MovimentarRoboAsync("api/Robo/movimentar-cabeca-inclinacao", new { Inclinacao = Enum.Parse<EnumRoboCabecaInclinacao>(valor) });
                        break;
                    case "braco-esquerdo-cotovelo":
                        Robo = await _roboService.MovimentarRoboAsync("api/Robo/movimentar-braco-esquerdo-cotovelo", new { Cotovelo = Enum.Parse<EnumRoboCotovelo>(valor) });
                        break;
                    case "braco-direito-cotovelo":
                        Robo = await _roboService.MovimentarRoboAsync("api/Robo/movimentar-braco-direito-cotovelo", new { Cotovelo = Enum.Parse<EnumRoboCotovelo>(valor) });
                        break;
                    case "braco-esquerdo-pulso":
                        Robo = await _roboService.MovimentarRoboAsync("api/Robo/movimentar-braco-esquerdo-pulso", new { Pulso = Enum.Parse<EnumRoboPulso>(valor) });
                        break;
                    case "braco-direito-pulso":
                        Robo = await _roboService.MovimentarRoboAsync("api/Robo/movimentar-braco-direito-pulso", new { Pulso = Enum.Parse<EnumRoboPulso>(valor) });
                        break;
                }

                ErrorMessage = null;
            }
            catch (ApiException ex)
            {

                ErrorMessage = ex.ErrorMessage;
            }

            return Page();
        }
    }
}
