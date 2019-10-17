using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CibDigiTechWebApp.Model
{
    public class EntryBookDto
    {
        [Key]
        public int PersonId { get; set; }

        [DataMember]
        public string PersonName { get; set; }

        [DataMember]
        public int PhoneNo { get; set; }

        [DataMember]
        public int PhoneBookId { get; set; }
    }
}
