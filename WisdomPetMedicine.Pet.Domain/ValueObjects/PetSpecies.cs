﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisdomPetMedicine.Pet.Domain.ValueObjects
{
    public record PetSpecies
    {
        public string Value { get; init; }

        internal PetSpecies(string value)
        {
            Value = value;
        }

        public static PetSpecies Get(string value)
        {
            return new PetSpecies(value);
        }

        public static implicit operator string(PetSpecies petSpecies)
        {
            return petSpecies.Value;
        }
    }
}
