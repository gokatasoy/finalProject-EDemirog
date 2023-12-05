using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //class : referans tip olabilir demek
    //"T" bir referans tip olmalı ve ya IEntity olabilir ya da IEntity'den implemente olan bir şey olabilir. IEntity referanslı olan classlar ise Category, Customer, Product.
    //new() : new'leneiblir olmalı. IEntity interface olduğu için new'lenemez. Bundan dolayı IEntity implemente edilmiş class'lar kullanabilirken kendisi kullanaılaz. 
    public interface IEntityRepository<T> where T: class,IEntity,new()
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
