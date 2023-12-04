using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Category'nin bir veri tablosu olduğunu anlarız çünkü IEntity'den kalıtım almış.
    public class Category:IEntity
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
