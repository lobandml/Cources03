using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources3.Study
{
    class GoodPupil:Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Reading: Good");
        }
        public override void Write()
        {
            Console.WriteLine("Writing: Good");
        }
        public override void Study()
        {
            Console.WriteLine("Studying: Good");
        }
        public override void Relax()
        {
            Console.WriteLine("Relaxing: Good");
        }
    }
}
