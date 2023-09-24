using System;
using System.Windows.Forms;

namespace CG.Tela_Inicial.Relatorios
{
    public partial class frm_log : Form
    {
        public frm_log()
        {
            InitializeComponent();
        }

        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();

        private void Frm_log_Load(object sender, EventArgs e)
        {
            dadosql = string.Format("SELECT * FROM `log` ORDER BY `cod` DESC");
            dgv_log.DataSource = mConn.LeituraLinha(dadosql);
        }

        private void dgv_log_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
