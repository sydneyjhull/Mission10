using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Models
{
    public interface IBookstoreRepository
    {
        //can read from this, but can't write
        IQueryable<Book> Books { get; }
    }
}
