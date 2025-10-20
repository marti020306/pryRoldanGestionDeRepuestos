namespace pryRoldanGestionDeRepuestos
{
    public partial class frmGestionDeRepuesto : Form
    {
        public frmGestionDeRepuesto()
        {
            InitializeComponent();
        }
        string[,] repuestos = new string[100, 5];
        int contador = 0;

        private void frmGestionDeRepuesto_Load(object sender, EventArgs e)
        {

        }

        private void cmdAgregarRepuesto_Click(object sender, EventArgs e)
        {
            if (contador >= 100)
            {
                MessageBox.Show("Ya se ingresaron los 100 repuestos permitidos.");
                return;
            }

            if (lstMarca.Text == "")
            {
                MessageBox.Show("Debe seleccionar una marca.");
                return;
            }

            if (mtbRepuestos.Text == "")
            {
                MessageBox.Show("Debe ingresar un número de repuesto.");
                return;
            }


            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción.");
                return;
            }
            if (mtbPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio.");
                return;
            }

            if (lstOrigen.Text == "")
            {
                MessageBox.Show("Debe seleccionar un origen.");
                return;
            }

            string numero = mtbRepuestos.Text;
            int num;

            try
            {
                num = int.Parse(numero);
                if (numero.Length > 6)
                {
                    MessageBox.Show("El número de repuesto no puede tener más de 6 dígitos.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un número de repuesto válido (solo números).");
                return;
            }

            // Validar repetido
            for (int i = 0; i < contador; i++)
            {
                if (repuestos[i, 2] == numero)
                {
                    MessageBox.Show("Ya existe un repuesto con ese número.");
                    return;
                }
            }

            string precio = mtbPrecio.Text;
            float prec;

            try
            {
                prec = float.Parse(precio);
                if (prec <= 0)
                {
                    MessageBox.Show("Ingrese un precio mayor a 0.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            // Carga en matriz
            repuestos[contador, 0] = lstMarca.Text;
            repuestos[contador, 1] = lstOrigen.Text;
            repuestos[contador, 2] = numero;
            repuestos[contador, 3] = txtDescripcion.Text;
            repuestos[contador, 4] = precio;
            contador++;

            MessageBox.Show("Repuesto cargado correctamente.");

            // Limpiar
            lstMarca.SelectedIndex = -1;
            mtbRepuestos.Text = "";
            txtDescripcion.Text = "";
            mtbPrecio.Text = "";

        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MessageBox.Show("No hay repuestos cargados.");
                return;
            }

            if (lstMarca2.Text == "")
            {
                MessageBox.Show("Debe seleccionar una marca para consultar.");
                return;
            }

            char marca = lstMarca2.Text[0];
            char origen = optNacional.Checked ? 'N' : 'I';
            bool encontrado = false;

            ltbResultado.Items.Clear();

            for (int i = 0; i < contador; i++)
            {
                if (repuestos[i, 0][0] == marca && repuestos[i, 1][0] == origen)
                {
                    encontrado = true;
                    ltbResultado.Items.Add(
                        "Número: " + repuestos[i, 2] +
                        " | Descripción: " + repuestos[i, 3] +
                        " | Precio: $" + repuestos[i, 4]
                    );
                }
            }

            if (!encontrado)
            {
                ltbResultado.Items.Add("No se encontraron repuestos con esos criterios.");
            }
        }
    }
}
