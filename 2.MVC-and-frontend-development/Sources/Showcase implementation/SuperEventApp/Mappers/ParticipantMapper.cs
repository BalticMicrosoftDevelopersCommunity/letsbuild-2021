using SuperEventApp.Models;
using SuperEventModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperEventApp.Mappers
{
    /// <summary>
    /// This shows a very manual (and controlled) approach to mapping data between contracts, if you are using automapper, you don't need this
    /// </summary>
    public static class ParticipantMapper
    {
        public static ParticipantViewModel Map(Participant item)
        {
            var result = new ParticipantViewModel()
            {
                Name = item.Name,
                Age = item.Age,
                Email = item.Email
            };
            return result;
        }

        public static Participant Map(ParticipantViewModel item)
        {
            var result = new Participant()
            {
                Name = item.Name,
                Age = item.Age,
                Email = item.Email
            };
            return result;
        }
    }
}
