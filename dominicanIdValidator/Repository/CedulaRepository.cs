using dominicanIdValidator.Interface;
using System;
using System.Data.Entity;

namespace dominicanIdValidator.Repository
{
    public class CedulaRepository : ICedulaRepository
    {
        private readonly DominicanIdContext _context;
        public CedulaRepository(DominicanIdContext ctx)
        {
            _context = ctx;
        }


        public Task<Padron> getCedulaById(string id)
        {
            Padron data = _context.Padron.FirstOrDefault(w => w.Cedula == id);
            if (data != null)
            {
                return Task.FromResult(data);
            }
            else
            {
                return Task.FromResult<Padron>(null);
            }
        }


    }
}
