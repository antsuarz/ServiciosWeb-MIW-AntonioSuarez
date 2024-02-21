using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using WS.ChargerService.CyL.Application.Converter;
using WS.ChargerService.CyL.Application.Models; 

namespace WS.ChargerService.CyL.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargadorController : ControllerBase
    {
        private IConfiguration _configuration;
        public CargadorController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
         
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CargadorCyL>>> GetCargadores()
        { 
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(_configuration.GetValue<string>("ApplicationSettings:ClyEndPoint"));

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    JsonObject rootObject = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonObject>(result);
                    List<CargadorExterno> cargadores = rootObject.results;
                    List<CargadorCyL> cargadoresClY = new List<CargadorCyL>();
                    foreach (CargadorExterno car in cargadores) { 
                        cargadoresClY.Add(CargadorConverter.ToCargadorCyL(car));    
                    }
                    return Ok(cargadoresClY);
                }
                else
                {
                    return BadRequest("Error al llamar al servicio externo. Código de estado: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }
    }
}
