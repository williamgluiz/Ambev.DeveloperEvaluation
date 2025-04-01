using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branch.DeleteBranch
{
    /// <summary>
    /// Profile for mapping DeleteBranch feature requests to commands
    /// </summary>
    public class DeleteBranchProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for DeleteBranch feature
        /// </summary>
        public DeleteBranchProfile()
        {
            CreateMap<Guid, Application.Branch.DeleteBranch.DeleteBranchCommand>()
                .ConstructUsing(id => new Application.Branch.DeleteBranch.DeleteBranchCommand(id));
        }
    }
}
