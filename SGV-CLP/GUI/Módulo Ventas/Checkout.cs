using SGV_CLP.Classes;
using SGV_CLP.Classes.Customers_Module;
using SGV_CLP.Classes.Sales_Module;
using SGV_CLP.Classes.Sales_Module;
using Siticone.Desktop.UI.AnimatorNS;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_CLP.GUI.Módulo_Ventas
{

    public partial class Checkout : Form
    {
        public static List<Customer> clientes = CustomerMapper.GetAllCustomersSync();
        AutoCompleteStringCollection listaDeSugerenciasdeAutompletacion;

        readonly int num_atributos = 3;
        int count_correct_fields = 0;
        bool editClientIsEnabled = false;

        bool ccIsValid = false;
        bool firsLastNameIsValid = false;
        bool firstNameIsValid = false;
        bool addressIsValid = false;
        bool telefIsValid = false;
        bool correoIsValid = false;

        public Checkout(SiticoneDataGridView siticoneDataGridView)
        {
            InitializeComponent();
            foreach (DataGridViewRow rowItem in siticoneDataGridView.Rows)
            {
                DataGridViewRow row = (DataGridViewRow)rowItem.Clone();
                siticoneDataGridView1.Rows.Add(rowItem.Cells[0].Value, rowItem.Cells[1].Value, rowItem.Cells[2].Value);
            }
            setTotal(siticoneDataGridView1);
            listaDeSugerenciasdeAutompletacion = new AutoCompleteStringCollection();
            ActualizarListadeSugerenciasdeAutocompletacion();

            txtCC_ClienteVenta.AutoCompleteCustomSource = listaDeSugerenciasdeAutompletacion;

            // Limitamos la longitud segun los requisitos
            txtCC_ClienteVenta.MaxLength = Constants.LIMIT_CC_LENGTH;
            txtNombre1Venta.MaxLength = Constants.LIMIT_NOMBRE_LENGTH;
            txtApellido1Venta.MaxLength = Constants.LIMIT_APELLIDO_LENGTH;
            txtDireccionVenta.MaxLength = Constants.LIMIT_DIRECCION_LENGTH;
            txtTelefVenta.MaxLength = Constants.LIMIT_TELEF_LENGTH;
            txtCorreoVenta.MaxLength = Constants.LIMIT_CORREO_LENGTH;

            //Hide Validations Labels
            siticoneHtmlLabel_correct_email.Hide();
            siticoneHtmlLabel_cc_valida.Hide();
            siticoneHtmlLabel_cc_correct_length.Hide();
            labelCustomerIDUnique.Hide();
            labelCustomerIDNotUnique.Hide();
            siticoneHtmlLabel_correct_length_telef.Hide();
            siticoneHtmlLabel_wrong_email.Hide();
            siticoneHtmlLabel_wrong_length_telef.Hide();
            labelInvalidPhoneNumber.Hide();


            ButtonAniadirClienteVenta.Enabled = false;
            ButtonConfirmarVenta.Enabled = false;

        }

        private void ActualizarListadeSugerenciasdeAutocompletacion()
        {
            clientes.ForEach(a => listaDeSugerenciasdeAutompletacion.Add(a.customerID));
        }


        private void SiticoneButton1_Click(object sender, EventArgs e)
        {
            Customer clienteFinal = new(txtCC_ClienteVenta.Text, txtNombre1Venta.Text, txtApellido1Venta.Text, txtDireccionVenta.Text, txtTelefVenta.Text, txtCorreoVenta.Text);
            UC_Ventas.invoice.customer = clienteFinal;
            UC_Ventas.invoice.issuedDate = DateTime.Now;
            InvoiceMapper.AddInvoice(UC_Ventas.invoice);
            UC_Ventas.invoice.SetInvoiceDetail(InvoiceMapper.ConsultarUltimoID());
            UC_Ventas.invoice.invoiceDetailList.ForEach(item => InvoiceDetailMapper.AddInvoiceDetail(item));
            ReceiptHelper.GenerateReceipt(
                UC_Ventas.invoice,
                clienteFinal,
                txtTotalVenta.Text.Replace('.',','),
                txtRecibidoVenta.Text.Equals(string.Empty) ? txtTotalVenta.Text.Replace('.', ',') : txtRecibidoVenta.Text.Replace('.', ','),
                txtVueltoVenta.Text.Equals(string.Empty) ? "0,00" : txtVueltoVenta.Text.Replace('.', ','));
            //Print Receipt Line
            //PrintHelper.PrintPDF("receipt.pdf");
            UC_Ventas.invoice = new Invoice();
            UC_Ventas.resetNumPickers();
            SystemSounds.Beep.Play();
            MessageBox.Show("Venta finalizada con éxito", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MainMenu.uc_ventas.ResetValues();

            this.Dispose();
        }

        private void SiticoneButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Se presiona el boton de añadir cliente
        private void SiticoneButton4_Click(object sender, EventArgs e)
        {
            txtApellido1Venta.Enabled = true;
            txtNombre1Venta.Enabled = true;
            txtDireccionVenta.Enabled = true;
            txtTelefVenta.Enabled = true;
            txtCorreoVenta.Enabled = true;
            editClientIsEnabled = true;
            ButtonConfirmarVenta.Visible = true;

            txtApellido1Venta_TextChanged(null, null);
            txtNombre1Venta_TextChanged(null, null);
            txtDireccionVenta_TextChanged(null, null);
            txtTelefVenta_TextChanged(null, null);
            txtCorreoVenta_TextChanged(null, null);

            if (ValidationUtils.IsValidEmail(txtCorreoVenta.Text))
            {
                siticoneHtmlLabel_wrong_email.Hide();
                siticoneHtmlLabel_correct_email.Show();
            }
            else
            {
                siticoneHtmlLabel_wrong_email.Show();
                siticoneHtmlLabel_correct_email.Hide();
            }
            if (txtTelefVenta.TextLength == 10)
            {
                siticoneHtmlLabel_wrong_length_telef.Hide();
                siticoneHtmlLabel_correct_length_telef.Show();
            }
            else
            {
                siticoneHtmlLabel_wrong_length_telef.Show();
                siticoneHtmlLabel_correct_length_telef.Hide();
            }

        }

        private async void SiticoneButton3_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Cliente Registrado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ButtonConfirmarVenta.Visible = false;
            txtApellido1Venta.Enabled = false;
            txtNombre1Venta.Enabled = false;
            txtDireccionVenta.Enabled = false;
            txtTelefVenta.Enabled = false;
            txtCorreoVenta.Enabled = false;
            editClientIsEnabled = false;


            ccIsValid = false;
            firsLastNameIsValid = false;
            firstNameIsValid = false;
            addressIsValid = false;
            telefIsValid = false;
            correoIsValid = false;

            siticoneHtmlLabel_correct_length_telef.Visible = false;
            siticoneHtmlLabel_wrong_length_telef.Visible=false;
            siticoneHtmlLabel_correct_email.Visible = false;
            siticoneHtmlLabel_wrong_email.Visible = false;
            labelValidPhoneNumber.Visible = false;
            labelInvalidPhoneNumber.Visible = false;
            siticoneHtmlLabel_cc_correct_length.Visible = false;
            siticoneHtmlLabel_cc_wrong_length.Visible = false;
           
            Customer clienteNuevo = new Customer(txtCC_ClienteVenta.Text,
                txtNombre1Venta.Text,
                txtApellido1Venta.Text,
                txtDireccionVenta.Text,
                txtTelefVenta.Text,
                txtCorreoVenta.Text);

            switch (CustomerList.FindExistentCustomer(clientes, clienteNuevo))
            {
                case 0:
                    break;
                case 1:
                    await CustomerMapper.UpdateCustomer(clienteNuevo);
                    clientes = await CustomerMapper.GetAllCustomers();
                    break;
                case -1:
                    CustomerMapper.AddCustomer(clienteNuevo);
                    clientes = await CustomerMapper.GetAllCustomers();
                    break;
            }

            txtCC_ClienteVenta_TextChanged(null, null);
            ActualizarListadeSugerenciasdeAutocompletacion();
        }


        private void txtCC_ClienteVenta_KeyUp(object sender, KeyEventArgs e)
        {
            controlCedula();
        }

        public void controlCedula()
        {
            if (ValidationUtils.ValidarCedula(txtCC_ClienteVenta.Text))
            {
                siticoneHtmlLabel_cc_invalida.Hide();
                siticoneHtmlLabel_cc_valida.Show();
            }
            validateFieldsCounter();
        }

        private void txtCC_ClienteVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressDigitsValidation(e);
        }
        private void txtNombre1Venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressLetterValidation(e);
        }
        private void TxtApellido1Venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressLetterValidation(e);
        }
        private void TxtDireccionVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressAddressValidation(e);
        }

        private void TxtTelefVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressDigitsValidation(e);
        }

        private void TxtCorreoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressEmailValidation(e);

        }
        private void txtTotalVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressDoubleValidation(e);
        }

        private void txtCC_ClienteVenta_TextChanged(object sender, EventArgs e)
        {
            // comprueba que la cc == 10 y muesta mensaje de correcto
            if (txtCC_ClienteVenta.Text.Length == Constants.LIMIT_CC_LENGTH && !ccIsValid)
            {
                siticoneHtmlLabel_cc_wrong_length.Hide();
                siticoneHtmlLabel_cc_correct_length.Show();

                if (CustomerMapper.CustomerExistsByID(txtCC_ClienteVenta.Text))
                {
                    labelCustomerIDUnique.Hide();
                    labelCustomerIDNotUnique.Show();
                    ccIsValid = false;
                }
                else
                {
                    labelCustomerIDUnique.Show();
                    labelCustomerIDNotUnique.Hide();
                    ccIsValid = true;
                    count_correct_fields++;
                }
            }
            else if (txtCC_ClienteVenta.Text.Length < Constants.LIMIT_CC_LENGTH && ccIsValid)
            {
                // Borro 1 char de la cc teniendo ya completos los 10 previamente
                ccIsValid = false;
                count_correct_fields--;
                siticoneHtmlLabel_cc_invalida.Show();
                siticoneHtmlLabel_cc_wrong_length.Show();
                siticoneHtmlLabel_cc_correct_length.Hide();
                siticoneHtmlLabel_cc_valida.Hide();
                labelCustomerIDUnique.Hide();
                labelCustomerIDNotUnique.Hide();
            }
            else
            {
                ccIsValid = false;
                labelCustomerIDUnique.Hide();
                labelCustomerIDNotUnique.Hide();
                siticoneHtmlLabel_cc_invalida.Show();
                siticoneHtmlLabel_cc_wrong_length.Show();
                siticoneHtmlLabel_cc_correct_length.Hide();
                siticoneHtmlLabel_cc_valida.Hide();
            }

            ButtonAniadirClienteVenta.Enabled = false;
            Customer aux = findCustomer();
            if (aux != null)
            {
                loadCustomerFields(aux);
                ButtonFinalizarVenta.Enabled = true;
            }
            else
            {
                if (ccIsValid && ValidationUtils.ValidarCedula(txtCC_ClienteVenta.Text)) ButtonAniadirClienteVenta.Enabled = true;
                loadCustomerFields(new Customer("0", "", "", "", "", ""));
                ButtonFinalizarVenta.Enabled = false;
            }

            validateFieldsCounter();

        }

        private Customer findCustomer()
        {
            Customer clienteEncontrado = null;
            foreach (Customer cliente in clientes)
            {
                if (cliente != null)
                {
                    if (cliente.customerID.Equals(txtCC_ClienteVenta.Text))
                    {
                        clienteEncontrado = cliente;
                    }
                }
            }
            return clienteEncontrado;

        }

        private void txtRecibidoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtRecibidoVenta.Text != string.Empty)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (Convert.ToDouble(txtRecibidoVenta.Text, CultureInfo.InvariantCulture) > Convert.ToDouble(txtTotalVenta.Text, CultureInfo.InvariantCulture))
                    {
                        double cash = Convert.ToDouble(txtRecibidoVenta.Text, CultureInfo.InvariantCulture);
                        double totalSale = Convert.ToDouble(txtTotalVenta.Text, CultureInfo.InvariantCulture);
                        txtVueltoVenta.Text = $"{(cash - totalSale):0.00}".Replace(',', '.');
                        txtRecibidoVenta.Text = $"{cash:0.00}".Replace(',', '.');
                    }
                    else
                    {
                        txtRecibidoVenta.Text = "";
                        MessageBox.Show("El valor recibido debe ser mayor al total de la venta!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Ingrese únicamente números o \".\" !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void txtVueltoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressDoubleValidation(e);
        }

        private void validateFieldsCounter()
        {
            ButtonConfirmarVenta.Enabled = count_correct_fields >= num_atributos;
        }
        public void setTotal(SiticoneDataGridView tablaVenta)
        {
            double total = 0;
            foreach (DataGridViewRow rowItem in siticoneDataGridView1.Rows)
            {
                if (rowItem.Cells[0].Value != null)
                {
                    total += Convert.ToDouble(rowItem.Cells[2].Value, CultureInfo.InvariantCulture);
                }
                else
                {
                    break;
                }
            }
            txtTotalVenta.Text = $"{total:0.00}".Replace(',', '.');

        }


        private void loadCustomerFields(Customer cliente)
        {
            txtNombre1Venta.Text = cliente.firstName;
            txtApellido1Venta.Text = cliente.firstLastName;
            txtDireccionVenta.Text = cliente.homeAddress;
            txtTelefVenta.Text = cliente.phoneNumber;
            txtCorreoVenta.Text = cliente.eMail;

        }

        private void txtApellido1Venta_TextChanged(object sender, EventArgs e)
        {

            if (txtApellido1Venta.Text.Length > 0 && !firsLastNameIsValid && editClientIsEnabled)
            {
                firsLastNameIsValid = true;
                count_correct_fields++;
            }
            else if (txtApellido1Venta.Text.Length == 0 && firsLastNameIsValid && editClientIsEnabled)
            {
                firsLastNameIsValid = false;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void txtDireccionVenta_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccionVenta.Text.Length > 0 && !addressIsValid && editClientIsEnabled)
            {
                addressIsValid = true;
            }
            else if (txtDireccionVenta.Text.Length == 0 && addressIsValid && editClientIsEnabled)
            {
                addressIsValid = false;
            }
        }

        private void txtTelefVenta_TextChanged(object sender, EventArgs e)
        {
            if ((txtTelefVenta.Text.Length == Constants.LIMIT_TELEF_LENGTH || txtTelefVenta.Text.Length == Constants.LIMIT_TELEF_LENGTH_MIN)
                && !telefIsValid
                && editClientIsEnabled)
            {
                siticoneHtmlLabel_wrong_length_telef.Hide();
                siticoneHtmlLabel_correct_length_telef.Show();

                if (ValidationUtils.IsValidPhoneNumber(txtTelefVenta.Text))
                {
                    labelValidPhoneNumber.Show();
                    labelInvalidPhoneNumber.Hide();
                    telefIsValid = true;
                }
                else
                {
                    labelValidPhoneNumber.Hide();
                    labelInvalidPhoneNumber.Show();
                    telefIsValid = false;
                }
            }
            else if ( telefIsValid && editClientIsEnabled)
            {
                telefIsValid = false;
                siticoneHtmlLabel_wrong_length_telef.Show();
                siticoneHtmlLabel_correct_length_telef.Hide();
                labelValidPhoneNumber.Hide();
                labelInvalidPhoneNumber.Show();
            }
            else if (editClientIsEnabled)
            {
                telefIsValid = false;
                siticoneHtmlLabel_wrong_length_telef.Show();
                siticoneHtmlLabel_correct_length_telef.Hide();
                labelValidPhoneNumber.Hide();
                labelInvalidPhoneNumber.Show();
            }
        }

        private void txtCorreoVenta_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUtils.IsValidEmail(txtCorreoVenta.Text) && !correoIsValid && editClientIsEnabled)
            {
                //El correo es válido
                siticoneHtmlLabel_wrong_email.Hide();
                siticoneHtmlLabel_correct_email.Show();
                correoIsValid = true;

            }
            else if (!ValidationUtils.IsValidEmail(txtCorreoVenta.Text) && correoIsValid && editClientIsEnabled)
            {
                // El correo es invalido pero fue valido anteriormente
                siticoneHtmlLabel_wrong_email.Show();
                siticoneHtmlLabel_correct_email.Hide();
                correoIsValid = false;
            }
        }

        private void txtNombre1Venta_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre1Venta.Text.Length > 0 && !firstNameIsValid && editClientIsEnabled)
            {
                firstNameIsValid = true;
                count_correct_fields++;
            }
            else if (txtNombre1Venta.Text.Length == 0 && firstNameIsValid && editClientIsEnabled)
            {
                firstNameIsValid = false;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox1.Checked)
            {
                txtCC_ClienteVenta.Enabled = false;
                txtCC_ClienteVenta.Text = "9999999999";
                siticoneHtmlLabel_cc_valida.Visible = false;
                siticoneHtmlLabel_cc_invalida.Visible = false;
                siticoneHtmlLabel_cc_wrong_length.Visible = false;
                siticoneHtmlLabel_cc_correct_length.Visible = false;
            }
            else
            {
                txtCC_ClienteVenta.Enabled = true;
                txtCC_ClienteVenta.Text = string.Empty;
                txtCC_ClienteVenta_TextChanged(null, null);
            }
        }
    }
}
