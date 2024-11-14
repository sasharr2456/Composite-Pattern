using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Section : DocumentComponent
    {
        private string _title;
        private List<DocumentComponent> _components = new List<DocumentComponent>();

        public Section(string title)
        {
            _title = title;
        }

        public void Add(DocumentComponent component)
        {
            if (component is Paragraph || component is Section) _components.Add(component);

            else throw new InvalidOperationException("Раздел может содержать только параграфы и другие разделы.");

        }

        public void Remove(DocumentComponent component)
        {
            _components.Remove(component);
        }

        public void Display(int value)
        {
            Console.WriteLine(new string(' ', value * 2) + _title);
            foreach (var component in _components) component.Display(value + 1);

        }
    }
}