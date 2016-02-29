using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources3
{
    public static class Tasks
    {

        public static void Task1()
        {
            Printer p = new Printer();
            Printer hp = new HPPrinter();

            p.Print("This is printer");
            hp.Print("This is HPPrinter!");
        }
        public static void Task2()
        {
            Study.ClassRoom room;
            Study.Pupil[] pupils=new Study.Pupil[4];
            pupils[0] = new Study.BadPupil();
            pupils[1] = new Study.GoodPupil();
            pupils[2] = new Study.ExcelentPupil();
            pupils[3] = new Study.BadPupil();
            room=new Study.ClassRoom(pupils);


            for (int i = 0; i < room.pupils.Count; i++)
            {
                room.pupils[i].Write();
                room.pupils[i].Study();
                room.pupils[i].Read();
                room.pupils[i].Relax();
            }
        }
        public static void Task3()
        {
            Transport.Vehicle vehicle = new Transport.Vehicle(13, 14, 9000, 60, 1991);
            Console.WriteLine(vehicle.ToString());
            Transport.Car carv = new Transport.Car(15, 16, 3000, 70, 1993);
            Console.WriteLine(carv.ToString());
            Transport.Plane  planev= new Transport.Plane(100, 200, 8000, 300000, 800, 2001, 155);
            Console.WriteLine(planev.ToString());
            Transport.Ship shipv = new Transport.Ship(20, 30, 30000, 20, 1996, "Мурманск", 120);
            Console.WriteLine(shipv.ToString());
        }
        public static void Task4()
        {
            Docs.DocumentWorker testWorker;
            Console.WriteLine(@"введите ключ (pro\exp\any string)");

            string pass = Console.ReadLine();

            switch (pass)
            {
                case "pro":
                    testWorker = new Docs.ProDocumentWorker();
                    break;
                case "exp":
                    testWorker = new Docs.ExpertDocumentWorker();
                    break;
                default:
                    testWorker = new Docs.DocumentWorker();
                    break;
            }
            testWorker.OpenDocument();
            testWorker.EditDocument();
            testWorker.SaveDocument();
            Console.ReadLine();

        }
    }
}
