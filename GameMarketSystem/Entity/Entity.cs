using GameMarketSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketSystem.Entity
{
    public abstract class Entity:IEntity
    {
        private static int _nextId = 0;
        public Entity()
        {
            Id = ++_nextId;
        }
        public int Id { get; }
    }
}
