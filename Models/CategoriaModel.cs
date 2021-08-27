using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProMVC.Models
{
    public class CategoriaModel
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="Campo obrigatório!")]
        public string Descricao { get; set; }
        //public List<ProdutoModel> Produtos { get; set; }
    }
}
