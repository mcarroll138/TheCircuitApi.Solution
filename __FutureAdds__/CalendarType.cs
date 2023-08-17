namespace CircuitCalendarApi.Models
{
    public class CalendarType 
    //used for a calendar type, personal, work, social, groups etc
    {
        public int CalendarTypeId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        //Group Id? Needed to add users to specific groups?

    }
}