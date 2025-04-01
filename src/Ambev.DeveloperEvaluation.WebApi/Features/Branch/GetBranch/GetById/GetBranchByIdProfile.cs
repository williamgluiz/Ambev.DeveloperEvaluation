using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.GetBranch.GetById
{
    /// <summary>
    /// Profile for mapping GetBranchById feature requests and responses
    /// </summary>
    public class GetBranchByIdProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetBranchById feature
        /// </summary>
        public GetBranchByIdProfile()
        {
            CreateMap<GetBranchByIdRequest, Application.Branch.GetBranchById.GetBranchByIdQuery>();
            CreateMap<Application.Branch.GetBranchById.GetBranchByIdResult, GetBranchByIdResponse>();
        }
    }
}
