using AP1_P1_Jarissa.DAL;
using AP1_P1_Jarissa.Model;
using System.Linq.Expressions;
using AP1_P1_Jarissa.BLL;
using Microsoft.EntityFrameworkCore;


namespace AP1_P1_Jarissa.BLL
{

    public class AporteBLL
    {

        private Contexto contexto;

        public AporteBLL(Contexto _contexto)
        {
            contexto = _contexto;
        }

        public bool Modificar(Aporte aporte){

         contexto.Entry(aporte).State = EntityState.Modified;
            return contexto.SaveChanges() > 0;
        }



        public bool Existe ( int AporteId){

         return contexto.aporte.Any(o => o.AporteId == AporteId);

        }



        public   bool Insertar(Aporte aporte ){

             contexto .aporte.Add(aporte);
             return contexto.SaveChanges() > 0;
        }

        public bool Guardar(Aporte aporte)
        {
            if (!Existe(aporte.AporteId))
                return this.Insertar(aporte);
            else
                return this.Modificar(aporte);
        }

        public bool Eliminar(Aporte aporte)
        {
            contexto.Entry(aporte).State = EntityState.Deleted;
            return contexto.SaveChanges() > 0;
        }

         public Aporte? Buscar(int aporteid)
          {
               return contexto.aporte
                       .Where(o => o.AporteId == aporteid)
                       .AsNoTracking()
                       .SingleOrDefault();

          }   
        public List<Aporte> Getaporte(Expression<Func<Aporte, bool>> Criterio)
        {
            return contexto.aporte
                .AsNoTracking()
                .Where(Criterio)
                .ToList();
        }

    }
}








