using System;
namespace ChainOfResponsibility
{
    abstract class ServiceHandler
    {
        protected ServiceHandler _nextServiceHandler;
        protected ServiceRequirements _servicesProvided;
        public ServiceHandler(ServiceRequirements servicesProvided)
        {
            this._servicesProvided = servicesProvided;
        }
        public void Service(Car car)
        {
            if (_servicesProvided == (car.Requirements & _servicesProvided))
            {
                Console.WriteLine($"{this.GetType().Name} providing" +
                    $" {this._servicesProvided} services");
                car.Requirements &= ~_servicesProvided;
            }

            if (car.IsServiceCompleted || this._nextServiceHandler == null)
            {
                return;
            }
            else
            {
                this._nextServiceHandler.Service(car);
            }
        }
        public void SetNextServiceHandler(ServiceHandler nextServiceHandler)
        {
            this._nextServiceHandler = nextServiceHandler;
        }
    }
}
