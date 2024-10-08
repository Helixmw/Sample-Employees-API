﻿using Employees_API.DTOs.Departments;
using Microsoft.AspNetCore.Mvc;

namespace Employees_API.Controllers
{
    public interface IDepartmentsController
    {
        Task<IActionResult> DeleteById(int id);
        Task<IActionResult> Get();
        Task<IActionResult> GetById(int id);
        Task<IActionResult> Post(AddDepartmentDTO Value);
        Task<IActionResult> Update(EditDepartmentDTO Value);
    }
}