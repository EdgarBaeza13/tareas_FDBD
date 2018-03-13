using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_PSQL
{
    public partial class FormDis : Form
    {
        public FormDis()
        {
            InitializeComponent();
        }

        private void categoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void FormDis_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'postgresDataSet.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.postgresDataSet.categorias);

        }
    }
}
