using System.Diagnostics.CodeAnalysis;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace Etiquetas_transporte
{
    public partial class formHomePage : Form
    {
        [DllImport("winspool.drv", SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern bool SetDefaultPrinter(string Name);

        public formHomePage()
        {
            InitializeComponent();
            GetImpressoras();

            lBoxImpressoras.Text = GetImpressoraPadrao();
        }

        private void GetImpressoras()
        {
            foreach (string impressora in PrinterSettings.InstalledPrinters)
                lBoxImpressoras.Items.Add(impressora);
        }

        private string GetImpressoraPadrao()
        {
            var impressora = new PrinterSettings();
            return impressora.PrinterName;
        }

        private void tBoxKeyPress(object sender, KeyPressEventArgs c)
        {
            if (!char.IsControl(c.KeyChar) && !char.IsDigit(c.KeyChar))
            {
                c.Handled = true;
            }
        }


        private void btnImpeimir_Click(object sender, EventArgs e)
        {







            //Console.WriteLine(fOrigem);
        }

        public void atualizaPreview(string fOrigem, string fDestino, string nFiscal, string nomeResponsaveis, string nRamal,
        int nVolumes)
        {
            tBoxImpressao.Text = "Filial Origem: " + fOrigem + "\r\nFilial Destino: " + fDestino + "\r\nN° Nota Fiscal: " + nFiscal + " N° Volumes: " + nVolumes + "\r\n" + "Responssaveis: " +
                 nomeResponsaveis + " Número Ramal: " + nRamal;
        }

        private bool textBoxVazias()
        {
            //Valida se os campos estão vazio ou não
            foreach (Control c in this.Controls)
                if (c is TextBox)
                {
                    TextBox? textBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox?.Text))
                        return true;
                }
            return false;
        }

        private bool cBoxValoresAceitos()
        {
            string[] Filial = { "05 - Pontal", "08 - Cravinhos", "09 - Sertãozinho", "10 - CD",
                                "18 - Severinia", "22 - Morro Agudo", "23 - Frutal", "24 - Campo Florido",
                                "25 - Descalvado", "26 - Santa Rosa do Viterbo", "27 - Porto Ferreira",
                                "28 - Santa Cruz das palmeiras", "29 - Santa Rita do Passa Quatro",
                                "31 - Ituverava", "32 - Pitangueiras", "33 - Serrana", "37 - Paulo de faria",
                                "39 - Barretos", "40 - Batatais", "41 - Guaíra", "42 - Guará", "43 - Jaboticabal",
                                "52 - Monte Alto", "56 - Matão" };

            foreach (Control c in this.Controls) if (c is ComboBox)
                    if (c is ComboBox)
                    {
                        ComboBox? comboBox = c as ComboBox;
                        foreach (var item in Filial)
                        {
                            if (comboBox.Text == item)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
            return false;
        }

        private void formHomePage_Load(object sender, EventArgs e)
        {

            //Define como padrão uma filial selecionada
            cbFOrigem.SelectedIndex = 0;
            cbFDestino.SelectedIndex = 1;
            Size newSize = new Size(816, 513);
            //816; 513
            // Define o novo tamanho do formulário
            this.Size = newSize;
        }


        private void tboxNfiscal_TextChanged(object sender, EventArgs e)
        {
            //dava pra fazer usando um arrey  e um foreach para percorrer
            //por campos especificos que precisam de uma certa validação
            if (System.Text.RegularExpressions.Regex.IsMatch(tboxNfiscal.Text, "[^0-9]"))
            {
                // MessageBox.Show("Esse campo aceita apenas numeros!!");
                tboxNfiscal.Text = "";
            }
        }

        private void tboxNvolumes_TextChanged(object sender, EventArgs e)
        {
            //dava pra fazer usando um arrey  e um foreach para percorrer
            //por campos especificos que precisam de uma certa validação
            if (System.Text.RegularExpressions.Regex.IsMatch(tboxNvolumes.Text, "[^0-9]"))
            {
                //  MessageBox.Show("Esse campo aceita apenas numeros!!");
                tboxNvolumes.Text = "";
            }
        }

        private void tboxNramal_TextChanged(object sender, EventArgs e)
        {
            //dava pra fazer usando um arrey  e um foreach para percorrer
            //por campos especificos que precisam de uma certa validação
            if (System.Text.RegularExpressions.Regex.IsMatch(tboxNramal.Text, "[^0-9]"))
            {
                //  MessageBox.Show("Esse campo aceita apenas numeros!!");
                tboxNramal.Text = "";
            }
        }

        private void impressora_PrintPage(object sender, PrintPageEventArgs e)
        {
            string textoEtiqueta = tBoxImpressao.Text;
            Font fontImpressao = new Font("Arial", 14, FontStyle.Regular);
            SolidBrush corImpressao = new SolidBrush(Color.Black);
            Point LocalEtiqueta = new Point(50, 50);
            e.Graphics.DrawString(textoEtiqueta, fontImpressao, corImpressao, LocalEtiqueta);


        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            int QtVolumes;

            if (textBoxVazias())
            {
                MessageBox.Show("Favor Prencher todos os campos!");

            }
            else
            {

                QtVolumes = Convert.ToInt32(tboxNvolumes.Text);
                if (QtVolumes <= 0)
                {
                    MessageBox.Show("A quantidade de Volumes deve ser maior que 0");
                }
                else
                {
                    atualizaPreview(cbFOrigem.Text, cbFDestino.Text, tboxNfiscal.Text, tboxResponsaveis.Text, tboxNramal.Text, QtVolumes);
                }

            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int QtVolumes;
            if (textBoxVazias())
            {
                MessageBox.Show("Favor Prencher todos os campos!");

            }
            else
            {

                QtVolumes = Convert.ToInt32(tboxNvolumes.Text);
                if (QtVolumes <= 0)
                {
                    MessageBox.Show("A quantidade de Volumes deve ser maior que 0");
                }
                else
                {
                    //  Imprime
                    //   impressora.Print();
                    impressora.Print();

                }

            }
        }

        private void lBoxImpressoras_DoubleClick(object sender, EventArgs e)
        {
            if (SetDefaultPrinter(lBoxImpressoras.Text))
                lBoxImpressoras.Text = GetImpressoraPadrao();
        }

        private void btnSetPrinter_Click(object sender, EventArgs e)
        {
            Size newSize = new Size(1258, 513);
            //816; 513
            // Define o novo tamanho do formulário
            this.Size = newSize;
        }

        private void btnClosePrinterSettings_Click(object sender, EventArgs e)
        {
            Size newSize = new Size(816, 513);
            //816; 513
            // Define o novo tamanho do formulário
            this.Size = newSize;
        }
    }
}
