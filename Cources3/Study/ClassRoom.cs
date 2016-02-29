using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources3.Study
{
    class ClassRoom
    {
        public readonly List<Pupil> pupils = new List<Pupil>();

        public ClassRoom(Pupil[] pupils)
        {
            if (pupils.Length == 4)
            {
                this.pupils.AddRange(pupils);
            }
            else throw new Exception("Неверное кол-во учеников");
        }
    }
}
