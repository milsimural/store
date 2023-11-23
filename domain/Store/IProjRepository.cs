using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface IProjRepository
    {
        Proj[] GetAllByTitle(string titlePart); 
    }
}
