using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources3.Study
{
    class ExcelentPupil:Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Reading: Excellent");
        }
        public override void Write()
        {
            Console.WriteLine("Writing: Excellent");
        }
        public override void Study()
        {
            Console.WriteLine("Studying: Excellent");
        }
        public override void Relax()
        {
            Console.WriteLine("Relaxing: Excellent");
        }
    }
}
