using LovacNaCudovistaLibrary.DTOs;
using LovacNaCudovistaLibrary;
using Microsoft.AspNetCore.Mvc;

namespace LovacNaCudovistaAPI.Controllers
{
    public class SpecSposobnostController : Controller
    {
        public SpecSposobnostController() { }



        [HttpGet]
        [Route("PreuzmiSpecSposobnosti")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetBajalice()
        {
            var cudovista = DataProvider.vratiSpecSposobnosti();



            return Ok(cudovista);
        }

        [HttpPost]
        [Route("DodajSpecSposobnost")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddSpecSposobnost([FromBody] SpecSposobnostView p)
        {
            DataProvider.sacuvajSpecSpos(p);



            return StatusCode(201, $"Uspešno dodata SpecSposobnost. Naziv: {p.NazivSpecSpos}");
        }

        [HttpPut]
        [Route("PromeniSpecSposobnost")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeSpecSposobnost([FromBody] SpecSposobnostView p)
        {
            DataProvider.azurirajSpecSpos(p);



            return Ok($"Uspešno ažurirana SpecSposobnost. Naziv: {p.NazivSpecSpos}");
        }

        [HttpDelete]
        [Route("IzbrisiSpecSposobnost/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteSpecSposobnost(int id)
        {
            DataProvider.obrisiSpecSpos(id);



            return StatusCode(204, $"Uspešno obrisana SpecSposobnost. ID: {id}");
        }
    }
}
