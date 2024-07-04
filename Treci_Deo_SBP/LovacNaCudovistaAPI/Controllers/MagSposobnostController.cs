using LovacNaCudovistaLibrary.DTOs;
using LovacNaCudovistaLibrary;
using Microsoft.AspNetCore.Mvc;

namespace LovacNaCudovistaAPI.Controllers
{
    public class MagSposobnostController : Controller
    {
        public MagSposobnostController() { }



        [HttpGet]
        [Route("PreuzmiMagSposobnost")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetMagSpos()
        {
            var cudovista = DataProvider.vratiMagSposobnosti();



            return Ok(cudovista);
        }

        [HttpPost]
        [Route("DodajMagSposobnost")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddMagSpos([FromBody] MagSposobnostView p)
        {
            DataProvider.sacuvajMagSpos(p);



            return StatusCode(201, $"Uspešno dodata MagSposobnost. Naziv: {p.NazivMagSpos}");
        }

        [HttpPut]
        [Route("PromeniMagSposobnost")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeBajalicu([FromBody] MagSposobnostView p)
        {
            DataProvider.azurirajMagSpos(p);



            return Ok($"Uspešno ažurirana MagSposobnost. Naziv: {p.NazivMagSpos}");
        }

        [HttpDelete]
        [Route("IzbrisiMagSposobnost/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteMagSpos(int id)
        {
            DataProvider.obrisiMagSpos(id);



            return StatusCode(204, $"Uspešno obrisana MagSposobnost. ID: {id}");
        }
    }
}
