using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class EventModel
    {
        [Required(ErrorMessage = "Event Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Event Name is required")]
        public string EventName { get; set; }

        [Required(ErrorMessage = "Event Location is required")]
        public string EventLocation { get; set; }

        [Required(ErrorMessage = "Event Date is required")]
        public DateTime EventDate { get; set; }

    }
}