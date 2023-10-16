using Org.BouncyCastle.Asn1.Crmf;
using System.Reflection;

namespace CG.Util
{
    public class UtilForms
    {
        public static void StatusControles(Control container, bool status)
        {
            Color cor = status ? Color.White : Color.Gray;

            foreach (Control control in container.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    label.ForeColor = cor;
                }

                if (control is TextBox || control is ComboBox)
                {
                    control.Enabled = status;
                }
                else if (control.HasChildren)
                {
                    StatusControles(control, status);
                }
            }
        }

        public static void StatusItensMenu(ToolStripItemCollection menuStrip, bool status)
        {
            foreach (ToolStripItem menuItem in menuStrip)
            {
                if(menuItem.Name == "tsm_Salvar" || menuItem.Name == "tsm_Cancelar")
                {
                    menuItem.Enabled = !status;
                }
                else
                {
                    menuItem.Enabled = status;
                }

                if (menuItem.Name == "tsm_Usuario" || menuItem.Name == "txt_Usuario")
                {
                    menuItem.Enabled = false;
                }
            }
        }

        public static void CarregamentoDeFormsDesabilitandoCancelareSalvar(ToolStripItemCollection menuStrip)
        {
            foreach (ToolStripItem menuItem in menuStrip)
            {
                if (menuItem.Name == "tsm_Salvar" || menuItem.Name == "tsm_Cancelar")
                {
                    menuItem.Enabled = false;
                }             

                if (menuItem.Name == "tsm_Usuario" || menuItem.Name == "txt_Usuario")
                {
                    menuItem.Enabled = false;
                }
            }
        }

        public static T GerarObjeto<T>(Control container) where T : new()
        {
            T objeto = new T();

            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox && control.Name.StartsWith("txt_"))
                {
                    string propertyName = control.Name.Substring(4); // Remove o prefixo "txt_"
                    PropertyInfo propertyInfo = typeof(T).GetProperty(propertyName);
                    if (propertyInfo != null)
                    {
                        string valor = textBox.Text;
                        Type propertyType = propertyInfo.PropertyType;

                        if (propertyType == typeof(string))
                        {
                            propertyInfo.SetValue(objeto, valor);
                        }
                        else if (propertyType == typeof(int))
                        {
                            if (int.TryParse(valor, out int intValue))
                            {
                                propertyInfo.SetValue(objeto, intValue);
                            }
                        }
                        // Adicione tratamentos para outros tipos de dados, como double, DateTime, etc.
                    }
                }
                else if (control is ComboBox comboBox && control.Name.StartsWith("cbx_"))
                {
                    string propertyName = control.Name.Substring(4); // Remove o prefixo "cbx_"
                    PropertyInfo propertyInfo = typeof(T).GetProperty(propertyName);
                    if (propertyInfo != null)
                    {
                        string valor = comboBox.Text;
                        Type propertyType = propertyInfo.PropertyType;

                        if (propertyType == typeof(string))
                        {
                            propertyInfo.SetValue(objeto, valor);
                        }
                        else if (propertyType == typeof(int))
                        {
                            if (int.TryParse(valor, out int intValue))
                            {
                                propertyInfo.SetValue(objeto, intValue);
                            }
                        }
                        // Adicione tratamentos para outros tipos de dados, como double, DateTime, etc.
                    }
                }
            }

            return objeto;
        }
        public static void PreencherCampos<T>(Control container, T objeto)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox && control.Name.StartsWith("txt_"))
                {
                    string propertyName = control.Name.Substring(4); // Remove o prefixo "txt_"
                    PropertyInfo propertyInfo = objeto.GetType().GetProperty(propertyName);
                    if (propertyInfo != null)
                    {
                        string valor = propertyInfo.GetValue(objeto)?.ToString();
                        textBox.Text = valor;
                    }
                }
                else if (control is ComboBox comboBox && control.Name.StartsWith("cbx_"))
                {
                    string propertyName = control.Name.Substring(4); // Remove o prefixo "cbx_"
                    PropertyInfo propertyInfo = objeto.GetType().GetProperty(propertyName);
                    if (propertyInfo != null)
                    {
                        string valor = propertyInfo.GetValue(objeto)?.ToString();
                        comboBox.Text = valor;
                    }
                }
            }
        }
    }
}
