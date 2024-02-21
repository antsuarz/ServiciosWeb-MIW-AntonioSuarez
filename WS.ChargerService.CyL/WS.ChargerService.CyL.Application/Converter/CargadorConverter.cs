using System.Text.RegularExpressions;
using WS.ChargerService.CyL.Application.Models;

namespace WS.ChargerService.CyL.Application.Converter
{
    public class CargadorConverter
    {
        public static CargadorCyL ToCargadorCyL(CargadorExterno cargador) 
        {
            CargadorCyL result = new CargadorCyL();
            result.Title = cargador.Nombre + " "+ cargador.Direccion;
            string pattern = @"\((.*?)\)";
            Match match = Regex.Match(cargador.Direccion, pattern);
            if (match.Success)
            { 
                result.provincia = match.Groups[1].Value;
            }
            else
            {
                result.provincia = "";
            }
            result.cordY = cargador.DD.Lon;
            result.cordX = cargador.DD.Lat;
            result.Tipo = cargador.Tipo[0];
            return result;

        }
    }
}
