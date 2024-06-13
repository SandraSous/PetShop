using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using PetShop.src.Contrato.Repository;
using PetShop.src.Contrato.Service;

namespace PetShop.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase {

        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService) {

            _clienteService = clienteService;
        }
        [HttpPost]

        public ActionResult Create([FromBody] Cliente cliente) {
            try {
                _clienteService.Create(cliente);
                return Ok("Cliente cadastrado com sucesso");
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public  ActionResult Delete( [FromRoute] int id) {
            try {
                _clienteService.Delete(id);
                return Ok("Cliente excluido com sucesso");

            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]

        public  ActionResult Update([FromRoute] int id, [FromBody] Cliente cliente) {

            try {
                _clienteService.Update(id, cliente);
                return Ok("Cliente atualizado com sucesso");

            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public  ActionResult Get(int id) {
            try {
                return Ok( _clienteService.Get(id));
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public  ActionResult List() {
            try {
                return Ok( _clienteService.List());
            }
            catch (Exception e) {
                return BadRequest(e.Message);

            }


            }
        }
    }

