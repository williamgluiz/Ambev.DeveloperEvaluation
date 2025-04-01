using Ambev.DeveloperEvaluation.Application.Branch.GetBranches;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.GetBranch.GetAll
{
    /// <summary>
    /// Profile for mapping GetAllBranches feature requests and responses
    /// </summary>
    public class GetAllBranchesProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetAllBranches feature
        /// </summary>
        public GetAllBranchesProfile()
        {
            CreateMap<GetAllBranchesRequest, GetAllBranchesQuery>();
            CreateMap<GetAllBranchesResult, GetAllBranchesResponse>();

            CreateMap<BranchResult, BranchSummaryResponseModel>();
        }
    }
}
