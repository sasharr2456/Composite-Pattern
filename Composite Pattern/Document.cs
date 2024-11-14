using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Document : DocumentComponent
    {
        private List<DocumentComponent> _sections = new List<DocumentComponent>();

        public void Add(DocumentComponent component)
        {
            if (component is Section) _sections.Add(component);

            else throw new InvalidOperationException("Документ может содержать только разделы.");

        }

        public void Remove(DocumentComponent component)
        {
            _sections.Remove(component);
        }

        public void Display(int value)
        {
            Console.WriteLine("Документ:");
            foreach (var section in _sections) section.Display(value + 1);
        }
    }

}