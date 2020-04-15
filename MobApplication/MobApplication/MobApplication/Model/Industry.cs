using System;
using System.Collections.Generic;
using System.Text;

namespace MobApplication.Model
{
    class Industry
    {
        public string ImageUrl { get; set; }
        public string Detail { get; set; }
        public List<Industry> GetIndustryList()
        {
            return new List<Industry>()
            {
                new Industry{ ImageUrl="https://successive.tech/wp-content/uploads/2020/01/media_Thumbnails.png",Detail="The effective use of data based tools can power up marketing teams and amplify brand presence amongst your audience. "},
     new Industry { ImageUrl = "https://successive.tech/wp-content/uploads/2020/01/ecommerce_Thumbnails.png", Detail="Seamless omnichannel presence for your retail brand to augment customer loyalty and boost e-commerce toplines." },
     new Industry { ImageUrl = "https://successive.tech/wp-content/uploads/2020/01/Legal_Thumbnails.png", Detail="We enable an unbeatable combination of technology and legal acumen." },
     new Industry { ImageUrl = "https://successive.tech/wp-content/uploads/2020/01/agri_Thumbnails.png", Detail="We specialize in innovative tech-oriented business models that will drive massive ROI in the agriculture space." },
     new Industry { ImageUrl = "https://successive.tech/wp-content/uploads/2020/01/Fintech_Thumbnails.png", Detail="" },
     new Industry { ImageUrl = "https://successive.tech/wp-content/uploads/2020/01/Logistics_Thumbnails.png", Detail="" }
            };
        }
    }
}
