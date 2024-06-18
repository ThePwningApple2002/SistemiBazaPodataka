using LovacNaCudovistaLibrary;
using Microsoft.AspNetCore.Mvc;
using LovacNaCudovistaLibrary.DTOs;
using LovacNaCudovista.Entiteti;

namespace LovacNaCudovistaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MagCudovisteController : ControllerBase
    {
        public MagCudovisteController() { }



        [HttpGet]
        [Route("PreuzmiProdavnice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetProdavnice()
        {
            var cudovista = DataProvider.vratisvaMagCudovista();

          

            return Ok(cudovista);
        }

        [HttpPost]
        [Route("DodajProdavnicu")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddProdavnica([FromBody] MagCudovisteView p)
        {
            DataProvider.dodajMagCudoviste(p);

      

            return StatusCode(201, $"Uspešno dodata prodavnica. Naziv: {p.NazivCud}");
        }

        [HttpPut]
        [Route("PromeniProdavnicu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeProdavnica([FromBody] MagCudovisteView p)
        {
            DataProvider.azurirajMagCudoviste(p);

           

            return Ok($"Uspešno ažurirana prodavnica. Naziv: {p.NazivCud}");
        }

        [HttpDelete]
        [Route("IzbrisiProdavnicu/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteProdavnica(int id)
        {
            DataProvider.obrisiMagCudoviste(id);

        

            return StatusCode(204, $"Uspešno obrisana prodavnica. ID: {id}");
        }

    }
}
