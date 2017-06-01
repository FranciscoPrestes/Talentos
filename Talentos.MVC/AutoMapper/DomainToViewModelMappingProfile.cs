using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Talentos.Domain.Entities;
using Talentos.MVC.ViewModels;

namespace Talentos.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CandidatoViewModel, Candidato>();
            Mapper.CreateMap<HabilidadeViewModel, Habilidade>();
        }
    }
}