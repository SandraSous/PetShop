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
        public  ActionResult Create([FromBody] Animal animal) {
            try {
                _animaisRepository.Create(animal);
                return Ok("Animal criado com sucesso");
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{Id}")]
        public  ActionResult Delete(int id) {
            try {
                _animaisRepository.Delete(id);
                return Ok("Animal deletado com sucesso" );

            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{Id}")]

        public  ActionResult Update([FromRoute] int id, [FromBody] Animal animal) {

            try {
                return Ok( _animaisRepository.Update(id, animal));

            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public  ActionResult Get([FromRoute]int id) {

            try {
                return Ok(_animaisRepository.Get(id));
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














