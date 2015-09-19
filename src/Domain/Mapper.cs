using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    using Core.Entities;
    using Core.Models;

    using Domain.Models;

    public static class Mapper
    {
        static Mapper()
        {
            AutoMapper.Mapper.CreateMap<Person, IPersonEntity>().ReverseMap();
        }

        public static T1 Map<T1>(object input)
        {
            var output = AutoMapper.Mapper.Map<T1>(input);
            return output;
        }
    }
}
