using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL_Project.Models;

namespace TGL_Project.Interfaces
{
    public interface INewsService
    {
        System.Threading.Tasks.Task AddNews(News news);
        void DeleteNews(int newId);

    }
}
