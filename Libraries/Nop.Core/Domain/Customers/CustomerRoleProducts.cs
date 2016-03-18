using System.Collections.Generic;
using Nop.Core.Domain.Security;
using MongoDB.Bson.Serialization.Attributes;

namespace Nop.Core.Domain.Customers
{
    /// <summary>
    /// Represents a customer role
    /// </summary>
    [BsonIgnoreExtraElements]
    public partial class CustomerRoleProduct : BaseEntity
    {

        /// <summary>
        /// Gets or sets the customer role id
        /// </summary>
        public int CustomerRoleId { get; set; }

        /// <summary>
        /// Gets or sets the product Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

    }

}