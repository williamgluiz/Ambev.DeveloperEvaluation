using Ambev.DeveloperEvaluation.Application.Customer.GetCustomers;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Customer.CreateCustomer;
using Ambev.DeveloperEvaluation.WebApi.Features.Customer.DeleteCustomer;
using Ambev.DeveloperEvaluation.WebApi.Features.Customer.GetCustomer.GetAll;
using Ambev.DeveloperEvaluation.WebApi.Features.Customer.GetCustomer.GetById;
using Ambev.DeveloperEvaluation.WebApi.Features.Customer.UpdateCustomer;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer
{
    /// <summary>
    /// Controller responsible for managing customer-related operations.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersController"/> class.
        /// </summary>
        /// <param name="mediator">The instance of Mediator used for handling commands and queries.</param>
        /// <param name="mapper">The instance of AutoMapper used for object mappings.</param>
        public CustomersController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Creates a new customer record.
        /// </summary>
        /// <param name="request">The object containing customer details.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>The details of the newly created customer.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(ApiResponseWithData<CreateCustomerResponse>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var validator = new CreateCustomerRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.Customer.CreateCustomer.CreateCustomerCommand>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Created(string.Empty, new ApiResponseWithData<CreateCustomerResponse>
            {
                Success = true,
                Message = "Customer created successfully",
                Data = _mapper.Map<CreateCustomerResponse>(result)
            });
        }

        /// <summary>
        /// Retrieves a customer by their unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the customer to retrieve.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>The details of the customer if found.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ApiResponseWithData<GetCustomerByIdResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetCustomerById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new GetCustomerByIdRequest { Id = id };
            var validator = new GetCustomerByIdRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.Customer.GetCustomerById.GetCustomerByIdQuery>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponseWithData<GetCustomerByIdResponse>
            {
                Success = true,
                Message = "Customer retrieved successfully",
                Data = _mapper.Map<GetCustomerByIdResponse>(result)
            });
        }

        /// <summary>
        /// Retrieves all customers with optional filters.
        /// </summary>
        /// <param name="request">The object containing filtering and pagination options.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A list of customers that match the specified criteria.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(ApiResponseWithData<GetAllCustomersResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllCustomers([FromQuery] GetAllCustomersRequest request, CancellationToken cancellationToken)
        {
            var validator = new GetAllCustomersRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<GetAllCustomersQuery>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponseWithData<GetAllCustomersResponse>
            {
                Success = true,
                Message = "Customers retrieved successfully",
                Data = _mapper.Map<GetAllCustomersResponse>(result)
            });
        }

        /// <summary>
        /// Updates an existing customer record.
        /// </summary>
        /// <param name="request">The object containing updated customer details.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>The details of the updated customer.</returns>
        [HttpPut]
        [ProducesResponseType(typeof(ApiResponseWithData<UpdateCustomerResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateCustomer([FromBody] UpdateCustomerRequest request, CancellationToken cancellationToken)
        {
            var validator = new UpdateCustomerRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.Customer.UpdateCustomer.UpdateCustomerCommand>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponseWithData<UpdateCustomerResponse>
            {
                Success = true,
                Message = "Customer updated successfully",
                Data = _mapper.Map<UpdateCustomerResponse>(result)
            });
        }

        /// <summary>
        /// Deletes a customer by their unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the customer to delete.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A success response if the deletion was completed.</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCustomer([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new DeleteCustomerRequest { Id = id };
            var validator = new DeleteCustomerRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.Customer.DeleteCustomer.DeleteCustomerCommand>(request.Id);
            await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Customer deleted successfully"
            });
        }
    }
}