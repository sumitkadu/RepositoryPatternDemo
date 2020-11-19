using System;
using RepositoryPatternDemo.Domain.Models;

namespace RepositoryPatternDemo.Domain.Data
{
    public class UnitOfWork : IDisposable
    {
        private readonly MyMDBContext context;
        private GenericRepository<Movie> movieRepository;
        private GenericRepository<Star> starRepository;

        UnitOfWork(MyMDBContext myMDBContext)
        {
            context = myMDBContext;
        }

        public GenericRepository<Movie> MovieRepository
        {
            get
            {

                if (this.movieRepository == null)
                {
                    this.movieRepository = new GenericRepository<Movie>(context);
                }
                return movieRepository;
            }
        }

        public GenericRepository<Star> StarRepository
        {
            get
            {

                if (this.starRepository == null)
                {
                    this.starRepository = new GenericRepository<Star>(context);
                }
                return starRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}