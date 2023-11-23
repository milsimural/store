using System;
using System.Linq;

namespace Store.Memory
{
    public class ProjRepository : IProjRepository
    {
        private readonly Proj[] projs = new[]
        {
            new Proj(1, "Art Of Programming"),
            new Proj(2, "Refactoring"),
            new Proj(3, "C Programming Language"),
        };

        public Proj[] GetAllByTitle(string titlePart)
        {
            return projs.Where(proj => proj.Title.Contains(titlePart))
                .ToArray();
        }
    }
}
