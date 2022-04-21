using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ScheduleService
    {
        private IScheduleRepository repository;

        public ScheduleService(IScheduleRepository repository)
        {
            this.repository = repository;
        }

        public DataTable DisplaySchedules()
        {
            return repository.DisplaySchedule();
        }

        public DataTable DisplaySchedulesByFilter(string location)
        {
            return repository.DisplayByFilters(location);
        }

        public DataTable DisplaySchedulesByDate(string date)
        {
            return repository.FilterByDate(date);
        }

        public List<string> GetLocationsFilter()
        {
            return repository.GetLocations();
        }
    }
}
