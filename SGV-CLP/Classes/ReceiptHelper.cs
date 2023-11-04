using iTextSharp.text;
using iTextSharp.text.pdf;
using SGV_CLP.Classes.Customers_Module;
using SGV_CLP.Classes.Sales_Module;
using System;
using System.IO;

namespace SGV_CLP.Classes
{
    public static class ReceiptHelper
    {
        private static iTextSharp.text.Font font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8);
        private static iTextSharp.text.Font font1 = FontFactory.GetFont(FontFactory.HELVETICA, 8);
        public static void GenerateReceipt(Invoice invoice, Customer customer, string total, string cash, string change, int? tableNumber)
        {
            iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(226.77f, PageSize.LETTER.Height);
            // Crear un nuevo documento
            iTextSharp.text.Document document = new iTextSharp.text.Document(pageSize);
            document.SetMargins(10, 10, 20, 0);
            // Establecer el archivo donde deseas guardar el PDF
            string outputPath = "receipt.pdf";
            PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));

            // Abrir el documento para escritura
            document.Open();
            AddHeader(document);
            if (tableNumber != null)
                AddTableInfo(document, tableNumber);
            AddSeparator(document);
            AddCustomerInfo(document, customer);
            if (invoice.dineInDetailList.Count == 0)
            {
                AddToGoSeparator(document); 
            }
            else
            {
                AddSeparator(document);
            }
            AddProductDetail(document, invoice);
            AddSeparator(document);
            AddTotal(document, total, cash, change);
            AddSeparator(document);
            AddFooter(document);
            // Cerrar el documento
            document.Close();

        }
        static void AddHeader(iTextSharp.text.Document document)
        {
            Paragraph header = new iTextSharp.text.Paragraph("CAFETERÍA LA PROSPERIDAD\n\n", font);
            // Obtener la fecha y hora actuales
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("dd/MM/yyyy");
            string formattedTime = now.ToString("HH:mm:ss");
            header.Alignment = Element.ALIGN_CENTER;
            document.Add(header);
            document.Add(new Paragraph("RUC NRO: 1703869261001", font1));
            document.Add(new Paragraph("TELEFONO: 2811893", font1));
            document.Add(new Paragraph("OBLIGADO A LLEVAR CONTABILIDAD: NO", font1));
            document.Add(new Paragraph("FECHA: " + formattedDate + "   HORA: " + formattedTime, font1));

        }
        static void AddTableInfo(Document document, int? tableNumber)
        {
            document.Add(new Paragraph("MESA NRO: " + tableNumber.ToString() , font1));
        }
        static void AddSeparator(Document document)
        {
            Paragraph separator = new Paragraph("--------------------------------------------------\n")
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(separator);
        }
        static void AddToGoSeparator(Document document)
        {
            Paragraph separator = new Paragraph("\n------------------------- PARA LLEVAR -------------------------\n", font)
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(separator);
        }
        static void AddProductDetail(Document document, Invoice invoice)
        {
            float[] columnWidths = { 10f, 40f, 10f, 13f };
            if (invoice.dineInDetailList.Count > 0)
            {
                PdfPTable table = new PdfPTable(4); // 4 columnas
                table.SetWidths(columnWidths);
                table.WidthPercentage = 100; // Ancho de tabla al 100% del ancho de página
                AddDetailTableTitle(table);
                invoice.dineInDetailList.ForEach(item => { AddReceiptItem(table, item.soldQuantity, item.product.productName, (double)item.product.salePrice, (double)item.subTotal); });
                document.Add(table);
                if (invoice.toGoDetailList != null)
                    AddToGoSeparator(document);
            }
            if (invoice.toGoDetailList != null)
            {
                PdfPTable toGoDetailTable = new PdfPTable(4); // 4 columnas
                toGoDetailTable.SetWidths(columnWidths);
                toGoDetailTable.WidthPercentage = 100; // Ancho de tabla al 100% del ancho de página
                if(invoice.dineInDetailList.Count == 0)
                    AddDetailTableTitle(toGoDetailTable);
                invoice.toGoDetailList.ForEach(item => { AddReceiptItem(toGoDetailTable, item.soldQuantity, item.product.productName, (double)item.product.salePrice, (double)item.subTotal); });
                document.Add(toGoDetailTable);
            }
        }
        static void AddDetailTableTitle(PdfPTable table)
        {
            // Configurar el estilo de borde de las celdas
            PdfPCell cell = new PdfPCell();
            cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cell.PaddingTop = 5; // Añadir espacio entre el contenido de la celda y los bordes
            cell.PaddingBottom = 5;
            // Agregar encabezados de columna
            cell.HorizontalAlignment = Element.ALIGN_CENTER; // Centrar contenido horizontalmente
            cell.VerticalAlignment = Element.ALIGN_MIDDLE; // Centrar contenido verticalmente
            cell.Phrase = new Phrase("CAN", font);
            table.AddCell(cell);

            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Phrase = new Phrase("PRODUCTO", font);
            table.AddCell(cell);

            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Phrase = new Phrase("P. U.", font);
            table.AddCell(cell);

            cell.Phrase = new Phrase("P. TOT.", font);
            table.AddCell(cell);
        }
        static void AddReceiptItem(PdfPTable table, int quantity, string itemName, double itemPrice, double subTotal)
        {
            PdfPCell cell = new PdfPCell();
            cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_CENTER; // Centrar contenido horizontalmente
            cell.VerticalAlignment = Element.ALIGN_MIDDLE; // Centrar contenido verticalmente
            cell.Phrase = new Phrase(quantity.ToString(), font1);
            table.AddCell(cell);

            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Phrase = new Phrase(itemName.Length > 17 ? itemName.Substring(0, 17).ToUpper() + "." : itemName.ToUpper(), font1);
            table.AddCell(cell);

            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            cell.PaddingRight = 5;
            cell.Phrase = new Phrase($"{itemPrice:0.00}", font1);
            table.AddCell(cell);

            cell.PaddingRight = 8;
            cell.Phrase = new Phrase(new Phrase($"{subTotal:0.00}", font1));
            table.AddCell(cell);
        }
        static void AddTotal(iTextSharp.text.Document document, string totalAmount, string cash, string change)
        {
            PdfPTable table = new PdfPTable(2); // 4 columnas
            float[] columnWidths = { 5f, 1f };
            table.SetWidths(columnWidths);
            table.WidthPercentage = 100; // Ancho de tabla al 100% del ancho de página


            PdfPCell cell = new PdfPCell();
            cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_LEFT; // Centrar contenido horizontalmente

            PdfPCell rightCell = new PdfPCell();
            rightCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            rightCell.HorizontalAlignment = Element.ALIGN_RIGHT; // Centrar contenido horizontalmente
            rightCell.PaddingRight = 10;

            string blankSpace = "                         ";
            // Adding subtotal row
            cell.Phrase = new Phrase(blankSpace + "SUBTOTAL", font1);
            table.AddCell(cell);
            rightCell.Phrase = new Phrase(totalAmount, font1);
            table.AddCell(rightCell);

            //Adding IVA row
            cell.Phrase = new Phrase(blankSpace + "IVA 12%", font1);
            table.AddCell(cell);
            rightCell.Phrase = new Phrase($"0,00", font1);
            table.AddCell(rightCell);

            //Adding Total row
            cell.Phrase = new Phrase(blankSpace + "TOTAL", font1);
            table.AddCell(cell);
            rightCell.Phrase = new Phrase(totalAmount, font1);
            table.AddCell(rightCell);

            //Adding cash row
            cell.Phrase = new Phrase(blankSpace + "EFECTIVO", font1);
            table.AddCell(cell);
            rightCell.Phrase = new Phrase(cash, font1);
            table.AddCell(rightCell);

            //Adding cash row
            cell.Phrase = new Phrase(blankSpace + "CAMBIO", font1);
            table.AddCell(cell);
            rightCell.Phrase = new Phrase(change, font1);
            table.AddCell(rightCell);

            // Agregar la tabla al documento
            document.Add(table);
        }
        static void AddCustomerInfo(iTextSharp.text.Document document, Customer customer)
        {
            PdfPTable table = new PdfPTable(2); // 4 columnas
            float[] columnWidths = { 2f, 4f };
            table.SetWidths(columnWidths);
            table.WidthPercentage = 100; // Ancho de tabla al 100% del ancho de página


            PdfPCell cell = new PdfPCell();
            cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_LEFT; // Centrar contenido horizontalmente
                                                           // Adding subtotal row
            cell.Phrase = new Phrase("C.I/RUC:", font1);
            table.AddCell(cell);
            cell.Phrase = new Phrase(customer.customerID, font1);
            table.AddCell(cell);

            //Adding IVA row
            cell.Phrase = new Phrase("NOMBRE:", font1);
            table.AddCell(cell);
            cell.Phrase = new Phrase(customer?.firstName?.ToUpper() + " " + customer?.firstLastName?.ToUpper(), font);
            table.AddCell(cell);

            // Agregar la tabla al documento
            document.Add(table);
        }
        static void AddFooter(iTextSharp.text.Document document)
        {
            Paragraph header = new("**  GRACIAS POR SU COMPRA  **\n\n\n\n", font)
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(header);
        }

    }
}


