using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.UpdateBranch
{
    /// <summary>
    /// Profile for mapping UpdateBranch feature requests to commands
    /// </summary>
    public class UpdateBranchProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for UpdateBranch feature
        /// </summary>
        public UpdateBranchProfile()
        {
            CreateMap<UpdateBranchRequest, Application.Branch.UpdateBranch.UpdateBranchCommand>();
            CreateMap<Application.Branch.UpdateBranch.UpdateBranchResult, UpdateBranchResponse>();
        }
    }
}
