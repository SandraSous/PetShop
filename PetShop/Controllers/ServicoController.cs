using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using PetShop.src.Contrato.Repository;
using PetShop.src.Repository;

namespace PetShop.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoController : ControllerBase {
        private readonly IServicoRepository _servicoRepository;
        public ServicoController(IServicoRepository servicoRepository) {
            _servicoRepository = servicoRepository;

        }
        [HttpPost]

        public ActionResult Create([FromBody] Servico servico) {
            try {
                _servicoRepository.Create(servico);
                return Ok("Serviço cadastrado com sucesso");
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id) {
            try {
                _servicoRepository.Delete(id);
                return Ok("Serviço excluido com sucesso");

            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]

        public ActionResult Update([FromRoute] int id, [FromBody] Servico servico) {

            try {
                return Ok(_servicoRepository.Update(id, servico));

            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id) {
            try {
                return Ok(_servicoRepository.Get(id));
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public ActionResult List() {
            try {
                return Ok(_servicoRepository.List());
            }
            catch (Exception e) {
                return BadRequest(e.Message);

            }



        }





    }

}
