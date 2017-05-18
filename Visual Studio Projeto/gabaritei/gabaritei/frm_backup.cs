using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace gabaritei
{
    public partial class frm_backup : Form
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        string sql = " ";
        //string connectionString = "";
        string connectionStrig = "";


        public frm_backup()

        {
            InitializeComponent();


        
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //TESTE
            //TESTE
            //TESTE

            try
            {
                connectionStrig = "Data Source = " + textBox1.Text + "; User Id=" + textBox2.Text + "; Password=" + textBox3.Text + "";
                conn = new SqlConnection(connectionStrig);
                conn.Open();
                //sql = "EXEC sp_databases";
                sql = "SELECT * FROM sys.databases d WHERE  d.database_id>4";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                comboBox1.Items.Clear();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }
                reader.Dispose();
                conn.Close();
                conn.Dispose();

                textBox5.Enabled = !false;
                button1.Enabled = !true;
                button10.Enabled = !true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button2.Enabled = !false;
                button3.Enabled = true;
                comboBox1.Enabled = true;
                button6.Enabled = !true;
                button8.Enabled = true;
                {
                    MessageBox.Show("Please, select a DataBase");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //TESTE
            //TESTE
            //TESTE

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TESTE
            //TESTE
            //TESTE

            button10.Enabled = !false;
            button1.Enabled = !false;
            button2.Enabled = !true;
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox2.Enabled = true;
            button2.Enabled = true;
            comboBox1.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = !false;
            button3.Enabled = !true;
            textBox5.Enabled = !true;

            //TESTE
            //TESTE
            //TESTE
        }

        private void frm_backup_Load(object sender, EventArgs e)
        {
            //TESTE
            //TESTE
            //TESTE
            button2.Enabled = !true;
            button4.Enabled = !true;
            textBox5.Enabled = !true;
            button3.Enabled = false;
            comboBox1.Enabled = !true;
            button6.Enabled = false;
            button8.Enabled = false;

            //TESTE
            //TESTE
            //TESTE
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TESTE
            //TESTE
            //TESTE

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = dlg.SelectedPath;
                button4.Enabled = !false;
            }

            //TESTE
            //TESTE
            //TESTE
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //TESTE
            //TESTE
            //TESTE

            try
            {
                if (comboBox1.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Porfavor, Selecione um Banco de dados!");
                    return;
                }
                conn = new SqlConnection(connectionStrig);
                conn.Open();
                sql = "BACKUP DATABASE " + comboBox1.Text + " TO DISK= '" + textBox5.Text + "\\" + comboBox1.Text + "-" + DateTime.Now.Ticks.ToString() + ".bak'";
                //sql = "BACKUP DATABASE" + comboBox1.Text + " TO DISK= " + textBox4.Text + "\\" + comboBox1.Text + "-" + DateTime.Now.Ticks.ToString() + " .bak";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Backup da Base de dados feito com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //TESTE
            //TESTE
            //TESTE

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //TESTE
            //TESTE
            //TESTE

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = dlg.FileName;
            }

            //TESTE
            //TESTE
            //TESTE
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //TESTE
            //TESTE
            //TESTE


            try
            {
                if (comboBox1.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Porfavor, selecione um Banco de dados!");
                    return;
                }
                conn = new SqlConnection(connectionStrig);
                conn.Open();
                sql = "Alter DATABASE " + comboBox1.Text + " Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore DATABASE " + comboBox1.Text + " FROM DISK = '" + textBox5.Text + "' WITH REPLACE;";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Restauração do banco de dados feita com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //TESTE
            //TESTE
            //TESTE
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //TESTE
            //TESTE
            //TESTE

            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";

            //TESTE
            //TESTE
            //TESTE

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button3.Enabled = !true;
            button2.Enabled = !true;
            comboBox1.Enabled = !true;
            button2.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox5.Enabled = !true;
            button4.Enabled = !true;
            //TESTE
            //TESTE
            //TESTE


            //textBox1.Text = "SJC0417303W8-1";
            textBox2.Text = "sa";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";

            //TESTE
            //TESTE
            //TESTE
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        // PEGAR O NOME DE HOST DO COMPUTADOR
        public static string GetPC()//Nome do computador
        {
            string PcName = System.Net.Dns.GetHostName();
            return PcName;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // PEGAR O NOME DE HOST DO COMPUTADOR
            textBox1.Text = GetPC();
        }
    }
}
