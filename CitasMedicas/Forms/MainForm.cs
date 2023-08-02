using CitasMedicas.Forms;

namespace CitasMedicas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formRegisterDoctor = new RegisterDoctorForm();
            formRegisterDoctor.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formUpdatedDoctor = new UpdatedDoctorForm();
            formUpdatedDoctor.ShowDialog();
        }

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formRegisterPatient = new RegisterPatientForm();
            formRegisterPatient.ShowDialog();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formUpdatedPatient = new UpdatedPatientForm();
            formUpdatedPatient.ShowDialog();
        }

        private void requestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}