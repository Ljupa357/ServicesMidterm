using AutoMapper;
using midTerm.Data.Entities;
using midTerm.Models.Models.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace midTerm.Models.Profiles
{
    public class QuestionProfile
        : Profile
    {
        public QuestionProfile()
        {
            CreateMap<Question, QuestionModelBase>()
                .ReverseMap();
            CreateMap<Question, QuestionModelExtended>();
            CreateMap<QuestionCreateModel, Question>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text))
                 .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));


            CreateMap<QuestionUpdateModel, Question>()

               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ReverseMap();
        }
    }
}
