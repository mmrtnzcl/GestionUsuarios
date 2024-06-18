using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuarios.Entidades
{
    public interface IEmployer
    {

        string GetName();
        int GetId();
       abstract decimal GetSalario();
   
        

    }
}
