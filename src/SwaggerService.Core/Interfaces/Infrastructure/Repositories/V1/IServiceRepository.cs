using System.Collections.Generic;
using System.Threading.Tasks;
using SwaggerService.Core.Models.Features;
using SwaggerService.Core.Models.Service;

namespace SwaggerService.Core.Interfaces.Infrastructure.Repositories.V1
{
    /// <summary>
    /// IServiceRepositoy interface
    /// </summary>
    public interface IServiceRepository
    {
        #region Methods

        /// <summary>
        /// GetServices
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        IEnumerable<ServiceResponse> GetServices();        
        
        #endregion
        
    }
}