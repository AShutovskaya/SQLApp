using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }

  

        private void Tables_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appDataSet.Заселение". При необходимости она может быть перемещена или удалена.
            this.заселениеTableAdapter.Fill(this.appDataSet.Заселение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appDataSet.Бронирования". При необходимости она может быть перемещена или удалена.
            this.бронированияTableAdapter.Fill(this.appDataSet.Бронирования);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appDataSet.Номера". При необходимости она может быть перемещена или удалена.
            this.номераTableAdapter.Fill(this.appDataSet.Номера);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appDataSet.Типы_номеров". При необходимости она может быть перемещена или удалена.
            this.типы_номеровTableAdapter.Fill(this.appDataSet.Типы_номеров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appDataSet.Постояльцы". При необходимости она может быть перемещена или удалена.
            this.постояльцыTableAdapter.Fill(this.appDataSet.Постояльцы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appDataSet.Дежурные". При необходимости она может быть перемещена или удалена.
            this.дежурныеTableAdapter.Fill(this.appDataSet.Дежурные);

        }
        private void дежурныеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.дежурныеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appDataSet);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.постояльцыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appDataSet);
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.типы_номеровBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appDataSet);

        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.номераBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appDataSet);


        }

        private void toolStripButton28_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.бронированияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appDataSet);
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void дежурныеBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void постояльцыbindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void заселениеDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void паспортные_данныеLabel_Click(object sender, EventArgs e)
        {

        }

        private void фИОLabel1_Click(object sender, EventArgs e)
        {

        }

        private void id_постояльцаLabel_Click(object sender, EventArgs e)
        {

        }

        private void полLabel_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void сумма_за_проживаниеLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton35_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заселениеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appDataSet);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
