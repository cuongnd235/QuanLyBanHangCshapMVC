﻿namespace Models.DTO
{
    public class AccountUserDto
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
    }
}
