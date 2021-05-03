using SuperEventModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperEventService
{
    public class ParticipantLogic : IParticipantLogic
    {
        public void AddParticipant(Participant person)
        {
            // save to database
        }

        public List<Participant> GetEventParticipants()
        {
            List<Participant> participantList = new List<Participant>();
            participantList.Add(new Participant { Name = "Johny", Age = 25, Email = "johny@gmail.com" });
            participantList.Add(new Participant { Name = "Johny", Age = 25, Email = "johny@gmail.com" });
            participantList.Add(new Participant { Name = "Johny", Age = 25, Email = "johny@gmail.com" });
            participantList.Add(new Participant { Name = "Johny", Age = 25, Email = "johny@gmail.com" });

            return participantList.OrderBy(x=>x.Name).ToList();
        }
    }
}
