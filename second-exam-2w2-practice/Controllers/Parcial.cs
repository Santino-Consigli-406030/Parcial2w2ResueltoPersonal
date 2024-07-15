using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using second_exam_2w2_practice.DTOs;
using second_exam_2w2_practice.Repositories.Interfaces;

namespace second_exam_2w2_practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Parcial : ControllerBase
    {
        private readonly IDbRepositoryObras _dbRepositoryObras;
        public Parcial(IDbRepositoryObras dbRepositoryObras) { 

            _dbRepositoryObras = dbRepositoryObras;
        }

        [HttpGet("getObrasActivas")]
        public async Task<IActionResult> GetObras() {
            var response = await _dbRepositoryObras.GetObrasAsync();

            return Ok(response);
        }

        [HttpPost("postAlbanilXObra")]
        public async Task<IActionResult> PostAlbanilXObra([FromBody] AlbanilXObraPostDTORequest albanilXObraPostDTORequest)
        {
            var response = await _dbRepositoryObras.PostAlbanilXObraAsync(albanilXObraPostDTORequest);
            return Ok(response);
        }
        [HttpGet("getAlbaniles/{id}")]
        public async Task<IActionResult> GetAlbanilesNotInObra(Guid id)
        {
            var response = await _dbRepositoryObras.GetAlbanilesNotInObraAsync(id);
            return Ok(response);
        }
        [HttpPost("postAlbanil")]
        public async Task<IActionResult> PostAlbanil([FromBody] AlbanilPostDTORequest albanilPostDTORequest)
        {
            var response = await _dbRepositoryObras.PostAlbanilAsync(albanilPostDTORequest);
            return Ok(response);
        }

    }
}
