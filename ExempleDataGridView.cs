public partial class ExempleDataGridView : Form
{
    public ExempleDataGridView()
    {
        InitializeComponent();

        // Afegim columnes a la Taula.
        this.Taula.ColumnCount = 2;
        this.Taula.Columns[0].Name = "Nom";
        this.Taula.Columns[1].Name = "Cognom";

        // Associem esdeveniments.
        this.Button_afegir.Click += new EventHandler(this.Button_afegir_Click);
        this.Button_eliminar.Click += new EventHandler(this.Button_eliminar_Click);
        this.Taula.SelectionChanged += new EventHandler(this.Taula_SelectionChanged);
        this.Taula.CellValidating += new DataGridViewCellValidatingEventHandler(this.Taula_CellValidating);
    }

    // Quan es prem el botó Afegir.
    private void Button_afegir_Click(object sender, EventArgs e)
    {
        // Evitem afegir files en blanc.
        if (string.IsNullOrWhiteSpace(this.TextBox_nom.Text) || string.IsNullOrWhiteSpace(this.TextBox_cognom.Text))
        {
            MessageBox.Show("No es poden afegir valors buits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Afegim una fila a la Taula
        this.Taula.Rows.Add(this.TextBox_nom.Text, this.TextBox_cognom.Text);

        // Netejem els TextBox després d’afegir.
        this.TextBox_nom.Clear();
        this.TextBox_cognom.Clear();
    }

    // Quan es prem el botó Eliminar.
    private void Button_eliminar_Click(object sender, EventArgs e)
    {
        if (this.Taula.SelectedRows.Count > 0)
        {
            // Eliminem la fila seleccionada.
            this.Taula.Rows.RemoveAt(this.Taula.SelectedRows[0].Index);
        }
        else
        {
            MessageBox.Show("Selecciona una fila per eliminar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // Quan es selecciona una fila de la Taula.
    private void Taula_SelectionChanged(object sender, EventArgs e)
    {
        if (this.Taula.SelectedRows.Count > 0)
        {
            DataGridViewRow fila_seleccionada = this.Taula.SelectedRows[0];

            // Assignem els valors als TextBox
            this.TextBox_nom.Text = fila_seleccionada.Cells[0].Value?.ToString() ?? "";
            this.TextBox_cognom.Text = fila_seleccionada.Cells[1].Value?.ToString() ?? "";
        }
    }

    // Validació per evitar cel·les buides.
    private void Taula_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
    {
        // Si és la fila nova, sortir de la validació.
        if (this.Taula.Rows[e.RowIndex].IsNewRow)
            return;

        if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
        {
            MessageBox.Show("No pots deixar una cel·la buida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.Cancel = true; // Cancela l’edició de la cel·la.
        }
    }
}