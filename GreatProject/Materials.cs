﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class Materials : Item
    {
        private int capacity;                           //об'єм 
        private int weight;                            // вага
        readonly string type_of_materials;                  


        public int Capacity
        {
            get { return capacity; }
            set {
                if (capacity > 0)
                {
                    capacity = value;
                }
                else
                {
                    throw new CapacityException("Capacity!<0", 0);
                }
            }
        }
        public string Type_of_materials
        {
            get { return type_of_materials; }
        }
       

        public Materials() :base()
        {

        }

        public Materials(string name, int capacity, int weight, string type_of_materials)
        {
            Name = name;
            Capacity = capacity;
            Weight = weight;
            this.type_of_materials = type_of_materials;
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public double price_of_Materials()
        {
            if ((Convert.ToDouble(Capacity / Weight)) > 1)          //вартість об'єкту повинна розраховуватись від його густини, чим більша густина тим більша ціна, якось так)
            {
                return Capacity * Weight * 1.5;
            }
            else
                return Capacity * Weight * 2;
        }

        public override string Print_Info()
        {
            return $"Name:{Name} Capacity:{Capacity}  Weight:{Weight} Type:{Type_of_materials}";
        }
    }
}
