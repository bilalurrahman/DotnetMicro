using Catalogs.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogs.API.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Products> Products { get; }
    }
}
 