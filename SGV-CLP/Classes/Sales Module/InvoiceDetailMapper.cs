using Npgsql;
using SGV_CLP.Classes.Customers_Module;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Sales_Module
{
    public class InvoiceDetailMapper
    {

        private static readonly string s_connectionString = Constants.CONNECTION_STRING;
        //USAR using SGV_CLP.Classes
        //--------
        //CREATE
 

        public static void AddInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"OrderDetail\"(\"detailID\", \"orderID\", \"productID\", \"quantity\", \"subTotal\", \"isToGo\") VALUES (@NumDetalle, @Cod_NotaVenta, @Cod_Producto, @Cantidad, @SubTotal, @isToGo)", connection))
            {
                cmd.Parameters.AddWithValue("@NumDetalle", invoiceDetail.detailNumber);
                cmd.Parameters.AddWithValue("@Cod_NotaVenta", invoiceDetail.invoiceCode);
                cmd.Parameters.AddWithValue("@Cod_Producto", invoiceDetail.product.productCode);
                cmd.Parameters.AddWithValue("@Cantidad", invoiceDetail.soldQuantity);
                cmd.Parameters.AddWithValue("@SubTotal", invoiceDetail.subTotal);
                cmd.Parameters.AddWithValue("@isToGo", invoiceDetail.isToGo);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<InvoiceDetail> GetAllInvoiceDetails(int invoiceCode)
        {
            List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>();
            string queryString = "SELECT \"name\",\"quantity\",\"subTotal\",\"isToGo\" FROM public.\"OrderDetail\" join public.\"Product\" on \"OrderDetail\".\"productID\" = \"Product\".\"productID\" where \"orderID\" = @CodNotaVenta;";
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using var command = new NpgsqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@CodNotaVenta", invoiceCode);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    invoiceDetails.Add(new InvoiceDetail(reader.GetString(0), reader.GetInt32(1), reader.GetDouble(2), reader.GetBoolean(3)));
                }
            }
            return invoiceDetails;
        }
    }

}
