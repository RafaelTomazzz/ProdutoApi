using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdutoApi.Models;
using ProdutoApi.Data;

namespace ProdutoApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class ProdutosController : ControllerBase
    {
        private readonly DataContext _context;

        public ProdutosController(DataContext context)
        {
            _context = context;
        }



        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Produto> lista = await _context.Produtos.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}