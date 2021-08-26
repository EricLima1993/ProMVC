using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProMVC.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public CategoriaModel Categoria { get; set; }
    }
}
