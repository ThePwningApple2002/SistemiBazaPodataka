using LovacNaCudovistaLibrary.DTOs;
using LovacNaCudovistaLibrary;
using Microsoft.AspNetCore.Mvc;

namespace LovacNaCudovistaAPI.Controllers
{
    public class LegendaController : Controller
    {
        public LegendaController() { }



        [HttpGet]
        [Route("PreuzmiLegende")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetLegende(PoznatiPredstavnikView id)
        {
            var cudovista = DataProvider.vratiLegendePozPred(id);



            return Ok(cudovista);
        }

        [HttpPost]
        [Route("DodajLegendu")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddBajalicu([FromBody] LegendaView p)
        {
            DataProvider.dodajLegendu(p);



            return StatusCode(201, $"Uspešno dodata Bajalica. Naziv: {p.TekstLegende}");
        }

        [HttpPut]
        [Route("PromeniLegendu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeLegendu([FromBody] LegendaView p)
        {
            DataProvider.izmeniLegendu(p);



            return Ok($"Uspešno ažurirana Bajalica. Naziv: {p.TekstLegende}");
        }

        [HttpDelete]
        [Route("IzbrisiLegendu/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteLegendu(int id)
        {
            DataProvider.obrisiLegendu(id);



            return StatusCode(204, $"Uspešno obrisana Legenda. ID: {id}");
        }
    }
}
