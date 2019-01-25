using AutoMapper;
using FitCard.DesafioPratico.Dominio;
using FitCard.DesafioPratico.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitCard.DesafioPratico.AutoMapper
{
    public class DominioParaViewModelProfile : Profile
    {
        public DominioParaViewModelProfile()
        {
            CreateMap<Estabelecimento, EstabelecimentoViewModel>();
            CreateMap<Estabelecimento, EstabelecimentoEditViewModel>();
        }
    }
}