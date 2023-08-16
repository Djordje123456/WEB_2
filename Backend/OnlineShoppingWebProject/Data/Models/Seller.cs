﻿using System.Collections.Generic;

namespace Data.Models
{
	public class Seller : ISeller
	{
		public ICollection<Article> Articles { get; set; }

		public SellerApprovalStatus ApprovalStatus { get; set; }
		
		public long Id { get; set; }
		
		public string Firstname { get; set; }
		
		public string Lastname { get; set; }
		
		public string Username { get; set; }
		
		public string Email { get; set; }
		
		public string Password { get; set; }
		
		public string Address { get; set; }
		
		public string ProfileImage { get; set; }
	}
}
