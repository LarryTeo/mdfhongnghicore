using System;
using System.Collections.Generic;
using System.Text;

namespace HN.Infrastructure.ShareKernel
{
    public abstract class DomainEntiy <T>
    {
        public T Id { get; set; }

        /// <summary>
        /// True if domain entity has an identity
        /// </summary>
        /// <returns></returns>
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}
