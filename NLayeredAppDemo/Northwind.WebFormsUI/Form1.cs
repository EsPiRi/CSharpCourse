using Northwind.Business.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Business;
using Northwind.Business.Abstract;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxAddCategory.DataSource = _categoryService.GetAll();
            cbxAddCategory.DisplayMember = "CategoryName";
            cbxAddCategory.ValueMember = "CategoryId";
            
            cbxUpdateCategory.DataSource = _categoryService.GetAll();
            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {
               
            }
            
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbxProductName.Text))
                {
                    dgwProduct.DataSource = _productService.GetProductByProductName(tbxProductName.Text);
                }
                else
                {
                    LoadProducts();
                }
            }
            catch
            {
               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxAddCategory.SelectedValue),
                    ProductName = tbxProductName2.Text,
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStock.Text)

                });
                MessageBox.Show("Ürün eklendi");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }
           
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                    ProductName = tbxUpdateProductName.Text,
                    QuantityPerUnit = tbxUpdateQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxUpdateUnitsInStock.Text)

                });
                MessageBox.Show("Ürün güncellendi");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxUpdateProductName.Text = row.Cells[1].Value.ToString();
            cbxUpdateCategory.SelectedValue = row.Cells[2].Value;
            tbxUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
            tbxUpdateQuantityPerUnit.Text = row.Cells[4].Value.ToString();
            tbxUpdateUnitsInStock.Text = row.Cells[5].Value.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwProduct.CurrentRow != null)
                {
                    _productService.Delete(new Product { ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value) });
                    MessageBox.Show("Ürün silindi.");
                    LoadProducts();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           

            
        }
    }
}
