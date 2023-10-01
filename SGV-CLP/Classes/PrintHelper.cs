
using System.Drawing.Printing;
using PdfiumViewer;

namespace SGV_CLP.Classes
{
    internal class PrintHelper
    {
        const string printerName = "NCR 7197 Receipt";
        public static bool PrintPDF(string filename)
        {
            try
            {
                // Create the printer settings for our printer
                var printerSettings = new PrinterSettings
                {
                    PrinterName = printerName,
                    Copies = 1,
                };
                // Create our page settings for the paper size selected
                var pageSettings = new PageSettings(printerSettings)
                {
                    Margins = new Margins(0, 0, 0, 0),
                };

                // Now print the PDF document
                using (var document = PdfDocument.Load(filename))
                {
                    using (var printDocument = document.CreatePrintDocument())
                    {
                        printDocument.PrinterSettings = printerSettings;
                        printDocument.DefaultPageSettings = pageSettings;
                        printDocument.Print();
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al imprimir " + ex.Message);
                return false;
            }
        }

    }
}
