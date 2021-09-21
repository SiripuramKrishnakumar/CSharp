using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            // single level
            SA sa = new SA();
            sa.M1();
            sa.M2();
            Console.WriteLine("------------------");
            SB sb = new SB();
            sb.M1();
            sb.M2();
            sb.M3();
            sb.M4();
            Console.WriteLine("------------------");
            // multilevel
            MA ma = new MA();
            ma.M1();
            ma.M2();
            Console.WriteLine("------------------");
            MB mb = new MB();
            mb.M1();
            mb.M2();
            mb.M3();
            mb.M4();
            Console.WriteLine("------------------");
            MC mc = new MC();
            mc.M1();
            mc.M2();
            mc.M3();
            mc.M4();
            mc.M5();
            mc.M6();
            Console.WriteLine("------------------");
            //Heirarchical level
            HRA hRA = new HRA();
            hRA.M1();
            hRA.M2();
            Console.WriteLine("------------------");
            HRB hrb = new HRB();
            hrb.M1();
            hrb.M2();
            hrb.M3();
            hrb.M4();
            Console.WriteLine("------------------");

            HRC hrc = new HRC();
            hrc.M1();
            hrc.M2();
            hrc.M5();
            hrc.M6();
            Console.WriteLine("------------------");
            HRD hrd = new HRD();
            hrd.M1();
            hrd.M2();
            hrd.M7();
            hrd.M8();
            Console.WriteLine("------------------");

	  // Hybrid
            HA ha = new HA();
            ha.M1();
            ha.M2();
            Console.WriteLine("------------------");
            HB hb = new HB();
            hb.M1();
            hb.M2();
            hb.M3();
            hb.M4();
            Console.WriteLine("------------------");
            HC hc = new HC();
            hc.M1();
            hc.M2();
            hc.M3();
            hc.M4();
            hc.M5();
            hc.M6();
            Console.WriteLine("------------------");
            HD hd = new HD();
            hd.M1();
            hd.M2();
            hd.M3();
            hd.M4();
            hd.M5();
            hd.M6();
            hd.M7();
            hd.M8();
            Console.WriteLine("------------------");
            HE he = new HE();
            he.M1();
            he.M2();
            he.M3();
            he.M4();
            he.M5();
            he.M6();
            he.M9();
            he.M10();
            Console.WriteLine("------------------");

            Implement imp = new Implement();
            imp.I1();
            imp.I2();
            imp.I3();
            imp.I4();
            imp.I5();
            imp.I6();
            imp.I7();
            imp.I8();

        }
    }
}
