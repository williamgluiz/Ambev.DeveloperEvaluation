
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.GetCustomers
{
    /// <summary>
    /// Handler for processing GetAllCustomersQuery requests.
    /// </summary>
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, GetAllCustomersResult>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of GetAllCustomersQueryHandler.
        /// </summary>
        /// <param name="customerRepository">The customer repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public GetAllCustomersQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the GetAllCustomersQuery request.
        /// </summary>
        /// <param name="query">The GetAllCustomers command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response containing all customer details.</returns>
        public async Task<GetAllCustomersResult> Handle(GetAllCustomersQuery query, CancellationToken cancellationToken)
        {
            var validator = new GetAllCustomersQueryValidator();
            var validationResult = await validator.ValidateAsync(query, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var customers = await _customerRepository.GetAllAsync();
            return new GetAllCustomersResult
            {
                Customers = _mapper.Map<IEnumerable<CustomerResult>>(customers),
                TotalCount = customers?.Count() > 0 ? customers.Count() : 0
            };
        }
    }
}
