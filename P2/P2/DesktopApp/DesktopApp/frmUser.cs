using UtilsApp.DTOs;
using UtilsApp.Services;

namespace DesktopApp
{
    public partial class frmUser : Form
    {
        const string API_URL = "https://localhost:7104/api/User";
        private readonly UserServices userService;

        public frmUser()
        {
            InitializeComponent();
            userService = new UserServices(API_URL, new HttpClient());
        }

        private async void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string username = txtBuscarUsuario.Text;

            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Por favor, Digite o nome do usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var users = await userService.GetByName(username);

            if (users != null)
            {
                dgvUser.DataSource = users;
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserDTO user = (UserDTO)dgvUser.Rows[e.RowIndex].DataBoundItem;

            var frmDetailsUser = new frmDetailsUser(this, user);

            frmDetailsUser.Show();
        }

        private void tstmiAdicionarUsuario_Click(object sender, EventArgs e)
        {
            var frmAddUser = new frmAddUser(this);

            frmAddUser.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmAddUser = new frmAddUser(this);

            frmAddUser.Show();
        }

        private void tsmiGerenciarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
