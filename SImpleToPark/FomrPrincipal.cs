using System.Data;
using Microsoft.VisualBasic;

namespace SImpleToPark
{
    public partial class Form1 : Form
    {

        private DataTable bancoDeDados;

        public Form1()
        {
            InitializeComponent();

            bancoDeDados = new DataTable();

            bancoDeDados = new DataTable("Estacionamento");
            bancoDeDados.Columns.Add("Placa", typeof(string));
            bancoDeDados.Columns.Add("Entrada", typeof(string));

            dataGridView1CarrosEstacionados.DataSource = bancoDeDados;


        }

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelValorArrecadado = new Label();
            dataGridView1CarrosEstacionados = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonCadastrar = new Button();
            buttonConfigurar = new Button();
            labelValordaHora = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1CarrosEstacionados).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.3103447F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.68965F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(725, 500);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(labelValorArrecadado, 0, 1);
            tableLayoutPanel2.Controls.Add(dataGridView1CarrosEstacionados, 0, 0);
            tableLayoutPanel2.Location = new Point(172, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85.4251F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5748987F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(550, 494);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelValorArrecadado
            // 
            labelValorArrecadado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelValorArrecadado.AutoSize = true;
            labelValorArrecadado.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValorArrecadado.Location = new Point(324, 454);
            labelValorArrecadado.Name = "labelValorArrecadado";
            labelValorArrecadado.Size = new Size(223, 19);
            labelValorArrecadado.TabIndex = 0;
            labelValorArrecadado.Text = "Valor da Arrecadado R$ 0,00";
            // 
            // dataGridView1CarrosEstacionados
            // 
            dataGridView1CarrosEstacionados.AllowUserToAddRows = false;
            dataGridView1CarrosEstacionados.AllowUserToDeleteRows = false;
            dataGridView1CarrosEstacionados.AllowUserToResizeColumns = false;
            dataGridView1CarrosEstacionados.AllowUserToResizeRows = false;
            dataGridView1CarrosEstacionados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1CarrosEstacionados.BackgroundColor = Color.White;
            dataGridView1CarrosEstacionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1CarrosEstacionados.Location = new Point(3, 3);
            dataGridView1CarrosEstacionados.Name = "dataGridView1CarrosEstacionados";
            dataGridView1CarrosEstacionados.ReadOnly = true;
            dataGridView1CarrosEstacionados.RowHeadersVisible = false;
            dataGridView1CarrosEstacionados.Size = new Size(544, 398);
            dataGridView1CarrosEstacionados.TabIndex = 1;
            dataGridView1CarrosEstacionados.CellContentClick += dataGridView1CarrosEstacionados_CellContentClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonCadastrar, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonConfigurar, 0, 2);
            tableLayoutPanel3.Controls.Add(labelValordaHora, 0, 1);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.565218F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80.4347839F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tableLayoutPanel3.Size = new Size(163, 494);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCadastrar.BackColor = Color.Silver;
            buttonCadastrar.Location = new Point(3, 3);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(157, 66);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += button1_Click;
            // 
            // buttonConfigurar
            // 
            buttonConfigurar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonConfigurar.BackColor = Color.Silver;
            buttonConfigurar.Location = new Point(3, 371);
            buttonConfigurar.Name = "buttonConfigurar";
            buttonConfigurar.Size = new Size(157, 120);
            buttonConfigurar.TabIndex = 1;
            buttonConfigurar.Text = "Configurar";
            buttonConfigurar.UseVisualStyleBackColor = false;
            buttonConfigurar.Click += button2_Click;
            // 
            // labelValordaHora
            // 
            labelValordaHora.AutoSize = true;
            labelValordaHora.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValordaHora.Location = new Point(3, 72);
            labelValordaHora.Name = "labelValordaHora";
            labelValordaHora.Size = new Size(141, 38);
            labelValordaHora.TabIndex = 2;
            labelValordaHora.Text = "Valor da Hora R$ 0,00";
            labelValordaHora.TextAlign = ContentAlignment.BottomLeft;
            labelValordaHora.Click += labelValordaHora_Click;
            // 
            // Form1
            // 
            BackColor = Color.Goldenrod;
            ClientSize = new Size(749, 524);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            ShowIcon = false;
            Text = "Simple To Park";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1CarrosEstacionados).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelValorArrecadado;
        private DataGridView dataGridView1CarrosEstacionados;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonCadastrar;
        private Button buttonConfigurar;
        private Label labelValordaHora;

        private void button1_Click(object sender, EventArgs e)
        {
            var placa = Interaction.InputBox("Digite a placa do veículo:", "Entrada do Veículo");
            if (!string.IsNullOrEmpty(placa))
            {
                bancoDeDados.Rows.Add(new string[] { placa, DateTime.Now.ToString() });
                dataGridView1CarrosEstacionados.Rows[dataGridView1CarrosEstacionados.Rows.Count - 1].MinimumHeight = 30;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void labelValordaHora_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1CarrosEstacionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
