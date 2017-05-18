using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using System.IO;
namespace gabaritei
{
    public partial class frm_utilitarios : Form
    {
        public frm_utilitarios()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void chb_princ_alun_indice_CheckedChanged(object sender, EventArgs e)
        {
            //crt_princ_alun_graf.Visible = chb_princ_alun_indice.Checked;

            ////o Ponto de exclamação fez com que executasse o inverso
            //groupBox3.Visible = !chb_princ_alun_indice.Checked;
        }

        private void button20_Click(object sender, EventArgs e)
        {



            System.Diagnostics.Process.Start("msaccess");
            //  System.Diagnostics.Process.Start("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office 2013.exe"); 





        }

        private void button1_Click(object sender, EventArgs e)
        {

            string app = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office 2013\Excel 2013.lnk";
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string app = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office 2013\Excel 2013.lnk";
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string app = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office 2013\Word 2013.lnk";
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string app = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office 2013\PowerPoint 2013.lnk";
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);

        }

        private void frm_utilitarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.cargo' table. You can move, or remove it, as needed.
            this.cargoTableAdapter.Fill(this.GABARITEIDataSet.cargo);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.materia' table. You can move, or remove it, as needed.
            this.materiaTableAdapter.Fill(this.GABARITEIDataSet.materia);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.GABARITEIDataSet.funcionario);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.GABARITEIDataSet.aluno);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.turma' table. You can move, or remove it, as needed.
            this.turmaTableAdapter.Fill(this.GABARITEIDataSet.turma);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.aluno' table. You can move, or remove it, as needed.



            turmaBindingSource.MoveLast();
            alunoBindingSource.MoveLast();
            funcionarioBindingSource.MoveLast();
            materiaBindingSource.MoveLast();
            cargoBindingSource.MoveLast();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //string app = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office 2013\Excel 2013.lnk";
            //System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);

            System.Diagnostics.Process.Start("excel");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string app = @"C:\Windows\System32\calc.exe";
            //System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);

            System.Diagnostics.Process.Start("calc");

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //string app = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office 2013\Word 2013.lnk";
            //System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);

            System.Diagnostics.Process.Start("winword");

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //string app = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office 2013\PowerPoint 2013.lnk";
            //System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);

            System.Diagnostics.Process.Start("powerpnt");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string app = @"C:\Windows\System32\notepad.exe";
            //System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);

            System.Diagnostics.Process.Start("notepad");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //string app = @"C:\Windows\System32\SnippingTool.exe";
            //System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);

            //System.Diagnostics.Process.Start("snippingtool");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //string app = @"C:\Program Files\Internet Explorer\iexplore.exe";
            string param = "http://google.com.br";
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(/*app,*/ param);

        }

        private void txb_princ_alun_estud_matric_TextChanged(object sender, EventArgs e)
        {

            ////Pega o primeiro código (chave primaria) 
            //alunoTableAdapter.Fill(GABARITEIDataSet.aluno);

            ////Move para o ultimo código
            //alunoBindingSource.MoveLast();
        }

        private void txb_princ_alun_tot_alunos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
