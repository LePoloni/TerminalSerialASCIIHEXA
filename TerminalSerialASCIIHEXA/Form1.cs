using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;  //Incluído manualmente para uso de porta serial
//somente assim é possível saber as portas COM
//disponíveis
using System.Media;

//Link Convertendo byte[] para string e vice-versa
//http://www.codigofonte.net/dicas/csharp/550_convertendo-byte-para-string-e-viceversa
//Link byte[] Array to Hex String
//http://social.msdn.microsoft.com/Forums/en-US/csharpgeneral/thread/3928b8cb-3703-4672-8ccd-33718148d1e3/
//Link Convert Integer or Hexadecimal value to unicode point
//https://stackoverflow.com/questions/23150832/convert-integer-or-hexadecimal-value-to-unicode-point

namespace WinTeste
{
    public partial class Form1 : Form
    {
        static int qual = 0; //Utilizado no pulling automático

        public Form1()
        {
            InitializeComponent();
            CarregaComPort();
            CarregaBaudRate();
        }
        //Lista as portas seriais disponíveis
        public void CarregaComPort()
        {
            #region "carrega PORTA COM "                    //Apenas define uma região para code foldind
            String[] ListCom = SerialPort.GetPortNames();   //Retorna todas as portas COM disponíveis do computador
            int x = 0;
            for (int i = 0; i < ListCom.Length; i++)        //Popular o ComboBox
            {
                cbPorta.Items.Add(ListCom[i]);
                x = i;
            }
            if (ListCom.Length > 0)
            {
                cbPorta.SelectedIndex = x;
            }
            #endregion
        }
        //Lista as opções de baudrate
        public void CarregaBaudRate()
        {
            Int32[] BaudRateValores ={ 
                                     100,300,600,1200,2400,4800,9600,14400,19200,
                                     38400,56000,57600,115200,128000,256000
                                     };

            for (int i = 0; i < BaudRateValores.Length; i++)
            {
                cbBaudRate.Items.Add(BaudRateValores[i].ToString());
            }
            cbBaudRate.SelectedIndex = 6; //9600bps
        }

