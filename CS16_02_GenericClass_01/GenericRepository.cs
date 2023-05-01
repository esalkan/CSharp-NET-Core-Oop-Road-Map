using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS16_02_GenericClass_01
{
    public class GenericRepository<T>
    /*
     * We can use that generic class like;
     *      - public class GenericRepository<T, R, K, etc...>  = But it is not nice, maximum 2 is general usage.
     *      - public class GenericRepository<T> where T:Class  = Means, T type must be Class.
     */
    {
        public GenericRepository()
        {
            // context : EntityFramework (EF), DBFirst.
        }

        public virtual List<T> Bring() // List Generic can return, int, string, Customer too
        {
            // Amaç: Gelen T tipini database üzerinden sorgulamak ve elde etmiş olduğum kayıtları generic koleksiyon olarak bir üst katmana dönmek..
            // Purpose: To query the incoming T type from the database and return the records I have obtained to the upper layer as a generic collection.
            return null;
        }

        public virtual void addNewRecord(T data)
        {
            // T tipinin işaret ettiği tabloya bize gelen T tipindeki bilgileri ekliyoruz.
            // We add the information in the T type that comes to us to the table that the T type points to.
        }
    }
}
