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
        [Route("PreuzmiMagCudovista")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetMagCudovista()
        {
            var cudovista = DataProvider.vratisvaMagCudovista();

          

            return Ok(cudovista);
        }

        [HttpPost]
        [Route("DodajMagCudoviste")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddMagCudoviste([FromBody] MagCudovisteView p)
        {
            DataProvider.dodajMagCudoviste(p);

      

            return StatusCode(201, $"Uspešno dodato Cudoviste. Naziv: {p.NazivCud}");
        }

        [HttpPut]
        [Route("PromeniMagCudoviste")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeMagCudoviste([FromBody] MagCudovisteView p)
        {
            DataProvider.azurirajMagCudoviste(p);

           

            return Ok($"Uspešno ažurirano Cudoviste. Naziv: {p.NazivCud}");
        }

        [HttpDelete]
        [Route("IzbrisiMagCudoviste/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteMagCudoviste(int id)
        {
            DataProvider.obrisiMagCudoviste(id);

        

            return StatusCode(204, $"Uspešno obrisano Cudoviste. ID: {id}");
        }

    }
}
