using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Collections;

namespace gabaritei
{
    class classe_PUBLICA
    {

        //private void desabilitar_campos(Boolean v_campos);

        //gb_DadosPessoais_cad_fun.Enabled = !v_opcao;
        //btn_novo.Enabled = v_opcao;
        //btn_alterar.Enabled = v_opcao;
        //btn_salvar.Enabled = !v_opcao;
        //btn_cancelar.Enabled = !v_opcao;
        //btn_excluir.Enabled = v_opcao;
        //btn_primeiro.Enabled = v_opcao;
        //btn_anterior.Enabled = v_opcao;
        //btn_proximo.Enabled = v_opcao;
        //btn_Ultimo.Enabled = v_opcao;

        private static Boolean _logout;
        public static Boolean v_logout
        {
            get { return _logout; }
            set { _logout = value; }
        }

        //--------------------------------------------
         
        //LOGIN
        private static string _usuario;
        public static string v_usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public static string v_alunocd;

        //DADOS ALUNOS 2
        private static string _usuario2;
        public static string v_usuario2
        {
            get { return _usuario2; }
            set { _usuario2 = value; }
        }

        public static string v_alunocd2;

        //DADOS ALUNOS 3
        private static string _usuario3;
        public static string v_usuario3
        {
            get { return _usuario3; }
            set { _usuario3 = value; }
        }

        public static string v_alunocd3;

        //DADOS ALUNOS 4
        private static string _usuario4;
        public static string v_usuario4
        {
            get { return _usuario4; }
            set { _usuario4 = value; }
        }

        public static string v_alunocd4;
        

        //--------------------------------------------

        //CADASTRO DE FUNCIONARIO
        private static string _fun;
        public static string v_fun
        {
            get { return _fun; }
            set { _fun = value; }
        }

        public static string v_funcd;

        //--------------------------------------------

        //ABERTURA DE TURMAS
        private static string _aturmas;
        public static string v_aturmas
        {
            get { return _aturmas; }
            set { _aturmas = value; }
        }

        public static string v_turmascd;

        //TURMAS
        private static string _bturmas;
        public static string v_bturmas
        {
            get { return _bturmas; }
            set { _bturmas = value; }
        }

        public static string v_bturmascd;

        //--------------------------------------------

        //CADASTRO ADICAO MATERIAS
        private static string _acmateria;
        public static string v_acmateria
        {
            get { return _acmateria; }
            set { _acmateria = value; }
        }

        public static string v_acmateriacd;

        //CADASTRO ADICAO MATERIAS2
        private static string _acmateria2;
        public static string v_acmateria2
        {
            get { return _acmateria2; }
            set { _acmateria2 = value; }
        }

        public static string v_acmateriacd2;

        //CADASTRO ADICAO MATERIAS3
        private static string _acmateria3;
        public static string v_acmateria3
        {
            get { return _acmateria3; }
            set { _acmateria3 = value; }
        }

        public static string v_acmateriacd3;


        //--------------------------------------------

        //CADASTRO MATERIAS
        private static string _cmateria;
        public static string v_cmateria
        {
            get { return _cmateria; }
            set { _cmateria = value; }
        }

        public static string v_cmateriacd;

        //--------------------------------------------

        //ABERTURA TURMAS
        private static string _abturma;
        public static string v_abturma
        {
            get { return _abturma; }
            set { _abturma = value; }
        }

        public static string v_abturmacd;

        //--------------------------------------------

        //RESPONSAVEIS
        private static string _respon;
        public static string v_respon
        {
            get { return _respon; }
            set { _respon = value; }
        }

        public static string v_responcd;

        //--------------------------------------------

        //CADASTRO ALUNO
        private static string _alut;
        public static string v_alut
        {
            get { return _alut; }
            set { _alut = value; }
        }

        public static string v_alutcd;

        //--------------------------------------------

        //LANÇAMENTO DE NOTAS
        private static string _lnotas;
        public static string v_lnotas
        {
            get { return _lnotas; }
            set { _lnotas = value; }
        }

        public static string v_lnotascd;

        //--------------------------------------------

        //CADASTRODE LOGIN FUNCIONARIO
        private static string _cafun;
        public static string v_cafun
        {
            get { return _cafun; }
            set { _cafun = value; }
        }

        public static string v_cafuncd;

        //--------------------------------------------
        // DATA GRID VIEW -  RESPONSAVEL  

        private static string _dvresp;
        public static string v_dvresp
        {
            get { return _dvresp; }
            set { _dvresp = value; }
        }

        public static string v_dvrespcd;
        

        //--------------------------------------------



        //NOVO RESPONSAVEL
        private static string _respcont;
        public static string v_respcont
        {
            get { return _respcont; }
            set { _respcont = value; }
        }

        public static string v_respcontcd;

        //--------------------------------------------

        //CADASTRO TIPO RESPOSNAVEL
        private static string _tresp;
        public static string v_tresp
        {
            get { return _tresp; }
            set { _tresp = value; }
        }

        public static string v_trespcd;

        //--------------------------------------------

        //CADASTRO TELEFONE
        private static string _cadtel;
        public static string v_cadtel
        {
            get { return _cadtel; }
            set { _cadtel = value; }
        }

        public static string v_cadtelcd;

        //--------------------------------------------

        //CADASTRO DE FUNCIONARIO
        private static string _cargo;
        public static string v_cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        public static string v_cargocd;

        //--------------------------------------------


        //CIDADE
        private static string _cidade;
        public static string v_cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        public static string v_cidadecd;

        //--------------------------------------------


        private static string _tipouser;
        public static string v_tipouser
        {
            get { return _tipouser; }
            set { _tipouser = value; }
        }

        public static string v_tipousercd;

        //--------------------------------------------


        ////TESTE VALIDAÇÃO
        //private void validarNome(textBox textBox, ErrorProvider1 errorProvider)
        //{
        //    if (!String.IsNullOrWhiteSpace(textBox.Text))
        //    {
        //        errorProvider.SetError(textBox, "");
        //    }
        //    else
        //    {
        //        errorProvider.setError(textBox, "nome invalido.");
        //    }


        //}

        //private void validarIdade(TextBox textBox, ErrorProvider errorProvider)
        //{
        //    try
        //    {
        //        int idade = Convert.ToInt32(textBox.Text);
        //        if (idade <=0 || idade > 125)
        //        {
        //            throw new Exception();
        //        }

        //        errorProvider.SetError(textBox, "");

        //    }

        //    catch (Exception e)
        //    {
        //        errorProvider.setError(textBox, "idade invalida.");
        //    }
        //}
        ////FIM TESTE VALIDAÇÃO


        ////FIM TESTE VALIDAÇÃO
        //public partial class Obrigatorio : Component, IExtenderProvider
        //public void SetObrigatorio(Control lControl, bool bValue)
        //{
        //    EnsurePropertiesExists(lControl).Obrigatorio = bValue;
        //}

        //public bool GetObrigatorio(Control lControl)
        //{
        //    return EnsurePropertiesExists(lControl).Obrigatorio;
        //}
        ////FIM TESTE VALIDAÇÃO

    }

}

