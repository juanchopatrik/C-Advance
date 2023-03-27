using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  InterfacezConMetodo
{
    internal interface IElectronico
    {
        void Encender(bool interruptor);
    }
}
