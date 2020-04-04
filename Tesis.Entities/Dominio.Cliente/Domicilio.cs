
namespace Tesis.Models.Dominio.Cliente
{
    public class Domicilio
    {
        public string Localidad { get; set; }
        public string Barrio { get; set; }
        public string Calle { get; set; }
        public int? Numero { get; set; }
        public int? Lote { get; set; }
        public int? Manzana { get; set; }
        public int? Piso { get; set; }
        public string Depto { get; set; }
    }
}