using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tanks
    {
        /// <summary>
        /// Unique tank identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Volume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MaxVolume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int UnitId {  get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Tanks[] GetTanks()
        {
            return new Tanks[] {
            new Tanks { Id = 1, Name = "Резервуар 1", Description = "Надземно-вертикальный", Volume = 1500, MaxVolume = 2000,  UnitId = 1 },
            new Tanks { Id = 2, Name = "Резервуар 2", Description = "Надземно-горизонтальный", Volume = 2500, MaxVolume = 3000,  UnitId = 1 },
            new Tanks { Id = 3, Name = "Дополнительный резервуар 24", Description = "Надземно-горизонтальный", Volume = 3000, MaxVolume = 2000,  UnitId = 2},
            new Tanks { Id = 4, Name = "Резервуар 35", Description = "Надземно-вертикальный", Volume = 3000, MaxVolume = 3000,  UnitId = 2 },
            new Tanks { Id = 5, Name = "Резервуар 47", Description = "Подземно-двустенный", Volume = 4000, MaxVolume = 5000, UnitId = 2 },
            new Tanks { Id = 6, Name = "Резервуар 256", Description = "Подводный", Volume = 500, MaxVolume = 500,  UnitId = 3 }
            };
        }
        public static int GetTotalVolume(Tanks[] tanks)
        {
            int totalVolume = 0;
            foreach (var tank in tanks)
            {
                totalVolume += tank.Volume;
            }
            return totalVolume;
        }


    }
}
