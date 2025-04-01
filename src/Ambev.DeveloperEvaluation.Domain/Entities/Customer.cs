using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents a customer in the system.
    /// </summary>
    public class Customer : BaseEntity
    {
        /// <summary>
        /// Name of the customer.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// External identity for referencing in other domains.
        /// </summary>
        public string ExternalId { get; private set; }

        /// <summary>
        /// Denormalized description of the customer.
        /// </summary>
        public string Description { get; private set; }

        public Customer(string name, string externalId, string description)
        {
            Name = name;
            ExternalId = externalId;
            Description = description;
        }

        /// <summary>
        /// Updates the customer's details.
        /// </summary>
        /// <remarks>
        /// This method allows updating the customer's attributes: Name, ExternalId, and Description.
        /// It is intended to be used for modifications to an existing customer instance,
        /// maintaining encapsulation and consistency.
        /// </remarks>
        /// <param name="name">The new name for the customer.</param>
        /// <param name="externalId">The updated external identifier for the customer.</param>
        /// <param name="description">The modified description of the customer.</param>
        public void UpdateCustomer(string name, string externalId, string description)
        {
            Name = name;
            ExternalId = externalId;
            Description = description;
        }
    }
}
