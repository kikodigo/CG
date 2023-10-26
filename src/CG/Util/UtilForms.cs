using CG.Domain.Enum;
using CpfCnpjLibrary;
using System.Reflection;

namespace CG.Util
{
    public class UtilForms
    {
        /// <summary>
        /// Metodo serve para bloquear e desbloquear campos de um formulario
        /// </summary>
        /// <param name="container">Informar this para passar o formulario</param>
        /// <param name="status">true para desbloquear, false para bloquear</param>
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
                    if (control.Name == "txt_Id")
                    {
                        control.Enabled = false;
                    }
                    else
                    {
                        control.Enabled = status;
                    }
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
                if (menuItem.Name == "tsm_Salvar" || menuItem.Name == "tsm_Cancelar")
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
                        else if (propertyType == typeof(StatusEnum))
                        {
                            if (Enum.TryParse(valor, out StatusEnum statusEnum))
                            {
                                propertyInfo.SetValue(objeto, statusEnum);
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

        public static void LimparCampos(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear(); // Limpa o conteúdo do TextBox
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1; // Remove a seleção do ComboBox
                }
                else if (control.HasChildren)
                {
                    // Se o controle tiver controles filhos (por exemplo, um painel), chame o método de limpeza recursivamente
                    LimparCampos(control);
                }
            }
        }

        /// <summary>
        /// Valida se o documento é valido
        /// </summary>
        /// <param name="doc">Qual documento a ser validado</param>
        /// <returns>bool, true se esta valido, false se for invalido</returns>
        public static bool ValidarDoc(string doc)
        {
            if (doc.Length == 14)
            {
                return Cnpj.Validar(doc);
            }
            else
            {
                return Cpf.Validar(doc);
            }
        }
    }
}
