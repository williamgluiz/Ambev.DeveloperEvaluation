using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Branch.GetBranchById
{
    /// <summary>
    /// Profile for mapping between Branch entity and GetBranchByIdResponse.
    /// </summary>
    public class GetBranchByIdProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetBranchById operation.
        /// </summary>
        public GetBranchByIdProfile()
        {
            CreateMap<Domain.Entities.Branch, GetBranchByIdResult>();
        }
    }
}
