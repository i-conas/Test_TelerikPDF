using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf;

// Für das Telerik PDF Processing
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.Editing;
using Telerik.Windows.Zip;

// Für das optionale Nutzen von Farben, Shapes, ... in dem PDFProcessing 
//using Presen


namespace Test_TelerikPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            RadFixedDocument document = new RadFixedDocument();
            RadFixedPage page = document.Pages.AddPage();

            FixedContentEditor editor = new FixedContentEditor(page);
            editor.DrawText("Hallo Armand!");

            PdfFormatProvider provider = new PdfFormatProvider();
            using (Stream output = File.OpenWrite("Test_Telerik.pdf"))
            {
                provider.Export(document, output);
            }
        }
    }
}
