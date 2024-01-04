﻿namespace LMS_G7.Shared.Dtos.ModulesDtos
{
	public class ModuleDto
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		//public ICollection<ActivityDto> Activities { get; set; }
	}
}