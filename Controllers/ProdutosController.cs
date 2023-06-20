using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdutoApi.Models;
using ProdutoApi.Data;
using System.Threading.Tasks;

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
        

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                Produto a = await _context.Produtos.FirstOrDefaultAsync(aBusca => aBusca.Id == id);
                return Ok(a);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        


    }
}