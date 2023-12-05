using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        //ürünleri kategoriye göre listele, ürünleri fiyata göre listele gibi filtreler yazabilmemizi sağlar.
        //filer=null ifadesi, filtre vermeyedebilirsin anlamına gelir. Filtre vermediği zaman tüm datayı getir der.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter); 

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
