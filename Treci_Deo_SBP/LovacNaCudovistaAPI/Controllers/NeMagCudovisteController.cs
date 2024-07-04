using LovacNaCudovistaLibrary;
using Microsoft.AspNetCore.Mvc;
using LovacNaCudovistaLibrary.DTOs;
using LovacNaCudovista.Entiteti;

namespace LovacNaCudovistaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NeMagCudovisteController : ControllerBase
    {
        public NeMagCudovisteController() { }



        [HttpGet]
        [Route("PreuzmiNeMagCudovista")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetMagCudovista()
        {
            var cudovista = DataProvider.vratisvaNeMagCudovista();



            return Ok(cudovista);
        }

        [HttpPost]
        [Route("DodajNeMagCudoviste")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddNeMagCudoviste([FromBody] NeMagCudovisteView p)
        {
            DataProvider.dodajNeMagCudoviste(p);



            return StatusCode(201, $"Uspešno dodato Cudoviste. Naziv: {p.NazivCud}");
        }

        [HttpPut]
        [Route("PromeniNeMagCudoviste")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeNeMagCudoviste([FromBody] NeMagCudovisteView p)
        {
            DataProvider.azurirajNeMagCudoviste(p);



            return Ok($"Uspešno ažurirano Cudoviste. Naziv: {p.NazivCud}");
        }

        [HttpDelete]
        [Route("IzbrisiNeMagCudoviste/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteNeMagCudoviste(int id)
        {
            DataProvider.obrisiNeMagCudoviste(id);



            return StatusCode(204, $"Uspešno obrisano Cudoviste. ID: {id}");
        }

    }
}
