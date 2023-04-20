using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam413_zm275.Models
{
    public class EFEntertainmentAgencyRepository : IEntertainmentAgencyRepository
    {
        private EntertainmentAgencyExampleContext context { get; set; }
        public EFEntertainmentAgencyRepository(EntertainmentAgencyExampleContext temp) => context = temp;

        public IQueryable<Entertainers> Entertainer => context.Entertainers;

        public IEnumerable<Entertainers> GetEntertainers()
        {
            return context.Entertainers.ToList();

        }
        public Entertainers GetEntertainersByID(long id)
        {
            return context.Entertainers.Find(id);
        }

        public void InsertEntertainers(Entertainers Entertainers)
        {
            context.Entertainers.Add(Entertainers);
        }

        public void DeleteEntertainers(Entertainers Entertainers)
        {
            
            context.Entertainers.Remove(Entertainers);
        }

        public void UpdateEntertainers(Entertainers Entertainers)
        {
            context.Entry(Entertainers).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
