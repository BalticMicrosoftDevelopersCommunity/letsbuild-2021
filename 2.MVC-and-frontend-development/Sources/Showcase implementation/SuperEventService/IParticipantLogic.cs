using SuperEventModels;
using System.Collections.Generic;

namespace SuperEventService
{
    public interface IParticipantLogic
    {
        void AddParticipant(Participant person);
        List<Participant> GetEventParticipants();
    }
}