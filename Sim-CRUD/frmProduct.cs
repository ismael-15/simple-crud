using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;

namespace Sim_CRUD
{
    
    public partial class frmProduct : Form
    {
        private string action = "";
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            // deja tab
            tabs.TabPages.Remove(tabForm);

            //cargamos los datos del datagridview
            //deshabilitar controles
            fillDataGridView();
            controlsDisable();
        }
        public void fillDataGridView()
        {
            //intancai de la clase product
            Product product = new Product();

            clearDataGridView();
            dtgProduct.Columns.Add("productId", "PRODUCT ID");
            dtgProduct.Columns.Add("nombre", "NOMBRE");
            dtgProduct.Columns.Add("descripcion", "DESCRIPCION");
            dtgProduct.Columns.Add("precio", "PRECIO");

            //llamado al metodo getProduct
            MySqlDataReader dataReader = product.getProduct();

            //leer el metodo
            while(dataReader.Read())
            {
                dtgProduct.Rows.Add(
                    dataReader.GetValue(0),
                    dataReader.GetValue(1),
                    dataReader.GetString(2),
                    dataReader.GetValue(3)
                    );
                    
            }



        }
        public void clearDataGridView()
        {
            dtgProduct.Columns.Clear();
            dtgProduct.Rows.Clear();
        }
        public void controlsDisable()
        {
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

        }

        public void controlsEnable()
        {
            txtId.Enabled = false;
            txtName.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        public void clearControls()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
              
        }

        private void dtgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabs.TabPages.Remove(tabData);
            tabs.TabPages.Add(tabForm);
            tabs.TabPages[0].Text = "EDIT PRODUCT";

            action = "edit";
            controlsEnable();

            txtId.Visible = true;
            txtId.ReadOnly = true;
            IblId.Visible = true;

            //cargar los datos en controles
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //instanciar la clase product
            Product product = new Product();

            if(action=="edit")
            {
                product._productId = Convert.ToInt32(txtId.Text);
            }

            //asignar los valores a las prpiedades
            product._nombre = txtName.Text;
            product._descripcion = txtDescripcion.Text;
            product._precio = txtPrecio.Text;

            string mensaje = "Esta seguro que desea guardar el registro";
             if(MessageBox.Show(this, mensaje, "Nuevo Registro",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
             {
                if (product.newEditProduct(action))
                {
                    MetroMessageBox.Show(this, "Los datos se guardaron correctamente", "Nuevo Registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Los datos no se guardaron correctamente", "Nuevo Registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearControls();
                controlsDisable();
                controlsEnable();
                tabs.TabPages.Remove(tabForm);
                tabs.TabPages.Add(tabData);
                tabs.TabPages[0].Text = "PRODUCT LIST";

             }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //boton salir
            string mensaje = "¿Esta seguro que quiere salir?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "confrimar",MessageBoxButtons.YesNo,MessageBoxIcon.Stop) ==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void INew_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Add(tabForm);
            tabs.TabPages.Remove(tabData);
            tabs.TabPages[0].Text = "NEW PRODUCT";

            txtId.Visible = false;
            IblId.Visible = false;
            txtName.Focus();
            action = "new";
            controlsEnable();
            clearControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Esta seguro que quiere cancelar";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==DialogResult.Yes)
            {
                clearControls();
                controlsDisable();

                tabs.TabPages.Remove(tabForm);
                tabs.TabPages.Add(tabData);
                tabs.TabPages[0].Text = "PRODUCT LIST";
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Remove(tabData);
            tabs.TabPages.Add(tabForm);
            tabs.TabPages[0].Text = "EDIT PRODUCT";

            controlsEnable();
            txtId.Visible = true;
            txtId.ReadOnly = true;
            IblId.Visible = true;

            txtId.Text = dtgProduct.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dtgProduct.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text=dtgProduct.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dtgProduct.CurrentRow.Cells[3].Value.ToString();

            action = "edit";





        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro que deseaeliminar el registro)";
            if (MessageBox.Show(this, mensaje, "ELIMINAR REGISTRO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                Product product = new Product();
                product._productId = Convert.ToInt32(dtgProduct.CurrentRow.Cells[0].Value);

                if (product.deleteProduct())
                {
                    MetroMessageBox.Show(this, "se ha eliminado el registro", "ELIMINAR REGISTRO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //actualizar datagridview
                    fillDataGridView();

                }
                else
                {
                    MetroMessageBox.Show(this, "No se pudo eliminar el registro", "ELIMINAR REGSITRO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
        }
    }
}
