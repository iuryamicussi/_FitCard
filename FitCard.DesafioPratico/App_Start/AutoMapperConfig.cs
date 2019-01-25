using AutoMapper;
using FitCard.DesafioPratico.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitCard.DesafioPratico.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configurar()
        {
            Mapper.Initialize(cfg => {
                cfg.AddProfile<DominioParaViewModelProfile>();
                cfg.AddProfile<ViewModelParaDominioProfile>();
            });
        }
    }
}