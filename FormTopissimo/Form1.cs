namespace FormTopissimo
{
    public partial class Form1 : Form
    {
        List<string> produtos = new List<string> {"Chinela", "Relógio", "Rafitos", "Dollynho"};
        
        public Form1()
        {
            InitializeComponent();
        }

        void geraForm(string produto)
        {
            Panel panel = new Panel();
            panel.Name = "panel";
            panel.BackColor = Color.AliceBlue;
            panel.Size = new Size(100, 100);

            Label label = new Label();
            // label.name =...
            label.Text = produto;
            label.AutoSize = true;
            label.Location = new Point(0, 0);

            void comprar (object sender, EventArgs e) 
            {
                label.Text = "comprado";
                panel.BackColor = Color.Green;
            }

            Button button = new Button();
            button.Text = "COMPRAR";
            button.Location = new Point(0, label.Height);
            button.Click += comprar; 


            panel.Controls.Add(label);
            panel.Controls.Add(button);
            panel.Location = new Point(0, panel1.Height);

            if (panel1.Height < 500)
                panel1.Height += panel.Height + 10;


            panel1.Controls.Add(panel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string produto in produtos)
            {
                geraForm(produto);
            }
        }
    }
}