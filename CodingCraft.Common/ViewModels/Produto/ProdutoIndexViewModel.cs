﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingCraft.Common.ViewModels.Produto
{
    public class ProdutoIndexViewModel
    {
        public string Descricao { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}