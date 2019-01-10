using System;
using FluentValidation;
using FluentValidation.Results;
namespace RM.Domain.Core.Entities
{
    public abstract class Entity<T> : AbstractValidator<T> where T : Entity<T>
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public ValidationResult ValidationResult { get; set; }
        public abstract bool IsValidated();
    }
}