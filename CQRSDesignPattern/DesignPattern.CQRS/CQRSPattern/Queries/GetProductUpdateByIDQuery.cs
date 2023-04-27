using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductUpdateByIDQuery
    {
        public GetProductUpdateByIDQuery(int id)
        {
            ID = id;
        }

        public int ID { get; set; }
    }
}
