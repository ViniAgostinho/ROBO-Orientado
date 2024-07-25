namespace Becomex.Narwal.ROBO.Web.Models
{
    public class RoboViewModel
    {
        public CabecaViewModel Cabeca { get; set; }
        public BracoViewModel BracoDireito { get; set; }
        public BracoViewModel BracoEsquerdo { get; set; }
    }

    public class CabecaViewModel
    {
        public string Rotacao { get; set; }
        public string Inclinacao { get; set; }
    }

    public class BracoViewModel
    {
        public string Cotovelo { get; set; }
        public string Pulso { get; set; }
    }
}
