using System;

namespace dominicanIdValidator.Interface
{
    public interface ICedulaRepository
    {
        public Task<Padron> getCedulaById(string id);
    }
}
