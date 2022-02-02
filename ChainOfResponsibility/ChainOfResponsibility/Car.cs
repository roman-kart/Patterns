using System;
namespace ChainOfResponsibility
{
    public class Car
    {
        public ServiceRequirements Requirements { get; set; }
        public bool IsServiceCompleted
        {
            get
            {
                return this.Requirements == ServiceRequirements.None;
            }
        }
    }
}
