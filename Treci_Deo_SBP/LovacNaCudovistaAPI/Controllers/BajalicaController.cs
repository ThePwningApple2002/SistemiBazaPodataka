using LovacNaCudovistaLibrary;
using Microsoft.AspNetCore.Mvc;
using LovacNaCudovistaLibrary.DTOs;
using LovacNaCudovista.Entiteti;

namespace LovacNaCudovistaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BajalicaController : ControllerBase
    {
        public BajalicaController() { }



        [HttpGet]
        [Route("PreuzmiBajalice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetBajalice()
        {
            var cudovista = DataProvider.vratisveBajalice();



            return Ok(cudovista);
        }

        [HttpPost]
        [Route("DodajBajalicu")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddBajalicu([FromBody] BajalicaView p)
        {
            DataProvider.dodajBajalicu(p);



            return StatusCode(201, $"Uspešno dodata Bajalica. Naziv: {p.NazivBajalica}");
        }

        [HttpPut]
        [Route("PromeniBajalicu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeBajalicu([FromBody] BajalicaView p)
        {
            DataProvider.azurirajBajalicu(p);



            return Ok($"Uspešno ažurirana Bajalica. Naziv: {p.NazivBajalica}");
        }

        [HttpDelete]
        [Route("IzbrisiBajalicu/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteBajalicu(int id)
        {
            DataProvider.obrisiBajalicu(id);



            return StatusCode(204, $"Uspešno obrisana Bajalica. ID: {id}");
        }

    }
}
