namespace AndresPa.CAI.Ej04;

public partial class PersonasForm : Form
{
    PersonasModel model;

    public PersonasForm()
    {
        InitializeComponent();
    }

    private void PersonasForm_Load(object sender, EventArgs e)
    {
        model = new PersonasModel();

        foreach (var persona in model.Personas)
        {
            var item = new ListViewItem();
            item.Text = persona.Documento.ToString(); // = item.Subitems[0].Text Implicitamente agrega el subitem 0
            item.SubItems.Add(persona.Apellido); //implicitamente estoy agregando el subitem 1, no el 0.
            item.SubItems.Add(persona.Nombre);
            item.SubItems.Add(persona.Telefono);
            item.Tag = persona;

            PersonasListView.Items.Add(item);
        }
    }

    private void EliminarButton_Click(object sender, EventArgs e)
    {
        if (PersonasListView.SelectedItems.Count == 0)
        {
            MessageBox.Show("Selecciona una persona de la lista.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Persona personaSeleccionada = (Persona)PersonasListView.SelectedItems[0].Tag;

        if (MessageBox.Show($"Se dispone a borrar a {personaSeleccionada.Apellido} {personaSeleccionada.Nombre}. ¿Está ud. seguro?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
        {
            return;
        }

        var error = model.Borrar(personaSeleccionada);
        if (error != null)
        {
            MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }


        PersonasListView.Items.Remove(PersonasListView.SelectedItems[0]);
    }

    private void ModificarButton_Click(object sender, EventArgs e)
    {
        if (PersonasListView.SelectedItems.Count == 0)
        {
            MessageBox.Show("Selecciona una persona de la lista.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Persona personaSeleccionada = (Persona)PersonasListView.SelectedItems[0].Tag;

        DocumentoTextBox.Text = personaSeleccionada.Documento.ToString();
        ApellidoTextBox.Text = personaSeleccionada.Apellido;
        NombreTextBox.Text = personaSeleccionada.Nombre;
        TelefonoTextBox.Text = personaSeleccionada.Telefono;

        PersonaEnEdicionGroup.Enabled = true;
        ListaPersonasGroup.Enabled = false;
    }

    private void CancelarButton_Click(object sender, EventArgs e)
    {
        DocumentoTextBox.Text = "";
        ApellidoTextBox.Text = "";
        NombreTextBox.Text = "";
        TelefonoTextBox.Text = "";

        PersonaEnEdicionGroup.Enabled = false;
        ListaPersonasGroup.Enabled = true;
    }

    private void AceptarButton_Click(object sender, EventArgs e)
    {
        Persona personaAModificar = (Persona)PersonasListView.SelectedItems[0].Tag;


        Persona personaNuevaVersion = new Persona();

        if (!int.TryParse(DocumentoTextBox.Text, out int documento))
        {
            MessageBox.Show("No ha ingresado un documento válido.");
            return;
        }

        personaNuevaVersion.Documento = documento;
        personaNuevaVersion.Apellido = ApellidoTextBox.Text;
        personaNuevaVersion.Nombre = NombreTextBox.Text;
        personaNuevaVersion.Telefono = TelefonoTextBox.Text;

        var error = model.Modificar(personaAModificar, personaNuevaVersion);
        if (error != null)
        {
            MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var item = PersonasListView.SelectedItems[0];
        item.Text = personaAModificar.Documento.ToString();
        item.SubItems[1].Text = personaAModificar.Nombre;
        item.SubItems[2].Text = personaAModificar.Apellido;        
        item.SubItems[3].Text = personaAModificar.Telefono;

        DocumentoTextBox.Text = "";
        ApellidoTextBox.Text = "";
        NombreTextBox.Text = "";
        TelefonoTextBox.Text = "";

        PersonaEnEdicionGroup.Enabled = false;
        ListaPersonasGroup.Enabled = true;
    }
}
