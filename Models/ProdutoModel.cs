using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProMVC.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        [Range(1,50,ErrorMessage ="Valor inválido!")]
        public int Quantidade { get; set; }
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public CategoriaModel Categoria { get; set; }
    }
}
