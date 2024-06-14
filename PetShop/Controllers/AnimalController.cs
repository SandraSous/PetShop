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
        //private readonly IAnimaisService _animal;
        //public AnimalController(IAnimaisService animal) {
        //    _animal = animal;
        //}
        private readonly IAnimailRepository _animaisRepository;
        public AnimalController(IAnimailRepository animaisRepository)
        {
          _animaisRepository = animaisRepository;
        }

        [HttpPost]
        public async Task <ActionResult> Create([FromBody] Animal animal) {
            try {
               await _animaisRepository.Create(animal);
                return Ok("Animal criado com sucesso");
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task <ActionResult> Delete(int id) {
            try {
               await _animaisRepository.Delete(id);
                return Ok("Animal deletado com sucesso" );

            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]

        public async Task<ActionResult> Update([FromRoute] int id, [FromBody] Animal animal) {

            try {
               await _animaisRepository.Update(id, animal);
                return Ok("Animal atualizado com sucesso");

            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task <ActionResult> Get([FromRoute]int id) {

            try {
                await _animaisRepository.Get(id);
                return Ok();
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public async Task <ActionResult> List() {
            try {
                var result = await _animaisRepository.List();
                return Ok(result );
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

    }
}














