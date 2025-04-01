using Ambev.DeveloperEvaluation.Application.Branch.GetBranches;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Branch.CreateBranch;
using Ambev.DeveloperEvaluation.WebApi.Features.Branch.DeleteBranch;
using Ambev.DeveloperEvaluation.WebApi.Features.Branch.GetBranch.GetAll;
using Ambev.DeveloperEvaluation.WebApi.Features.Branch.GetBranch.GetById;
using Ambev.DeveloperEvaluation.WebApi.Features.Branch.UpdateBranch;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch
{
    /// <summary>
    /// Controller for managing branch operations
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BranchesController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of BranchController
        /// </summary>
        /// <param name="mediator">The mediator instance</param>
        /// <param name="mapper">The AutoMapper instance</param>
        public BranchesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Creates a new branch
        /// </summary>
        /// <param name="request">The branch creation request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created branch details</returns>
        [HttpPost]
        [ProducesResponseType(typeof(ApiResponseWithData<CreateBranchResponse>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateBranch([FromBody] CreateBranchRequest request, CancellationToken cancellationToken)
        {
            var validator = new CreateBranchRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.Branch.CreateBranch.CreateBranchCommand>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Created(string.Empty, new ApiResponseWithData<CreateBranchResponse>
            {
                Success = true,
                Message = "Branch created successfully",
                Data = _mapper.Map<CreateBranchResponse>(result)
            });
        }

        /// <summary>
        /// Retrieves a branch by its ID
        /// </summary>
        /// <param name="id">The unique identifier of the branch</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The branch details if found</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ApiResponseWithData<GetBranchByIdResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetBranchById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new GetBranchByIdRequest { Id = id };
            var validator = new GetBranchByIdRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.Branch.GetBranchById.GetBranchByIdQuery>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponseWithData<GetBranchByIdResponse>
            {
                Success = true,
                Message = "Branch retrieved successfully",
                Data = _mapper.Map<GetBranchByIdResponse>(result)
            });
        }

        /// <summary>
        /// Retrieves all branches
        /// </summary>
        /// <param name="request">The request model for filtering and pagination</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>A list of branches</returns>
        [HttpGet]
        [ProducesResponseType(typeof(ApiResponseWithData<GetAllBranchesResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllBranches([FromQuery] GetAllBranchesRequest request, CancellationToken cancellationToken)
        {
            var validator = new GetAllBranchesRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<GetAllBranchesQuery>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponseWithData<GetAllBranchesResponse>
            {
                Success = true,
                Message = "Branches retrieved successfully",
                Data = _mapper.Map<GetAllBranchesResponse>(result)
            });
        }

        /// <summary>
        /// Updates an existing branch
        /// </summary>
        /// <param name="request">The branch update request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The updated branch details</returns>
        [HttpPut]
        [ProducesResponseType(typeof(ApiResponseWithData<UpdateBranchResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateBranch([FromBody] UpdateBranchRequest request, CancellationToken cancellationToken)
        {
            var validator = new UpdateBranchRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.Branch.UpdateBranch.UpdateBranchCommand>(request);
            var result = await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponseWithData<UpdateBranchResponse>
            {
                Success = true,
                Message = "Branch updated successfully",
                Data = _mapper.Map<UpdateBranchResponse>(result)
            });
        }

        /// <summary>
        /// Deletes a branch by its ID
        /// </summary>
        /// <param name="id">The unique identifier of the branch to delete</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Success response if the branch was deleted</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteBranch([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new DeleteBranchRequest { Id = id };
            var validator = new DeleteBranchRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<Application.Branch.DeleteBranch.DeleteBranchCommand>(request.Id);
            await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Branch deleted successfully"
            });
        }
    }
}
