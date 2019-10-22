using System;

namespace PalTracker
{
    public class TimeEntry
    {
        public long? Id { get; set; }
        public long ProjectId { get; set; }
        public long UserId { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }

        public TimeEntry()
        {
        }
        
        public TimeEntry(int id, int projectId, int userId, DateTime date, int hours)
        {
            Id = id;
            ProjectId = projectId;
            UserId = userId;
            Date = date;
            Hours = hours;
        }

        public TimeEntry(int projectId, int userId, DateTime date, int hours)
        {
            Id = null;
            ProjectId = projectId;
            UserId = userId;
            Date = date;
            Hours = hours;
        }

        public override bool Equals ( object obj )
        {
            return Equals(obj as TimeEntry);
        }

        public bool Equals ( TimeEntry obj )
        {
            return obj != null && obj.Id == this.Id && obj.ProjectId == this.ProjectId && obj.UserId == this.UserId
                   && obj.Date == this.Date && obj.Hours == this.Hours;

        }
    }
}