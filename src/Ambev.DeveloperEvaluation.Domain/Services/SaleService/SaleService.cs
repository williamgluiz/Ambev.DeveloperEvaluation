using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Events;
using Ambev.DeveloperEvaluation.Domain.Events.SaleEvents;

namespace Ambev.DeveloperEvaluation.Domain.Services.SaleService
{
    //public class SaleService : ISaleService
    //{
    //    private readonly IEventPublisher _eventPublisher;

    //    public SaleService(IEventPublisher eventPublisher)
    //    {
    //        _eventPublisher = eventPublisher;
    //    }

    //    public async Task CreateSaleAsync(Sale sale)
    //    {
    //        if (sale == null)
    //            throw new ArgumentNullException(nameof(sale), "Sale cannot be null.");

    //        if (string.IsNullOrWhiteSpace(sale.SaleNumber))
    //            throw new ArgumentException("SaleNumber cannot be null or empty.", nameof(sale.SaleNumber));

    //        var saleCreatedEvent = new SaleCreatedEvent
    //        {
    //            SaleId = sale.Id,
    //            SaleNumber = sale.SaleNumber,
    //            SaleDate = sale.SaleDate,
    //            CustomerId = sale.CustomerId,
    //            BranchId = sale.BranchId,
    //            TotalAmount = sale.TotalAmount
    //        };

    //        try
    //        {
    //            await _eventPublisher.PublishAsync(saleCreatedEvent);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"Failed to publish SaleCreatedEvent: {ex.Message}");
    //            throw;
    //        }
    //    }

    //    public async Task CancelSaleAsync(Sale sale)
    //    {
    //        if (sale == null)
    //            throw new ArgumentNullException(nameof(sale), "Sale cannot be null.");

    //        if (sale.IsCancelled)
    //            throw new InvalidOperationException("Sale is already cancelled.");

    //        sale.Cancel();

    //        var saleCancelledEvent = new SaleCancelledEvent
    //        {
    //            SaleId = sale.Id,
    //            SaleNumber = sale.SaleNumber,
    //            CancelledDate = DateTime.UtcNow // Garantimos consistência com UtcNow
    //        };

    //        try
    //        {
    //            await _eventPublisher.PublishAsync(saleCancelledEvent);
    //        }
    //        catch (Exception ex)
    //        {
    //            // Log de erro
    //            Console.WriteLine($"Failed to publish SaleCancelledEvent: {ex.Message}");
    //            throw;
    //        }
    //    }

    //    public async Task ModifySaleAsync(Sale sale, decimal updatedTotalAmount)
    //    {
    //        if (sale == null)
    //            throw new ArgumentNullException(nameof(sale), "Sale cannot be null.");

    //        if (updatedTotalAmount <= 0)
    //            throw new ArgumentException("Updated total amount must be greater than zero.", nameof(updatedTotalAmount));

    //        sale.UpdateSale(sale.CustomerId, sale.BranchId, sale.Items, updatedTotalAmount, sale.IsCancelled);

    //        var saleModifiedEvent = new SaleModifiedEvent
    //        {
    //            SaleId = sale.Id,
    //            SaleNumber = sale.SaleNumber,
    //            UpdatedTotalAmount = updatedTotalAmount,
    //            ModifiedDate = DateTime.UtcNow 
    //        };

    //        try
    //        {
    //            await _eventPublisher.PublishAsync(saleModifiedEvent);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"Failed to publish SaleModifiedEvent: {ex.Message}");
    //            throw;
    //        }
    //    }
    //}
}
