using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Branch.GetBranches
{
    /// <summary>
    /// Profile for mapping between Branch entity and GetAllBranchesResponse.
    /// </summary>
    public class GetAllBranchesProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetAllBranches operation.
        /// </summary>
        public GetAllBranchesProfile()
        {
            CreateMap<Domain.Entities.Branch, BranchResult>();
        }
    }
}