        private void bConectar_Click(object sender, EventArgs e)
        {

            try
            {
                if (bConectar.Text == "Conectar")
                {
                    SerialPort1.PortName = cbPorta.Text;
                    SerialPort1.BaudRate = int.Parse(cbBaudRate.Text);
                    SerialPort1.Open(); //Abre uma conexão serial nova

                    if (SerialPort1.IsOpen) //Se a conexão está aberta...
                    {
                        bConectar.Text = "Desconectar";
                        if ((tbEnviar.Text == "<Conecte antes de enviar>") || (tbEnviar.Text == "ERRO ao conectar!!!"))
                        {
                            tbEnviar.Clear();
                            tbEnviarH.Clear();
                        }
                        bEnviar.Enabled = true;
                        bEnviarH.Enabled = true;
                        cbPorta.Enabled = false;
                        cbBaudRate.Enabled = false;
                        //Trata botões Serial Mensagem
                        bT1.Enabled = true;
                        bT2.Enabled = true;
                        bT3.Enabled = true;
                        bT4.Enabled = true;
                        //Trata text boxes Serial Mensagem
                        if (tbT1.Text == "<Conecte antes de enviar>")
                        {
                            tbT1.Clear();
                            tbT2.Clear();
                            tbT3.Clear();
                            tbT4.Clear();
                        }
                        SystemSounds.Exclamation.Play();
                        tbEnviar.Focus();
                    }
                }
                else
                {
                    SerialPort1.Close();
                    bConectar.Text = "Conectar";
                    //tbEnviar.Text = "<Conecte antes de enviar>";
                    //tbEnviarH.Text = "<Conecte antes de enviar>";
                    bEnviar.Enabled = false;
                    bEnviarH.Enabled = false;
                    cbPorta.Enabled = true;
                    cbBaudRate.Enabled = true;
                    //Trata botões Serial Mensagem
                    bT1.Enabled = false;
                    bT2.Enabled = false;
                    bT3.Enabled = false;
                    bT4.Enabled = false;
                    //Trata text boxes Serial Mensagem
                    //tbT1.Text = "<Conecte antes de enviar>";
                    //tbT2.Text = "<Conecte antes de enviar>";
                    //tbT3.Text = "<Conecte antes de enviar>";
                    //tbT4.Text = "<Conecte antes de enviar>";

                    SystemSounds.Asterisk.Play();
                }
            }
            catch (Exception)
            { tbEnviar.Text = "ERRO ao conectar!!!"; }

        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            //Cria inteiro para controle de bytes extras
            int extra = 0;
            if (cbCR.Checked) extra++;  //Adiciona um caractere extra
            if (cbLF.Checked) extra++;  //Adiciona um caractere extra
            //Cria vetores com tamanho proporcional a string a ser enviada
            string EnviarS = tbEnviar.Text;
            byte[] EnviarB = new byte[EnviarS.Length + extra];
            char[] EnviarC = new char[EnviarS.Length];
            //Converte de string -> vetor de chars -> vetor de bytes
            for (int i = 0; i < EnviarS.Length; i++)
            {
                EnviarC[i] = Convert.ToChar(EnviarS.Substring(i, 1));
                EnviarB[i] = Convert.ToByte(EnviarC[i]);
            }
            //Testa a presença de terminadores (Carrier return e Line feed)
            if (cbCR.Checked && cbLF.Checked)
            {
                EnviarB[EnviarB.Length - 2] = 0x0D;
                EnviarB[EnviarB.Length - 1] = 0x0A;
            }
            else if (cbCR.Checked)
            {
                EnviarB[EnviarB.Length - 1] = 0x0D;
            }
            else if (cbLF.Checked)
            {
                EnviarB[EnviarB.Length - 1] = 0x0A;
            }
            //Para mostrar em hexa
            //StringBuilder sb = new StringBuilder(EnviarS.Length * 3);//dois cracteres + um espaço
            //for (int i = 0; i < EnviarS.Length; i++)
            //{
            //    sb.AppendFormat("{0:x2} ", EnviarB[i]);
            //}
            //tbEnviarH.Text = sb.ToString();

            //Envia string pela serial
            //SerialPort1.Write(tbEnviar.Text);
            //Envia pacote de bytes pela serial
            SerialPort1.Write(EnviarB, 0, EnviarB.Length);
            //Limpa a caixa de texto
            if (cbAutoLimpa.Checked)
                tbEnviar.Clear();
            //Chama funções de atualização de estado
            Enviado(EnviarB);
        }

