﻿using EditorDeTexto.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto
{
    public partial class frmNovo : Form
    {
        ListaEncadeada[] dicionario = new ListaEncadeada[20000];
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

            openFileDialog1.ShowDialog();     // show the dialog

            filenamee = openFileDialog1.FileName;
            // load the file into the richTextBox
            richTextBox1.LoadFile(filenamee, RichTextBoxStreamType.PlainText);



        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                saveFileDialog1.ShowDialog();
                string file;

                string filename = saveFileDialog1.FileName;
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.RichText);
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

            string contapalavra = texto.Text;

            string[] vetorpalavras = contapalavra.Split(" ");

            foreach (var item in vetorpalavras)
            {

                int tamanhoVet;

                int[] codasc = new int[30];
                int somacodasc = 0;


                tamanhoVet = (item.Length);

                Char[] caractere = item.ToUpper().ToCharArray();

                for (int i = 0; i < tamanhoVet; i++)
                {
                    int codigoascii = Convert.ToInt32(caractere[i]);
                    codasc[i] = codigoascii;
                    somacodasc = somacodasc + codasc[i];
                }

                string posicao = somacodasc.ToString();
                richTextBox2.AppendText($"{item} ");
                richTextBox2.AppendText($"{posicao} ");



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checarpalavras(richTextBox1);
        }


        private void carregardicionario()
        {
            

            string conteudo = File.ReadAllText("C:\\Users\\lamontanari\\Source\\Repos\\loys-montanari\\Editor-De-Texto-AED-UCL\\EditorDeTexto\\Dicionario.txt");

            string[] vetorpalavras = conteudo.Split(",");

            StringComparer ordemalfabetica = StringComparer.CurrentCultureIgnoreCase;

            Array.Sort(vetorpalavras, ordemalfabetica);

            foreach (var item in vetorpalavras)
            {

                int tamanhoVet;

                int[] codasc = new int[30];
                int somacodasc = 0;


                tamanhoVet = (item.Length);

                Char[] caractere = item.ToUpper().ToCharArray();

                for (int i = 0; i < tamanhoVet; i++)
                {
                    int codigoascii = Convert.ToInt32(caractere[i]);
                    codasc[i] = codigoascii;
                    somacodasc = somacodasc + codasc[i];
                }

                if (dicionario[somacodasc] == null)
                {
                    dicionario[somacodasc] = new ListaEncadeada();
                    dicionario[somacodasc].insereInicio(item);
                    
                }
                else {
                    dicionario[somacodasc].insereInicio(item);
                    
                
                }

                string posicao = somacodasc.ToString();
                richTextBox2.AppendText($"{item} ");
                richTextBox2.AppendText($"{posicao} ");
            }
            


        }



    }
}
