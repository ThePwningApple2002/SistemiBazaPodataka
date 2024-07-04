using LovacNaCudovistaLibrary.DTOs;
using LovacNaCudovistaLibrary;
using Microsoft.AspNetCore.Mvc;
using LovacNaCudovista.Entiteti;

namespace LovacNaCudovistaAPI.Controllers
{
    public class PoznatiPredstavnikController : Controller
    {
        public PoznatiPredstavnikController() { }



        [HttpGet]
        [Route("PreuzmiPoznatiPredstavnike")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetPoznatiPredstavnike()
        {
            var cudovista = DataProvider.vratiPozPredstavnike();



            return Ok(cudovista);
        }

        [HttpPost]
        [Route("DodajPoznatogPredstavnika")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddPoznatogPred([FromBody] PoznatiPredstavnikView p, CudovisteView c)
        {
            DataProvider.dodajPozPred(p, c);



            return StatusCode(201, $"Uspešno dodat Poznati Predstavnik. Naziv: {p.JedinstvenoIme}");
        }
       
        [HttpPut]
        [Route("PromeniPoznatiPredstavnika")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangePoznatogPred([FromBody] PoznatiPredstavnikView p)
        {
            DataProvider.izmeniPozPred(p);



            return Ok($"Uspešno ažurirana Poznati Predstavnik. Naziv: {p.JedinstvenoIme}");
        }

        [HttpDelete]
        [Route("IzbrisiPoznatiPredstavnika/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeletePoznatiPredstavnika(int id)
        {
            DataProvider.obrisiPozPred(id);



            return StatusCode(204, $"Uspešno obrisana Poznati Predstavnik. ID: {id}");
        }
    }
}
