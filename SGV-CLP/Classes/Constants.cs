using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class Constants
    {
        public const int LIMIT_CC_LENGTH = 10;
        public const int MAX_NOMBRE_LENGTH = 50;
        public const int MAX_APELL_LENGTH = 50;
        public const int LIMIT_NOMBRE_LENGTH = 50;
        public const int LIMIT_APELLIDO_LENGTH = 50;
        public const int LIMIT_DIRECCION_LENGTH = 100;
        public const int LIMIT_TELEF_LENGTH_MIN = 7;
        public const int LIMIT_TELEF_LENGTH = 10;
        public const int LIMIT_FECHANAC_LENGTH = 10;
        public const int LIMIT_CORREO_LENGTH = 100;
        public const int MAX_RECEIPT_DESCRIPTION_LENGTH = 40;

        // Constantes de módulo Productos
        public const int LIMIT_IDPROD_LENGTH = 7;
        public const int LIMIT_NOMBREPROD_LENGTH = 50;
        public const int LIMIT_RUTAIMAGEN_LENGTH = 100;

        //SettingsNames
        public const string TABLE_NUMBER_SETTING = "TableNumberEnabled";
        public const string LAST_ORDERS_SETTING = "LastOrdersEnabled";
        public const string MULTIPLE_PRINT_SETTING = "MultiplePrintEnabled";

        //UC_Ventas
        public const int SCROLL_WIDTH = 10;

        //Connectivity
        public const string CONNECTION_STRING = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGVCLP";

    }
}
