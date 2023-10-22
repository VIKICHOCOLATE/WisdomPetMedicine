using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisdomPetMedicine.Common
{
    public class DomainEvent<T>
    {
        private List<Action<T>> Actions { get; } = new List<Action<T>>();
        public void Register()
        {

        }

        public void Publish(T args)
        {

        }
    }
}
