using Ambev.DeveloperEvaluation.Application.SaleItem.GetSaleItems;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.CreateSaleItem;
using Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.DeleteSaleItem;
using Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.GetSaleItem.GetAll;
using Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.GetSaleItem.GetById;
using Ambev.DeveloperEvaluation.WebApi.Features.SaleItem.Update;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItem
{
    /// <summary>
    /// Controller responsible for managing CRUD operations for sale items.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SaleItemsController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="SaleItemsController"/> class.
        /// </summary>
        /// <param name="mediator">Instance of Mediator for handling commands and queries.</param>
        /// <param name="mapper">Instance of AutoMapper for object mapping.</param>
        public SaleItemsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Creates a new sale item record.
        /// </summary>
        /// <param name="request">Object containing the details of the sale item.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>The details of the newly created sale item.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(ApiResponseWithData<CreateSaleItemResponse>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateSaleItem([FromBody] CreateSaleItemRequest request, CancellationToken cancellationToken)
        {
            var validator = new CreateSaleItemRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.SaleItem.CreateSaleItem.CreateSaleItemCommand>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Created(string.Empty, new ApiResponseWithData<CreateSaleItemResponse>
            {
                Success = true,
                Message = "Sale item created successfully",
                Data = _mapper.Map<CreateSaleItemResponse>(result)
            });
        }

        /// <summary>
        /// Retrieves a sale item by its ID.
        /// </summary>
        /// <param name="id">Unique identifier of the sale item to retrieve.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>The details of the sale item if found.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ApiResponseWithData<GetSaleItemByIdResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetSaleItemById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new GetSaleItemByIdRequest { Id = id };
            var validator = new GetSaleItemByIdRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.SaleItem.GetSaleItemById.GetSaleItemByIdCommand>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponseWithData<GetSaleItemByIdResponse>
            {
                Success = true,
                Message = "Sale item retrieved successfully",
                Data = _mapper.Map<GetSaleItemByIdResponse>(result)
            });
        }

        /// <summary>
        /// Retrieves all sale items with optional filters.
        /// </summary>
        /// <param name="request">Object containing filtering and pagination options.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>A list of sale items matching the criteria.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(ApiResponseWithData<GetAllSaleItemsResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllSaleItems([FromQuery] GetAllSaleItemsRequest request, CancellationToken cancellationToken)
        {
            var validator = new GetAllSaleItemsRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<GetAllSaleItemsQuery>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponseWithData<GetAllSaleItemsResponse>
            {
                Success = true,
                Message = "Sale items retrieved successfully",
                Data = _mapper.Map<GetAllSaleItemsResponse>(result)
            });
        }

        /// <summary>
        /// Updates an existing sale item record.
        /// </summary>
        /// <param name="request">Object containing the updated details of the sale item.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>The details of the updated sale item.</returns>
        [HttpPut]
        [ProducesResponseType(typeof(ApiResponseWithData<UpdateSaleItemResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateSaleItem([FromBody] UpdateSaleItemRequest request, CancellationToken cancellationToken)
        {
            var validator = new UpdateSaleItemRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.SaleItem.UpdateSaleItem.UpdateSaleItemCommand>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponseWithData<UpdateSaleItemResponse>
            {
                Success = true,
                Message = "Sale item updated successfully",
                Data = _mapper.Map<UpdateSaleItemResponse>(result)
            });
        }

        /// <summary>
        /// Deletes a sale item by its ID.
        /// </summary>
        /// <param name="id">Unique identifier of the sale item to delete.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>A success response if deletion was completed.</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteSaleItem([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new DeleteSaleItemRequest { Id = id };
            var validator = new DeleteSaleItemRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.SaleItem.DeleteSaleItem.DeleteSaleItemCommand>(request.Id);
            await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Sale item deleted successfully"
            });
        }
    }
}