        private void bEnviarH_Click(object sender, EventArgs e)
        {
            //Cria inteiro para controle de bytes extras
            int extra = 0;
            if (cbCR.Checked) extra++;  //Adiciona um caractere extra
            if (cbLF.Checked) extra++;  //Adiciona um caractere extra
            //Cria vetores com tamanho proporcional a string a ser enviada
            string EnviarH = tbEnviarH.Text;
            byte[] EnviarB = new byte[EnviarH.Length / 2 + extra];
            string converte;
            //Teste a quantidade de caractres na string hexadecimal
            if (EnviarH.Length % 2 == 0)    //Para: OK
            {
                try
                {
                    //Converte de string hexa -> vetor de bytes
                    for (int i = 0; i < EnviarH.Length; i += 2)
                    {
                        converte = EnviarH.Substring(i, 2);
                        EnviarB[i / 2] = Convert.ToByte(converte, 16);  //Converte string hexadecimal para byte
                    }
                    //Testa a presença de terminadores (Carrier return e Line feed)
                    if (cbCR.Checked && cbLF.Checked)
                    {
                        EnviarB[EnviarB.Length - 2] = 0x0D;
                        EnviarB[EnviarB.Length - 1] = 0x0A;
                    }
                    else if (cbCR.Checked)
                    {
                        EnviarB[EnviarB.Length - 1] = 0x0D;
                    }
                    else if (cbLF.Checked)
                    {
                        EnviarB[EnviarB.Length - 1] = 0x0A;
                    }
                    //Envia pacote de bytes
                    SerialPort1.Write(EnviarB, 0, EnviarB.Length);
                    //Limpa a caixa de texto
                    if (cbAutoLimpa.Checked)
                        tbEnviarH.Clear();
                    //Chama funções de atualização de estado
                    Enviado(EnviarB);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "ERRO"); }
            }
            else    //Ímpar: ERRO
            { MessageBox.Show("Falta um nibble!", "ERRO"); }
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //string Texto = SerialPort1.ReadExisting();    //Lê dados no buffer da serial
            int[] RX = new int[200];
            //Esse loop cria uma espécie de timeout de recepção, evita quebra de pacotes.
            //Assim após recebido o primeiro byte pelo comando anterior,
            //passa algum tempo tentando receber outros bytes.
            string Texto = "";
            int j = 0;
            for (int i = 0; i < 10000; i++)
            {
                if (SerialPort1.BytesToRead > 0)
                {
                    //Texto += SerialPort1.ReadExisting();  //Dessa forma, ocorre erro na representação dos códigos >7F, todos são lidos como 3F
                    RX[j] = SerialPort1.ReadByte();
                    //Texto += (char.ConvertFromUtf32(RX[j++]).ToString()); //Aceita 8 bits por char (consegue representar acentos, cedilha e til)
                    Texto += Convert.ToChar(RX[j++]).ToString();    //Aceita 8 bits por char (consegue representar acentos, cedilha e til)
                }
            }

            ////string Texto = SerialPort1.ReadTo(0x03.ToString());   //Lê dados no buffer da serial até encotrar 0x03
            //string Texto;
            //SerialPort1.ReadTimeout = 500;      //Define o Time-out em 500 ms
            //try
            //{
            //    Texto = SerialPort1.ReadLine(); //Lê dados no butter da serial até receber um NewLine (LineFeed 0x0A) - ajustar timeout
            //    SerialPort1.DiscardInBuffer();  //Descarta dados que sobreram no buffer de recebimento
            //}
            //catch (TimeoutException) //Quando ocorre ReadTimeOut uma exceção é gerada: TimeoutException
            //{
            //    Texto = "";
            //    //MessageBox.Show("TIMEOUT");
            //}

            if (Texto.Length > 0)
            {
                //tbRecebido.Text += Texto;
                //Isso não pode ser feito diretamente por contra do controle 
                //ter sido inicializado em uma thread diferente daquela que 
                //controla o recebimento da porta serial
                //A função abaixo é parte da solução deste problema               
                GravaTexto(Texto);
            }
        }

        delegate void PegaTexto(string text); //Cria um delegate que será um "ponteiro de função"

