using Ambev.DeveloperEvaluation.Domain.Repositories;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Branch.DeleteBranch
{
    /// <summary>
    /// Handler for processing DeleteBranchCommand requests.
    /// </summary>
    public class DeleteBranchHandler : IRequestHandler<DeleteBranchCommand, DeleteBranchResult>
    {
        private readonly IBranchRepository _branchRepository;

        /// <summary>
        /// Initializes a new instance of DeleteBranchHandler.
        /// </summary>
        /// <param name="branchRepository">The branch repository.</param>
        public DeleteBranchHandler(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        /// <summary>
        /// Handles the DeleteBranchCommand request.
        /// </summary>
        /// <param name="command">The DeleteBranch command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A response indicating the result of the deletion.</returns>
        public async Task<DeleteBranchResult> Handle(DeleteBranchCommand command, CancellationToken cancellationToken)
        {
            var validator = new DeleteBranchCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var branch = await _branchRepository.GetByIdAsync(command.Id);
            if (branch == null)
                throw new KeyNotFoundException($"Branch with ID {command.Id} not found.");

            await _branchRepository.DeleteAsync(command.Id);

            return new DeleteBranchResult
            {
                Success = true,
                Message = "Branch deleted successfully."
            };
        }
    }
}
