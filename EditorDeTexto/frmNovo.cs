using EditorDeTexto.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto
{
    public partial class frmNovo : Form
    {
        

        ListaEncadeada[] dicionario = new ListaEncadeada[20000];
        List<string> palavrascheckbox = new List<string>();

        string filenamee;
        public frmNovo()
        {
            InitializeComponent();
        }
        private void frmNovo_Load(object sender, EventArgs e)
        {

            // preenchendo cbo de fonts
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                cboFontFamily.Items.Add(family.Name);
            }
            // preenchendo cbo de tamanho do texto
            for (int i = 8; i < 80; i += 2)
            {
                cboTamanho.Items.Add(i);
            }
            carregardicionario();
            this.clbPalavrasNovas.Visible = false;
            this.lblDicionario.Visible = false;
            this.richTextBox2.Visible = false;
            this.btnAddPalavras.Visible = false;
            this.lblPalavrasNovas.Visible = false;


        }

        private void btnBold_CheckedChanged(object sender, EventArgs e)
        {
            if (btnBold.Checked == false)
            {
                btnBold.Checked = true;

            }
            else if (btnBold.Checked == true)
            {
                btnBold.Checked = false;
            }

            if (richTextBox1.SelectionFont == null)
            {
                return;
            }


            FontStyle style = richTextBox1.SelectionFont.Style;


            if (richTextBox1.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold;
            }
            else
            {
                style |= FontStyle.Bold;

            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);

        }

        private void btnItalick_Click(object sender, EventArgs e)
        {
            if (btnItalic.Checked == false)
            {
                btnItalic.Checked = true;
            }
            else if (btnItalic.Checked == true)
            {
                btnItalic.Checked = false;
            }

            if (richTextBox1.SelectionFont == null)
            {
                return;
            }
            // create fontStyle object
            FontStyle style = richTextBox1.SelectionFont.Style;

            // determines font style
            if (richTextBox1.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
            }
            else
            {
                style |= FontStyle.Italic;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (btnUnderline.Checked == false)
            {
                btnUnderline.Checked = true;
            }
            else if (btnUnderline.Checked == true)
            {
                btnUnderline.Checked = false;
            }

            if (richTextBox1.SelectionFont == null)
            {
                return;
            }

            // create fontStyle object
            FontStyle style = richTextBox1.SelectionFont.Style;

            // determines the font style
            if (richTextBox1.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
            }
            else
            {
                style |= FontStyle.Underline;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void btnAlinhaEsquerda_Click(object sender, EventArgs e)
        {
            // set properties
            btnAlinhaCentro.Checked = false;
            btnAlinhaDireita.Checked = false;
            if (btnAlinhaEsquerda.Checked == false)
            {
                btnAlinhaEsquerda.Checked = true;    // LEFT ALIGN is active
            }
            else if (btnAlinhaEsquerda.Checked == true)
            {
                btnAlinhaEsquerda.Checked = false;    // LEFT ALIGN is not active
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;    // selects left alignment
        }

        private void btnAlinhaCentro_Click(object sender, EventArgs e)
        {
            // set properties
            btnAlinhaEsquerda.Checked = false;
            btnAlinhaDireita.Checked = false;
            if (btnAlinhaCentro.Checked == false)
            {
                btnAlinhaCentro.Checked = true;    // CENTER ALIGN is active
            }
            else if (btnAlinhaCentro.Checked == true)
            {
                btnAlinhaCentro.Checked = false;    // CENTER ALIGN is not active
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;     // selects center alignment
        }

        private void btnAlinhaDireita_Click(object sender, EventArgs e)
        {
            // set properties
            btnAlinhaEsquerda.Checked = false;
            btnAlinhaCentro.Checked = false;

            if (btnAlinhaDireita.Checked == false)
            {
                btnAlinhaDireita.Checked = true;    // RIGHT ALIGN is active
            }
            else if (btnAlinhaDireita.Checked == true)
            {
                btnAlinhaDireita.Checked = false;    // RIGHT ALIGN is not active
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;    // selects right alignment
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
             openFile1.DefaultExt = "*.txt";
             openFile1.Filter = "txt files (*.txt)|*.txt|RTF Files|*.rtf";


            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFile1.FileName.Length > 0 && openFile1.FileName.EndsWith("txt"))
                {
                    // Load the contents of the file into the RichTextBox.
                    richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
                }
                else if (openFile1.FileName.Length > 0 )
                {                   
                    try
                    {
                        // Load the contents of the file into the RichTextBox.
                        richTextBox1.LoadFile(openFile1.FileName);
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Tipo de arquivo inválido");
                    }
                }
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                saveFileDialog1.ShowDialog();
                string file;

                string filename = saveFileDialog1.FileName;
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
                file = Path.GetFileName(filename);
                MessageBox.Show("Seu arquivo " + file + " foi salvo com sucesso.", "Gravação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }
            // sets the font size when changed
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, Convert.ToInt32(cboTamanho.Text), richTextBox1.SelectionFont.Style);
        }

        private void cboFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                // sets the Font Family style
                richTextBox1.SelectionFont = new Font(cboFontFamily.Text, richTextBox1.Font.Size);
            }
            // sets the selected font famly style
            richTextBox1.SelectionFont = new Font(cboFontFamily.Text, richTextBox1.SelectionFont.Size);
        }

        private void checarpalavras(RichTextBox texto)
        {   
            
            string contapalavra = texto.Text.ToLower();

            string[] vetorpalavras = contapalavra.Split(" ");

            foreach (var item in vetorpalavras)
            {

                int tamanhoVet;
                
                int[] codasc = new int[30];
                int somacodasc = 0;


                tamanhoVet = (item.Length);

                Char[] caractere = item.ToLower().ToCharArray();

                for (int i = 0; i < tamanhoVet; i++)
                {
                    int codigoascii = Convert.ToInt32(caractere[i]);
                    codasc[i] = codigoascii;
                    somacodasc = somacodasc + codasc[i];
                }
               
                if(dicionario[somacodasc] == null )
                {
                                      
                    clbPalavrasNovas.Items.Add(item);
                    
                } 
                else if(dicionario[somacodasc].buscaElemento(item) == false)
                {
                    
                    clbPalavrasNovas.Items.Add(item);
                    
                }

            }
            this.clbPalavrasNovas.Visible = true;
            this.btnAddPalavras.Visible = true;
            this.lblPalavrasNovas.Visible = true;
        }

        private void carregardicionario()
        {
            string conteudo = File.ReadAllText($@"c:\temp\Dicionario.txt");
            string[] vetorpalavras = conteudo.Split(",");

            StringComparer ordemalfabetica = StringComparer.CurrentCultureIgnoreCase;

            Array.Sort(vetorpalavras, ordemalfabetica);

            foreach (var item in vetorpalavras)
            {

                int tamanhoVet;

                int[] codasc = new int[1000];
                int somacodasc = 0;


                tamanhoVet = (item.Length);

                Char[] caractere = item.ToCharArray();

                for (int i = 0; i < tamanhoVet; i++)
                {
                    int codigoascii = Convert.ToInt32(caractere[i]);
                    codasc[i] = codigoascii;
                    somacodasc = somacodasc + codasc[i];
                }

                if (dicionario[somacodasc] == null)
                {
                    dicionario[somacodasc] = new ListaEncadeada();
                    dicionario[somacodasc].insereFim(item);
                    richTextBox2.AppendText($"{item} ");


                }
                else {
                    dicionario[somacodasc].insereFim(item);
                    richTextBox2.AppendText($"{item} ");

                }

                string posicao = somacodasc.ToString();

            }
            
        }
     
        private void btnAddPalavras_Click(object sender, EventArgs e)
        {
            addPalavras();

        }
    
        private void addPalavras()
        {
            var caminho = $@"c:\temp\Dicionario.txt";

            foreach (var item in clbPalavrasNovas.CheckedItems)
            {

                int tamanhoVet;
                int[] codasc = new int[30];
                int somacodasc = 0;


                tamanhoVet = (item.ToString().Length);

                Char[] caractere = item.ToString().ToUpper().ToCharArray();

                for (int i = 0; i < tamanhoVet; i++)
                {
                    int codigoascii = Convert.ToInt32(caractere[i]);
                    codasc[i] = codigoascii;
                    somacodasc = somacodasc + codasc[i];
                }

                if (dicionario[somacodasc] == null)
                {
                    dicionario[somacodasc] = new ListaEncadeada();
                    dicionario[somacodasc].insereInicio(item.ToString());
                    File.AppendAllText(caminho, $"{item.ToString()},");

                }
                else
                {
                    dicionario[somacodasc].insereInicio(item.ToString());
                    File.AppendAllText(caminho, $"{item.ToString()},");

                }
                
            }     
                  carregardicionario();
                  clbPalavrasNovas.Items.Clear();
                  checarpalavras(richTextBox1);
                  MessageBox.Show("Palavras adicionadas ao dicionário com sucesso!");
        }

        private void btnScanear_Click(object sender, EventArgs e)
        {   if(richTextBox1.Text != string.Empty)
            {
                checarpalavras(richTextBox1);
            }
            
        }

        private void btnDicionario_Click(object sender, EventArgs e)
        {
            if(lblDicionario.Visible == false)
            {
                lblDicionario.Visible = true;
                richTextBox2.Visible = true;

            }
            else
            {
                lblDicionario.Visible = false;
                richTextBox2.Visible = false;
            }
        }

    }
}

