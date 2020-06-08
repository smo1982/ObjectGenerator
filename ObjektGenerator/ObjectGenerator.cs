using System;
using System.Collections.Generic;
using System.Text;

namespace ObjektGenerator
{
    class ObjectGenerator
    {
        public T GetNewObject<T>() where T : new()
        {
            T newObjekt = new T();

            return newObjekt;
        }

        public List<T> GetNewObjects<T>(int amountOfObjects) where T : new()
        {
            List<T> list = new List<T>();

            for(int i = 0; i < amountOfObjects; i++)
            {
                T newObjekt = GetNewObject<T>();
                list.Add(newObjekt);
            }

            return list;
        }
    }
}
