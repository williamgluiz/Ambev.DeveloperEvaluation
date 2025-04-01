using Ambev.DeveloperEvaluation.Domain.Repositories;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customer.DeleteCustomer
{
    /// <summary>
    /// Handler for processing DeleteCustomerCommand requests.
    /// </summary>
    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, DeleteCustomerResult>
    {
        private readonly ICustomerRepository _customerRepository;

        /// <summary>
        /// Initializes a new instance of DeleteCustomerHandler.
        /// </summary>
        /// <param name="customerRepository">The customer repository.</param>
        public DeleteCustomerHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        /// <summary>
        /// Handles the DeleteCustomerCommand request.
        /// </summary>
        /// <param name="command">The DeleteCustomer command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response indicating the result of the deletion.</returns>
        public async Task<DeleteCustomerResult> Handle(DeleteCustomerCommand command, CancellationToken cancellationToken)
        {
            var validator = new DeleteCustomerCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var customer = await _customerRepository.GetByIdAsync(command.Id);
            if (customer == null)
                throw new KeyNotFoundException($"Customer with ID {command.Id} not found.");

            await _customerRepository.DeleteAsync(command.Id);

            return new DeleteCustomerResult 
            {
                Success = true,
                Message = "Customer deleted successfully."
            };
        }
    }
}
