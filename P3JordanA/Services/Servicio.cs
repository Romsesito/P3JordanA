using P3JordanA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P3JordanA.Services
{
    public interface Servicio
    {
        public Task<List<Chistechuck>>GetChistechucks();
   
    }
}
