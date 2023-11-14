using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Abstracts;

namespace Entity.Concretes
{
    public class Category : IEntities
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
