using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.CreateBranch
{
    /// <summary>
    /// Profile for mapping between Application and API CreateBranch requests and responses
    /// </summary>
    public class CreateBranchProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateBranch feature
        /// </summary>
        public CreateBranchProfile()
        {
            CreateMap<CreateBranchRequest, Application.Branch.CreateBranch.CreateBranchCommand>();
            CreateMap<Application.Branch.CreateBranch.CreateBranchResult, CreateBranchResponse>();
        }
    }
}
