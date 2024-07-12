using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using PetShop.src.Contrato.Repository;
using PetShop.src.Contrato.Service;

namespace PetShop.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase {

        private readonly src.Contrato.Service.IClienteService _cliente;

        public ClienteController(src.Contrato.Service.IClienteService cliente) {

            _cliente = cliente;
        }
        [HttpPost]

        public async Task <ActionResult> Create([FromBody] Cliente cliente) {
            try {
               await _cliente.Create(cliente);
                return Ok("Cliente cadastrado com sucesso");
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{Id}")]
        public async Task< ActionResult> Delete( [FromRoute] int Id) {
            try {
                await _cliente.Delete(Id);
                return Ok("Cliente excluido com sucesso");

            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{Id}")]

        public async  Task<ActionResult> Update([FromRoute] int Id, [FromBody] Cliente cliente) {

            try {
               await _cliente.Update(Id, cliente);
                return Ok("Cliente atualizado com sucesso");

            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult> Get([FromRoute] int Id) {
            try {
                var result = await _cliente.Get(Id);
                return Ok(result);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public async Task<ActionResult> List() {
            try {
                var result = await _cliente.List();
                return Ok(result);
            }
            catch (Exception e) {
                return BadRequest(e.Message);

            }


            }
        }
    }

