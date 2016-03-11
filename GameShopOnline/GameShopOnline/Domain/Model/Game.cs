using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnline
{
    public class Game : BaseModel
    {
        private int producerId;
        private Producer produser;

        private int platformId;
        private Platform platform;

        private int genreId;
        private Genre genre;

        private int priceId;
        private Price price;

        private int pictureId;
        private AttachedFile picture;

        private int videoId;
        private AttachedFile urlvideo;

        public string Name { get; set; }

        public int ProduserId {
            get { return producerId; }
            set {
                if (value == producerId)
                { return; }
                producerId = value;
                produser = null;
            } }

        public Producer Producer { get
            { return produser; }
            set { produser = value;
                producerId = produser == null?default(int): produser.Id;
            } }

        public int PlatformId {
            get { return platformId; }
            set
            {
                if (value == platformId)
                { return; }
                platformId = value;
                platform = null;
            }
        }

        public Platform Platform {
            get
            { return platform; }
            set
            {
                platform = value;
                platformId = platform == null ? default(int) : platform.Id;
            }
        }

        public int GenreId {
            get { return genreId; }
            set
            {
                if (value == genreId)
                { return; }
                genreId = value;
                genre = null;
            }
        }

        public Genre Genre {
            get
            { return genre; }
            set
            {
                genre = value;
                genreId = genre == null ? default(int) : genre.Id;
            }
        }

        public int PriceId
        {
            get { return priceId; }
            set
            {
                if (value == priceId)
                { return; }
                priceId = value;
                price = null;
            }

        }

        public Price Price {
            get
            { return price; }
            set
            {
                price = value;
                priceId = price == null ? default(int) : price.Id;
            }
        }

        public int PictureId {
            get { return pictureId; }
            set
            {
                if (value == pictureId)
                { return; }
                pictureId = value;
                picture = null;
            }
        }

        public AttachedFile Pictute {
            get
            { return picture; }
            set
            {
                picture = value;
                pictureId = picture == null ? default(int) : picture.Id;
            }
        }

        public int VideoId {
            get { return videoId; }
            set
            {
                if (value == videoId)
                { return; }
                videoId = value;
                urlvideo = null;
            }
        }

        public AttachedFile URLVideo {
            get
            { return urlvideo; }
            set
            {
                urlvideo = value;
                videoId = price == null ? default(int) : urlvideo.Id;
            }
        }



        public List<Comment> Comments { get; set; }

        //public override object Clone()
        //{
        //    return new Game
        //    {
        //        Id = this.Id,
        //        Name = this.Name,
        //        Producer = (Producer)this.Producer.Clone(),
        //        Platform = (Platform)this.Platform.Clone(),
        //        Genre = (Genre)this.Genre.Clone(),
        //        Price = (Price)this.Price.Clone(),
        //        Pictute = (AttachedFile)this.Pictute.Clone(),
        //        URLVideo=(AttachedFile)this.URLVideo.Clone()
        //    };
        //}

        //public override void SetNullReferences()
        //{
        //    base.SetNullReferences();
        //    this.produser = null;
        //    this.platform = null;
        //    this.genre = null;
        //    this.price = null;
        //    this.picture = null;
        //    this.urlvideo = null;
        //}

        //public override void Map(object objTO)
        //{
        //    if (!(objTO is Game))
        //    {
        //        return;
        //    }
        //    var typedObj = (Game)objTO;
        //    typedObj.Name = this.Name;
        //    typedObj.ProduserId = this.producerId;
        //    typedObj.Producer = (Producer)this.Producer.Clone();
        //    typedObj.PlatformId = this.PlatformId;
        //    typedObj.Platform = (Platform) this.Platform.Clone();
        //    typedObj.PriceId = this.PriceId;
        //    typedObj.Price = (Price) this.Price.Clone();
        //    typedObj.GenreId = this.GenreId;
        //    typedObj.Genre = (Genre) this.Genre.Clone();
        //    typedObj.VideoId = this.VideoId;
        //    typedObj.URLVideo = (AttachedFile) this.URLVideo.Clone();
        //    typedObj.PictureId = this.PictureId;
        //    typedObj.Pictute = (AttachedFile) this.Pictute.Clone();
        //}
    }
}
