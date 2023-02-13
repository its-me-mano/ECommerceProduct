using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ECommerceProduct.Entities.Model
{
    public class RefSet : BaseModel
    {

        ///<summary>
        /// Id of the Refset 
        ///</summary>
        [Required]
        [DataMember(Name = "key")]
        public string Key { get; set; }
        ///<summary>
        /// description of the refset key 
        ///</summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
