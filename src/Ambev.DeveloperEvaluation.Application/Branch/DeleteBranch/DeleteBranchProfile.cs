using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Branch.DeleteBranch
{
    /// <summary>
    /// Profile for mapping between Branch entity and DeleteBranchResponse.
    /// </summary>
    public class DeleteBranchProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for DeleteBranch operation.
        /// </summary>
        public DeleteBranchProfile()
        {
            CreateMap<Domain.Entities.Branch, DeleteBranchResult>();
        }
    }
}
