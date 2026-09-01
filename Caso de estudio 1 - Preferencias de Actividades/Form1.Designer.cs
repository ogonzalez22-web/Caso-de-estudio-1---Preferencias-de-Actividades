namespace Caso_de_estudio_1___Preferencias_de_Actividades
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NombreAlumnoTXT = new TextBox();
            ActividadesGB = new GroupBox();
            DeportesCB = new CheckBox();
            AprendizajeDeLenguasCB = new CheckBox();
            InstrumentosMusicalesCB = new CheckBox();
            ProgramacionWebCB = new CheckBox();
            DibujoArtisticoCB = new CheckBox();
            ModalidadGB24 = new GroupBox();
            HibridaRB = new RadioButton();
            OnlineRB = new RadioButton();
            PresencialRB = new RadioButton();
            LimpiarBTN = new Button();
            MostrarResumenBTN = new Button();
            label2 = new Label();
            ResumenTXT = new TextBox();
            ActividadesGB.SuspendLayout();
            ModalidadGB24.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Font = new Font("Sylfaen", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 47);
            label1.Name = "label1";
            label1.Size = new Size(338, 42);
            label1.TabIndex = 0;
            label1.Text = "Nombre de el Alumno";
            // 
            // NombreAlumnoTXT
            // 
            NombreAlumnoTXT.Location = new Point(537, 63);
            NombreAlumnoTXT.Margin = new Padding(3, 2, 3, 2);
            NombreAlumnoTXT.Name = "NombreAlumnoTXT";
            NombreAlumnoTXT.Size = new Size(469, 23);
            NombreAlumnoTXT.TabIndex = 1;
            NombreAlumnoTXT.TextChanged += NombreAlumnoTXT_TextChanged;
            // 
            // ActividadesGB
            // 
            ActividadesGB.BackColor = Color.AliceBlue;
            ActividadesGB.Controls.Add(DeportesCB);
            ActividadesGB.Controls.Add(AprendizajeDeLenguasCB);
            ActividadesGB.Controls.Add(InstrumentosMusicalesCB);
            ActividadesGB.Controls.Add(ProgramacionWebCB);
            ActividadesGB.Controls.Add(DibujoArtisticoCB);
            ActividadesGB.Location = new Point(167, 127);
            ActividadesGB.Margin = new Padding(3, 2, 3, 2);
            ActividadesGB.Name = "ActividadesGB";
            ActividadesGB.Padding = new Padding(3, 2, 3, 2);
            ActividadesGB.Size = new Size(373, 178);
            ActividadesGB.TabIndex = 2;
            ActividadesGB.TabStop = false;
            ActividadesGB.Text = "Actividades preferentes";
            ActividadesGB.Enter += ActividadesGB_Enter;
            // 
            // DeportesCB
            // 
            DeportesCB.AutoSize = true;
            DeportesCB.Location = new Point(28, 136);
            DeportesCB.Margin = new Padding(3, 2, 3, 2);
            DeportesCB.Name = "DeportesCB";
            DeportesCB.Size = new Size(137, 19);
            DeportesCB.TabIndex = 4;
            DeportesCB.Text = "Deportes o Atletismo";
            DeportesCB.UseVisualStyleBackColor = true;
            // 
            // AprendizajeDeLenguasCB
            // 
            AprendizajeDeLenguasCB.AutoSize = true;
            AprendizajeDeLenguasCB.Location = new Point(28, 113);
            AprendizajeDeLenguasCB.Margin = new Padding(3, 2, 3, 2);
            AprendizajeDeLenguasCB.Name = "AprendizajeDeLenguasCB";
            AprendizajeDeLenguasCB.Size = new Size(154, 19);
            AprendizajeDeLenguasCB.TabIndex = 3;
            AprendizajeDeLenguasCB.Text = "Aprendizaje de Lenguas ";
            AprendizajeDeLenguasCB.UseVisualStyleBackColor = true;
            AprendizajeDeLenguasCB.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // InstrumentosMusicalesCB
            // 
            InstrumentosMusicalesCB.AutoSize = true;
            InstrumentosMusicalesCB.Location = new Point(28, 91);
            InstrumentosMusicalesCB.Margin = new Padding(3, 2, 3, 2);
            InstrumentosMusicalesCB.Name = "InstrumentosMusicalesCB";
            InstrumentosMusicalesCB.Size = new Size(151, 19);
            InstrumentosMusicalesCB.TabIndex = 2;
            InstrumentosMusicalesCB.Text = "Instrumentos Musicales";
            InstrumentosMusicalesCB.UseVisualStyleBackColor = true;
            InstrumentosMusicalesCB.CheckedChanged += InstrumentosMusicalesCB_CheckedChanged;
            // 
            // ProgramacionWebCB
            // 
            ProgramacionWebCB.AutoSize = true;
            ProgramacionWebCB.Location = new Point(28, 68);
            ProgramacionWebCB.Margin = new Padding(3, 2, 3, 2);
            ProgramacionWebCB.Name = "ProgramacionWebCB";
            ProgramacionWebCB.Size = new Size(128, 19);
            ProgramacionWebCB.TabIndex = 1;
            ProgramacionWebCB.Text = "Programacion Web";
            ProgramacionWebCB.UseVisualStyleBackColor = true;
            ProgramacionWebCB.CheckedChanged += ProgramacionWebCB_CheckedChanged;
            // 
            // DibujoArtisticoCB
            // 
            DibujoArtisticoCB.AutoSize = true;
            DibujoArtisticoCB.Location = new Point(28, 46);
            DibujoArtisticoCB.Margin = new Padding(3, 2, 3, 2);
            DibujoArtisticoCB.Name = "DibujoArtisticoCB";
            DibujoArtisticoCB.Size = new Size(108, 19);
            DibujoArtisticoCB.TabIndex = 0;
            DibujoArtisticoCB.Text = "Dibujo Artistico";
            DibujoArtisticoCB.UseVisualStyleBackColor = true;
            DibujoArtisticoCB.CheckedChanged += DibujoArtisticoCB_CheckedChanged;
            // 
            // ModalidadGB24
            // 
            ModalidadGB24.BackColor = Color.AliceBlue;
            ModalidadGB24.Controls.Add(HibridaRB);
            ModalidadGB24.Controls.Add(OnlineRB);
            ModalidadGB24.Controls.Add(PresencialRB);
            ModalidadGB24.Location = new Point(620, 127);
            ModalidadGB24.Margin = new Padding(3, 2, 3, 2);
            ModalidadGB24.Name = "ModalidadGB24";
            ModalidadGB24.Padding = new Padding(3, 2, 3, 2);
            ModalidadGB24.Size = new Size(367, 178);
            ModalidadGB24.TabIndex = 3;
            ModalidadGB24.TabStop = false;
            ModalidadGB24.Text = "Modalidad Preferida";
            ModalidadGB24.Enter += ModalidadGB24_Enter;
            // 
            // HibridaRB
            // 
            HibridaRB.AutoSize = true;
            HibridaRB.Location = new Point(49, 135);
            HibridaRB.Margin = new Padding(3, 2, 3, 2);
            HibridaRB.Name = "HibridaRB";
            HibridaRB.Size = new Size(64, 19);
            HibridaRB.TabIndex = 2;
            HibridaRB.TabStop = true;
            HibridaRB.Text = "Hibrida";
            HibridaRB.UseVisualStyleBackColor = true;
            // 
            // OnlineRB
            // 
            OnlineRB.AutoSize = true;
            OnlineRB.Location = new Point(49, 90);
            OnlineRB.Margin = new Padding(3, 2, 3, 2);
            OnlineRB.Name = "OnlineRB";
            OnlineRB.Size = new Size(60, 19);
            OnlineRB.TabIndex = 1;
            OnlineRB.TabStop = true;
            OnlineRB.Text = "Online";
            OnlineRB.UseVisualStyleBackColor = true;
            OnlineRB.CheckedChanged += OnlineRB_CheckedChanged;
            // 
            // PresencialRB
            // 
            PresencialRB.AutoSize = true;
            PresencialRB.Location = new Point(49, 45);
            PresencialRB.Margin = new Padding(3, 2, 3, 2);
            PresencialRB.Name = "PresencialRB";
            PresencialRB.Size = new Size(78, 19);
            PresencialRB.TabIndex = 0;
            PresencialRB.TabStop = true;
            PresencialRB.Text = "Presencial";
            PresencialRB.UseVisualStyleBackColor = true;
            PresencialRB.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // LimpiarBTN
            // 
            LimpiarBTN.BackColor = Color.SkyBlue;
            LimpiarBTN.Location = new Point(648, 323);
            LimpiarBTN.Margin = new Padding(3, 2, 3, 2);
            LimpiarBTN.Name = "LimpiarBTN";
            LimpiarBTN.Size = new Size(316, 50);
            LimpiarBTN.TabIndex = 0;
            LimpiarBTN.Text = "Limpiar";
            LimpiarBTN.UseVisualStyleBackColor = false;
            LimpiarBTN.Click += button1_Click;
            // 
            // MostrarResumenBTN
            // 
            MostrarResumenBTN.BackColor = Color.LightSkyBlue;
            MostrarResumenBTN.Location = new Point(195, 323);
            MostrarResumenBTN.Margin = new Padding(3, 2, 3, 2);
            MostrarResumenBTN.Name = "MostrarResumenBTN";
            MostrarResumenBTN.Size = new Size(305, 50);
            MostrarResumenBTN.TabIndex = 4;
            MostrarResumenBTN.Text = "Mostrar Resumen";
            MostrarResumenBTN.UseVisualStyleBackColor = false;
            MostrarResumenBTN.Click += MostrarResumenBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Sylfaen", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 430);
            label2.Name = "label2";
            label2.Size = new Size(159, 42);
            label2.TabIndex = 5;
            label2.Text = "Resumen:";
            label2.Click += label2_Click;
            // 
            // ResumenTXT
            // 
            ResumenTXT.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResumenTXT.Location = new Point(109, 479);
            ResumenTXT.Margin = new Padding(3, 2, 3, 2);
            ResumenTXT.Multiline = true;
            ResumenTXT.Name = "ResumenTXT";
            ResumenTXT.ReadOnly = true;
            ResumenTXT.Size = new Size(982, 127);
            ResumenTXT.TabIndex = 6;
            ResumenTXT.TextChanged += ResumenTXT_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1212, 658);
            Controls.Add(ResumenTXT);
            Controls.Add(label2);
            Controls.Add(LimpiarBTN);
            Controls.Add(MostrarResumenBTN);
            Controls.Add(ModalidadGB24);
            Controls.Add(ActividadesGB);
            Controls.Add(NombreAlumnoTXT);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Actividades preferentes";
            ActividadesGB.ResumeLayout(false);
            ActividadesGB.PerformLayout();
            ModalidadGB24.ResumeLayout(false);
            ModalidadGB24.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NombreAlumnoTXT;
        private GroupBox ActividadesGB;
        private GroupBox ModalidadGB24;
        private Button LimpiarBTN;
        private Button MostrarResumenBTN;
        private Label label2;
        private TextBox ResumenTXT;
        private CheckBox DeportesCB;
        private CheckBox AprendizajeDeLenguasCB;
        private CheckBox InstrumentosMusicalesCB;
        private CheckBox ProgramacionWebCB;
        private CheckBox DibujoArtisticoCB;
        private RadioButton HibridaRB;
        private RadioButton OnlineRB;
        private RadioButton PresencialRB;
    }
}
