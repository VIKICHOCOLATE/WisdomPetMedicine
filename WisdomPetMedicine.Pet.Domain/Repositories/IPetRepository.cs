﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisdomPetMedicine.Pet.Domain.Repositories
{
    public interface IPetRepository
    {
        Task<Entities.Pet> GetAsync(PetId id);
        Task AddAsync(Entities.Pet pet);
        Task UpdateAsync(Entities.Pet pet);
    }
}
