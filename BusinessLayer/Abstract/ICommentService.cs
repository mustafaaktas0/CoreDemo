﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //  void CommentUpdate(Comment comment);
        // void CommentDelete(Comment comment);
        List<Comment> GetAllList(int id);
        //   Comment GetById(int id);
    }
}
