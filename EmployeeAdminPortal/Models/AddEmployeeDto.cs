﻿namespace EmployeeAdminPortal.Models
{
    public class AddEmployeeDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public string Salary { get; set; }
    }
}
