using FrutasJABBA.Models;

namespace FrutasJABBA.ViewsModels
{
    public class FrutaViewModel
    {
        public FrutaViewModel(List<Fruta> frutas, List<StockFruta> stocksFrutas)
        {
            Frutas = frutas;
            StocksFrutas = stocksFrutas;
        }

        public List<Fruta> Frutas { get; set; } 
        public List<StockFruta> StocksFrutas { get; set; }

        public Fruta nuevaFruta { get; set; }
    }
}
