using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using PetShop.src.Contrato.Repository;
using PetShop.src.Contrato.Service;
using PetShop.src.Repository;
using PetShop.src.Services;

namespace PetShop.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoController : ControllerBase {
        private readonly IServicoService _servico;
        public ServicoController(IServicoService servico) {
            _servico = servico;

        }

        [HttpGet("Cliente/{Id}")]
        public async Task<ActionResult> GetAnimalByClienteId([FromRoute] int Id) {

            try {
                var result = await _servico.GetServicoByCliente(Id);
                return Ok(result);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]

        public async Task<ActionResult> Create([FromBody] Servico servico) {
            try {
                _servico.Create(servico);
                return Ok("Serviço cadastrado com sucesso");
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete([FromRoute] int Id) {
            try {
                await _servico.Delete(Id);
                return Ok("Serviço excluido com sucesso");

            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{Id}")]

        public async Task<ActionResult> Update([FromRoute] int Id, [FromBody] Servico servico) {

            try {
                await _servico.Update(Id, servico);
                return Ok("Servico atualizado com sucesso");

            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult> Get(int Id) {
            try {
                var result = await _servico.Get(Id);
                return Ok(result);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public async Task<ActionResult> List() {
            try {
                var result = await _servico.List();
                return Ok(result);
            }
            catch (Exception e) {
                return BadRequest(e.Message);

            }



        }





    }

}
