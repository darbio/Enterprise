using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    using Core.Models;

    public class Person : IPerson
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        internal Person() { }

        public int Age
        {
            get
            {
                var today = DateTime.Today;

                var a = (today.Year*100 + today.Month)*100 + today.Day;
                var b = (DateOfBirth.Year*100 + DateOfBirth.Month)*100 + DateOfBirth.Day;

                return (a - b)/10000;
            }
        }
    }
}
