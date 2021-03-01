using System.Collections.Generic;

namespace Projeto_MVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}