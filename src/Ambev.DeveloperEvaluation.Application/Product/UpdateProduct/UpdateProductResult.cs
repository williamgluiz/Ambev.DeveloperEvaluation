namespace Ambev.DeveloperEvaluation.Application.Product.UpdateProduct
{
    /// <summary>
    /// Response returned after successfully updating a Product.
    /// </summary>
    /// <remarks>
    /// This response indicates whether the update was successful and provides
    /// additional details.
    /// </remarks>
    public class UpdateProductResult
    {
        /// <summary>
        /// Indicates if the update was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Provides additional details about the update result.
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// The unique identifier of the created Product
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the Product
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// External identity for referencing in other domains
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// Description of the Product
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Price of the Product
        /// </summary>
        public decimal Price { get; set; }
    }
}
