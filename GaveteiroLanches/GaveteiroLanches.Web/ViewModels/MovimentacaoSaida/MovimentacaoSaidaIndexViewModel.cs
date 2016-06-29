﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GaveteiroLanches.Web.ViewModels.MovimentacaoSaida
{
    public class MovimentacaoSaidaIndexViewModel
    {
        public DateTime DataHora { get; set; }

        public string Usuario { get; set; }

        public int MovimentacaoId { get; set; }

        public decimal? Valor { get; set; }
    }
}