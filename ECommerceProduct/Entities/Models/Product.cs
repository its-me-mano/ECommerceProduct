using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ECommerceProduct.Entities.Model
{
    public class Product : BaseModel
    {
        /// <summary>
        /// Product Name
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
        /// <summary>
        /// Product Quantity
        /// </summary>
        [DataMember(Name = "product_count")]
        public int ProductCount { get; set; }
        /// <summary>
        /// Price of the  product
        /// </summary>
        [DataMember(Name = "price")]
        public float Price { get; set; }
        /// <summary>
        /// Visibility of the product
        /// </summary>
        [DataMember(Name = "visibility")]
        public Guid Visibility { get; set; }
        /// <summary>
        /// Product Image
        /// </summary>
        [DataMember(Name = "image_asset")]
        public Guid ImageAsset { get; set; }
        /// <summary>
        /// Category of the product
        /// </summary>
        [DataMember(Name = "category")]
        public Guid Category { get; set; }
    }
}
