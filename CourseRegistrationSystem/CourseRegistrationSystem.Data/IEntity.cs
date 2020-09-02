using System;

namespace CourseRegistrationSystem.Data
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
