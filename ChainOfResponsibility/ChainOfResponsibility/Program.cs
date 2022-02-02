using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // объекты для работы программы
            var mechanic = new Mechanic();
            var detailer = new Detailer();
            var wheels = new WheelSpecialist();
            var qa = new QualityControl();

            // установка последовательности
            qa.SetNextServiceHandler(detailer);
            wheels.SetNextServiceHandler(qa);
            mechanic.SetNextServiceHandler(wheels);

            Console.WriteLine("Car 1 is dirty");
            detailer.Service(new Car() { Requirements = ServiceRequirements.Dirty });

            Console.WriteLine();

            Console.WriteLine("Car 2 requires full service");
            detailer.Service(new Car()
            {
                Requirements = ServiceRequirements.Dirty |
                    ServiceRequirements.EngineTune |
                    ServiceRequirements.TestDrive |
                    ServiceRequirements.WheelAlignment
            });
        }
    }
}
