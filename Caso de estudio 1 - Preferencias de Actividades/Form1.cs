namespace Caso_de_estudio_1___Preferencias_de_Actividades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NombreAlumnoTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModalidadGB24_Enter(object sender, EventArgs e)
        {

        }

        private void ActividadesGB_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MostrarResumenBTN_Click(object sender, EventArgs e)
        //Esta seccion es en el boton donde se muestra el resumen de la informacion ingresada

        {
            //======================
            // 1-.Validar el nombre -- Esta seccion es en el TextBox donde se escribe el Nombre de el estudiante
            //======================
            if (string.IsNullOrWhiteSpace(NombreAlumnoTXT.Text))
            {
                MessageBox.Show("Porfavor, escribe tu nombre", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NombreAlumnoTXT.Focus();
            }
            //======================
            // 2-. Obtener las actividades seleccionadas -- Esta seccion es en el ListBox donde se seleccionan las actividades
            //======================
            List<String> actividades = new List<String>();
            //Esta sirve para hacer un registro de actividades que se van a realizar, si el usuario selecciona una actividad, se va a agregar a la lista de actividades
            //Se utiliza por cada checkbox que se tenga en el formulario, para saber cuales actividades se van a realizar
            if (DibujoArtisticoCB.Checked)
            {
                actividades.Add("Dibujo Artistico");
            }
            if (ProgramacionWebCB.Checked)
            {
                actividades.Add("Programacion web");

            }
            if (InstrumentosMusicalesCB.Checked)
            {
                actividades.Add("Instrumentos Musicales");
            }
            if (AprendizajeDeLenguasCB.Checked)
            {
                actividades.Add("Aprendizaje de lenguas");
            }
            if (DeportesCB.Checked)
            {
                actividades.Add("Deportes");
            }
                //========================
                //3-. Almenos una actividad seleccionada -- Esta seccion es en el ListBox donde se seleccionan las actividades
                if (actividades.Count == 0)
                {
                    MessageBox.Show("Porfavor, selecciona al menos una actividad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }


        private void DibujoArtisticoCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ProgramacionWebCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InstrumentosMusicalesCB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
