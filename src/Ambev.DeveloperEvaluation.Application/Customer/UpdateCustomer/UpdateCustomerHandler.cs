using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customer.UpdateCustomer
{
    /// <summary>
    /// Handler for processing UpdateCustomerCommand requests.
    /// </summary>
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, UpdateCustomerResult>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of UpdateCustomerHandler.
        /// </summary>
        /// <param name="customerRepository">The customer repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public UpdateCustomerHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the UpdateCustomerCommand request.
        /// </summary>
        /// <param name="command">The UpdateCustomer command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response indicating the result of the update.</returns>
        public async Task<UpdateCustomerResult> Handle(UpdateCustomerCommand command, CancellationToken cancellationToken)
        {
            var validator = new UpdateCustomerCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var customer = await _customerRepository.GetByIdAsync(command.Id);

            if (customer == null)
                throw new KeyNotFoundException($"Customer with ID {command.Id} not found.");

            customer.UpdateCustomer(command.Name, command.ExternalId, command.Description);

            var updatedCustomer = await _customerRepository.UpdateAsync(customer);

            return _mapper.Map<UpdateCustomerResult>(updatedCustomer);
        }
    }
}
