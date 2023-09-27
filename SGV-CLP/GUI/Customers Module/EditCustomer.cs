using SGV_CLP.Classes;
using SGV_CLP.Classes.Customers_Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_CLP.GUI.Customers_Module
{
    public partial class EditCustomer : Form
    {
        string customerID;

        int countCorrectFields, fieldsNumber;

        bool phoneNumberIsValid, homeAddressIsValid, eMailIsValid;

        public EditCustomer(String customerID)
        {
            InitializeComponent();

            this.customerID = customerID;

            countCorrectFields = 0;
            fieldsNumber = 0;

            phoneNumberIsValid = false;
            homeAddressIsValid = false;
            eMailIsValid = false;

            tbPhoneNumber.Text = CustomerMapper.GetCustomerField(customerID, "phone");
            tbHomeAddress.Text = CustomerMapper.GetCustomerField(customerID, "address");
            tbEMail.Text = CustomerMapper.GetCustomerField(customerID, "email");

            tbPhoneNumber.SelectionStart = tbPhoneNumber.Text.Length;
            tbHomeAddress.SelectionStart = tbHomeAddress.Text.Length;
            tbEMail.SelectionStart = tbEMail.Text.Length;

            tbPhoneNumber.MaxLength = Constants.LIMIT_TELEF_LENGTH;
            tbHomeAddress.MaxLength = Constants.LIMIT_DIRECCION_LENGTH;
            tbEMail.MaxLength = Constants.LIMIT_CORREO_LENGTH;

            labelCorrectPhoneNumberLength.Hide();
            labelValidPhoneNumber.Hide();
            labelCorrectEMail.Hide();

            buttonEditCustomer.Enabled = false;
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            CustomerMapper.EditCustomer(customerID, tbHomeAddress.Text, tbEMail.Text, tbPhoneNumber.Text);
            SystemSounds.Beep.Play();
            MessageBox.Show("Cliente editado con éxito", "Editar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }
        private void ValidateFieldsCounter()
        {
            buttonEditCustomer.Enabled = countCorrectFields >= fieldsNumber;
        }

        private void TbHomeAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ';' && e.KeyChar != ' ' && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras, números, \";\" o \".\"!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void tbEMail_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUtils.IsValidEmail(tbEMail.Text) && !eMailIsValid)
            {
                //El correo es válido
                labelWrongEMail.Hide();
                labelCorrectEMail.Show();
                countCorrectFields++;
                eMailIsValid = true;

            }
            else if (!ValidationUtils.IsValidEmail(tbEMail.Text) && eMailIsValid)
            {
                // El correo es invalido pero fue valido anteriormente
                labelWrongEMail.Show();
                labelCorrectEMail.Hide();
                countCorrectFields--;
                eMailIsValid = false;
            }
            ValidateFieldsCounter();
        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if ((tbPhoneNumber.Text.Length == Constants.LIMIT_TELEF_LENGTH || tbPhoneNumber.Text.Length == Constants.LIMIT_TELEF_LENGTH_MIN) && !phoneNumberIsValid)
            {
                labelWrongPhoneNumberLength.Hide();
                labelCorrectPhoneNumberLength.Show();


                if (ValidationUtils.IsValidPhoneNumber(tbPhoneNumber.Text))
                {
                    labelValidPhoneNumber.Show();
                    labelInvalidPhoneNumber.Hide();
                    phoneNumberIsValid = true;
                    countCorrectFields++;
                }
                else
                {
                    labelValidPhoneNumber.Hide();
                    labelInvalidPhoneNumber.Show();
                    phoneNumberIsValid = false;
                }
            }
            else if (phoneNumberIsValid)
            {
                labelValidPhoneNumber.Hide();
                labelInvalidPhoneNumber.Show();
                labelWrongPhoneNumberLength.Show();
                labelCorrectPhoneNumberLength.Hide();
                phoneNumberIsValid = false;
                countCorrectFields--;
            }
            else
            {
                labelValidPhoneNumber.Hide();
                labelInvalidPhoneNumber.Show();
                labelWrongPhoneNumberLength.Show();
                labelCorrectPhoneNumberLength.Hide();
                phoneNumberIsValid = false;
            }
            ValidateFieldsCounter();
        }

        private void tbHomeAddress_TextChanged(object sender, EventArgs e)
        {
            if (tbHomeAddress.Text.Length > 0 && !homeAddressIsValid)
            {
                homeAddressIsValid = true;
                countCorrectFields++;
            }
            else if (tbHomeAddress.Text.Length == 0 && homeAddressIsValid)
            {
                homeAddressIsValid = false;
                countCorrectFields--;
            }
            ValidateFieldsCounter();
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressDigitsValidation(e);
        }

        private void tbEMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressEmailValidation(e);
        }

    }
}
