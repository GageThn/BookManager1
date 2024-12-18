﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace BookManagerFinal.Models
{
	public class BookModel
	{
		[Key]
		public int BookId { get; set; }

		[Required(ErrorMessage = "Please enter a name.")]
		public string Name { get; set; } = string.Empty;

		[Required, StringLength (999, MinimumLength = 1, ErrorMessage = "Please enter a summary of the book.")]
		public string Summary { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please enter a Genre.")]
		public string Genre { get; set; } = string.Empty;

		[Required, MinLength(3, ErrorMessage = "Please enter the reading status (Read or Will Read).")]
		public string Status { get; set; } = string.Empty;

		[Range(0,5, ErrorMessage = "Please enter a Rating between 0 and 5.")]
		public int Rating { get; set; }
		public string? Slug => Name?.Replace(' ', '-').ToLower();
	}
}

