using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources3.Docs
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате.");
        }
    }
}
