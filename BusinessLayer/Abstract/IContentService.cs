﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetContents();
        List<Content> GetListByHeadingId(int id);
        void ContentAdd(Content content);
        Content GetById(int id);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}
