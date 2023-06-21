using ProdutoApi.Models;
using System;

namespace ProdutoApi.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Valor { get; set; }
        public DateTime Validade { get; set; } 
    }
}