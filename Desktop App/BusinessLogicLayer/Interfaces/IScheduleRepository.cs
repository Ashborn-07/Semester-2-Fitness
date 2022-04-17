using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface IScheduleRepository
    {
        public DataTable DisplaySchedule();

        public DataTable DisplayByFilters(string location);

        public List<string> GetLocations();

        public DataTable FilterByDate(string date);
    }
}
