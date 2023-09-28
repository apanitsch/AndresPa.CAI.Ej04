namespace AndresPa.CAI.Ej04;

partial class PersonasForm
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
        PersonasListView = new ListView();
        DocumentoHeader = new ColumnHeader();
        NombreHeader = new ColumnHeader();
        ApellidoHeader = new ColumnHeader();
        TelefonoHeader = new ColumnHeader();
        NuevaPersonaButton = new Button();
        ModificarButton = new Button();
        EliminarButton = new Button();
        PersonaEnEdicionGroup = new GroupBox();
        CancelarButton = new Button();
        AceptarButton = new Button();
        label4 = new Label();
        NombreTextBox = new TextBox();
        label3 = new Label();
        ApellidoTextBox = new TextBox();
        label2 = new Label();
        TelefonoTextBox = new TextBox();
        label1 = new Label();
        DocumentoTextBox = new TextBox();
        ListaPersonasGroup = new GroupBox();
        PersonaEnEdicionGroup.SuspendLayout();
        ListaPersonasGroup.SuspendLayout();
        SuspendLayout();
        // 
        // PersonasListView
        // 
        PersonasListView.Columns.AddRange(new ColumnHeader[] { DocumentoHeader, NombreHeader, ApellidoHeader, TelefonoHeader });
        PersonasListView.FullRowSelect = true;
        PersonasListView.Location = new Point(12, 51);
        PersonasListView.MultiSelect = false;
        PersonasListView.Name = "PersonasListView";
        PersonasListView.Size = new Size(754, 144);
        PersonasListView.TabIndex = 0;
        PersonasListView.UseCompatibleStateImageBehavior = false;
        PersonasListView.View = View.Details;
        // 
        // DocumentoHeader
        // 
        DocumentoHeader.Text = "Documento";
        DocumentoHeader.Width = 120;
        // 
        // NombreHeader
        // 
        NombreHeader.Text = "Nombre";
        NombreHeader.Width = 120;
        // 
        // ApellidoHeader
        // 
        ApellidoHeader.Text = "Apellido";
        ApellidoHeader.Width = 120;
        // 
        // TelefonoHeader
        // 
        TelefonoHeader.Text = "Telefono";
        TelefonoHeader.Width = 120;
        // 
        // NuevaPersonaButton
        // 
        NuevaPersonaButton.Location = new Point(693, 22);
        NuevaPersonaButton.Name = "NuevaPersonaButton";
        NuevaPersonaButton.Size = new Size(75, 23);
        NuevaPersonaButton.TabIndex = 1;
        NuevaPersonaButton.Text = "Nueva";
        NuevaPersonaButton.UseVisualStyleBackColor = true;
        // 
        // ModificarButton
        // 
        ModificarButton.Location = new Point(612, 22);
        ModificarButton.Name = "ModificarButton";
        ModificarButton.Size = new Size(75, 23);
        ModificarButton.TabIndex = 2;
        ModificarButton.Text = "Modificar";
        ModificarButton.UseVisualStyleBackColor = true;
        ModificarButton.Click += ModificarButton_Click;
        // 
        // EliminarButton
        // 
        EliminarButton.Location = new Point(531, 22);
        EliminarButton.Name = "EliminarButton";
        EliminarButton.Size = new Size(75, 23);
        EliminarButton.TabIndex = 3;
        EliminarButton.Text = "Eliminar";
        EliminarButton.UseVisualStyleBackColor = true;
        EliminarButton.Click += EliminarButton_Click;
        // 
        // PersonaEnEdicionGroup
        // 
        PersonaEnEdicionGroup.Controls.Add(CancelarButton);
        PersonaEnEdicionGroup.Controls.Add(AceptarButton);
        PersonaEnEdicionGroup.Controls.Add(label4);
        PersonaEnEdicionGroup.Controls.Add(NombreTextBox);
        PersonaEnEdicionGroup.Controls.Add(label3);
        PersonaEnEdicionGroup.Controls.Add(ApellidoTextBox);
        PersonaEnEdicionGroup.Controls.Add(label2);
        PersonaEnEdicionGroup.Controls.Add(TelefonoTextBox);
        PersonaEnEdicionGroup.Controls.Add(label1);
        PersonaEnEdicionGroup.Controls.Add(DocumentoTextBox);
        PersonaEnEdicionGroup.Enabled = false;
        PersonaEnEdicionGroup.Location = new Point(12, 232);
        PersonaEnEdicionGroup.Name = "PersonaEnEdicionGroup";
        PersonaEnEdicionGroup.Size = new Size(776, 294);
        PersonaEnEdicionGroup.TabIndex = 4;
        PersonaEnEdicionGroup.TabStop = false;
        PersonaEnEdicionGroup.Text = "Persona";
        // 
        // CancelarButton
        // 
        CancelarButton.Location = new Point(354, 164);
        CancelarButton.Name = "CancelarButton";
        CancelarButton.Size = new Size(75, 23);
        CancelarButton.TabIndex = 9;
        CancelarButton.Text = "Cancelar";
        CancelarButton.UseVisualStyleBackColor = true;
        CancelarButton.Click += CancelarButton_Click;
        // 
        // AceptarButton
        // 
        AceptarButton.Location = new Point(273, 164);
        AceptarButton.Name = "AceptarButton";
        AceptarButton.Size = new Size(75, 23);
        AceptarButton.TabIndex = 8;
        AceptarButton.Text = "Aceptar";
        AceptarButton.UseVisualStyleBackColor = true;
        AceptarButton.Click += AceptarButton_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(249, 99);
        label4.Name = "label4";
        label4.Size = new Size(51, 15);
        label4.TabIndex = 7;
        label4.Text = "Nombre";
        // 
        // NombreTextBox
        // 
        NombreTextBox.Location = new Point(249, 117);
        NombreTextBox.Name = "NombreTextBox";
        NombreTextBox.Size = new Size(180, 23);
        NombreTextBox.TabIndex = 6;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(249, 38);
        label3.Name = "label3";
        label3.Size = new Size(51, 15);
        label3.TabIndex = 5;
        label3.Text = "Apellido";
        // 
        // ApellidoTextBox
        // 
        ApellidoTextBox.Location = new Point(249, 56);
        ApellidoTextBox.Name = "ApellidoTextBox";
        ApellidoTextBox.Size = new Size(180, 23);
        ApellidoTextBox.TabIndex = 4;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(16, 99);
        label2.Name = "label2";
        label2.Size = new Size(52, 15);
        label2.TabIndex = 3;
        label2.Text = "Telefono";
        // 
        // TelefonoTextBox
        // 
        TelefonoTextBox.Location = new Point(16, 117);
        TelefonoTextBox.Name = "TelefonoTextBox";
        TelefonoTextBox.Size = new Size(180, 23);
        TelefonoTextBox.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(16, 38);
        label1.Name = "label1";
        label1.Size = new Size(70, 15);
        label1.TabIndex = 1;
        label1.Text = "Documento";
        // 
        // DocumentoTextBox
        // 
        DocumentoTextBox.Location = new Point(16, 56);
        DocumentoTextBox.Name = "DocumentoTextBox";
        DocumentoTextBox.Size = new Size(180, 23);
        DocumentoTextBox.TabIndex = 0;
        // 
        // ListaPersonasGroup
        // 
        ListaPersonasGroup.Controls.Add(EliminarButton);
        ListaPersonasGroup.Controls.Add(PersonasListView);
        ListaPersonasGroup.Controls.Add(NuevaPersonaButton);
        ListaPersonasGroup.Controls.Add(ModificarButton);
        ListaPersonasGroup.Location = new Point(12, 12);
        ListaPersonasGroup.Name = "ListaPersonasGroup";
        ListaPersonasGroup.Size = new Size(776, 214);
        ListaPersonasGroup.TabIndex = 5;
        ListaPersonasGroup.TabStop = false;
        // 
        // PersonasForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(796, 538);
        Controls.Add(ListaPersonasGroup);
        Controls.Add(PersonaEnEdicionGroup);
        Name = "PersonasForm";
        Text = "Ejercicio 4 - Lista de personas";
        Load += PersonasForm_Load;
        PersonaEnEdicionGroup.ResumeLayout(false);
        PersonaEnEdicionGroup.PerformLayout();
        ListaPersonasGroup.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ListView PersonasListView;
    private ColumnHeader DocumentoHeader;
    private ColumnHeader NombreHeader;
    private ColumnHeader ApellidoHeader;
    private ColumnHeader TelefonoHeader;
    private Button NuevaPersonaButton;
    private Button ModificarButton;
    private Button EliminarButton;
    private GroupBox PersonaEnEdicionGroup;
    private Label label4;
    private TextBox NombreTextBox;
    private Label label3;
    private TextBox ApellidoTextBox;
    private Label label2;
    private TextBox TelefonoTextBox;
    private Label label1;
    private TextBox DocumentoTextBox;
    private Button CancelarButton;
    private Button AceptarButton;
    private GroupBox ListaPersonasGroup;
}
