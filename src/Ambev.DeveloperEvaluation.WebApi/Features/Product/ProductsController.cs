using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Product.CreateProduct;
using Ambev.DeveloperEvaluation.WebApi.Features.Product.DeleteProduct;
using Ambev.DeveloperEvaluation.WebApi.Features.Product.GetProduct.GetAll;
using Ambev.DeveloperEvaluation.WebApi.Features.Product.GetProduct.GetById;
using Ambev.DeveloperEvaluation.WebApi.Features.Product.UpdateProduct;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product
{
    /// <summary>
    /// Controller responsible for handling CRUD operations related to Products.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsController"/> class.
        /// </summary>
        /// <param name="mediator">Instance of Mediator for handling commands and queries.</param>
        /// <param name="mapper">Instance of AutoMapper for object mapping.</param>
        public ProductsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Creates a new Product.
        /// </summary>
        /// <param name="request">The request object containing Product details.</param>
        /// <param name="cancellationToken">Cancellation token for asynchronous operation.</param>
        /// <returns>Details of the newly created Product.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(ApiResponseWithData<CreateProductResponse>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request, CancellationToken cancellationToken)
        {
            var validator = new CreateProductRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.Product.CreateProduct.CreateProductCommand>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Created(string.Empty, new ApiResponseWithData<CreateProductResponse>
            {
                Success = true,
                Message = "Product created successfully",
                Data = _mapper.Map<CreateProductResponse>(result)
            });
        }

        /// <summary>
        /// Retrieves a Product by its ID.
        /// </summary>
        /// <param name="id">The unique identifier of the Product.</param>
        /// <param name="cancellationToken">Cancellation token for asynchronous operation.</param>
        /// <returns>The Product details if found.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ApiResponseWithData<GetProductByIdResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProductById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new GetProductByIdRequest { Id = id };
            var validator = new GetProductByIdRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.Product.GetProductById.GetProductByIdQuery>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponseWithData<GetProductByIdResponse>
            {
                Success = true,
                Message = "Product retrieved successfully",
                Data = _mapper.Map<GetProductByIdResponse>(result)
            });
        }

        /// <summary>
        /// Retrieves all Products with optional filters.
        /// </summary>
        /// <param name="request">Request object containing filtering and pagination options.</param>
        /// <param name="cancellationToken">Cancellation token for asynchronous operation.</param>
        /// <returns>A list of Products.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(ApiResponseWithData<GetAllProductsResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllProducts([FromQuery] GetAllProductsRequest request, CancellationToken cancellationToken)
        {
            var validator = new GetAllProductsRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<GetAllProductsQuery>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponseWithData<GetAllProductsResponse>
            {
                Success = true,
                Message = "Products retrieved successfully",
                Data = _mapper.Map<GetAllProductsResponse>(result)
            });
        }

        /// <summary>
        /// Updates an existing Product.
        /// </summary>
        /// <param name="request">The request object containing updated Product details.</param>
        /// <param name="cancellationToken">Cancellation token for asynchronous operation.</param>
        /// <returns>The updated Product details.</returns>
        [HttpPut]
        [ProducesResponseType(typeof(ApiResponseWithData<UpdateProductResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductRequest request, CancellationToken cancellationToken)
        {
            var validator = new UpdateProductRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.Product.UpdateProduct.UpdateProductCommand>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponseWithData<UpdateProductResponse>
            {
                Success = true,
                Message = "Product updated successfully",
                Data = _mapper.Map<UpdateProductResponse>(result)
            });
        }

        /// <summary>
        /// Deletes a Product by its ID.
        /// </summary>
        /// <param name="id">The unique identifier of the Product to delete.</param>
        /// <param name="cancellationToken">Cancellation token for asynchronous operation.</param>
        /// <returns>A success response if deletion was completed.</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProduct([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new DeleteProductRequest { Id = id };
            var validator = new DeleteProductRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.Product.DeleteProduct.DeleteProductCommand>(request.Id);
            await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Product deleted successfully"
            });
        }
    }
}