﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmprestimoLivros.API.Entityes
{
    [Table("Livro_Cliente_Emprestimo")]
    public partial class LivroClienteEmprestimo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int LceIdCliente { get; set; }
        [Column("lceIdLivro")]
        public int LceIdLivro { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LceDataEmprestimo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LceDataEntrega { get; set; }
        public bool? LceEntrega { get; set; }

        [ForeignKey(nameof(LceIdCliente))]
        [InverseProperty(nameof(Cliente.LivroClienteEmprestimo))]
        public virtual Cliente LceIdClienteNavigation { get; set; }
        [ForeignKey(nameof(LceIdLivro))]
        [InverseProperty(nameof(Livro.LivroClienteEmprestimo))]
        public virtual Livro LceIdLivroNavigation { get; set; }
    }
}