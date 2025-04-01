using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Branch.CreateBranch
{
    /// <summary>
    /// Profile for mapping between Branch entity and CreateBranchResponse.
    /// </summary>
    public class CreateBranchProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateBranch operation.
        /// </summary>
        public CreateBranchProfile()
        {
            CreateMap<CreateBranchCommand, Domain.Entities.Branch>();
            CreateMap<Domain.Entities.Branch, CreateBranchResult>();
        }
    }
}
