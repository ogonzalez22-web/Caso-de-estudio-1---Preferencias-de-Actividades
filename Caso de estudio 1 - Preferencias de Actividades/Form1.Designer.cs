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
            label1.Location = new Point(160, 63);
            label1.Name = "label1";
            label1.Size = new Size(412, 52);
            label1.TabIndex = 0;
            label1.Text = "Nombre de el Alumno";
            // 
            // NombreAlumnoTXT
            // 
            NombreAlumnoTXT.Location = new Point(614, 84);
            NombreAlumnoTXT.Name = "NombreAlumnoTXT";
            NombreAlumnoTXT.Size = new Size(535, 27);
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
            ActividadesGB.Location = new Point(191, 169);
            ActividadesGB.Name = "ActividadesGB";
            ActividadesGB.Size = new Size(426, 238);
            ActividadesGB.TabIndex = 2;
            ActividadesGB.TabStop = false;
            ActividadesGB.Text = "Actividades preferentes";
            ActividadesGB.Enter += ActividadesGB_Enter;
            // 
            // DeportesCB
            // 
            DeportesCB.AutoSize = true;
            DeportesCB.Location = new Point(32, 181);
            DeportesCB.Name = "DeportesCB";
            DeportesCB.Size = new Size(173, 24);
            DeportesCB.TabIndex = 4;
            DeportesCB.Text = "Deportes o Atletismo";
            DeportesCB.UseVisualStyleBackColor = true;
            // 
            // AprendizajeDeLenguasCB
            // 
            AprendizajeDeLenguasCB.AutoSize = true;
            AprendizajeDeLenguasCB.Location = new Point(32, 151);
            AprendizajeDeLenguasCB.Name = "AprendizajeDeLenguasCB";
            AprendizajeDeLenguasCB.Size = new Size(194, 24);
            AprendizajeDeLenguasCB.TabIndex = 3;
            AprendizajeDeLenguasCB.Text = "Aprendizaje de Lenguas ";
            AprendizajeDeLenguasCB.UseVisualStyleBackColor = true;
            AprendizajeDeLenguasCB.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // InstrumentosMusicalesCB
            // 
            InstrumentosMusicalesCB.AutoSize = true;
            InstrumentosMusicalesCB.Location = new Point(32, 121);
            InstrumentosMusicalesCB.Name = "InstrumentosMusicalesCB";
            InstrumentosMusicalesCB.Size = new Size(184, 24);
            InstrumentosMusicalesCB.TabIndex = 2;
            InstrumentosMusicalesCB.Text = "Instrumentos Musicales";
            InstrumentosMusicalesCB.UseVisualStyleBackColor = true;
            InstrumentosMusicalesCB.CheckedChanged += InstrumentosMusicalesCB_CheckedChanged;
            // 
            // ProgramacionWebCB
            // 
            ProgramacionWebCB.AutoSize = true;
            ProgramacionWebCB.Location = new Point(32, 91);
            ProgramacionWebCB.Name = "ProgramacionWebCB";
            ProgramacionWebCB.Size = new Size(158, 24);
            ProgramacionWebCB.TabIndex = 1;
            ProgramacionWebCB.Text = "Programacion Web";
            ProgramacionWebCB.UseVisualStyleBackColor = true;
            ProgramacionWebCB.CheckedChanged += ProgramacionWebCB_CheckedChanged;
            // 
            // DibujoArtisticoCB
            // 
            DibujoArtisticoCB.AutoSize = true;
            DibujoArtisticoCB.Location = new Point(32, 61);
            DibujoArtisticoCB.Name = "DibujoArtisticoCB";
            DibujoArtisticoCB.Size = new Size(135, 24);
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
            ModalidadGB24.Location = new Point(709, 169);
            ModalidadGB24.Name = "ModalidadGB24";
            ModalidadGB24.Size = new Size(419, 238);
            ModalidadGB24.TabIndex = 3;
            ModalidadGB24.TabStop = false;
            ModalidadGB24.Text = "Modalidad Preferida";
            ModalidadGB24.Enter += ModalidadGB24_Enter;
            // 
            // HibridaRB
            // 
            HibridaRB.AutoSize = true;
            HibridaRB.Location = new Point(56, 180);
            HibridaRB.Name = "HibridaRB";
            HibridaRB.Size = new Size(80, 24);
            HibridaRB.TabIndex = 2;
            HibridaRB.TabStop = true;
            HibridaRB.Text = "Hibrida";
            HibridaRB.UseVisualStyleBackColor = true;
            // 
            // OnlineRB
            // 
            OnlineRB.AutoSize = true;
            OnlineRB.Location = new Point(56, 120);
            OnlineRB.Name = "OnlineRB";
            OnlineRB.Size = new Size(73, 24);
            OnlineRB.TabIndex = 1;
            OnlineRB.TabStop = true;
            OnlineRB.Text = "Online";
            OnlineRB.UseVisualStyleBackColor = true;
            // 
            // PresencialRB
            // 
            PresencialRB.AutoSize = true;
            PresencialRB.Location = new Point(56, 60);
            PresencialRB.Name = "PresencialRB";
            PresencialRB.Size = new Size(96, 24);
            PresencialRB.TabIndex = 0;
            PresencialRB.TabStop = true;
            PresencialRB.Text = "Presencial";
            PresencialRB.UseVisualStyleBackColor = true;
            PresencialRB.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // LimpiarBTN
            // 
            LimpiarBTN.BackColor = Color.SkyBlue;
            LimpiarBTN.Location = new Point(741, 431);
            LimpiarBTN.Name = "LimpiarBTN";
            LimpiarBTN.Size = new Size(361, 66);
            LimpiarBTN.TabIndex = 0;
            LimpiarBTN.Text = "Limpiar";
            LimpiarBTN.UseVisualStyleBackColor = false;
            LimpiarBTN.Click += button1_Click;
            // 
            // MostrarResumenBTN
            // 
            MostrarResumenBTN.BackColor = Color.LightSkyBlue;
            MostrarResumenBTN.Location = new Point(223, 431);
            MostrarResumenBTN.Name = "MostrarResumenBTN";
            MostrarResumenBTN.Size = new Size(349, 66);
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
            label2.Location = new Point(57, 574);
            label2.Name = "label2";
            label2.Size = new Size(194, 52);
            label2.TabIndex = 5;
            label2.Text = "Resumen:";
            label2.Click += label2_Click;
            // 
            // ResumenTXT
            // 
            ResumenTXT.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResumenTXT.Location = new Point(125, 639);
            ResumenTXT.Multiline = true;
            ResumenTXT.Name = "ResumenTXT";
            ResumenTXT.ReadOnly = true;
            ResumenTXT.Size = new Size(1122, 168);
            ResumenTXT.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1376, 849);
            Controls.Add(ResumenTXT);
            Controls.Add(label2);
            Controls.Add(LimpiarBTN);
            Controls.Add(MostrarResumenBTN);
            Controls.Add(ModalidadGB24);
            Controls.Add(ActividadesGB);
            Controls.Add(NombreAlumnoTXT);
            Controls.Add(label1);
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
