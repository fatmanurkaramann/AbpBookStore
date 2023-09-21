using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public interface IAddressManager
    {
        Task<Address> CreateAsync(Address address);
    }
}
