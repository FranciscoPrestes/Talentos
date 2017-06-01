using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Talentos.Domain.Entities;
using Talentos.Domain.Entities.ValueObjects;

namespace Talentos.MVC.ViewModels
{
    public class CandidatoViewModel
    {
        public int CandidatoId { get; set; }

        [Display(Name = "Nome (Obrigatório)")]
        [Required(ErrorMessage = "Preencha seu nome.")]
        [MaxLength(ErrorMessage = "Tamanho máximo 150 caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Email (Obrigatório)")]
        [Required(ErrorMessage = "Preencha seu email.")]
        [EmailAddress(ErrorMessage = "Endereço de email inválido.")]
        [MaxLength(ErrorMessage = "Tamanho máximo 150 caracteres.")]
        public string Email { get; set; }


    }
}