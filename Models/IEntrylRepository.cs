using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewRelicDemo_NN_01.Models
{
   public interface IEntrylRepository
    {
        IEnumerable<Entries> ListOfEntries(); 
    }
}
