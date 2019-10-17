using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CibDigiTechWebApp.Model
{
    public class Directory
    {
        [Key]
        public int PhoneBookId { get; set; }

        [DataMember]
        public string PhoneBookName { get; set; }

        [DataMember]
        public List<EntryBookDto> Entries { get; set; }
    }
}
