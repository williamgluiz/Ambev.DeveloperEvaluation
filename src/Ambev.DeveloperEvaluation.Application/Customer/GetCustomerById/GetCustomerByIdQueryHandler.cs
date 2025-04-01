using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.GetCustomerById
{
    /// <summary>
    /// Handler for processing GetCustomerByIdQuery requests.
    /// </summary>
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, GetCustomerByIdResult>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of GetCustomerByIdQueryHandler.
        /// </summary>
        /// <param name="customerRepository">The customer repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public GetCustomerByIdQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the GetCustomerByIdQuery request.
        /// </summary>
        /// <param name="query">The GetCustomerById query.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response containing customer details.</returns>
        public async Task<GetCustomerByIdResult> Handle(GetCustomerByIdQuery query, CancellationToken cancellationToken)
        {
            var validator = new GetCustomerByIdQueryValidator();
            var validationResult = await validator.ValidateAsync(query, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var customer = await _customerRepository.GetByIdAsync(query.Id);
            if (customer == null)
                throw new KeyNotFoundException($"Customer with ID {query.Id} not found.");

            return _mapper.Map<GetCustomerByIdResult>(customer);
        }
    }
}
