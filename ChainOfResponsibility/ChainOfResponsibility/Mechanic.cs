using System;
namespace ChainOfResponsibility
{
    class Mechanic : ServiceHandler
    {
        public Mechanic() : base(ServiceRequirements.EngineTune)
        {
        }
    }
}
