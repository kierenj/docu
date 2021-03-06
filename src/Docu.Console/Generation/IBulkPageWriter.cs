using System.Collections.Generic;
using System.Reflection;
using Docu.Documentation;

namespace Docu.Generation
{
    public interface IBulkPageWriter
    {
        void CreatePagesFromDirectory(string templatePath, string destination, IList<Namespace> namespaces);
        void SetAssemblies(IEnumerable<Assembly> assemblies);
    }
}