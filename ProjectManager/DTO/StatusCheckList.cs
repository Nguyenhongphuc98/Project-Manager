using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StatusCheckList
    {
        public int sum;
        public int finished;

        public StatusCheckList(int sum, int finished)
        {
            this.sum = sum;
            this.finished = finished;
        }
    }
}
