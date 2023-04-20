using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam413_zm275.Models
{
    public interface IEntertainmentAgencyRepository
    {
        IQueryable<Entertainers> Entertainer { get; }
    }
}
