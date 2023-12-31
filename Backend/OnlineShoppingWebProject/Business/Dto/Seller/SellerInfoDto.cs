﻿using Data.Models;
using System;

namespace Business.Dto.Seller
{
	public class SellerInfoDto : IDto
	{
		public string Firstname { get; set; }

		public string Lastname { get; set; }

		public string Username { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string Address { get; set; }

		public byte[] SellerProfileImage { get; set; }

		public DateTime Birthdate { get; set; }

		public SellerApprovalStatus ApprovalStatus { get; set; }
	}
}
