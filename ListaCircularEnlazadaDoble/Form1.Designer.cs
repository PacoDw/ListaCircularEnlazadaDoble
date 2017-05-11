namespace ListaCircularEnlazadaDoble
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dTimerFecha = new System.Windows.Forms.DateTimePicker();
            this.bttonAgregar = new System.Windows.Forms.Button();
            this.bttonAddPrincipio = new System.Windows.Forms.Button();
            this.bttonBuscar = new System.Windows.Forms.Button();
            this.bttonEliminar = new System.Windows.Forms.Button();
            this.bttonEliminarPrimero = new System.Windows.Forms.Button();
            this.bttonEliminarUltimo = new System.Windows.Forms.Button();
            this.bttonMostrarReporte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.txtAddMinutos = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttonAddFinal = new System.Windows.Forms.Button();
            this.bttonInsertarDespuesDe = new System.Windows.Forms.Button();
            this.txtNombreD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bttonReset = new System.Windows.Forms.Button();
            this.bttonRecorrido = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreRecorrido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(83, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 17);
            this.txtNombre.TabIndex = 0;
            // 
            // dTimerFecha
            // 
            this.dTimerFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTimerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimerFecha.Location = new System.Drawing.Point(12, 128);
            this.dTimerFecha.Name = "dTimerFecha";
            this.dTimerFecha.Size = new System.Drawing.Size(199, 22);
            this.dTimerFecha.TabIndex = 2;
            // 
            // bttonAgregar
            // 
            this.bttonAgregar.AutoSize = true;
            this.bttonAgregar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonAgregar.Location = new System.Drawing.Point(261, 12);
            this.bttonAgregar.Name = "bttonAgregar";
            this.bttonAgregar.Size = new System.Drawing.Size(114, 42);
            this.bttonAgregar.TabIndex = 5;
            this.bttonAgregar.Text = "Agregar \r\nordenado";
            this.bttonAgregar.UseVisualStyleBackColor = true;
            this.bttonAgregar.Click += new System.EventHandler(this.bttonAgregar_Click);
            // 
            // bttonAddPrincipio
            // 
            this.bttonAddPrincipio.AutoSize = true;
            this.bttonAddPrincipio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttonAddPrincipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonAddPrincipio.Location = new System.Drawing.Point(260, 60);
            this.bttonAddPrincipio.Name = "bttonAddPrincipio";
            this.bttonAddPrincipio.Size = new System.Drawing.Size(115, 42);
            this.bttonAddPrincipio.TabIndex = 6;
            this.bttonAddPrincipio.Text = "Agregar al \r\nprincipio";
            this.bttonAddPrincipio.UseVisualStyleBackColor = true;
            this.bttonAddPrincipio.Click += new System.EventHandler(this.bttonAddPrincipio_Click);
            // 
            // bttonBuscar
            // 
            this.bttonBuscar.AutoSize = true;
            this.bttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonBuscar.Location = new System.Drawing.Point(381, 12);
            this.bttonBuscar.Name = "bttonBuscar";
            this.bttonBuscar.Size = new System.Drawing.Size(115, 42);
            this.bttonBuscar.TabIndex = 8;
            this.bttonBuscar.Text = "Buscar";
            this.bttonBuscar.UseVisualStyleBackColor = true;
            this.bttonBuscar.Click += new System.EventHandler(this.bttonBuscar_Click);
            // 
            // bttonEliminar
            // 
            this.bttonEliminar.AutoSize = true;
            this.bttonEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonEliminar.Location = new System.Drawing.Point(381, 60);
            this.bttonEliminar.Name = "bttonEliminar";
            this.bttonEliminar.Size = new System.Drawing.Size(115, 42);
            this.bttonEliminar.TabIndex = 9;
            this.bttonEliminar.Text = "Eliminar";
            this.bttonEliminar.UseVisualStyleBackColor = true;
            this.bttonEliminar.Click += new System.EventHandler(this.bttonEliminar_Click);
            // 
            // bttonEliminarPrimero
            // 
            this.bttonEliminarPrimero.AutoSize = true;
            this.bttonEliminarPrimero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttonEliminarPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonEliminarPrimero.Location = new System.Drawing.Point(381, 108);
            this.bttonEliminarPrimero.Name = "bttonEliminarPrimero";
            this.bttonEliminarPrimero.Size = new System.Drawing.Size(115, 42);
            this.bttonEliminarPrimero.TabIndex = 10;
            this.bttonEliminarPrimero.Text = "Eliminar el \r\nprimero";
            this.bttonEliminarPrimero.UseVisualStyleBackColor = true;
            this.bttonEliminarPrimero.Click += new System.EventHandler(this.bttonEliminarPrimero_Click);
            // 
            // bttonEliminarUltimo
            // 
            this.bttonEliminarUltimo.AutoSize = true;
            this.bttonEliminarUltimo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttonEliminarUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonEliminarUltimo.Location = new System.Drawing.Point(502, 12);
            this.bttonEliminarUltimo.Name = "bttonEliminarUltimo";
            this.bttonEliminarUltimo.Size = new System.Drawing.Size(115, 42);
            this.bttonEliminarUltimo.TabIndex = 11;
            this.bttonEliminarUltimo.Text = "Eliminar el \r\núltimo";
            this.bttonEliminarUltimo.UseVisualStyleBackColor = true;
            this.bttonEliminarUltimo.Click += new System.EventHandler(this.bttonEliminarUltimo_Click);
            // 
            // bttonMostrarReporte
            // 
            this.bttonMostrarReporte.AutoSize = true;
            this.bttonMostrarReporte.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttonMostrarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonMostrarReporte.Location = new System.Drawing.Point(510, 178);
            this.bttonMostrarReporte.Name = "bttonMostrarReporte";
            this.bttonMostrarReporte.Size = new System.Drawing.Size(115, 42);
            this.bttonMostrarReporte.TabIndex = 12;
            this.bttonMostrarReporte.Text = "Actualizar \r\nreporte";
            this.bttonMostrarReporte.UseVisualStyleBackColor = true;
            this.bttonMostrarReporte.Click += new System.EventHandler(this.bttonMostrarReporte_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // txtReporte
            // 
            this.txtReporte.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReporte.Location = new System.Drawing.Point(6, 287);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ReadOnly = true;
            this.txtReporte.Size = new System.Drawing.Size(619, 122);
            this.txtReporte.TabIndex = 0;
            this.txtReporte.TabStop = false;
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.Location = new System.Drawing.Point(10, 49);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(65, 16);
            this.lblMinutos.TabIndex = 0;
            this.lblMinutos.Text = "Minutos:";
            // 
            // txtAddMinutos
            // 
            this.txtAddMinutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddMinutos.Location = new System.Drawing.Point(83, 50);
            this.txtAddMinutos.Name = "txtAddMinutos";
            this.txtAddMinutos.Size = new System.Drawing.Size(129, 17);
            this.txtAddMinutos.TabIndex = 1;
            this.txtAddMinutos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAddMinutos_KeyUp);
            // 
            // txtHora
            // 
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(13, 79);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(39, 33);
            this.txtHora.TabIndex = 0;
            this.txtHora.TabStop = false;
            // 
            // txtMinutos
            // 
            this.txtMinutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutos.Location = new System.Drawing.Point(71, 79);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.ReadOnly = true;
            this.txtMinutos.Size = new System.Drawing.Size(39, 33);
            this.txtMinutos.TabIndex = 0;
            this.txtMinutos.TabStop = false;
            // 
            // txtSegundos
            // 
            this.txtSegundos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundos.Location = new System.Drawing.Point(131, 79);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.ReadOnly = true;
            this.txtSegundos.Size = new System.Drawing.Size(39, 33);
            this.txtSegundos.TabIndex = 0;
            this.txtSegundos.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = ":";
            // 
            // bttonAddFinal
            // 
            this.bttonAddFinal.AutoSize = true;
            this.bttonAddFinal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttonAddFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonAddFinal.Location = new System.Drawing.Point(260, 108);
            this.bttonAddFinal.Name = "bttonAddFinal";
            this.bttonAddFinal.Size = new System.Drawing.Size(115, 42);
            this.bttonAddFinal.TabIndex = 7;
            this.bttonAddFinal.Text = "Agregar al \r\nfinal";
            this.bttonAddFinal.UseVisualStyleBackColor = true;
            this.bttonAddFinal.Click += new System.EventHandler(this.bttonAddFinal_Click);
            // 
            // bttonInsertarDespuesDe
            // 
            this.bttonInsertarDespuesDe.AutoSize = true;
            this.bttonInsertarDespuesDe.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bttonInsertarDespuesDe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttonInsertarDespuesDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonInsertarDespuesDe.Location = new System.Drawing.Point(12, 178);
            this.bttonInsertarDespuesDe.Name = "bttonInsertarDespuesDe";
            this.bttonInsertarDespuesDe.Size = new System.Drawing.Size(114, 42);
            this.bttonInsertarDespuesDe.TabIndex = 4;
            this.bttonInsertarDespuesDe.Text = "Insertar\r\ndespúes de";
            this.bttonInsertarDespuesDe.UseVisualStyleBackColor = true;
            this.bttonInsertarDespuesDe.Click += new System.EventHandler(this.bttonInsertarDespuesDe_Click);
            // 
            // txtNombreD
            // 
            this.txtNombreD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreD.Location = new System.Drawing.Point(143, 203);
            this.txtNombreD.Name = "txtNombreD";
            this.txtNombreD.Size = new System.Drawing.Size(95, 17);
            this.txtNombreD.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bttonReset
            // 
            this.bttonReset.AutoSize = true;
            this.bttonReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonReset.Location = new System.Drawing.Point(184, 81);
            this.bttonReset.Name = "bttonReset";
            this.bttonReset.Size = new System.Drawing.Size(54, 28);
            this.bttonReset.TabIndex = 0;
            this.bttonReset.TabStop = false;
            this.bttonReset.Text = "Reset";
            this.bttonReset.UseVisualStyleBackColor = true;
            this.bttonReset.Click += new System.EventHandler(this.bttonReset_Click);
            // 
            // bttonRecorrido
            // 
            this.bttonRecorrido.AutoSize = true;
            this.bttonRecorrido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttonRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonRecorrido.Location = new System.Drawing.Point(11, 226);
            this.bttonRecorrido.Name = "bttonRecorrido";
            this.bttonRecorrido.Size = new System.Drawing.Size(115, 42);
            this.bttonRecorrido.TabIndex = 12;
            this.bttonRecorrido.Text = "Mostrar \r\nReccorrido";
            this.bttonRecorrido.UseVisualStyleBackColor = true;
            this.bttonRecorrido.Click += new System.EventHandler(this.bttonRecorrido_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // txtNombreRecorrido
            // 
            this.txtNombreRecorrido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRecorrido.Location = new System.Drawing.Point(143, 251);
            this.txtNombreRecorrido.Name = "txtNombreRecorrido";
            this.txtNombreRecorrido.Size = new System.Drawing.Size(95, 17);
            this.txtNombreRecorrido.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hora inicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hora final";
            // 
            // dHoraInicio
            // 
            this.dHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dHoraInicio.Location = new System.Drawing.Point(260, 248);
            this.dHoraInicio.Name = "dHoraInicio";
            this.dHoraInicio.Size = new System.Drawing.Size(115, 22);
            this.dHoraInicio.TabIndex = 2;
            // 
            // dHoraFinal
            // 
            this.dHoraFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dHoraFinal.Location = new System.Drawing.Point(390, 247);
            this.dHoraFinal.Name = "dHoraFinal";
            this.dHoraFinal.Size = new System.Drawing.Size(115, 22);
            this.dHoraFinal.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 421);
            this.Controls.Add(this.dHoraFinal);
            this.Controls.Add(this.dHoraInicio);
            this.Controls.Add(this.dTimerFecha);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.bttonReset);
            this.Controls.Add(this.bttonRecorrido);
            this.Controls.Add(this.bttonMostrarReporte);
            this.Controls.Add(this.bttonEliminarUltimo);
            this.Controls.Add(this.bttonEliminarPrimero);
            this.Controls.Add(this.bttonEliminar);
            this.Controls.Add(this.bttonBuscar);
            this.Controls.Add(this.bttonAddFinal);
            this.Controls.Add(this.bttonAddPrincipio);
            this.Controls.Add(this.bttonInsertarDespuesDe);
            this.Controls.Add(this.bttonAgregar);
            this.Controls.Add(this.txtSegundos);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtAddMinutos);
            this.Controls.Add(this.txtNombreRecorrido);
            this.Controls.Add(this.txtNombreD);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.label3);
            this.Name = "FormMain";
            this.Text = "Rutas y bases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button bttonAgregar;
        private System.Windows.Forms.Button bttonAddPrincipio;
        private System.Windows.Forms.Button bttonBuscar;
        private System.Windows.Forms.Button bttonEliminar;
        private System.Windows.Forms.Button bttonEliminarPrimero;
        private System.Windows.Forms.Button bttonEliminarUltimo;
        private System.Windows.Forms.Button bttonMostrarReporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.TextBox txtAddMinutos;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTimerFecha;
        private System.Windows.Forms.Button bttonAddFinal;
        private System.Windows.Forms.Button bttonInsertarDespuesDe;
        private System.Windows.Forms.TextBox txtNombreD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bttonReset;
        private System.Windows.Forms.Button bttonRecorrido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreRecorrido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dHoraInicio;
        private System.Windows.Forms.DateTimePicker dHoraFinal;
    }
}

