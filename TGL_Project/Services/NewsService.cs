using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL_Project.Interfaces;
using TGL_Project.Models;

namespace TGL_Project.Services
{
    public class NewsService : INewsService
    {
        private readonly DataBaseContext _dataBaseContext;

        public NewsService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public async System.Threading.Tasks.Task AddNews(News news)
        {
            await _dataBaseContext.News.AddAsync(news);
            await _dataBaseContext.SaveChangesAsync();
        }

        public void DeleteNews(int newId)
        {
            News nw = _dataBaseContext.News.FirstOrDefault(p => p.Id == newId);

            _dataBaseContext.News.Remove(nw);
            _dataBaseContext.SaveChanges();
        }
    }
}