        private void GravaTexto(string t)
        {
            //Se o controle tbRecebido foi criado em uma thread diferente daquela
            //que está executando este método, uma instância do delegate deve ser criada
            //referenciando o método atual (GravaTexto).
            //Em seguida o método Invoke executa o delegate, que faz com o método SetTexto
            //passe a ser executado na thread que criou o controle tbRecebido, e a 
            //propriedade t passe a ser definida diretamente.
            try
            {
                if (this.tbRecebido.InvokeRequired) //cruzamento de threads 
                {
                    #region
                    //InvokeRequired retorna "true" se o Handle (identificador) do controle (tbRecebido) foi criado em 
                    //uma thread (segmento) diferente da thread que fez a chamada do teste (indicando que você
                    //deve fazer chamadas para o controle através do método invoke (invocar)).

                    //Se o ID da thread principal (interface gráfica) for diferente
                    //de quem está chamando a função, então InvokeRequired retorna TRUE

                    //InvokeRequired compara o "thread ID" da thread chamadora 
                    //com o da thread criadora.
                    //Se eles forem diferentes, ele retorna true.
                    #endregion
                    //Instancia o delegate do tipo PegaTexto
                    PegaTexto d = new PegaTexto(GravaTexto);
                    #region
                    //Em seguida é passado ao delegate o ponteiro da função 
                    //para que posteriormente possamos invocar (Invoke) o método SetTexto
                    //dentro da thread Principal, portando na segunta execução os IDs 
                    //são iguais, fato que permite a atribuição de valores na thread 
                    //principal. 

                    /*Executes the specified delegate, on the thread that owns the control's 
                     * underlying window handle, with the specified list of arguments.
                     * 
                     * Executa o delegate (representante) especificado, na thread que possui o 
                     * identificador do controle subjacente janela (this), com a lista de
                     * argumentos especificada.
                     */
                    #endregion
                    this.Invoke(d, new object[] { t });
                }
                else
                {
                    char[] c = t.ToCharArray();
                    bool Enter = false;
                    string str = ""; // String que irá receber a conversão
                    //System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();    //Só aceita 7 bits por char
                    foreach (var b in c)
                    {
                        Enter = false;
                        //str += char.ConvertFromUtf32(b).ToString(); //Aceita 8 bits por char (consegue representar acentos, cedilha e til)
                        str += Convert.ToChar(b).ToString();        //Aceita 8 bits por char (consegue representar acentos, cedilha e til)
                        if (cbEnter.Checked)
                            if ((b == 0x0D) || (b == 0x0A))
                            {
                                str += Environment.NewLine;
                                Enter = true;                       //Evita um duplo enter quando finaliza a string no TextBox
                            }
                    }
                    //Para mostrar em string
                    //str = enc.GetString(pac);
                    if (Enter)
                        tbRecebido.AppendText(str);
                    else
                        //tbRecebido.Text += str + Environment.NewLine;    //Acrescenta string e linha
                        tbRecebido.AppendText(str + Environment.NewLine);    //Acrescenta string, linha e faz scroll automático

                    //Para mostrar em hexa
                    if (cbHexaEspaço.Checked)
                    {
                        StringBuilder sb = new StringBuilder(c.Length * 3);//dois cracteres + um espaço
                        foreach (byte b in c)
                        {
                            sb.AppendFormat("{0:x2} ", b);
                            if (cbEnter.Checked)
                                if ((b == 0x0D) || (b == 0x0A))
                                    sb.Append(Environment.NewLine);
                        }
                        if (Enter)
                            tbRecebidoH.AppendText(sb.ToString());
                        else
                            //tbRecebidoH.Text += sb.ToString() + Environment.NewLine; //Acrescenta string e linha
                            tbRecebidoH.AppendText(sb.ToString() + Environment.NewLine); //Acrescenta string, linha e faz scroll automático
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder(c.Length * 2);//dois cracteres
                        foreach (byte b in c)
                        {
                            sb.AppendFormat("{0:x2}", b);
                            if (cbEnter.Checked)
                                if ((b == 0x0D) || (b == 0x0A))
                                    sb.Append(Environment.NewLine);
                        }
                        if (Enter)
                            tbRecebidoH.AppendText(sb.ToString());
                        else
                            //tbRecebidoH.Text += sb.ToString() + Environment.NewLine; //Acrescenta string e linha
                            tbRecebidoH.AppendText(sb.ToString() + Environment.NewLine); //Acrescenta string, linha e faz scroll automático
                    }

                    if (cbSom.Checked == true)
                    {
                        SystemSounds.Asterisk.Play();
                    }

                    //Sem tratamento dos códigos 0x0D e 0x0A (Enter)
                    ////Para mostrar em string
                    ////this.tbRecebido.Text += t + Environment.NewLine;  //Acrescenta string e linha 
                    //this.tbRecebido.AppendText(t + Environment.NewLine);    //Acrescenta string, linha e faz scroll automático

                    ////Para mostrar em hexa
                    //if (cbHexaEspaço.Checked)
                    //{
                    //    StringBuilder sb = new StringBuilder(t.Length * 3);//dois cracteres + um espaço
                    //    foreach (byte b in t)
                    //    {
                    //        sb.AppendFormat("{0:x2} ", b);
                    //    }
                    //    //tbRecebidoH.Text += sb.ToString() + Environment.NewLine;    //Acrescenta string e linha
                    //    tbRecebidoH.AppendText(sb.ToString() + Environment.NewLine);    //Acrescenta string, linha e faz scroll automático
                    //}
                    //else
                    //{
                    //    StringBuilder sb = new StringBuilder(t.Length * 2);//dois cracteres
                    //    foreach (byte b in t)
                    //    {
                    //        sb.AppendFormat("{0:x2}", b);
                    //    }
                    //    //tbRecebidoH.Text += sb.ToString() + Environment.NewLine;    //Acrescenta string e linha
                    //    tbRecebidoH.AppendText(sb.ToString() + Environment.NewLine);    //Acrescenta string, linha e faz scroll automático
                    //}
                }
            }
            catch
            { }
        }

