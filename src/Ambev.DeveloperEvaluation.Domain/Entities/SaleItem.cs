using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents an item in a sale.
    /// </summary>
    public class SaleItem : BaseEntity
    {
        /// <summary>
        /// Identifier of the sale this item belongs to.
        /// </summary>
        public Guid SaleId { get; private set; }

        /// <summary>
        /// Identifier of the product.
        /// </summary>
        public Guid ProductId { get; private set; }

        /// <summary>
        /// Quantity sold of the SaleItem.
        /// </summary>
        public int Quantity { get; private set; }

        /// <summary>
        /// Unit price of the SaleItem.
        /// </summary>
        public decimal UnitPrice { get; private set; }

        /// <summary>
        /// Discount applied to the item.
        /// </summary>
        public decimal Discount { get; private set; }

        /// <summary>
        /// Total amount of the item after applying the discount.
        /// </summary>
        public decimal TotalAmount { get; private set; }

        public SaleItem(Guid saleId, Guid productId, int quantity, decimal unitPrice)
        {
            SaleId = saleId;
            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            CalculateDiscount();
            CalculateTotal();
        }

        public SaleItem()
        {
            
        }

        /// Updates the sale item's details.
        /// </summary>
        /// <remarks>
        /// This method allows updating the sale item's attributes: SaleId, SaleItemId, Quantity, and UnitPrice.
        /// It is intended to be used for modifications to an existing sale item instance,
        /// maintaining encapsulation and consistency.
        /// </remarks>
        /// <param name="saleId">The identifier of the sale associated with the sale item.</param>
        /// <param name="quantity">The quantity of the SaleItem in the sale item.</param>
        /// <param name="unitPrice">The unit price of the SaleItem in the sale item.</param>
        public void UpdateSaleItem(Guid saleId, int quantity, decimal unitPrice)
        {
            SaleId = saleId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            CalculateDiscount();
            CalculateTotal();
        }

        private void CalculateDiscount()
        {
            if (Quantity >= 4 && Quantity < 10)
            {
                Discount = Quantity * UnitPrice * 0.10m;
            }
            else if (Quantity >= 10 && Quantity <= 20)
            {
                Discount = Quantity * UnitPrice * 0.20m;
            }
            else
            {
                Discount = 0;
            }

            if (Quantity > 20)
            {
                throw new InvalidOperationException("Maximum quantity per SaleItem exceeded.");
            }
        }

        private void CalculateTotal()
        {
            TotalAmount = (Quantity * UnitPrice) - Discount;
        }
    }
}
