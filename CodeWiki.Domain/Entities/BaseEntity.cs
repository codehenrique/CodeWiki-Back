using System;

namespace CodeWiki.Domain.Entities
{
	public abstract class BaseEntity
    {
		private DateTime? _createAt;

		public int Id { get; set; }
		public DateTime UpdateAt { get; set; }


		public DateTime? CreateAt
		{
			get => _createAt;
			set => _createAt = value == null ? DateTime.UtcNow : value;
		}
	}
}
