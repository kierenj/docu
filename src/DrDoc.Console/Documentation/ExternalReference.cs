using DrDoc.Documentation;
using DrDoc.Parsing.Model;

namespace DrDoc.Documentation
{
    public class ExternalReference : IReferencable
    {
        public ExternalReference(Identifier name)
        {
            Name = name;
            FullName = Name.ToString();

            if (Name is TypeIdentifier)
                FullName = Name.CloneAsNamespace() + "." + Name;
        }

        public Identifier Name { get; private set; }
        public string FullName { get; private set; }
    }
}