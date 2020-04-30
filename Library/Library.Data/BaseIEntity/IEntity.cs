using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.BaseIEntity
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
