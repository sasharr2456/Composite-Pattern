using static System.Collections.Specialized.BitVector32;
using System.Reflection.Metadata;


using Composite_Pattern;

public interface DocumentComponent
{
    void Add(DocumentComponent component);
    void Remove(DocumentComponent component);
    void Display(int value);
}


class Program
{
    static void Main(string[] args)
    {
        Composite_Pattern.Document document = new Composite_Pattern.Document();

        Composite_Pattern.Section section1 = new Composite_Pattern.Section("Введение");
        section1.Add(new Paragraph("параграф введения №1."));
        section1.Add(new Paragraph("параграф введения №2."));
        section1.Add(new Paragraph("параграф введения №3."));
        section1.Add(new Paragraph("параграф введения №4."));

        Composite_Pattern.Section section2 = new Composite_Pattern.Section("Методы");
        section2.Add(new Paragraph("параграф методов №1."));
        section2.Add(new Paragraph("параграф методов №2."));

        Composite_Pattern.Section subsection = new Composite_Pattern.Section("Термины");
        subsection.Add(new Paragraph("параграф раздела терминов в разделе Методов."));
        section2.Add(subsection);

        document.Add(section1);
        document.Add(section2);

        document.Display(0);
    }
}