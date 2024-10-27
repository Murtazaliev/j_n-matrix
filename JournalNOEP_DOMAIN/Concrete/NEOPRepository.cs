using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace JournalNOEP_DOMAIN
{
    public class NEOPRepository : IRepository
    {
        private readonly NEOPContext _context;

        public NEOPRepository(NEOPContext context)
        {
            _context = context;
        }

        public IQueryable<Articles> Articles => _context.Articles;
        public IQueryable<DataArticleAuthors> DataArticleAuthors => _context.DataArticleAuthors;
        public IQueryable<DataEdition> DataEdition => _context.DataEdition;
        public IQueryable<DataYear> DataYear => _context.DataYear;
        public IQueryable<SprJoiurnalAuthors> SprJoiurnalAuthors => _context.SprJoiurnalAuthors;
        public IQueryable<SprJournalSection> SprJournalSection => _context.SprJournalSection;
        public IQueryable<DataInfo> DataInfo => _context.DataInfo;

        public IQueryable<DataConferenceYear> DataConferenceYears => _context.DataConferenceYears;
        public IQueryable<DataConferenceArticle> DataConferenceArticles => _context.DataConferenceArticles;
        public IQueryable<DataConferenceArticleAuthor> DataConferenceArticleAuthors => _context.DataConferenceArticleAuthors;
        public IQueryable<DataConferenceEdition> DataConferenceEditions => _context.DataConferenceEditions;

        #region |-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-[  Универсальные методы CRUD ]-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|

        /// <summary>
        /// Создание универсального метода вставки
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public void Insert<TEntity>(TEntity entity) where TEntity : class
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
        }

        /// <summary>
        /// Запись нескольких полей в БД
        /// </summary>
        public void Inserts<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            foreach (TEntity entity in entities)
            {
                _context.Entry(entity).State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Универсальный метод обновления
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public void Update<TEntity>(TEntity entity)
            where TEntity : class
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        /// <summary>
        /// Универсальный метод удаления данных
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public void Delete<TEntity>(TEntity entity)
            where TEntity : class
        {
            _context.Entry<TEntity>(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        #endregion

    }
}
