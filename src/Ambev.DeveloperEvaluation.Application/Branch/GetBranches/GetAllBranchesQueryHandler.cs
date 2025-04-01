using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Branch.GetBranches
{
    /// <summary>
    /// Handler for processing GetAllBranchesCommand requests.
    /// </summary>
    public class GetAllBranchesQueryHandler : IRequestHandler<GetAllBranchesQuery, GetAllBranchesResult>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of GetAllBranchesHandler.
        /// </summary>
        /// <param name="branchRepository">The branch repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public GetAllBranchesQueryHandler(IBranchRepository branchRepository, IMapper mapper)
        {
            _branchRepository = branchRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the GetAllBranchesCommand request.
        /// </summary>
        /// <param name="query">The GetAllBranches command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response containing all branch details.</returns>
        public async Task<GetAllBranchesResult> Handle(GetAllBranchesQuery query, CancellationToken cancellationToken)
        {
            var validator = new GetAllBranchesQueryValidator();
            var validationResult = await validator.ValidateAsync(query, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var branches = await _branchRepository.GetAllAsync();

            return new GetAllBranchesResult
            {
                Branches = _mapper.Map<IEnumerable<BranchResult>>(branches),
                TotalCount = branches?.Count() > 0 ? branches.Count() : 0
            };
        }
    }
}
