using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace ECommerceProduct.Entities.Model
{
    public class SetRefTerm : BaseModel
    {

        ///<summary>
        /// refset Id 
        ///</summary>
        [DataMember(Name = "refSet_id")]
        [ForeignKey("RefSetid")]
        public Guid RefSetid { get; set; }

        ///<summary>
        /// refterm id 
        ///</summary>
        [ForeignKey("ReftermId")]
        [DataMember(Name = "refterm_id")]
        public Guid ReftermId { get; set; }
    }
}
