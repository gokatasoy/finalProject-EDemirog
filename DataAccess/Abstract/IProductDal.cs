using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Product ile ilgili veritabanında yapacağımız operasyonları içerir. ekle, sil, güncelle, listele gibi.
    public interface IProductDal:IEntityRepository<Product>
    {
           
    }
}

//Interface olarak tanımlanmasının sebebi farklı VTYS'ler ile çalışırken kodun genel yapısı değişmeden farklı veri tabanlarına geçiş yapmak daha kolay hale gelir.
