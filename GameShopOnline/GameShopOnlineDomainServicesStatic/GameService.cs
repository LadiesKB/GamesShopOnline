using GameShopOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShopOnline;
using GameShopOnlineDomainServicesStatic.Comon;
using GameShopOnline.Audit;

namespace GameShopOnlineDomainServicesStatic
{
    public class GameService : DomainService<Game>, IDGameService 
    {
        private readonly List<Game> entities = new List<Game>();
        private readonly IDAttachedFileService attachedFileService;
        private readonly IDGenreService genreService;
        private readonly IDPlatformService platformServicce;
        private readonly IDPriceService priceService;
        private readonly IDProducerService producerService;

        private readonly GameService service;
        protected override List<Game> GetEntities()
        {
            return entities;
        }

        public GameService(IDAttachedFileService attachedFileService, IDGenreService genreService,
        IDPlatformService platformServicce, IDPriceService priceService, IDProducerService producerService,
        IAuditManager auditmanager) : base(auditmanager)
        {

            this.attachedFileService = attachedFileService;
            this.genreService = genreService;
            this.platformServicce = platformServicce;
            this.priceService = priceService;
            this.producerService = producerService;
        }

        protected override void Resolve(ref Game entity)
        {
            base.Resolve(ref entity);
            entity.Pictute = entity.PictureId <= 0 ? null :attachedFileService.Get(entity.PictureId);
            entity.Platform = entity.PlatformId <= 0 ? null : platformServicce.Get(entity.PlatformId);
            entity.Price= entity.PriceId <= 0 ? null : priceService.Get(entity.PriceId);
            entity.Producer = entity.ProduserId <= 0 ? null : producerService.Get(entity.ProduserId);
            entity.URLVideo = entity.VideoId <= 0 ? null : attachedFileService.Get(entity.VideoId);
            entity.Genre = entity.GenreId <= 0 ? null : genreService.Get(entity.GenreId);
        }
    }
}
