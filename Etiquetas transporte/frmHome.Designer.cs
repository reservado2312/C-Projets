namespace Etiquetas_transporte
{
    partial class formHomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHomePage));
            impressora = new System.Drawing.Printing.PrintDocument();
            splitter1 = new Splitter();
            lblSelImpressora = new Label();
            lBoxImpressoras = new ListBox();
            lblTitle = new Label();
            btnImprimir = new Button();
            tBoxImpressao = new TextBox();
            lblOrigem = new Label();
            lblDestino = new Label();
            tboxNfiscal = new TextBox();
            cbFDestino = new ComboBox();
            tboxNvolumes = new TextBox();
            cbFOrigem = new ComboBox();
            lblNramal = new Label();
            lblNfiscal = new Label();
            tboxNramal = new TextBox();
            lblNvolumes = new Label();
            lblResponsaveis = new Label();
            tboxResponsaveis = new TextBox();
            btnPreview = new Button();
            btnSetPrinter = new Button();
            btnClosePrinterSettings = new Button();
            SuspendLayout();
            // 
            // impressora
            // 
            impressora.PrintPage += impressora_PrintPage;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 474);
            splitter1.TabIndex = 22;
            splitter1.TabStop = false;
            // 
            // lblSelImpressora
            // 
            lblSelImpressora.AutoSize = true;
            lblSelImpressora.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelImpressora.Location = new Point(797, 11);
            lblSelImpressora.Name = "lblSelImpressora";
            lblSelImpressora.Size = new Size(326, 22);
            lblSelImpressora.TabIndex = 17;
            lblSelImpressora.Text = "Selecione a impressora padrão";
            // 
            // lBoxImpressoras
            // 
            lBoxImpressoras.FormattingEnabled = true;
            lBoxImpressoras.ItemHeight = 15;
            lBoxImpressoras.Location = new Point(800, 37);
            lBoxImpressoras.Name = "lBoxImpressoras";
            lBoxImpressoras.Size = new Size(426, 424);
            lBoxImpressoras.TabIndex = 21;
            lBoxImpressoras.DoubleClick += lBoxImpressoras_DoubleClick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(61, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(688, 34);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Impreção de Etiquetas para Transferências";
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImprimir.Location = new Point(412, 270);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(382, 42);
            btnImprimir.TabIndex = 40;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // tBoxImpressao
            // 
            tBoxImpressao.Location = new Point(18, 321);
            tBoxImpressao.MaxLength = 8;
            tBoxImpressao.Multiline = true;
            tBoxImpressao.Name = "tBoxImpressao";
            tBoxImpressao.ReadOnly = true;
            tBoxImpressao.Size = new Size(776, 140);
            tBoxImpressao.TabIndex = 39;
            tBoxImpressao.Text = "Preview Etiqueta";
            // 
            // lblOrigem
            // 
            lblOrigem.AutoSize = true;
            lblOrigem.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigem.Location = new Point(18, 84);
            lblOrigem.Name = "lblOrigem";
            lblOrigem.Size = new Size(145, 22);
            lblOrigem.TabIndex = 26;
            lblOrigem.Text = "Filial Origem";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDestino.Location = new Point(18, 153);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(152, 22);
            lblDestino.TabIndex = 28;
            lblDestino.Text = "Filial Destino";
            // 
            // tboxNfiscal
            // 
            tboxNfiscal.AutoCompleteMode = AutoCompleteMode.Suggest;
            tboxNfiscal.Location = new Point(18, 241);
            tboxNfiscal.MaxLength = 8;
            tboxNfiscal.Name = "tboxNfiscal";
            tboxNfiscal.Size = new Size(154, 23);
            tboxNfiscal.TabIndex = 29;
            tboxNfiscal.TextChanged += tboxNfiscal_TextChanged;
            // 
            // cbFDestino
            // 
            cbFDestino.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbFDestino.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbFDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFDestino.FormattingEnabled = true;
            cbFDestino.Items.AddRange(new object[] { "05 - Pontal", "08 - Cravinhos", "09 - Sertãozinho", "10 - CD", "18 - Severinia", "22 - Morro Agudo", "23 - Frutal", "24 - Campo Florido", "25 - Descalvado", "26 - Santa Rosa do Viterbo", "27 - Porto Ferreira", "28 - Santa Cruz das palmeiras", "29 - Santa Rita do Passa Quatro", "31 - Ituverava", "32 - Pitangueiras", "33 - Serrana", "37 - Paulo de faria", "39 - Barretos", "40 - Batatais", "41 - Guaíra", "42 - Guará", "43 - Jaboticabal", "52 - Monte Alto", "56 - Matão" });
            cbFDestino.Location = new Point(18, 178);
            cbFDestino.Name = "cbFDestino";
            cbFDestino.Size = new Size(776, 23);
            cbFDestino.TabIndex = 38;
            // 
            // tboxNvolumes
            // 
            tboxNvolumes.Location = new Point(178, 241);
            tboxNvolumes.MaxLength = 2;
            tboxNvolumes.Name = "tboxNvolumes";
            tboxNvolumes.Size = new Size(121, 23);
            tboxNvolumes.TabIndex = 30;
            tboxNvolumes.Text = "1";
            tboxNvolumes.TextChanged += tboxNvolumes_TextChanged;
            // 
            // cbFOrigem
            // 
            cbFOrigem.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbFOrigem.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbFOrigem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFOrigem.FormattingEnabled = true;
            cbFOrigem.Items.AddRange(new object[] { "05 - Pontal", "08 - Cravinhos", "09 - Sertãozinho", "10 - CD", "18 - Severinia", "22 - Morro Agudo", "23 - Frutal", "24 - Campo Florido", "25 - Descalvado", "26 - Santa Rosa do Viterbo", "27 - Porto Ferreira", "28 - Santa Cruz das palmeiras", "29 - Santa Rita do Passa Quatro", "31 - Ituverava", "32 - Pitangueiras", "33 - Serrana", "37 - Paulo de faria", "39 - Barretos", "40 - Batatais", "41 - Guaíra", "42 - Guará", "43 - Jaboticabal", "52 - Monte Alto", "56 - Matão" });
            cbFOrigem.Location = new Point(18, 109);
            cbFOrigem.Name = "cbFOrigem";
            cbFOrigem.Size = new Size(776, 23);
            cbFOrigem.TabIndex = 27;
            // 
            // lblNramal
            // 
            lblNramal.AutoSize = true;
            lblNramal.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNramal.Location = new Point(649, 216);
            lblNramal.Name = "lblNramal";
            lblNramal.Size = new Size(100, 22);
            lblNramal.TabIndex = 37;
            lblNramal.Text = "N° Ramal";
            // 
            // lblNfiscal
            // 
            lblNfiscal.AutoSize = true;
            lblNfiscal.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNfiscal.Location = new Point(18, 216);
            lblNfiscal.Name = "lblNfiscal";
            lblNfiscal.Size = new Size(154, 22);
            lblNfiscal.TabIndex = 32;
            lblNfiscal.Text = "N° NOta Fiscal";
            // 
            // tboxNramal
            // 
            tboxNramal.Location = new Point(649, 241);
            tboxNramal.MaxLength = 8;
            tboxNramal.Name = "tboxNramal";
            tboxNramal.Size = new Size(145, 23);
            tboxNramal.TabIndex = 36;
            tboxNramal.TextChanged += tboxNramal_TextChanged;
            // 
            // lblNvolumes
            // 
            lblNvolumes.AutoSize = true;
            lblNvolumes.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNvolumes.Location = new Point(178, 216);
            lblNvolumes.Name = "lblNvolumes";
            lblNvolumes.Size = new Size(121, 22);
            lblNvolumes.TabIndex = 33;
            lblNvolumes.Text = "n° Volumes";
            // 
            // lblResponsaveis
            // 
            lblResponsaveis.AutoSize = true;
            lblResponsaveis.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResponsaveis.Location = new Point(305, 216);
            lblResponsaveis.Name = "lblResponsaveis";
            lblResponsaveis.Size = new Size(146, 22);
            lblResponsaveis.TabIndex = 35;
            lblResponsaveis.Text = "Responsáveis";
            // 
            // tboxResponsaveis
            // 
            tboxResponsaveis.Location = new Point(305, 241);
            tboxResponsaveis.MaxLength = 20;
            tboxResponsaveis.Name = "tboxResponsaveis";
            tboxResponsaveis.Size = new Size(338, 23);
            tboxResponsaveis.TabIndex = 34;
            // 
            // btnPreview
            // 
            btnPreview.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPreview.Location = new Point(18, 270);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(388, 42);
            btnPreview.TabIndex = 31;
            btnPreview.Text = "Preview Etiqueta";
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += btnPreview_Click;
            // 
            // btnSetPrinter
            // 
            btnSetPrinter.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSetPrinter.Location = new Point(613, 84);
            btnSetPrinter.Name = "btnSetPrinter";
            btnSetPrinter.Size = new Size(181, 22);
            btnSetPrinter.TabIndex = 41;
            btnSetPrinter.Text = "Configurar Impressora padrão";
            btnSetPrinter.UseVisualStyleBackColor = true;
            btnSetPrinter.Click += btnSetPrinter_Click;
            // 
            // btnClosePrinterSettings
            // 
            btnClosePrinterSettings.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClosePrinterSettings.Location = new Point(1154, 12);
            btnClosePrinterSettings.Name = "btnClosePrinterSettings";
            btnClosePrinterSettings.Size = new Size(72, 19);
            btnClosePrinterSettings.TabIndex = 42;
            btnClosePrinterSettings.Text = "Fechar";
            btnClosePrinterSettings.UseVisualStyleBackColor = true;
            btnClosePrinterSettings.Click += btnClosePrinterSettings_Click;
            // 
            // formHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1258, 474);
            Controls.Add(btnClosePrinterSettings);
            Controls.Add(btnSetPrinter);
            Controls.Add(lBoxImpressoras);
            Controls.Add(lblSelImpressora);
            Controls.Add(lblTitle);
            Controls.Add(btnImprimir);
            Controls.Add(tBoxImpressao);
            Controls.Add(lblOrigem);
            Controls.Add(lblDestino);
            Controls.Add(tboxNfiscal);
            Controls.Add(cbFDestino);
            Controls.Add(tboxNvolumes);
            Controls.Add(cbFOrigem);
            Controls.Add(btnPreview);
            Controls.Add(lblNramal);
            Controls.Add(lblNfiscal);
            Controls.Add(tboxNramal);
            Controls.Add(lblNvolumes);
            Controls.Add(lblResponsaveis);
            Controls.Add(tboxResponsaveis);
            Controls.Add(splitter1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1800, 1800);
            MinimumSize = new Size(816, 333);
            Name = "formHomePage";
            Text = "Impreção de Etiquetas para Transferências";
            Load += formHomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Drawing.Printing.PrintDocument impressora;
        private Splitter splitter1;
        private Label lblSelImpressora;
        private ListBox lBoxImpressoras;
        private Label lblTitle;
        private Button btnImprimir;
        private TextBox tBoxImpressao;
        private Label lblOrigem;
        private Label lblDestino;
        private TextBox tboxNfiscal;
        private ComboBox cbFDestino;
        private TextBox tboxNvolumes;
        private ComboBox cbFOrigem;
        private Label lblNramal;
        private Label lblNfiscal;
        private TextBox tboxNramal;
        private Label lblNvolumes;
        private Label lblResponsaveis;
        private TextBox tboxResponsaveis;
        private Button btnPreview;
        private Button btnSetPrinter;
        private Button btnClosePrinterSettings;
    }
}
