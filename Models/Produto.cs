using ProdutoApi.Models;

namespace ProdutoApi.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Valor { get; set; }
        //public DateOnly Validade { get; set;} 
    }
}