using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTel.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }

        [Required(ErrorMessage="{0} É obrigatório ")]
        [StringLength(40,ErrorMessage ="Use menos Caracteres")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage ="{0} É obrigatório ")]
        [StringLength(45,ErrorMessage ="Use 45 Caracteres")]
        public string SobreNome { get; set; }
        
        [Required(ErrorMessage ="{0} É Obrigatório ")] 
        [Range(18,int.MaxValue,ErrorMessage =" Idade Inválida")]
        public int Idade { get; set; }


        [Required(ErrorMessage ="{0} É Obrigatório ")]
        [StringLength(45,ErrorMessage =" Use 45 Caracteres")]
        [EmailAddress(ErrorMessage =" Email Inválido ")]
        public string Email { get; set; }

        [Required(ErrorMessage ="{0} É Obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage ="{0} É Obrigatório")]
        public TipoTelefone TipoTelefone { get; set; }

        public string Foto { get; set; }



    }

    public enum TipoTelefone
    {
        Pessoal , Comercial 
    }
}
