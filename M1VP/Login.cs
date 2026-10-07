namespace M1VP
{
    public partial class Login : Form
    {
        public Data data;
        public Login(Data data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();

            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(inputLoginUser.Text == "" || inputLoginPass.Text == "")
            {
                MessageBox.Show("Username atau password jangan kosong!");
                return;
            }

            foreach(Player p in data.ListPlayer)
            {
                if (p.username == inputLoginUser.Text && p.password == inputLoginPass.Text)
                {
                    this.data.CurrentPlayer = p;

                    MainMenu menu = new MainMenu(this);
                    menu.Show();

                    this.Hide();

                    return;
                }

            }

            MessageBox.Show("Username atau password salah!");
        }
    }
}
