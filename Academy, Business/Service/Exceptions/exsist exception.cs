using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy__Business.Service.Exceptions;

public class exsist_exception : Exception
{
    public exsist_exception(string message)  :base(message) { }
    
} 
