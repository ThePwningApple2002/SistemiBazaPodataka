using LovacNaCudovistaLibrary.DTOs;
using LovacNaCudovistaLibrary;
using Microsoft.AspNetCore.Mvc;

namespace LovacNaCudovistaAPI.Controllers
{
    public class PredmetController : Controller
    {
        public PredmetController() { }



        [HttpGet]
        [Route("PreuzmiPredmete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetBajalice()
        {
            var cudovista = DataProvider.VratiSvePredmete();



            return Ok(cudovista);
        }

        [HttpPost]
        [Route("DodajPredmet")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddPredmet([FromBody] PredmetView p)
        {
            DataProvider.DodajPredmet(p);



            return StatusCode(201, $"Uspešno dodata Predmet. Naziv: {p.NazivPredmeta}");
        }

        [HttpPut]
        [Route("PromeniPredmet")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangePredmet([FromBody] PredmetView p)
        {
            DataProvider.AzurirajPredmet(p);



            return Ok($"Uspešno ažurirana Predmet. Naziv: {p.NazivPredmeta}");
        }

        [HttpDelete]
        [Route("IzbrisiPredmet/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeletePredmet(int id)
        {
            DataProvider.ObrisiPredmet(id);



            return StatusCode(204, $"Uspešno obrisana Predmet. ID: {id}");
        }
    }
}
