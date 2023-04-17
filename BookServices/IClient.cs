using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core 
{
    public  interface IClient <T> where T : class 
    {
        IMongoCollection<T> GetCollection0();      

       


    }
}
