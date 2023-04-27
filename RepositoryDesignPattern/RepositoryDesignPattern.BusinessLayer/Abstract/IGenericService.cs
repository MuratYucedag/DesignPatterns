﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T t);
        void TUpdate(T t);
        void TDelete(T t);
        List<T> TGetList();
        T TGetByID(int id);
    }
}
