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
    public partial class frm_cadastro_turmas : Form
    {
        public frm_cadastro_turmas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //(NOMEDOBANCODEDADOS) livroBindingSource.EndEdit();
            //(NOMEDOBANCODEDADOS) livroTableAdapter.Update((NOMEDOBANCODEDADOS) bibliotecaDataSet);
            //string v_codigo = txb_codigo.Text;
            //(NOMEDOBANCODEDADOS) livroTableAdapter.Fill((NOMEDOBANCODEDADOS) bibliotecaDataSet.livro);

            //// Faz a busca no banco, a coluna que for colocada (liv_cd)
            //int v_posicao = (NOMEDOBANCODEDADOS) livroBindingSource.Find("(COLUNADECODICODOBANCODEDADOS) liv_cd", txb_codigo.Text);
            ////
            //(NOMEDOBANCODEDADOS) livroBindingSource.Position = v_posicao;
            //habilitar_campos(true);
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //PARA SALVAR OS DADOS NO BANCO E LIMPAR
            //(COLOCAROBANCODEDADOS) livroBindingSource.EndEdit();
            //(COLOCAROBANCODEDADOS) livroTableAdapter.Update((COLOCARBANCODEDADOS)bibliotecaDataSet);
            //(COLOCAROBANCODEDADOS) livroTableAdapter.Fill((COLOCARBANCODEDADOS)bibliotecaDataSet.livro);
           // habilitar_campos(false);

            //PARA LIMPAR TODOS OS CAMPOS APÓS SALVAR NO BANCO DE CADOS
            // (NOMEDOBANCODEDADOS) livroBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Para travar os campos, foi somente para teste
            //NAO HABILITAR
            //this.Visible = false;

            //CANCELAR
            this.Visible = false;
            //habilitar_campos(true);
            // (NOMEDOBANCODEDADOS).CancelEdit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //habilitar_campos(false);
            // (NOMEDOBANCODEDADOS) livroBindingSource.AddNew();
        }
    }
}
