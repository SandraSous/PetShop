using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using PetShop.src.Contrato.Repository;
using PetShop.src.Contrato.Service;
using System.Linq.Expressions;

namespace PetShop.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalController : ControllerBase {
        private readonly IAnimaisService _animal;
        public AnimalController(IAnimaisService animal) {
            _animal = animal;
        }
       

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Animal animal) {
            try {
                await _animal.Create(animal);
                return Ok("Animal criado com sucesso");
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int Id) {
            try {
                await _animal.Delete(Id);
                return Ok("Animal deletado com sucesso");

            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{Id}")]

        public async Task<ActionResult> Update([FromRoute] int Id, [FromBody] Animal animal) {

            try {
                await _animal.Update(Id, animal);
                return Ok("Animal atualizado com sucesso");

            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult> Get([FromRoute] int Id) {

            try {
                var result = await _animal.Get(Id);
                return Ok(result);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("Cliente/{Id}")]
        public async Task<ActionResult> GetAnimalByClienteId([FromRoute] int Id) {

            try {
                var result = await _animal.GetAnimalByCliente(Id);
                return Ok(result);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> List() {
            try {
                var result = await _animal.List();
                return Ok(result);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }

            
        }

    }
}














