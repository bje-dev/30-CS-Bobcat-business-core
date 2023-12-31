﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Contracts
{
    internal interface IGenericRelationship<T, U>
    {
        /// <summary>
        /// Agrego una relación de tipo 1 a *, T elemento origen, U es el destino
        /// </summary>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        void Join(T obj1, U obj2);

        /// <summary>
        /// Obtener elementos destino a partir de un elemento origen T
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        List<U> Get(T obj);
    }
}
