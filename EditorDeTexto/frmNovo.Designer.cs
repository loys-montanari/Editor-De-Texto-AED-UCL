namespace EditorDeTexto
{
    partial class frmNovo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTamanho = new System.Windows.Forms.ComboBox();
            this.cboFontFamily = new System.Windows.Forms.ComboBox();
            this.btnAlinhaDireita = new System.Windows.Forms.CheckBox();
            this.btnAlinhaCentro = new System.Windows.Forms.CheckBox();
            this.btnAlinhaEsquerda = new System.Windows.Forms.CheckBox();
            this.btnUnderline = new System.Windows.Forms.CheckBox();
            this.btnItalic = new System.Windows.Forms.CheckBox();
            this.btnBold = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.clbPalavrasNovas = new System.Windows.Forms.CheckedListBox();
            this.btnAddPalavras = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 125);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(552, 568);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 15);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.cboTamanho);
            this.panel2.Controls.Add(this.cboFontFamily);
            this.panel2.Controls.Add(this.btnAlinhaDireita);
            this.panel2.Controls.Add(this.btnAlinhaCentro);
            this.panel2.Controls.Add(this.btnAlinhaEsquerda);
            this.panel2.Controls.Add(this.btnUnderline);
            this.panel2.Controls.Add(this.btnItalic);
            this.panel2.Controls.Add(this.btnBold);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnAbrir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 56);
            this.panel2.TabIndex = 3;
            // 
            // cboTamanho
            // 
            this.cboTamanho.FormattingEnabled = true;
            this.cboTamanho.Location = new System.Drawing.Point(569, 11);
            this.cboTamanho.Name = "cboTamanho";
            this.cboTamanho.Size = new System.Drawing.Size(95, 23);
            this.cboTamanho.TabIndex = 29;
            this.cboTamanho.Text = "Tamanho";
            this.cboTamanho.SelectedIndexChanged += new System.EventHandler(this.cboTamanho_SelectedIndexChanged);
            // 
            // cboFontFamily
            // 
            this.cboFontFamily.FormattingEnabled = true;
            this.cboFontFamily.Location = new System.Drawing.Point(359, 11);
            this.cboFontFamily.Name = "cboFontFamily";
            this.cboFontFamily.Size = new System.Drawing.Size(193, 23);
            this.cboFontFamily.TabIndex = 28;
            this.cboFontFamily.Text = "Font Family";
            this.cboFontFamily.SelectedIndexChanged += new System.EventHandler(this.cboFontFamily_SelectedIndexChanged);
            // 
            // btnAlinhaDireita
            // 
            this.btnAlinhaDireita.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAlinhaDireita.AutoSize = true;
            this.btnAlinhaDireita.BackgroundImage = global::EditorDeTexto.Properties.Resources.align_right1;
            this.btnAlinhaDireita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlinhaDireita.FlatAppearance.BorderSize = 0;
            this.btnAlinhaDireita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlinhaDireita.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlinhaDireita.Location = new System.Drawing.Point(761, 7);
            this.btnAlinhaDireita.Name = "btnAlinhaDireita";
            this.btnAlinhaDireita.Size = new System.Drawing.Size(17, 21);
            this.btnAlinhaDireita.TabIndex = 27;
            this.btnAlinhaDireita.Text = " ";
            this.btnAlinhaDireita.UseVisualStyleBackColor = true;
            this.btnAlinhaDireita.Click += new System.EventHandler(this.btnAlinhaDireita_Click);
            // 
            // btnAlinhaCentro
            // 
            this.btnAlinhaCentro.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAlinhaCentro.AutoSize = true;
            this.btnAlinhaCentro.BackgroundImage = global::EditorDeTexto.Properties.Resources.align_white;
            this.btnAlinhaCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlinhaCentro.FlatAppearance.BorderSize = 0;
            this.btnAlinhaCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlinhaCentro.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlinhaCentro.Location = new System.Drawing.Point(733, 7);
            this.btnAlinhaCentro.Name = "btnAlinhaCentro";
            this.btnAlinhaCentro.Size = new System.Drawing.Size(17, 21);
            this.btnAlinhaCentro.TabIndex = 26;
            this.btnAlinhaCentro.Text = " ";
            this.btnAlinhaCentro.UseVisualStyleBackColor = true;
            this.btnAlinhaCentro.Click += new System.EventHandler(this.btnAlinhaCentro_Click);
            // 
            // btnAlinhaEsquerda
            // 
            this.btnAlinhaEsquerda.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAlinhaEsquerda.AutoSize = true;
            this.btnAlinhaEsquerda.BackgroundImage = global::EditorDeTexto.Properties.Resources.align_left_white;
            this.btnAlinhaEsquerda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlinhaEsquerda.FlatAppearance.BorderSize = 0;
            this.btnAlinhaEsquerda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlinhaEsquerda.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlinhaEsquerda.Location = new System.Drawing.Point(706, 6);
            this.btnAlinhaEsquerda.Name = "btnAlinhaEsquerda";
            this.btnAlinhaEsquerda.Size = new System.Drawing.Size(17, 21);
            this.btnAlinhaEsquerda.TabIndex = 25;
            this.btnAlinhaEsquerda.Text = " ";
            this.btnAlinhaEsquerda.UseVisualStyleBackColor = true;
            this.btnAlinhaEsquerda.Click += new System.EventHandler(this.btnAlinhaEsquerda_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnUnderline.AutoSize = true;
            this.btnUnderline.BackgroundImage = global::EditorDeTexto.Properties.Resources.underline_white;
            this.btnUnderline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUnderline.FlatAppearance.BorderSize = 0;
            this.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnderline.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUnderline.Location = new System.Drawing.Point(308, 6);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(17, 21);
            this.btnUnderline.TabIndex = 24;
            this.btnUnderline.Text = " ";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnItalic.AutoSize = true;
            this.btnItalic.BackgroundImage = global::EditorDeTexto.Properties.Resources.italics_white;
            this.btnItalic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnItalic.FlatAppearance.BorderSize = 0;
            this.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItalic.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnItalic.Location = new System.Drawing.Point(280, 5);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(17, 21);
            this.btnItalic.TabIndex = 23;
            this.btnItalic.Text = " ";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalick_Click);
            // 
            // btnBold
            // 
            this.btnBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnBold.AutoSize = true;
            this.btnBold.BackgroundImage = global::EditorDeTexto.Properties.Resources.bold_white;
            this.btnBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBold.FlatAppearance.BorderSize = 0;
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBold.Location = new System.Drawing.Point(253, 5);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(17, 21);
            this.btnBold.TabIndex = 22;
            this.btnBold.Text = " ";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Maroon;
            this.panel6.Location = new System.Drawing.Point(801, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 56);
            this.panel6.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.Location = new System.Drawing.Point(678, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 56);
            this.panel5.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(221, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 56);
            this.panel4.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(116, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 56);
            this.panel3.TabIndex = 4;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::EditorDeTexto.Properties.Resources.big_dictionary_white;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(197)))), ((int)(((byte)(246)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(155, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 24);
            this.button8.TabIndex = 20;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(140, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dicionário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(34, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Arquivo";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::EditorDeTexto.Properties.Resources.save_white1;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(197)))), ((int)(((byte)(246)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(69, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(24, 27);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(722, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Texto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(271, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fonte";
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrir.BackgroundImage = global::EditorDeTexto.Properties.Resources.folder_white;
            this.btnAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbrir.FlatAppearance.BorderSize = 0;
            this.btnAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(197)))), ((int)(((byte)(246)))));
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Location = new System.Drawing.Point(27, 5);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(24, 27);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Maroon;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 71);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1018, 1);
            this.panel7.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(839, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "posicao palavra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clbPalavrasNovas
            // 
            this.clbPalavrasNovas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbPalavrasNovas.FormattingEnabled = true;
            this.clbPalavrasNovas.Location = new System.Drawing.Point(839, 125);
            this.clbPalavrasNovas.Name = "clbPalavrasNovas";
            this.clbPalavrasNovas.Size = new System.Drawing.Size(167, 274);
            this.clbPalavrasNovas.TabIndex = 6;
            // 
            // btnAddPalavras
            // 
            this.btnAddPalavras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPalavras.Location = new System.Drawing.Point(931, 91);
            this.btnAddPalavras.Name = "btnAddPalavras";
            this.btnAddPalavras.Size = new System.Drawing.Size(75, 28);
            this.btnAddPalavras.TabIndex = 5;
            this.btnAddPalavras.Text = "Adicionar";
            this.btnAddPalavras.UseVisualStyleBackColor = true;
            this.btnAddPalavras.Click += new System.EventHandler(this.btnAddPalavras_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(582, 125);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(238, 568);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1018, 705);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.clbPalavrasNovas);
            this.Controls.Add(this.btnAddPalavras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmNovo";
            this.Text = "Editor de Texto";
            this.Load += new System.EventHandler(this.frmNovo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private Panel panel1;
        private Panel panel2;
        private Button btnAbrir;
        private Label label2;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnSalvar;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button button8;
        private Label label4;
        private Label label3;
        private ContextMenuStrip contextMenuStrip2;
        private CheckBox btnBold;
        private CheckBox btnUnderline;
        private CheckBox btnItalic;
        private CheckBox btnAlinhaDireita;
        private CheckBox btnAlinhaCentro;
        private CheckBox btnAlinhaEsquerda;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ComboBox cboTamanho;
        private ComboBox cboFontFamily;
        private Panel panel7;
        private Button button1;
        private CheckedListBox clbPalavrasNovas;
        private Button btnAddPalavras;
        private RichTextBox richTextBox2;
    }
}