using EmployeesAssessments.Application.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAssessments.Application.Contracts.Identity
{
    public interface IAuthenticationService
    {
        Task<AuthenticationDTO> AuthenticateAsync(AuthenticationRequest request);
        Task<RegistrationDTO> RegisterAsync(RegistrationRequest request);
    }
}
