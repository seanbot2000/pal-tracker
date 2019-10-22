using System.Collections.Generic;
using System.Linq;

namespace PalTracker
{
    public class InMemoryTimeEntryRepository : ITimeEntryRepository 
    {
        private readonly IDictionary<long, TimeEntry> _timeEntries = new Dictionary<long, TimeEntry>();

        public TimeEntry Create(TimeEntry timeEntry)
        {
            var id = _timeEntries.Any() ? _timeEntries.Values.Max(te => te.Id) + 1 : 1;
            timeEntry.Id = id;
            
            _timeEntries.Add(id.Value, timeEntry);

            return timeEntry;
        }

        public TimeEntry Find(long id)
        {
            _timeEntries.TryGetValue(id, out var timeEntry);
            return timeEntry;
        }

        public bool Contains(long id)
        {
            var success = _timeEntries.TryGetValue(id, out var timeEntry);
            return success;
        }

        public void Delete(long id)
        {
            _timeEntries.Remove(id);
        }

        public TimeEntry Update(long id, TimeEntry timeEntry)
        {
            timeEntry.Id = id;
            _timeEntries.TryGetValue(id, out var thisTimeEntry);

            if (thisTimeEntry == null)
            {
                _timeEntries.Add(id, timeEntry);
            }
            else
            {
                _timeEntries[id] = timeEntry;
            }

            return timeEntry;
        }

        public IEnumerable<TimeEntry> List()
        {
            return _timeEntries.Values;
        }
    }
}