        private void bLimpar_Click(object sender, EventArgs e)
        {
            tbEnviar.Clear();
            tbEnviarH.Clear();
        }

        private void bLimpar2_Click(object sender, EventArgs e)
        {
            tbRecebido.Clear();
            tbRecebidoH.Clear();
            tbEnviado.Clear();
            tbEnviadoH.Clear();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                bLimpar_Click(sender, e);
                bLimpar2_Click(sender, e);
            }
        }

        #region BOTÕES DE TESTE
        private void bT1_Click(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen) //Se a conexão está aberta...
            {
                //byte[] pacote = new byte[6];
                ////Monta um pacote de bytes
                //pacote[0] = Convert.ToByte('T');
                //pacote[1] = Convert.ToByte('e');
                //pacote[2] = Convert.ToByte('s');
                //pacote[3] = Convert.ToByte('t');
                //pacote[4] = Convert.ToByte('e');
                //pacote[5] = Convert.ToByte('1');
                //SerialPort1.Write(pacote, 0, 6);
                ////Chama funções de atualização de estado
                //Enviado(pacote);
                tbEnviar.Text = tbT1.Text;
                bEnviar.PerformClick();
            }
        }

        private void bT2_Click(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen) //Se a conexão está aberta...
            {
                //byte[] pacote = new byte[7];
                ////Monta um pacote de bytes
                //pacote[0] = Convert.ToByte('T');
                //pacote[1] = Convert.ToByte('e');
                //pacote[2] = Convert.ToByte('s');
                //pacote[3] = Convert.ToByte('t');
                //pacote[4] = Convert.ToByte('e');
                //pacote[5] = Convert.ToByte('2');
                //pacote[6] = 0x0D;
                //SerialPort1.Write(pacote, 0, 7);
                ////Chama funções de atualização de estado
                //Enviado(pacote);
                tbEnviar.Text = tbT2.Text;
                bEnviar.PerformClick();
            }
        }

        private void bT3_Click(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen) //Se a conexão está aberta...
            {
                //byte[] pacote = new byte[7];
                ////Monta um pacote de bytes
                //pacote[0] = Convert.ToByte('T');
                //pacote[1] = Convert.ToByte('e');
                //pacote[2] = Convert.ToByte('s');
                //pacote[3] = Convert.ToByte('t');
                //pacote[4] = Convert.ToByte('e');
                //pacote[5] = Convert.ToByte('3');
                //pacote[6] = 0x0A;
                //SerialPort1.Write(pacote, 0, 7);
                ////Chama funções de atualização de estado
                //Enviado(pacote);
                tbEnviar.Text = tbT3.Text;
                bEnviar.PerformClick();
            }
        }

        private void bT4_Click(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen) //Se a conexão está aberta...
            {
                //byte[] pacote = new byte[8];
                ////Monta um pacote de bytes
                //pacote[0] = Convert.ToByte('T');
                //pacote[1] = Convert.ToByte('e');
                //pacote[2] = Convert.ToByte('s');
                //pacote[3] = Convert.ToByte('t');
                //pacote[4] = Convert.ToByte('e');
                //pacote[5] = Convert.ToByte('4');
                //pacote[6] = 0x0D;
                //pacote[7] = 0x0A;
                //SerialPort1.Write(pacote, 0, 8);
                ////Chama funções de atualização de estado
                //Enviado(pacote);
                tbEnviar.Text = tbT4.Text;
                bEnviar.PerformClick();
            }
        }
        #endregion

        public void Enviado(byte[] pac)
        {
            bool Enter = false;
            string str = ""; // String que irá receber a conversão
            //System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();    //Só aceita 7 bits por char
            foreach (var b in pac)
            {
                Enter = false;
                //str += char.ConvertFromUtf32(b).ToString(); //Aceita 8 bits por char (consegue representar acentos, cedilha e til)
                str += Convert.ToChar(b).ToString();        //Aceita 8 bits por char (consegue representar acentos, cedilha e til)
                if (cbEnter.Checked)
                    if ((b == 0x0D) || (b == 0x0A))
                    {
                        str += Environment.NewLine;
                        Enter = true;                       //Evita um duplo enter quando finaliza a string no TextBox
                    }
            }

            //Para mostrar em string
            //str = enc.GetString(pac);
            if (Enter || (cbCR.Checked && cbLF.Checked))
                tbEnviado.AppendText(str);
            else
                //tbEnviado.Text += str + Environment.NewLine;    //Acrescenta string e linha
                tbEnviado.AppendText(str + Environment.NewLine);    //Acrescenta string, linha e faz scroll automático

            //Para mostrar em hexa
            if (cbHexaEspaço.Checked)
            {
                StringBuilder sb = new StringBuilder(pac.Length * 3);//dois cracteres + um espaço
                foreach (byte b in pac)
                {
                    sb.AppendFormat("{0:x2} ", b);
                    if (cbEnter.Checked)
                        if ((b == 0x0D) || (b == 0x0A))
                            sb.Append(Environment.NewLine);
                }
                if(Enter)
                    tbEnviadoH.AppendText(sb.ToString());
                else
                    //tbEnviadoH.Text += sb.ToString() + Environment.NewLine; //Acrescenta string e linha
                    tbEnviadoH.AppendText(sb.ToString() + Environment.NewLine); //Acrescenta string, linha e faz scroll automático
            }
            else
            {
                StringBuilder sb = new StringBuilder(pac.Length * 2);//dois cracteres
                foreach (byte b in pac)
                {
                    sb.AppendFormat("{0:x2}", b);
                    if (cbEnter.Checked)
                        if ((b == 0x0D) || (b == 0x0A))
                            sb.Append(Environment.NewLine);
                }
                if (Enter)
                    tbEnviadoH.AppendText(sb.ToString());
                else
                    //tbEnviadoH.Text += sb.ToString() + Environment.NewLine; //Acrescenta string e linha
                    tbEnviadoH.AppendText(sb.ToString() + Environment.NewLine); //Acrescenta string, linha e faz scroll automático
            }

            if (cbSom.Checked == true)
            {
                SystemSounds.Asterisk.Play();
            }
        }
    }
}
/*
    // Converter o byte[] para String
    byte [] dBytes = ... // seu array de bytes.
    string str; // String que irá receber a conversão
    System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
    str = enc.GetString(dBytes);

    // Converte uma string em um byte[]
    public static byte[] StrToByteArray(string str)
    {
        System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
        return encoding.GetBytes(str);
    }
 
    // byte[] Array to Hex String
    Byte[] ba = {0xFF, 0xD0, 0xFF, 0xD1} to "FFD0FFD1" ?
    
    StringBuilder sb = new StringBuilder(ba.Length * 2);
    foreach (byte b in ba)
    {
       sb.AppendFormat("{0:x2}", b)
    }
    return sb.ToString();
*/