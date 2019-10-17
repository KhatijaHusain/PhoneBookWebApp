using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CibDigiTechWebApp.Dto
{
    public class PhoneBookDto
    {
        [Key]
        public int PhoneBookId { get; set; }

        [DataMember]
        public string PhoneBookName { get; set; }
    }
}
