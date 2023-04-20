using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam413_zm275.Models
{
    public interface IEntertainmentAgencyRepository
    {
        IEnumerable<Entertainers> GetEntertainers();
        Entertainers GetEntertainersByID(long EntertainersId);
        void InsertEntertainers(Entertainers Entertainers);
        void DeleteEntertainers(Entertainers Entertainers);
        void UpdateEntertainers(Entertainers Entertainers);
        void Save();

    }
}
