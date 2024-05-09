using POS.Infrastructure.Persistences.Contexts;
using POS.Infrastructure.Persistences.Interfaces;

namespace POS.Infrastructure.Persistences.Repositories
{
    internal class CategoryRepository : ICategoryRepository
    { //----------------------------------- Generado por comando. 
        private POSContext context;

        public CategoryRepository(POSContext context)
        {
            this.context = context;
        }
    } //----------------------------------- Toca ver más adelante como es de verdad
}