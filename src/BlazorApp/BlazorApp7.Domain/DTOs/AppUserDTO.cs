﻿namespace BlazorApp7.Domain.DTOs;

public class AppUserDTO
{
	public string Id { get; set; } = default!;
	public string? UserName { get; set; }
	public string? NormalizedUserName { get; set; }
	public string? Email { get; set; }
	public bool EmailConfirmed { get; set; }
	public string? PhoneNumber { get; set; }
	public bool PhoneNumberConfirmed { get; set; }
	public bool TwoFactorEnabled { get; set; }
	public DateTimeOffset? LockoutEnd { get; set; }
	public bool LockoutEnabled { get; set; }
	public int AccessFailedCount { get; set; }
}
