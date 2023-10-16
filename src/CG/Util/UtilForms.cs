namespace CG.Util
{
    public class UtilForms
    {
        public void StatusControles(Control container, bool status)
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

        public void StatusItensMenu(ToolStripItemCollection menuStrip, bool status)
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

        public void CarregamentoDeFormsDesabilidantoCancelareSalvar(ToolStripItemCollection menuStrip)
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
        
    }
}
