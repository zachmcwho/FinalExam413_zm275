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
    }
}
