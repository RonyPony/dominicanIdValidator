using System;

namespace dominicanIdValidator.Interface
{
    public interface ICedulaService
    {
        public IEnumerable<Padron> getAllPadrons();
        public Padron getPadronById(string id);
        public Task<Padron> CreatePadron(Padron Padron);
        public Task<Padron> UpdatePadron(Padron Padron);
        public Task<bool> RemovePadron(Guid PadronId);
    }
}
