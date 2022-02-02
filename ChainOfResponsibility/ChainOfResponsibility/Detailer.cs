using System;
namespace ChainOfResponsibility
{
    class Detailer : ServiceHandler
    {
        public Detailer() : base(ServiceRequirements.Dirty)
        {
        }
    }
}
