using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents a branch where sales are made.
    /// </summary>
    public class Branch : BaseEntity
    {
        /// <summary>
        /// Name of the branch.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// External identity for referencing in other domains.
        /// </summary>
        public string ExternalId { get; private set; }

        /// <summary>
        /// Denormalized description of the branch.
        /// </summary>
        public string Description { get; private set; }

        public Branch(string name, string externalId, string description)
        {
            Name = name;
            ExternalId = externalId;
            Description = description;
        }

        /// <summary>
        /// Updates the branch's details.
        /// </summary>
        /// <remarks>
        /// This method allows updating the branch's attributes: Name, ExternalId, and Description.
        /// It is intended to be used for modifications to an existing branch instance,
        /// maintaining encapsulation and consistency.
        /// </remarks>
        /// <param name="name">The new name for the branch.</param>
        /// <param name="externalId">The updated external identifier for the branch.</param>
        /// <param name="description">The modified description of the branch.</param>
        public void UpdateBranch(string name, string externalId, string description)
        {
            Name = name;
            ExternalId = externalId;
            Description = description;
        }
    }
}
