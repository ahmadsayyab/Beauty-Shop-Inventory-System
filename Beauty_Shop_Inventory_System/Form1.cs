using MianLogic_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Beauty_Shop_Inventory_System
{
    public partial class Form1 : Form
    {
        Product product = new Product();
        Procedure procedure = new Procedure();
        
        Services services = new Services();
      
        ProductServices productServices = new ProductServices();
        ProcedureServices procedureServices = new ProcedureServices();
      
        public Form1()
        {
            InitializeComponent();
        }

        //method to validate string inputs
        private void EnsureValidStringInput(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsLetter(ch))
            {
                e.Handled = false;
            }
            // Allow backspace (ASCII code 8)
            else if (ch == 8)
            {
                e.Handled = false;
            }
            // Allow space (ASCII code 32)
            else if (ch == 32)
            {
                e.Handled = false;
            }
            // Allow comma (ASCII code 44)
            else if (ch == 44)
            {
                e.Handled = false;
            }
            // Allow hyphen/minus sign (ASCII code 45)
            else if (ch == 45)
            {
                e.Handled = false;
            }
             // Allow dot (ASCII code 46)
            else if (ch == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //method to validate numeric inputss
        private void EnsureValidNumericInput(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else if (ch == 44)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
        private void txtProductName_Enter(object sender, EventArgs e)
        {
            if (txtProductName.Text == "Enter product name")
            {
                txtProductName.Text = "";
                txtProductName.ForeColor = Color.Black;
            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                txtProductName.Focus();
                errorProvider1.SetError(this.txtProductName, "Enter product name!!");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidStringInput(e);
        }

        private void txtProductDescription_Enter(object sender, EventArgs e)
        {
            if (txtProductDescription.Text == "Enter product description")
            {
                txtProductDescription.Text = "";
                txtProductDescription.ForeColor = Color.Black;
            }
        }

        private void txtProductDescription_Leave(object sender, EventArgs e)
        {
            if (txtProductDescription.Text == "")
            {
                txtProductDescription.Focus();
                errorProvider2.SetError(this.txtProductDescription, "Enter product description!!");

            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtProductDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidStringInput(e);
        }

        private void txtProductPrice_Enter(object sender, EventArgs e)
        {
            if (txtProductPrice.Text == "Enter product price")
            {
                txtProductPrice.Text = "";
                txtProductPrice.ForeColor = Color.Black;
            }
        }

        private void txtProductPrice_Leave(object sender, EventArgs e)
        {
            if (txtProductPrice.Text == "")
            {
                txtProductPrice.Focus();
                errorProvider3.SetError(this.txtProductPrice, "Enter product price!!");

            }

            else
            {
                errorProvider3.Clear();
            }
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidNumericInput(e);
        }

        private void txtProcedureName_Enter(object sender, EventArgs e)
        {
            if (txtProcedureName.Text == "Enter procedure name")
            {
                txtProcedureName.Text = "";
                txtProcedureName.ForeColor = Color.Black;
            }
        }

        private void txtProcedureName_Leave(object sender, EventArgs e)
        {
            if (txtProcedureName.Text == "")
            {
                txtProcedureName.Focus();
                errorProvider4.SetError(this.txtProcedureName, "Enter procedure name!!");

            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void txtProcedureName_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidStringInput(e);
        }

        private void txtProcedureDescription_Enter(object sender, EventArgs e)
        {
            if (txtProcedureDescription.Text == "Enter procedure description")
            {
                txtProcedureDescription.Text = "";
                txtProcedureDescription.ForeColor = Color.Black;
            }
        }

        private void txtProcedureDescription_Leave(object sender, EventArgs e)
        {
            if (txtProcedureDescription.Text == "")
            {
                txtProcedureDescription.Focus();
                errorProvider5.SetError(this.txtProcedureDescription, "Enter procedure description!!");

            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void txtProcedureDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidStringInput(e);
        }

        private void txtProcedurePrice_Enter(object sender, EventArgs e)
        {
            if (txtProcedurePrice.Text == "Enter procedure price")
            {
                txtProcedurePrice.Text = "";
                txtProcedurePrice.ForeColor = Color.Black;
            }
        }

        private void txtProcedurePrice_Leave(object sender, EventArgs e)
        {
            if (txtProcedurePrice.Text == "")
            {
                txtProcedurePrice.Focus();
                errorProvider6.SetError(this.txtProcedurePrice, "Enter procedure price!!");

            }

            else
            {
                errorProvider6.Clear();
            }
        }

        private void txtProcedurePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidNumericInput(e);
        }

        private void txtProcedureMinutes_Enter(object sender, EventArgs e)
        {
            if (txtProcedureMinutes.Text == "Enter appointment duration")
            {
                txtProcedureMinutes.Text = "";
                txtProcedureMinutes.ForeColor = Color.Black;
            }
        }

        private void txtProcedureMinutes_Leave(object sender, EventArgs e)
        {
            if (txtProcedureMinutes.Text == "")
            {
                txtProcedureMinutes.Focus();
                errorProvider7.SetError(this.txtProcedureMinutes, "Enter appointment duration!!");

            }

            else
            {
                errorProvider7.Clear();
            }
        }

        private void txtProcedureMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidNumericInput(e);
        }




        //add Product

        private void addProbtn_Click(object sender, EventArgs e)
        {
          
            if(txtProductName.Text == "Enter product name" && txtProductDescription.Text == "Enter product description" && txtProductPrice.Text == "Enter product price")
            {
                MessageBox.Show("Enter data in all fields of the product area!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtProductName.Text != string.Empty && txtProductDescription.Text != string.Empty && txtProductPrice.Text != string.Empty)
            {
               
                product.Name = txtProductName.Text;
                product.Description = txtProductDescription.Text;
                product.Price = Convert.ToDouble(txtProductPrice.Text);



              bool nameExists = productServices.Add(product);


                if (nameExists)
                {
                    MessageBox.Show("Data with the same name already exists!! Please use a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("Data added successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetFields();
                    FillListBox();
                }
                
            }
            else
            {
                MessageBox.Show("Enter data in all fields of the product area!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillListBox();
        }


        //to read either product data or procedure data into their 
        //respective textboxes
        string selectedName = "";
        private void stockitemsLB_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtProductName.Text = stockitemsLB.SelectedItem.ToString();
            txtProductName.ForeColor = Color.Black;
            txtProductName.ReadOnly = true;

            selectedName = txtProductName.Text;
            string priceLabel = proPricelbl.Text;
            string minutesLabel = prcMinuteslbl.Text;
            string targetData = services.GetProductOrProcedure(selectedName,priceLabel, minutesLabel);

           
            if (targetData == "product")
            {
                ResetProcedureFields();
                ReadProductData();
                
            }
            else
            {
                ResetFields();
                ReadProcedureData();
            }

            

        }

        //read Product data into their respective textboxes
        private void ReadProductData()
        {
            try
            {
                txtProductName.Text = stockitemsLB.SelectedItem.ToString();
                txtProductName.ForeColor = Color.Black;
                txtProductName.ReadOnly = true;

                selectedName = txtProductName.Text;

                GetProductDescription();
                GetProductPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //read procedure data into their respective textboxes
        private void ReadProcedureData()
        {
            try
            {
                txtProcedureName.Text = stockitemsLB.SelectedItem.ToString();
                txtProcedureName.ForeColor = Color.Black;
                txtProcedureName.ReadOnly = true;

                selectedName = txtProcedureName.Text;

                GetProcedureDescription();
                GetProcedurePrice();
                GetProcedureMinutes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //get procedure description
        private void GetProcedureDescription()
        {

            string descLabel = prcDesclbl.Text;
            string itemDesc = procedureServices.GetItemDescription(selectedName, descLabel);
            txtProcedureDescription.Text = itemDesc;
            txtProcedureDescription.ForeColor = Color.Black;


        }

        //get procedure price
        private void GetProcedurePrice()
        {

            string priceLabel = prcPricelbl.Text;
            string itemPrice = procedureServices.GetItemPrice(selectedName, priceLabel);
            txtProcedurePrice.Text = itemPrice;
            txtProcedurePrice.ForeColor = Color.Black;


        }

        //get procedure minutes
        private void GetProcedureMinutes()
        {

            string minutesLabel = prcMinuteslbl.Text;
            string procedureMinutes = procedureServices.GetProcedureMinutes(selectedName, minutesLabel);
            txtProcedureMinutes.Text = procedureMinutes;
            txtProcedureMinutes.ForeColor = Color.Black;


        }

        //reset product textboxes
        private void ResetFields()
        {
            txtProductName.Clear();
            txtProductDescription.Clear();
            txtProductPrice.Clear();
        }
        //get product description
        private void GetProductDescription()
        {
           
            string descLabel = proDesclbl.Text;
            string itemDesc = productServices.GetItemDescription(selectedName, descLabel);
            txtProductDescription.Text = itemDesc;
            txtProductDescription.ForeColor = Color.Black;

            
        }


        //get product Price
        private void GetProductPrice()
        {
         
            string priceLabel = proPricelbl.Text;
            string itemPrice = productServices.GetItemPrice(selectedName, priceLabel);
            txtProductPrice.Text = itemPrice;
            txtProductPrice.ForeColor = Color.Black;

          
        }

        //read back values into a listbox
        private void FillListBox()
        {
            stockitemsLB.Items.Clear();
            string nameLabel = proNamelbl.Text;
            List<string> items = services.GetAllItems(nameLabel);

            stockitemsLB.Items.AddRange(items.ToArray());
            stockitemsLB.Sorted = true;
        }


        //Update a Product
        private void updateProbtn_Click(object sender, EventArgs e)
        {

            product.Name = txtProductName.Text;
            product.Description = txtProductDescription.Text;
            product.Price = Convert.ToDouble(txtProductPrice.Text);

            productServices.Update(product);

            MessageBox.Show("Data Updated successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetFields();
            txtProductName.ReadOnly = false;
            FillListBox();

            



        }


        //Delete a product
        private void deleteProbtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure want to delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                product.Name = txtProductName.Text;
                productServices.Delete(product);

                MessageBox.Show("Data Deleted successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields();
                txtProductName.ReadOnly = false;
                FillListBox();
            }
            
        }


        //add a procedure
        private void addPrcbtn_Click(object sender, EventArgs e)
        {
           
            if (txtProcedureName.Text == "Enter procedure name" && txtProcedureDescription.Text == "Enter procedure description" && txtProcedurePrice.Text == "Enter procedure price" && txtProcedureMinutes.Text == "Enter appointment duration")
            {
                MessageBox.Show("Enter data in all fields of the procedure area!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtProcedureName.Text != string.Empty && txtProcedureDescription.Text != string.Empty && txtProcedurePrice.Text != string.Empty && txtProcedureMinutes.Text != string.Empty)
            {

                procedure.Name = txtProcedureName.Text;
                procedure.Description = txtProcedureDescription.Text;
                procedure.Price = Convert.ToDouble(txtProcedurePrice.Text);
                procedure.Minutes = Convert.ToInt32(txtProcedureMinutes.Text);

                bool nameExists = procedureServices.Add(procedure);


                if (nameExists)
                {
                    MessageBox.Show("Procedure with the same name already exists!! Please use a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProcedureName.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("Procedure item added successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetProcedureFields();
                    FillListBox();
                }

            }

            else
            {
                MessageBox.Show("Enter data in all fields of the procedure area!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //reset procedure textboxes
        private void ResetProcedureFields()
        {
            txtProcedureName.Clear();
            txtProcedureDescription.Clear();
            txtProcedurePrice.Clear();
            txtProcedureMinutes.Clear();
        }


        //update procedure
        private void updatePrcbtn_Click(object sender, EventArgs e)
        {
            
            procedure.Name = txtProcedureName.Text;
            procedure.Description = txtProcedureDescription.Text;
            procedure.Price =Convert.ToDouble(txtProcedurePrice.Text);
            procedure.Minutes =Convert.ToInt32(txtProcedureMinutes.Text);

            procedureServices.Update(procedure);

            MessageBox.Show("Procedure Data Updated successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetProcedureFields();
            txtProductName.ReadOnly = false;
            FillListBox();

        }

        //delete procedure from file
        private void deletePrcbtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure want to delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
          
                procedure.Name = txtProcedureName.Text;

                procedureServices.Delete(procedure);

                MessageBox.Show("Procedure Data Deleted successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetProcedureFields();
                txtProductName.ReadOnly = false;
                FillListBox();
            }
        }


        //search by name for specific product or procedure
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string name = Searchtb.Text;
            string nameLabel = prcNamelbl.Text;

            string targetName= services.GetItemByName(name , nameLabel);

            if(targetName != "")
            {
                stockitemsLB.Items.Clear();
                stockitemsLB.Items.Add(targetName);
                Searchtb.Clear();


            }
            else
            {
                MessageBox.Show("Item not found!!", "Failed", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Searchtb.Clear();
                
            }
            
            

        }

       
        //Reload items from file into listBox 
        private void LoadItemBackAfterSearch_Click(object sender, EventArgs e)
        {
            FillListBox();
            ResetFields();
            ResetProcedureFields();
        }

       
    }
}

