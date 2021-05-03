using AutoMapper;
using SuperEventApp.Models;
using SuperEventModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperEventApp.Mappers
{
    /// <summary>
    /// Automapper mapping configuration class. You don't need this if you are doing manual mapping
    /// </summary>
    public class ParticipantProfile : Profile
    {
        public ParticipantProfile()
        {
            CreateMap<ParticipantViewModel, Participant>();
        }
    }
}
