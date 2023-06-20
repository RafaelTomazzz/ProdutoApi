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

        [HttpPost]
        public async Task<IActionResult> Post(Produto novoProduto)
        {
            try
            {
                await _context.Produtos.AddAsync(novoProduto);
                await _context.SaveChangesAsync();

                return Ok(novoProduto.Id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Produto pRemover = await _context.Produtos.FirstOrDefaultAsync(p => p.Id == id);

                _context.Produtos.Remove(pRemover);
                int linhaAfetadas = await _context.SaveChangesAsync();
                return Ok(linhaAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        public async Task<IActionResult> Update(Produto novoProduto)
        {
            try
            {
                _context.Produtos.Update(novoProduto);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}