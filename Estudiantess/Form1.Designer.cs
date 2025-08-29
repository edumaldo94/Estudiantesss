using System;
using System.Drawing;
using System.Windows.Forms;

namespace Estudiantess
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelet = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBemail = new System.Windows.Forms.TextBox();
            this.labelNid = new System.Windows.Forms.Label();
            this.textBnId = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBlastName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBname = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.txtBSearch = new System.Windows.Forms.TextBox();
            this.labelEstudiante = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPrimero = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonUltimo = new System.Windows.Forms.Button();
            this.labelPaginas = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de estudiantes";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox2.Controls.Add(this.btnDelet);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.labelEmail);
            this.groupBox2.Controls.Add(this.textBemail);
            this.groupBox2.Controls.Add(this.labelNid);
            this.groupBox2.Controls.Add(this.textBnId);
            this.groupBox2.Controls.Add(this.labelLastName);
            this.groupBox2.Controls.Add(this.textBlastName);
            this.groupBox2.Controls.Add(this.labelName);
            this.groupBox2.Controls.Add(this.textBname);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 297);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnDelet
            // 
            this.btnDelet.BackColor = System.Drawing.Color.Red;
            this.btnDelet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelet.FlatAppearance.BorderSize = 0;
            this.btnDelet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnDelet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDelet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelet.Location = new System.Drawing.Point(93, 222);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(64, 24);
            this.btnDelet.TabIndex = 6;
            this.btnDelet.Text = "Eliminar";
            this.btnDelet.UseVisualStyleBackColor = false;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gold;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(186, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 24);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(5, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 24);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(127, 164);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(36, 15);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // textBemail
            // 
            this.textBemail.Location = new System.Drawing.Point(127, 179);
            this.textBemail.Name = "textBemail";
            this.textBemail.Size = new System.Drawing.Size(124, 20);
            this.textBemail.TabIndex = 4;
            this.textBemail.TextChanged += new System.EventHandler(this.textBemail_TextChanged);
            this.textBemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBemail_KeyPress);
            // 
            // labelNid
            // 
            this.labelNid.AutoSize = true;
            this.labelNid.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNid.Location = new System.Drawing.Point(5, 126);
            this.labelNid.Name = "labelNid";
            this.labelNid.Size = new System.Drawing.Size(35, 15);
            this.labelNid.TabIndex = 7;
            this.labelNid.Text = "N° Id";
            // 
            // textBnId
            // 
            this.textBnId.Location = new System.Drawing.Point(5, 141);
            this.textBnId.Name = "textBnId";
            this.textBnId.Size = new System.Drawing.Size(117, 20);
            this.textBnId.TabIndex = 1;
            this.textBnId.TextChanged += new System.EventHandler(this.textBnId_TextChanged);
            this.textBnId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBnId_KeyPress);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(5, 164);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(48, 15);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Apelido";
            // 
            // textBlastName
            // 
            this.textBlastName.Location = new System.Drawing.Point(5, 179);
            this.textBlastName.Name = "textBlastName";
            this.textBlastName.Size = new System.Drawing.Size(117, 20);
            this.textBlastName.TabIndex = 3;
            this.textBlastName.TextChanged += new System.EventHandler(this.textBlastName_TextChanged);
            this.textBlastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBlastName_KeyPress);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(127, 126);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 15);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nombre";
            // 
            // textBname
            // 
            this.textBname.Location = new System.Drawing.Point(127, 141);
            this.textBname.Name = "textBname";
            this.textBname.Size = new System.Drawing.Size(124, 20);
            this.textBname.TabIndex = 2;
            this.textBname.TextChanged += new System.EventHandler(this.textBname_TextChanged);
            this.textBname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBname_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox5.Controls.Add(this.pictureBoxImage);
            this.groupBox5.Location = new System.Drawing.Point(62, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(129, 104);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Información del estudiante";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.labelPaginas);
            this.groupBox3.Controls.Add(this.buttonUltimo);
            this.groupBox3.Controls.Add(this.buttonSiguiente);
            this.groupBox3.Controls.Add(this.buttonAnterior);
            this.groupBox3.Controls.Add(this.buttonPrimero);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(261, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 297);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lista de estudiantes";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox4.Controls.Add(this.labelBuscar);
            this.groupBox4.Controls.Add(this.txtBSearch);
            this.groupBox4.Controls.Add(this.labelEstudiante);
            this.groupBox4.Location = new System.Drawing.Point(0, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(831, 57);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.BackColor = System.Drawing.Color.Azure;
            this.labelBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelBuscar.Location = new System.Drawing.Point(471, 26);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(48, 17);
            this.labelBuscar.TabIndex = 2;
            this.labelBuscar.Text = "Buscar";
            // 
            // txtBSearch
            // 
            this.txtBSearch.Location = new System.Drawing.Point(525, 26);
            this.txtBSearch.Name = "txtBSearch";
            this.txtBSearch.Size = new System.Drawing.Size(133, 20);
            this.txtBSearch.TabIndex = 1;
            this.txtBSearch.TextChanged += new System.EventHandler(this.txtBSearch_TextChanged);
            // 
            // labelEstudiante
            // 
            this.labelEstudiante.AutoSize = true;
            this.labelEstudiante.BackColor = System.Drawing.Color.Azure;
            this.labelEstudiante.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstudiante.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelEstudiante.Location = new System.Drawing.Point(32, 27);
            this.labelEstudiante.Name = "labelEstudiante";
            this.labelEstudiante.Size = new System.Drawing.Size(78, 17);
            this.labelEstudiante.TabIndex = 0;
            this.labelEstudiante.Text = "Estudiantes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(552, 180);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // buttonPrimero
            // 
            this.buttonPrimero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrimero.Location = new System.Drawing.Point(107, 222);
            this.buttonPrimero.Name = "buttonPrimero";
            this.buttonPrimero.Size = new System.Drawing.Size(75, 23);
            this.buttonPrimero.TabIndex = 3;
            this.buttonPrimero.Text = "<<";
            this.buttonPrimero.UseVisualStyleBackColor = true;
            this.buttonPrimero.Click += new System.EventHandler(this.buttonPrimero_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnterior.Location = new System.Drawing.Point(205, 222);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(75, 23);
            this.buttonAnterior.TabIndex = 4;
            this.buttonAnterior.Text = "<";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSiguiente.Location = new System.Drawing.Point(286, 222);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(75, 23);
            this.buttonSiguiente.TabIndex = 5;
            this.buttonSiguiente.Text = ">";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonUltimo
            // 
            this.buttonUltimo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUltimo.Location = new System.Drawing.Point(387, 222);
            this.buttonUltimo.Name = "buttonUltimo";
            this.buttonUltimo.Size = new System.Drawing.Size(75, 23);
            this.buttonUltimo.TabIndex = 6;
            this.buttonUltimo.Text = ">>";
            this.buttonUltimo.UseVisualStyleBackColor = true;
            this.buttonUltimo.Click += new System.EventHandler(this.buttonUltimo_Click);
            // 
            // labelPaginas
            // 
            this.labelPaginas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPaginas.AutoSize = true;
            this.labelPaginas.BackColor = System.Drawing.Color.Azure;
            this.labelPaginas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaginas.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelPaginas.Location = new System.Drawing.Point(261, 202);
            this.labelPaginas.Name = "labelPaginas";
            this.labelPaginas.Size = new System.Drawing.Size(49, 17);
            this.labelPaginas.TabIndex = 7;
            this.labelPaginas.Text = "Pagina";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 222);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxImage.Image = global::Estudiantess.Properties.Resources.images1;
            this.pictureBoxImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(129, 104);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.pictureBoxImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(831, 413);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de estudiantes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label3;
        private Label labelEstudiante;
        private Label label4;
        private TextBox txtBSearch;
        private Label labelNid;
        private TextBox textBnId;
        private Label labelLastName;
        private TextBox textBlastName;
        private Label labelName;
        private TextBox textBname;
        private Label labelEmail;
        private TextBox textBemail;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnDelet;
        private PictureBox pictureBoxImage;
        private Label labelBuscar;
        private DataGridView dataGridView1;
        private Button buttonUltimo;
        private Button buttonSiguiente;
        private Button buttonAnterior;
        private Button buttonPrimero;
        private NumericUpDown numericUpDown1;
        private Label labelPaginas;
    }
}
