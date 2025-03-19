using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Units
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int FactoryId { get; set; }
        /// <summary>
        /// array of installations
        /// </summary>
        /// <returns></returns>
        public static Units[] GetUnits()
        {
            return new Units[] {
            new Units { Id = 1, Name = "ГФУ-2", Description = "Газофракционирующая установка", FactoryId = 1 },
            new Units { Id = 2, Name = "АВТ-6", Description = "Атмосферно-вакуумная трубчатка", FactoryId = 1 },
            new Units { Id = 3, Name = "АВТ-10", Description = "Атмосферно-вакуумная трубчатка", FactoryId = 2 } 
            };
        
        }
        /// <summary>
        /// the factory object corresponding to the installation
        /// </summary>
        /// <param name="units"></param>
        /// <param name="tanks"></param>
        /// <param name="unitName"></param>
        /// <returns></returns>
        public static Units FindUnit(Units[] units, Tanks[] tanks, string tankName)
        {
            foreach (var tank in tanks)
            {
                if (tank.Name == tankName)
                {
                    foreach (var unit in units)
                    {
                        if (unit.Id == tank.UnitId)
                        {
                            return unit;
                        }
                    }
                }
            }
            return null;
        }


    }
}
