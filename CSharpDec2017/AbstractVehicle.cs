using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{

    public class AbstractVehicleBase
    {

    }
    public class VehicleBase
    {
        public string Code { get; set; }
    }

    public abstract class AbstractVehicle : AbstractVehicleBase
    {
        public AbstractVehicle()
        {
            Console.WriteLine("This is abstract class constructor");
        }
        public string Color { get; set; }
        public int EngineSize { get; set; }


        public virtual void TestMethod()
        {
            Console.WriteLine("normal test method");
        }

        public abstract void DisplayMessage();
    }

    public class SuzikiBalino : AbstractVehicle
    {
        public SuzikiBalino()
        {
            Console.WriteLine("suziki balino class constructor");
        }

        public sealed override void TestMethod()
        {
            Console.WriteLine("Overriden Balino Test Method");
        }

        public override void DisplayMessage()
        {
            TestMethod();
            base.TestMethod();
            Color = "Royal Blue";
            Console.WriteLine("Suziki Balino with : " + Color);
        }

        public void BalinoInnerMethod()
        {

        }

    }
    public sealed class SuzikiCiaz : AbstractVehicle
    {
        public override void DisplayMessage()
        {
            // TestMethod();
            Color = "Silver";
            Console.WriteLine("Suziki Ciaz with : " + Color);
        }
    }



    public class SuzikiBalinoChild : SuzikiBalino
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Display balino child");
        }

        //public override void TestMethod()
        //{
        //    Console.WriteLine("Balino child test method");
        //}
    }
}
