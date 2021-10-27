﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolrInsertWebAPIExample.Models
{
    public class Post
    {
		public Post() { }

		public string Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public bool IsActive { get; set; }
		public DateTime PostedDate { get; set; }
		public DateTime ExpiryDate { get; set; }
		public DateTime IsSold { get; set; }
	}
}
