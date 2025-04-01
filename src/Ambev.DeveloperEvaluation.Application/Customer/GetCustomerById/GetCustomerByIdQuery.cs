using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customer.GetCustomerById
{
    /// <summary>
    /// Command for retrieving a customer by their unique identifier.
    /// </summary>
    /// <remarks>
    /// This command captures the data required to fetch a customer, 
    /// specifically the unique identifier of the customer to be retrieved. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="GetCustomerByIdResponse"/>.
    /// </remarks>
    public class GetCustomerByIdQuery : IRequest<GetCustomerByIdResult>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the customer to be retrieved.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Validates the query using GetCustomerByIdQueryValidator.
        /// </summary>
        public ValidationResultDetail Validate()
        {
            var validator = new GetCustomerByIdQueryValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
