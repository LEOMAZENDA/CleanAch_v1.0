using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }

        public DateTime CreateDate { get; protected set; }
        public DateTime LastUpdate { get; protected set; }

        public EntityBase()
        {
                CreateDate = DateTime.Now;
                LastUpdate = DateTime.Now;
        }

    }
}
