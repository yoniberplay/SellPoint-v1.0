namespace ProgramacionII
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusbar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxroluser = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxdireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxnumerodocumento = new System.Windows.Forms.TextBox();
            this.textBoxlocalidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxtipoentidad = new System.Windows.Forms.TextBox();
            this.textBoxtelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxtipodocumento = new System.Windows.Forms.TextBox();
            this.textBoxnodocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxestadoentidad = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1206, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entidadesToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.archivoToolStripMenuItem.Text = "Archivos";
            // 
            // entidadesToolStripMenuItem
            // 
            this.entidadesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.entidadesToolStripMenuItem.Name = "entidadesToolStripMenuItem";
            this.entidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entidadesToolStripMenuItem.Text = "Entidades";
            this.entidadesToolStripMenuItem.Click += new System.EventHandler(this.entidadesToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCercaDeToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // aCercaDeToolStripMenuItem
            // 
            this.aCercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.aCercaDeToolStripMenuItem.Name = "aCercaDeToolStripMenuItem";
            this.aCercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aCercaDeToolStripMenuItem.Text = "Acerca de...";
            this.aCercaDeToolStripMenuItem.Click += new System.EventHandler(this.aCercaDeToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.AllowItemReorder = true;
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusbar2,
            this.toolStripStatusLabel1,
            this.labelstatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 510);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.Size = new System.Drawing.Size(1206, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // labelstatus
            // 
            this.labelstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.labelstatus.Margin = new System.Windows.Forms.Padding(725, 3, 0, 2);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(45, 17);
            this.labelstatus.Text = "fecha";
            this.labelstatus.Click += new System.EventHandler(this.labelstatus_Click);
            // 
            // statusbar2
            // 
            this.statusbar2.ForeColor = System.Drawing.Color.Lime;
            this.statusbar2.MarqueeAnimationSpeed = 5;
            this.statusbar2.Name = "statusbar2";
            this.statusbar2.Size = new System.Drawing.Size(100, 16);
            this.statusbar2.Step = 1;
            this.statusbar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.statusbar2.Value = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxroluser);
            this.panel1.Controls.Add(this.textBoxusername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxdireccion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxnumerodocumento);
            this.panel1.Controls.Add(this.textBoxlocalidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxtipoentidad);
            this.panel1.Controls.Add(this.textBoxtelefono);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxtipodocumento);
            this.panel1.Controls.Add(this.textBoxnodocumento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxestadoentidad);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 480);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxroluser
            // 
            this.textBoxroluser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBoxroluser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxroluser.Enabled = false;
            this.textBoxroluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxroluser.Location = new System.Drawing.Point(110, 189);
            this.textBoxroluser.Name = "textBoxroluser";
            this.textBoxroluser.ReadOnly = true;
            this.textBoxroluser.Size = new System.Drawing.Size(130, 15);
            this.textBoxroluser.TabIndex = 29;
            this.textBoxroluser.Text = "cedula";
            this.textBoxroluser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxusername
            // 
            this.textBoxusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBoxusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxusername.ForeColor = System.Drawing.Color.Lime;
            this.textBoxusername.Location = new System.Drawing.Point(110, 155);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.ReadOnly = true;
            this.textBoxusername.ShortcutsEnabled = false;
            this.textBoxusername.Size = new System.Drawing.Size(130, 28);
            this.textBoxusername.TabIndex = 27;
            this.textBoxusername.TabStop = false;
            this.textBoxusername.Text = "402";
            this.textBoxusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProgramacionII.Properties.Resources.user128;
            this.pictureBox1.Location = new System.Drawing.Point(110, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(133, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBoxdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdireccion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxdireccion.Location = new System.Drawing.Point(195, 372);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.ReadOnly = true;
            this.textBoxdireccion.Size = new System.Drawing.Size(161, 15);
            this.textBoxdireccion.TabIndex = 24;
            this.textBoxdireccion.TabStop = false;
            this.textBoxdireccion.Text = "cedula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(22, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label8.Location = new System.Drawing.Point(192, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Direccion:";
            // 
            // textBoxnumerodocumento
            // 
            this.textBoxnumerodocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBoxnumerodocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxnumerodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnumerodocumento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxnumerodocumento.Location = new System.Drawing.Point(25, 240);
            this.textBoxnumerodocumento.Name = "textBoxnumerodocumento";
            this.textBoxnumerodocumento.ReadOnly = true;
            this.textBoxnumerodocumento.Size = new System.Drawing.Size(161, 15);
            this.textBoxnumerodocumento.TabIndex = 10;
            this.textBoxnumerodocumento.TabStop = false;
            this.textBoxnumerodocumento.Text = "4022797176546";
            // 
            // textBoxlocalidad
            // 
            this.textBoxlocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBoxlocalidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxlocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxlocalidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxlocalidad.Location = new System.Drawing.Point(195, 328);
            this.textBoxlocalidad.Name = "textBoxlocalidad";
            this.textBoxlocalidad.ReadOnly = true;
            this.textBoxlocalidad.Size = new System.Drawing.Size(161, 15);
            this.textBoxlocalidad.TabIndex = 22;
            this.textBoxlocalidad.TabStop = false;
            this.textBoxlocalidad.Text = "cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(22, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo de Entidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label7.Location = new System.Drawing.Point(192, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Localidad:";
            // 
            // textBoxtipoentidad
            // 
            this.textBoxtipoentidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBoxtipoentidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxtipoentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtipoentidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxtipoentidad.Location = new System.Drawing.Point(25, 277);
            this.textBoxtipoentidad.Name = "textBoxtipoentidad";
            this.textBoxtipoentidad.ReadOnly = true;
            this.textBoxtipoentidad.Size = new System.Drawing.Size(161, 15);
            this.textBoxtipoentidad.TabIndex = 12;
            this.textBoxtipoentidad.TabStop = false;
            this.textBoxtipoentidad.Text = "cedula";
            // 
            // textBoxtelefono
            // 
            this.textBoxtelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBoxtelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxtelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtelefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxtelefono.Location = new System.Drawing.Point(195, 284);
            this.textBoxtelefono.Name = "textBoxtelefono";
            this.textBoxtelefono.ReadOnly = true;
            this.textBoxtelefono.Size = new System.Drawing.Size(161, 15);
            this.textBoxtelefono.TabIndex = 20;
            this.textBoxtelefono.TabStop = false;
            this.textBoxtelefono.Text = "cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(22, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label6.Location = new System.Drawing.Point(192, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Telefono:";
            // 
            // textBoxtipodocumento
            // 
            this.textBoxtipodocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBoxtipodocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxtipodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtipodocumento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxtipodocumento.Location = new System.Drawing.Point(25, 358);
            this.textBoxtipodocumento.Name = "textBoxtipodocumento";
            this.textBoxtipodocumento.ReadOnly = true;
            this.textBoxtipodocumento.Size = new System.Drawing.Size(161, 15);
            this.textBoxtipodocumento.TabIndex = 16;
            this.textBoxtipodocumento.TabStop = false;
            this.textBoxtipodocumento.Text = "cedula";
            // 
            // textBoxnodocumento
            // 
            this.textBoxnodocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBoxnodocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxnodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnodocumento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxnodocumento.Location = new System.Drawing.Point(195, 240);
            this.textBoxnodocumento.Name = "textBoxnodocumento";
            this.textBoxnodocumento.ReadOnly = true;
            this.textBoxnodocumento.Size = new System.Drawing.Size(161, 15);
            this.textBoxnodocumento.TabIndex = 18;
            this.textBoxnodocumento.TabStop = false;
            this.textBoxnodocumento.Text = "cedula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(22, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo documentos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label5.Location = new System.Drawing.Point(192, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "No. de Documento:";
            // 
            // textBoxestadoentidad
            // 
            this.textBoxestadoentidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBoxestadoentidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxestadoentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxestadoentidad.ForeColor = System.Drawing.Color.Lime;
            this.textBoxestadoentidad.Location = new System.Drawing.Point(25, 314);
            this.textBoxestadoentidad.Name = "textBoxestadoentidad";
            this.textBoxestadoentidad.ReadOnly = true;
            this.textBoxestadoentidad.Size = new System.Drawing.Size(161, 15);
            this.textBoxestadoentidad.TabIndex = 14;
            this.textBoxestadoentidad.TabStop = false;
            this.textBoxestadoentidad.Text = "cedula";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel1.Text = "Conectado.";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1206, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar statusbar2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel labelstatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnumerodocumento;
        private System.Windows.Forms.TextBox textBoxtipoentidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxnodocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxtipodocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxestadoentidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxdireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxlocalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxtelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxroluser;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}



