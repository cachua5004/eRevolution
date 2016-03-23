using System.Threading.Tasks;
using Abp.Application.Services;
using eRevolution.Roles.Dto;

namespace eRevolution.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
