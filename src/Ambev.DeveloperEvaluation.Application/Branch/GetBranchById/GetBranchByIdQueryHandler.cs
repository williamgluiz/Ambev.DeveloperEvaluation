using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Branch.GetBranchById
{
    /// <summary>
    /// Handler for processing GetBranchByIdQuery requests.
    /// </summary>
    public class GetBranchByIdQueryHandler : IRequestHandler<GetBranchByIdQuery, GetBranchByIdResult>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of GetBranchByIdQueryHandler.
        /// </summary>
        /// <param name="branchRepository">The branch repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public GetBranchByIdQueryHandler(IBranchRepository branchRepository, IMapper mapper)
        {
            _branchRepository = branchRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the GetBranchByIdCommand request.
        /// </summary>
        /// <param name="query">The GetBranchById query.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response containing branch details.</returns>
        public async Task<GetBranchByIdResult> Handle(GetBranchByIdQuery query, CancellationToken cancellationToken)
        {
            var validator = new GetBranchByIdQueryValidator();
            var validationResult = await validator.ValidateAsync(query, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var branch = await _branchRepository.GetByIdAsync(query.Id);
            if (branch == null)
                throw new KeyNotFoundException($"Branch with ID {query.Id} not found.");

            return _mapper.Map<GetBranchByIdResult>(branch);
        }
    }
}
