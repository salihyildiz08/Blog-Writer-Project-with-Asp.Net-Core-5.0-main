﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLatterManager : INewsLatterService
    {
        INewsLatterDal _newslatterdal;

        public NewsLatterManager(INewsLatterDal newslatterdal)
        {
            _newslatterdal = newslatterdal;
        }

        public void AddNewsLatter(NewsLetter newsLetter)
        {
            _newslatterdal.Insert(newsLetter);
        }
    }
}
