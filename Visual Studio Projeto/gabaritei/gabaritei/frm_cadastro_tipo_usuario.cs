using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gabaritei
{
    public partial class frm_cadastro_tipo_usuario : Form
    {
        public frm_cadastro_tipo_usuario()
        {
            InitializeComponent();
        }

        private void frm_cadastro_tipo_usuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gABARITEIDataSet.tipo_de_user' table. You can move, or remove it, as needed.
            this.tipo_de_userTableAdapter.Fill(this.gABARITEIDataSet.tipo_de_user);

            if (classe_PUBLICA.v_tipousercd == "0")
            {
                tipodeuserBindingSource.AddNew();


            }
            else
            {

                tipodeuserBindingSource.Filter = "tipo_user_cd  = " + classe_PUBLICA.v_tipousercd;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipodeuserBindingSource.EndEdit();
            tipo_de_userTableAdapter.Update(gABARITEIDataSet);
            tipo_de_userTableAdapter.Fill(gABARITEIDataSet.tipo_de_user);
        }
    }
}
