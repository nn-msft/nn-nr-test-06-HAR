using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace NewRelicDemo_NN_01.Models
{
    public class EntryRepository : IEntrylRepository
    {
        //private Entries entry;
        private static ConcurrentDictionary<string, Entries> _entries = new ConcurrentDictionary<string, Entries>();
        public EntryRepository() {

            
        
        }
        public IEnumerable<Entries> ListOfEntries() {

            return _entries.Values;
        }

    }
}
