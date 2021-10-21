using System.Data;
using CapaLogica.Login;
using System.Windows.Forms;

namespace CapaVista.Usuarios
{
    public partial class CV_UCUsuarios : UserControl
    {
        public CV_UCUsuarios()
        {
            InitializeComponent();
            DiseñoDgv();
            panelBusqueda.Visible = false;
        }

        private void BtnBuscar_Click(object sender, System.EventArgs e)
        {
            panelBusqueda.Visible = true;
            CL_BuscarUsuarios Usuarios = new CL_BuscarUsuarios();
            dgvUsuarios.DataSource = Usuarios.Buscar(txtPalabra.Text);
        }


        private void CV_UCUsuarios_Load(object sender, System.EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void BtnCerrar_Click_1(object sender, System.EventArgs e)
        {
            Dispose();
        }
        private void DiseñoDgv()
        {
            dgvUsuarios.ReadOnly = true; //hace que la grilla no se pueda editar
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona toda la fila
            dgvUsuarios.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;//alterna colores de las filas
            dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;//alterna colores de las filas
            dgvUsuarios.AllowUserToAddRows = false; //desactiva la ultima fila 
        }

        private void DgvUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
