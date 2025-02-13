using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class EventServices
    {
        private readonly List<EventModel> eventList = [];

        public void AddNewEvent(EventModel newEvent)
        {
            int newId = GetRandomInt();
            EventModel eventExists = GetEventById(newId);

            while (eventExists != null)
            {
                newId = GetRandomInt();
                eventExists = GetEventById(newId);
            }

            eventList.Add(newEvent);
        }

        public void DeleteEvent(int eventId)
        {
            eventList.RemoveAll(e => e.Id == eventId);
        }

        public List<EventModel> GetAllEvents()
        {
            return eventList;
        }
        public List<EventModel> GetEventByName(string searchQuery)
        {
            return eventList.FindAll(e => e.EventName.StartsWith(searchQuery));
        }

        private int GetRandomInt()
        {
            return new Random().Next(1, 1000);
        }

        private EventModel GetEventById(int eventId)
        {
            return eventList.Find(e => e.Id == eventId);
        }
        

    }
}