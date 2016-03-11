using GameShopOnline;
using GameShopOnline.Audit;
using GameShopOnline.Domain.Services;
using GameShopOnlineDomainServicesStatic.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnlineDomainServicesStatic
{
    public class GameServiceAsync : DomainServiceAsync<Game>, IDGameServiceAsync
    {
        private readonly List<Game> entities = new List<Game>();
        private readonly IDAttachedFileServiceAsync attachedFileService;
        private readonly IDGenreServiceAsync genreService;
        private readonly IDPlatformServiceAsync platformService;
        private readonly IDPriceServiceAsync priceService;
        private readonly IDProducerServiceAsync producerService;

        public GameServiceAsync(IDAttachedFileServiceAsync attachedFileService,
        IDGenreServiceAsync genreService, IDPlatformServiceAsync platformService,
        IDPriceServiceAsync priceService, IDProducerServiceAsync producerService, 
        IAuditManager auditManager): base(auditManager)
        {
            this.attachedFileService = attachedFileService;
            this.genreService = genreService;
            this.platformService = platformService;
            this.priceService = priceService;
            this.producerService = producerService;
        }

        protected override List<Game> GetEntities()
        {
            return entities;
        }

        protected override void Resolve(ref Game entity)
        {
            base.Resolve(ref entity);

            var pictureTask = entity.PictureId <= 0 ? Task.FromResult<AttachedFile>(null) : attachedFileService.GetAsync(entity.PictureId);
            var urlVideoTask = entity.VideoId <= 0 ? Task.FromResult<AttachedFile>(null) : attachedFileService.GetAsync(entity.VideoId);
            var genreTask = entity.GenreId<= 0 ? Task.FromResult<Genre>(null) : genreService.GetAsync(entity.GenreId);
            var platformTask = entity.PlatformId <= 0 ? Task.FromResult<Platform>(null) : platformService.GetAsync(entity.PlatformId);
            var priceTask = entity.PriceId <= 0 ? Task.FromResult<Price>(null) : priceService.GetAsync(entity.PriceId);
            var producerTask = entity.ProduserId<= 0 ? Task.FromResult<Producer>(null) : producerService.GetAsync(entity.ProduserId);

            entity.Pictute = pictureTask.Result;
            entity.URLVideo = urlVideoTask.Result;
            entity.Genre = genreTask.Result;
            entity.Platform = platformTask.Result;
            entity.Price = priceTask.Result;
            entity.Producer = producerTask.Result;
        }
    }
}
