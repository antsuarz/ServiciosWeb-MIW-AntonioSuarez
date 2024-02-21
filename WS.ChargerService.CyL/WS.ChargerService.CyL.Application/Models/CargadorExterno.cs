namespace WS.ChargerService.CyL.Application.Models
{
    public class CargadorExterno
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Operador { get; set; }
        public string Numero { get; set; }
        public List<string> Tipo { get; set; }
        public Coordenadas DD { get; set; }
    }

    public class Coordenadas
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
    }

    public class JsonObject
    {
        public int total_count { get; set; }
        public List<CargadorExterno> results { get; set; }
    }
}
