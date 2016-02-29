using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources3.Study
{
    class BadPupil:Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Reading: Bad");
        }
        public override void Write()
        {
            Console.WriteLine("Writing: Bad");
        }
        public override void Study()
        {
            Console.WriteLine("Studying: Bad");
        }
        public override void Relax()
        {
            Console.WriteLine("Relaxing: Bad");
        }
    }
}
