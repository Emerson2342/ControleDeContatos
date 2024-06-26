﻿using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        //public int Ordem {  get; set; }
        [Required(ErrorMessage ="Digite o nome do contato!")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Digite o Email do contato!")]
        [EmailAddress(ErrorMessage ="O Email informado não é válido!")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Digite o celular do contato!")]
        [Phone(ErrorMessage ="O celular informado não é válido")]
        public string Celular { get; set; } 

        public int? UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }
        

    }
}
