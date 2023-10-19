﻿namespace EmployeesAssessments.Api.Middleware
{
    public static class MiddlewareExtention
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
