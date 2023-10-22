using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisdomPetMedicine.Pet.Domain.Services
{
    public interface IBreedService
    {
        PetBreed Find(string name);
    }
}
