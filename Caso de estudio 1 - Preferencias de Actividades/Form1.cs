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
            NombreAlumnoTXT.Clear(); //Tambien se puede utilizar el metodo NombreAlumnoTXT.Text = ""; para limpiar el TextBox
            //Desmarcamos el checkbox de las actividades
            DibujoArtisticoCB.Checked = false;
            ProgramacionWebCB.Checked = false;
            InstrumentosMusicalesCB.Checked = false;
            AprendizajeDeLenguasCB.Checked = false;
            DeportesCB.Checked = false;
            //Desmarcar Radiobutton 
              PresencialRB.Checked = false;
                OnlineRB.Checked = false;
            HibridaRB.Checked = false;
            //Limpiar el TextBox del resumen
            ResumenTXT.Clear();
            //Reegresamos el cursor al TextBox del nombre
            NombreAlumnoTXT.Focus();
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
                actividades.Add("Deportes o Atletismo");
            }
            //========================
            //3-. Almenos una actividad seleccionada -- Esta seccion es en el ListBox donde se seleccionan las actividades
            if (actividades.Count == 0)
            {
                MessageBox.Show("Porfavor, selecciona al menos una actividad",
                    "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //======================
            // 4-. Obtener la modalidad seleccionada -- Esta seccion es en el ListBox donde se seleccionan las Modalidades
            //======================

            string modalidad = "";
            if (PresencialRB.Checked)
            {
                modalidad = "Presencial";

            }
            else if (OnlineRB.Checked)
            {
                modalidad = "Online";
            }
            else if (HibridaRB.Checked)
            {
                modalidad = "Hibrida";
            }
            else
            {
                MessageBox.Show("Porfavor, selecciona una modalidad",
                    "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
            //======================
            // 5-. Crear el resumen -- Esta seccion se mostrara el resumen de el nombre, las actividades y la modalidad seleccionada en el cuadro de texto de el resumen
            //======================

            string resumen =
                "RESUMEN DE PREFERENCIAS\r\n" +
                "--------------------------\r\n" +
                "Nombre: " + NombreAlumnoTXT.Text + "\r\n" +
                "Actividades: " + string.Join(", ", actividades) + "\r\n" +
                "Modalidad: " + modalidad;
            ResumenTXT.Text = resumen;
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

        private void OnlineRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ResumenTXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
