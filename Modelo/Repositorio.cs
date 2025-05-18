using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public abstract class Repositorio<T>
    {
        protected Context context = new Context(); //no voy a usar esta instancia igualmente
        public abstract List<T> Listar();
        public abstract void Add(T t);
        public abstract void Del(T t);
        public abstract void Mod(T t);

        public bool Guardar()
        {
            bool ret = false;
            try
            {
                context.SaveChanges();
                context.Dispose();
                context = new Context();
                ret = true;
            }
            catch (DbUpdateException ex)
            {
                throw;
            }

            return ret;
        }
    }
}