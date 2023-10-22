using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WisdomPetMedicine.Common;

namespace WisdomPetMedicine.Pet.Domain.Events
{
    public class PetColorChanged : IDomainEvent
    {
        public Guid Id { get; set; }

        public string Color { get; set; }
    }
}
