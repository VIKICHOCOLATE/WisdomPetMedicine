using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WisdomPetMedicine.Common;

namespace WisdomPetMedicine.Pet.Domain.Events
{
    public class PetBreedChanged : IDomainEvent
    {
        public Guid Id { get; set; }
        public string Breed { get; set; }
    }
}
