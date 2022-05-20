﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetWriters();
        void WriterAdd(Writer writer);
        Writer GetById(int id);
        void WriterDelete(Writer writer);
        void WriterUpdate(Writer writer);
    }
}