using System.Collections.Generic;

namespace PalTracker
{
    public interface ITimeEntryRepository
    {
        TimeEntry Create(TimeEntry timeEntry);
        TimeEntry Find(long id);
        bool Contains(long id);
        void Delete(long id);
        TimeEntry Update(long id, TimeEntry timeEntry);
        IEnumerable<TimeEntry> List();
    }
}