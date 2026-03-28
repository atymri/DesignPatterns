using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class EmpAddress
    {
        public string Address { get; set; }

        public EmpAddress(string a)
        {
            Address = a;
        }

        public EmpAddress Clone()
        {
            return this.MemberwiseClone() as EmpAddress;
        }

        public override string ToString()
        {
            return Address;
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmpAddress Address { get; set; }

        public Employee(int id, string name, EmpAddress address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        // clone constructor for deep copy
        public Employee(Employee emp)
        {
            Id = emp.Id;
            Name = emp.Name;
            Address = emp.Address.Clone(); // cloning it to prevent single reference
        }

        public Employee Clone()
        {
            // shallow copy:
            // return this.MemberwiseClone() as Employee;

            // deep copy:
            var clone = this.MemberwiseClone() as Employee;
            clone.Address = Address.Clone();

            return clone;
        }

        public override string ToString()
        {
            return $"Employee name is: {Name}, Employee Id is: {Id}, Employee Address is: {Address}";
        }
    }
}
