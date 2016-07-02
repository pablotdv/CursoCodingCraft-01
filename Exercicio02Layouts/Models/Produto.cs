﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Exercicio02Layouts.Models
{
    /*
     Scaffold Portugues.Controller Produto -ModelType:Exercicio02Layouts.Models.Produto -Verbose -Force -DbContextType:Exercicio02Layouts.Models.ApplicationDbContext
     Scaffold Portugues.RazorView Produto -ModelType:Exercicio02Layouts.Models.Produto -Verbose -Force

    --gera somente os criar do bootstrap
     Scaffold Portugues.RazorView Produto -ViewName:Criar -Template:bootstrap -ModelType:Exercicio02Layouts.Models.Produto -Force

         */
    public class Produto
    {
        [Key]
        public Guid ProdutoId { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required]
        public Guid ProdutoGrupoId { get; set; }

        [ForeignKey("ProdutoGrupoId")]
        [Required]
        public virtual ProdutoGrupo ProdutoGrupo { get; set; }
    }
}