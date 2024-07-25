using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Domain.Entities
{
    public class SnowFallData
    {
        public int Year { get; set; }
        public List<MonthlySnowFallData> MonthlySnowFallDataItems { get; set; }
    }
}
