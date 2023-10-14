namespace CG.Util
{
    public class InitForms
    {
        public void HabilitarControles(Control container, bool habilitar)
        {
            Color cor = habilitar ? Color.White : Color.Gray;

            foreach (Control control in container.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    label.ForeColor = cor;
                }

                if (control is TextBox || control is ComboBox)
                {
                    control.Enabled = habilitar;
                }
                else if (control.HasChildren)
                {
                    HabilitarControles(control, habilitar);
                }
            }
        }
        public void HabilitarItensMenu(ToolStripItemCollection menuStrip, bool habilitar)
        {
            foreach (ToolStripItem menuItem in menuStrip)
            {
                if(menuItem.Name == "tsm_Salvar" || menuItem.Name == "tsm_Cancelar")
                {
                    menuItem.Enabled = !habilitar;
                }
                else
                {
                    menuItem.Enabled = habilitar;
                }

                if (menuItem.Name == "tsm_Usuario" || menuItem.Name == "txt_Usuario")
                {
                    menuItem.Enabled = false;
                }
            }
        }
    }
}
