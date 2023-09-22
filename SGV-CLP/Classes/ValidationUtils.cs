using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public static class ValidationUtils
    {
        public static bool IsValidEmail(string email)
        {
            // Define la expresión regular para validar un correo electrónico
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Crea un objeto Regex con la expresión regular
            Regex regex = new Regex(pattern);

            // Valida el correo electrónico
            return regex.IsMatch(email);
        }

        public static bool IsValidDouble(string doubleNumber)
        {
            // Define la expresión regular para validar un double con dos decinales como máximo
            string pattern = @"^\d+(\.\d{1,2})?$";

            // Crea un objeto Regex con la expresión regular
            Regex regex = new Regex(pattern);

            // Valida el double
            return regex.IsMatch(doubleNumber);
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Define la expresión regular para validar un número de celular
            string pattern = @"^(09[0-9]{8}|[1-9][0-9]{6})$";

            // Crea un objeto Regex con la expresión regular
            Regex regex = new Regex(pattern);

            // Valida el double
            return regex.IsMatch(phoneNumber);
        }

        public static bool IsValidPath(string path)
        {
            // Define la expresión regular para validar un path
            string pattern = @"^(?:[a-zA-Z]:|\\\\[a-zA-Z0-9_.$-]+\\[a-zA-Z0-9_.$-]+)(?:\\(?:[^\\/:*?""<>|]+))*\\?$";

            // Crea un objeto Regex con la expresión regular
            Regex regex = new Regex(pattern);

            // Valida el path
            return regex.IsMatch(path);
        }

        public static bool ValidarPvpMayorIgualPe(string pvp, string pe)
        {
            bool isValid = false;
            if (IsValidDouble(pvp) && IsValidDouble(pe) && pe != String.Empty && pvp != String.Empty && (Convert.ToDouble(pvp, CultureInfo.InvariantCulture) >= Convert.ToDouble(pe, CultureInfo.InvariantCulture)))
            {
                isValid = true;
            }
            return isValid;
        }

        public static bool ValidarCedula(string cedula)
        {
            // Verificar que la cédula tenga 10 dígitos
            if (cedula.Length != 10)
            {
                return false;
            }

            int tercerDigito = int.Parse(cedula[2].ToString());

            // Verificar que el tercer dígito sea entre 0 y 5
            if (tercerDigito < 0 || tercerDigito > 5)
            {
                return false;
            }

            // Verificar el último dígito de la cédula
            int ultimoDigito = int.Parse(cedula[9].ToString());

            int suma = 0;

            for (int i = 0; i < 9; i++)
            {
                int digito = int.Parse(cedula[i].ToString());

                if (i % 2 == 0)
                {
                    digito *= 2;

                    if (digito > 9)
                    {
                        digito -= 9;
                    }
                }

                suma += digito;
            }

            int digitoVerificador = 10 - (suma % 10);

            if (digitoVerificador == 10)
            {
                digitoVerificador = 0;
            }

            return ultimoDigito == digitoVerificador;
        }

        public static void keyPressEmailValidation(KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '_' && e.KeyChar != '@' && e.KeyChar != '.')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras o números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        public static void keyPressLetterValidation(KeyPressEventArgs e) 
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        public static void keyPressAddressValidation(KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ';' && e.KeyChar != ' ' && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras, números, \" \", \";\" o \".\"!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        public static void keyPressDigitsValidation(KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        public static void keyPressDoubleValidation(KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números o \".\" !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
