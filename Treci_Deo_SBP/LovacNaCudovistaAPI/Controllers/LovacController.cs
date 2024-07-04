using LovacNaCudovistaLibrary;
using Microsoft.AspNetCore.Mvc;
using LovacNaCudovistaLibrary.DTOs;
using LovacNaCudovista.Entiteti;

namespace LovacNaCudovistaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LovacController : ControllerBase
    {
        public LovacController() { }



        [HttpGet]
        [Route("PreuzmiLovce")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetLovce()
        {
            var cudovista = DataProvider.vratisveLovce();



            return Ok(cudovista);
        }

        [HttpPost]
        [Route("DodajLovca")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddLovca([FromBody] LovacView lovacView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await DataProvider.dodajLovca(lovacView);
                return StatusCode(201, $"Uspešno dodat Lovac. Naziv: {lovacView.ImeLovca}");
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPut]
        [Route("PromeniLovca")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeLovca([FromBody] LovacView p)
        {
            DataProvider.azurirajLovca(p);



            return Ok($"Uspešno ažuriran Lovac. Naziv: {p.ImeLovca}");
        }

        [HttpDelete]
        [Route("IzbrisiLovca/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteLovca(int id)
        {
            DataProvider.obrisiLovca(id);



            return StatusCode(204, $"Uspešno obrisana Lovca. ID: {id}");
        }

    }
}
