using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branch.UpdateBranch
{
    /// <summary>
    /// Handler for processing UpdateBranchCommand requests.
    /// </summary>
    public class UpdateBranchHandler : IRequestHandler<UpdateBranchCommand, UpdateBranchResult>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of UpdateBranchHandler.
        /// </summary>
        /// <param name="branchRepository">The branch repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public UpdateBranchHandler(IBranchRepository branchRepository, IMapper mapper)
        {
            _branchRepository = branchRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the UpdateBranchCommand request.
        /// </summary>
        /// <param name="command">The UpdateBranch command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response indicating the result of the update.</returns>
        public async Task<UpdateBranchResult> Handle(UpdateBranchCommand command, CancellationToken cancellationToken)
        {
            var validator = new UpdateBranchCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var branch = await _branchRepository.GetByIdAsync(command.Id);
            if (branch == null)
                throw new KeyNotFoundException($"Branch with ID {command.Id} not found.");

            branch.UpdateBranch(command.Name, command.ExternalId, command.Description);

            var branchUpdated = await _branchRepository.UpdateAsync(branch);

            return _mapper.Map<UpdateBranchResult>(branchUpdated);
        }
    }
}
