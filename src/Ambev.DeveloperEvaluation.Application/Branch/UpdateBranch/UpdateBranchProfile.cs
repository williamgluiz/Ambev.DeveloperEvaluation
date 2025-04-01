using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Branch.UpdateBranch
{
    /// <summary>
    /// Profile for mapping between Branch entity and UpdateBranchResponse.
    /// </summary>
    public class UpdateBranchProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for UpdateBranch operation.
        /// </summary>
        public UpdateBranchProfile()
        {
            CreateMap<Domain.Entities.Branch, UpdateBranchResult>();
            CreateMap<UpdateBranchCommand, Domain.Entities.Branch>();
        }
    }
}
