namespace Compilador
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pestañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colodeFuenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal = new System.Windows.Forms.TabControl();
            this.inicio = new System.Windows.Forms.TabPage();
            this.rtInicial = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvArbolAST = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbEstado = new System.Windows.Forms.RichTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btCompilar = new System.Windows.Forms.PictureBox();
            this.btCerrarPestaña = new System.Windows.Forms.PictureBox();
            this.btGuardar = new System.Windows.Forms.PictureBox();
            this.btAbrir = new System.Windows.Forms.PictureBox();
            this.btNuevaPestaña = new System.Windows.Forms.PictureBox();
            this.tTipNuevaPestaña = new System.Windows.Forms.ToolTip(this.components);
            this.tTipAbrir = new System.Windows.Forms.ToolTip(this.components);
            this.tTipGuardar = new System.Windows.Forms.ToolTip(this.components);
            this.tTipCerrarPestaña = new System.Windows.Forms.ToolTip(this.components);
            this.tTipCompilar = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btCompilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrarPestaña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAbrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btNuevaPestaña)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(57, 20);
            this.Archivo.Text = "Archivo";
            this.Archivo.Click += new System.EventHandler(this.Archivo_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.pestañaToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.archivoToolStripMenuItem.Text = "Proyecto";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // pestañaToolStripMenuItem
            // 
            this.pestañaToolStripMenuItem.Name = "pestañaToolStripMenuItem";
            this.pestañaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pestañaToolStripMenuItem.Text = "Pestaña";
            this.pestañaToolStripMenuItem.Click += new System.EventHandler(this.pestañaToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.archivoToolStripMenuItem1.Text = "Proyecto";
            this.archivoToolStripMenuItem1.Click += new System.EventHandler(this.archivoToolStripMenuItem1_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem,
            this.adelanteToolStripMenuItem,
            this.toolStripSeparator1,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.toolStripSeparator2,
            this.seleccionarTodoToolStripMenuItem,
            this.borrarTodoToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem2.Tag = "";
            this.toolStripMenuItem2.Text = "Edición ";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.atrasToolStripMenuItem.Text = "Atras";
            // 
            // adelanteToolStripMenuItem
            // 
            this.adelanteToolStripMenuItem.Name = "adelanteToolStripMenuItem";
            this.adelanteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.adelanteToolStripMenuItem.Text = "Adelante";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.seleccionarTodoToolStripMenuItem.Text = "Seleccionar Todo";
            // 
            // borrarTodoToolStripMenuItem
            // 
            this.borrarTodoToolStripMenuItem.Name = "borrarTodoToolStripMenuItem";
            this.borrarTodoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.borrarTodoToolStripMenuItem.Text = "Borrar Todo";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuenteToolStripMenuItem,
            this.colodeFuenterToolStripMenuItem,
            this.colorDeFondoToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem3.Text = "Formato";
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            // 
            // colodeFuenterToolStripMenuItem
            // 
            this.colodeFuenterToolStripMenuItem.Name = "colodeFuenterToolStripMenuItem";
            this.colodeFuenterToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.colodeFuenterToolStripMenuItem.Text = "Color de Fuente ";
            // 
            // colorDeFondoToolStripMenuItem
            // 
            this.colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
            this.colorDeFondoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.colorDeFondoToolStripMenuItem.Text = "Color  de Fondo";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = global::Compilador.Properties.Resources.Acerca_de;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.inicio);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.SelectedIndex = 0;
            this.panelPrincipal.Size = new System.Drawing.Size(647, 461);
            this.panelPrincipal.TabIndex = 0;
            // 
            // inicio
            // 
            this.inicio.Controls.Add(this.rtInicial);
            this.inicio.Location = new System.Drawing.Point(4, 22);
            this.inicio.Name = "inicio";
            this.inicio.Padding = new System.Windows.Forms.Padding(3);
            this.inicio.Size = new System.Drawing.Size(639, 435);
            this.inicio.TabIndex = 0;
            this.inicio.Text = "new Tab";
            this.inicio.UseVisualStyleBackColor = true;
            // 
            // rtInicial
            // 
            this.rtInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtInicial.Location = new System.Drawing.Point(3, 3);
            this.rtInicial.Name = "rtInicial";
            this.rtInicial.Size = new System.Drawing.Size(633, 429);
            this.rtInicial.TabIndex = 0;
            this.rtInicial.Text = "";
            this.rtInicial.TextChanged += new System.EventHandler(this.rtInicial_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelPrincipal);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(830, 461);
            this.splitContainer1.SplitterDistance = 647;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer3.Size = new System.Drawing.Size(179, 461);
            this.splitContainer3.SplitterDistance = 347;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvArbolAST);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 347);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TreeView";
            // 
            // tvArbolAST
            // 
            this.tvArbolAST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvArbolAST.Location = new System.Drawing.Point(3, 22);
            this.tvArbolAST.Name = "tvArbolAST";
            this.tvArbolAST.Size = new System.Drawing.Size(173, 322);
            this.tvArbolAST.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbEstado);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 110);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rtbEstado
            // 
            this.rtbEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEstado.Location = new System.Drawing.Point(3, 16);
            this.rtbEstado.Name = "rtbEstado";
            this.rtbEstado.ReadOnly = true;
            this.rtbEstado.Size = new System.Drawing.Size(173, 91);
            this.rtbEstado.TabIndex = 0;
            this.rtbEstado.Text = "";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btCompilar);
            this.splitContainer2.Panel1.Controls.Add(this.btCerrarPestaña);
            this.splitContainer2.Panel1.Controls.Add(this.btGuardar);
            this.splitContainer2.Panel1.Controls.Add(this.btAbrir);
            this.splitContainer2.Panel1.Controls.Add(this.btNuevaPestaña);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(830, 497);
            this.splitContainer2.SplitterDistance = 32;
            this.splitContainer2.TabIndex = 3;
            // 
            // btCompilar
            // 
            this.btCompilar.Image = global::Compilador.Properties.Resources.Compilar;
            this.btCompilar.Location = new System.Drawing.Point(119, 5);
            this.btCompilar.Name = "btCompilar";
            this.btCompilar.Size = new System.Drawing.Size(80, 24);
            this.btCompilar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btCompilar.TabIndex = 6;
            this.btCompilar.TabStop = false;
            this.tTipCompilar.SetToolTip(this.btCompilar, "Compilar\r\n");
            this.btCompilar.Click += new System.EventHandler(this.btCompilar_Click);
            // 
            // btCerrarPestaña
            // 
            this.btCerrarPestaña.Image = global::Compilador.Properties.Resources.cerrar;
            this.btCerrarPestaña.Location = new System.Drawing.Point(91, 4);
            this.btCerrarPestaña.Name = "btCerrarPestaña";
            this.btCerrarPestaña.Size = new System.Drawing.Size(22, 24);
            this.btCerrarPestaña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btCerrarPestaña.TabIndex = 5;
            this.btCerrarPestaña.TabStop = false;
            this.tTipCerrarPestaña.SetToolTip(this.btCerrarPestaña, "Cerrar Pestaña");
            this.btCerrarPestaña.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Image = global::Compilador.Properties.Resources.Guardar;
            this.btGuardar.Location = new System.Drawing.Point(63, 5);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(22, 24);
            this.btGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btGuardar.TabIndex = 4;
            this.btGuardar.TabStop = false;
            this.tTipGuardar.SetToolTip(this.btGuardar, "Guardar Archivo");
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btAbrir
            // 
            this.btAbrir.Image = global::Compilador.Properties.Resources.Abrir;
            this.btAbrir.Location = new System.Drawing.Point(35, 4);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(22, 24);
            this.btAbrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btAbrir.TabIndex = 3;
            this.btAbrir.TabStop = false;
            this.tTipAbrir.SetToolTip(this.btAbrir, "Abrir Archivo");
            this.btAbrir.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btNuevaPestaña
            // 
            this.btNuevaPestaña.Image = global::Compilador.Properties.Resources.Nuevo;
            this.btNuevaPestaña.Location = new System.Drawing.Point(7, 5);
            this.btNuevaPestaña.Name = "btNuevaPestaña";
            this.btNuevaPestaña.Size = new System.Drawing.Size(22, 24);
            this.btNuevaPestaña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btNuevaPestaña.TabIndex = 2;
            this.btNuevaPestaña.TabStop = false;
            this.tTipNuevaPestaña.SetToolTip(this.btNuevaPestaña, "Nueva pestaña");
            this.btNuevaPestaña.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tTipNuevaPestaña
            // 
            this.tTipNuevaPestaña.ToolTipTitle = "Nuevo";
            this.tTipNuevaPestaña.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // tTipAbrir
            // 
            this.tTipAbrir.ToolTipTitle = "Abrir";
            // 
            // tTipGuardar
            // 
            this.tTipGuardar.ToolTipTitle = "Guardar";
            // 
            // tTipCerrarPestaña
            // 
            this.tTipCerrarPestaña.ToolTipTitle = "Cerrar";
            // 
            // tTipCompilar
            // 
            this.tTipCompilar.ToolTipTitle = "Compilar";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 521);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(840, 555);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPILADOR C# - Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.inicio.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btCompilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrarPestaña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAbrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btNuevaPestaña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adelanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colodeFuenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDeFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pestañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.TabControl panelPrincipal;
        private System.Windows.Forms.TabPage inicio;
        private System.Windows.Forms.RichTextBox rtInicial;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox btGuardar;
        private System.Windows.Forms.PictureBox btAbrir;
        private System.Windows.Forms.PictureBox btNuevaPestaña;
        private System.Windows.Forms.ToolTip tTipNuevaPestaña;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolTip tTipGuardar;
        private System.Windows.Forms.ToolTip tTipAbrir;
        private System.Windows.Forms.PictureBox btCerrarPestaña;
        private System.Windows.Forms.PictureBox btCompilar;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvArbolAST;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbEstado;
        private System.Windows.Forms.ToolTip tTipCompilar;
        private System.Windows.Forms.ToolTip tTipCerrarPestaña;

    }
}