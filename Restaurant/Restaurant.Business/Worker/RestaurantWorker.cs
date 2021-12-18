using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Business.Manegers;
using Restaurant.Business.Services;
using Restaurantt.DataAcces.UnitOfWork;

namespace Restaurant.Business.Worker
{
    public class RestaurantWorker : IWorker
    {
        private IUnitOfWork _uow;
        public IUrunServices UrunServices { get; set; }
        public ITanimServices TanimServices { get; set; }
        public IPorsiyonServices PorsiyonServices { get; set; }
        public IEkMalzemeServices EkMalzemeServices { get; set; }
        public IMusteriService MusteriService { get; set; }
        public ITelefonService TelefonService { get; set; }
        public IAdresService AdresService { get; set; } 


        public RestaurantWorker(string connectionString=null)
        {
            _uow = new RestaurantUnitOfWork(connectionString);
            UrunServices = new UrunManeger(_uow);
            TanimServices = new TanimManeger(_uow);
            PorsiyonServices = new PorsiyonManeger(_uow);
            EkMalzemeServices = new EkMalzemeManeger(_uow);
            MusteriService = new MusteriManager(_uow);
            TelefonService = new TelefonManager(_uow);
            AdresService = new AdresManeger(_uow);
        }


        private bool disposedValue;

        public bool Commit()
        {
            return  _uow.Commit();
        }

        public void DetectChanges()
        {
            _uow.DetectChanges();
        }

        public bool HasChanges()
        {
            return _uow.HasChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~RestaurantWorker()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
