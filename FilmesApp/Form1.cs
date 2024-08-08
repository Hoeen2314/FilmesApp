using FilmesApp.Moddels;

namespace FilmesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Contexto db;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.db = new Contexto();
            this.db.Database.EnsureCreated();
        }
    }
}
