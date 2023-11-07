namespace Beauty_Shop_Inventory_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.stockitemsLB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.deleteProbtn = new System.Windows.Forms.Button();
            this.updateProbtn = new System.Windows.Forms.Button();
            this.addProbtn = new System.Windows.Forms.Button();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.proPricelbl = new System.Windows.Forms.Label();
            this.proDesclbl = new System.Windows.Forms.Label();
            this.proNamelbl = new System.Windows.Forms.Label();
            this.prcNamelbl = new System.Windows.Forms.Label();
            this.prcDesclbl = new System.Windows.Forms.Label();
            this.prcPricelbl = new System.Windows.Forms.Label();
            this.txtProcedureName = new System.Windows.Forms.TextBox();
            this.txtProcedureDescription = new System.Windows.Forms.TextBox();
            this.txtProcedurePrice = new System.Windows.Forms.TextBox();
            this.addPrcbtn = new System.Windows.Forms.Button();
            this.updatePrcbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deletePrcbtn = new System.Windows.Forms.Button();
            this.txtProcedureMinutes = new System.Windows.Forms.TextBox();
            this.prcMinuteslbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Searchtb = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.LoadItemBackAfterSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.group1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beauty Shop Inventory Management";
            // 
            // stockitemsLB
            // 
            this.stockitemsLB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stockitemsLB.FormattingEnabled = true;
            this.stockitemsLB.Location = new System.Drawing.Point(21, 177);
            this.stockitemsLB.Name = "stockitemsLB";
            this.stockitemsLB.Size = new System.Drawing.Size(222, 394);
            this.stockitemsLB.TabIndex = 1;
            this.stockitemsLB.SelectedIndexChanged += new System.EventHandler(this.stockitemsLB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(17, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "All Stock Items:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 630);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 17);
            this.panel2.TabIndex = 3;
            // 
            // group1
            // 
            this.group1.Controls.Add(this.deleteProbtn);
            this.group1.Controls.Add(this.updateProbtn);
            this.group1.Controls.Add(this.addProbtn);
            this.group1.Controls.Add(this.txtProductPrice);
            this.group1.Controls.Add(this.txtProductDescription);
            this.group1.Controls.Add(this.txtProductName);
            this.group1.Controls.Add(this.proPricelbl);
            this.group1.Controls.Add(this.proDesclbl);
            this.group1.Controls.Add(this.proNamelbl);
            this.group1.ForeColor = System.Drawing.Color.Teal;
            this.group1.Location = new System.Drawing.Point(273, 125);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(513, 180);
            this.group1.TabIndex = 4;
            this.group1.TabStop = false;
            this.group1.Text = "Products Area";
            // 
            // deleteProbtn
            // 
            this.deleteProbtn.BackColor = System.Drawing.Color.Red;
            this.deleteProbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProbtn.ForeColor = System.Drawing.Color.Wheat;
            this.deleteProbtn.Location = new System.Drawing.Point(349, 148);
            this.deleteProbtn.Name = "deleteProbtn";
            this.deleteProbtn.Size = new System.Drawing.Size(123, 32);
            this.deleteProbtn.TabIndex = 5;
            this.deleteProbtn.Text = "Delete";
            this.deleteProbtn.UseVisualStyleBackColor = false;
            this.deleteProbtn.Click += new System.EventHandler(this.deleteProbtn_Click);
            // 
            // updateProbtn
            // 
            this.updateProbtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.updateProbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProbtn.ForeColor = System.Drawing.Color.Black;
            this.updateProbtn.Location = new System.Drawing.Point(349, 98);
            this.updateProbtn.Name = "updateProbtn";
            this.updateProbtn.Size = new System.Drawing.Size(123, 32);
            this.updateProbtn.TabIndex = 4;
            this.updateProbtn.Text = "Update";
            this.updateProbtn.UseVisualStyleBackColor = false;
            this.updateProbtn.Click += new System.EventHandler(this.updateProbtn_Click);
            // 
            // addProbtn
            // 
            this.addProbtn.BackColor = System.Drawing.Color.Teal;
            this.addProbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addProbtn.Location = new System.Drawing.Point(349, 41);
            this.addProbtn.Name = "addProbtn";
            this.addProbtn.Size = new System.Drawing.Size(123, 32);
            this.addProbtn.TabIndex = 3;
            this.addProbtn.Text = "Add";
            this.addProbtn.UseVisualStyleBackColor = false;
            this.addProbtn.Click += new System.EventHandler(this.addProbtn_Click);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.ForeColor = System.Drawing.Color.Gray;
            this.txtProductPrice.Location = new System.Drawing.Point(22, 160);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(242, 20);
            this.txtProductPrice.TabIndex = 2;
            this.txtProductPrice.Text = "Enter product price";
            this.txtProductPrice.Enter += new System.EventHandler(this.txtProductPrice_Enter);
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductPrice_KeyPress);
            this.txtProductPrice.Leave += new System.EventHandler(this.txtProductPrice_Leave);
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.ForeColor = System.Drawing.Color.Gray;
            this.txtProductDescription.Location = new System.Drawing.Point(22, 106);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(242, 33);
            this.txtProductDescription.TabIndex = 1;
            this.txtProductDescription.Text = "Enter product description";
            this.txtProductDescription.Enter += new System.EventHandler(this.txtProductDescription_Enter);
            this.txtProductDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductDescription_KeyPress);
            this.txtProductDescription.Leave += new System.EventHandler(this.txtProductDescription_Leave);
            // 
            // txtProductName
            // 
            this.txtProductName.ForeColor = System.Drawing.Color.Gray;
            this.txtProductName.Location = new System.Drawing.Point(22, 49);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(242, 20);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.Text = "Enter product name";
            this.txtProductName.Enter += new System.EventHandler(this.txtProductName_Enter);
            this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductName_KeyPress);
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // proPricelbl
            // 
            this.proPricelbl.AutoSize = true;
            this.proPricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proPricelbl.Location = new System.Drawing.Point(19, 142);
            this.proPricelbl.Name = "proPricelbl";
            this.proPricelbl.Size = new System.Drawing.Size(47, 16);
            this.proPricelbl.TabIndex = 0;
            this.proPricelbl.Text = "Price:";
            // 
            // proDesclbl
            // 
            this.proDesclbl.AutoSize = true;
            this.proDesclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proDesclbl.Location = new System.Drawing.Point(19, 86);
            this.proDesclbl.Name = "proDesclbl";
            this.proDesclbl.Size = new System.Drawing.Size(90, 16);
            this.proDesclbl.TabIndex = 0;
            this.proDesclbl.Text = "Description:";
            // 
            // proNamelbl
            // 
            this.proNamelbl.AutoSize = true;
            this.proNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proNamelbl.Location = new System.Drawing.Point(19, 30);
            this.proNamelbl.Name = "proNamelbl";
            this.proNamelbl.Size = new System.Drawing.Size(52, 16);
            this.proNamelbl.TabIndex = 0;
            this.proNamelbl.Text = "Name:";
            // 
            // prcNamelbl
            // 
            this.prcNamelbl.AutoSize = true;
            this.prcNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prcNamelbl.Location = new System.Drawing.Point(19, 30);
            this.prcNamelbl.Name = "prcNamelbl";
            this.prcNamelbl.Size = new System.Drawing.Size(52, 16);
            this.prcNamelbl.TabIndex = 0;
            this.prcNamelbl.Text = "Name:";
            // 
            // prcDesclbl
            // 
            this.prcDesclbl.AutoSize = true;
            this.prcDesclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prcDesclbl.Location = new System.Drawing.Point(19, 86);
            this.prcDesclbl.Name = "prcDesclbl";
            this.prcDesclbl.Size = new System.Drawing.Size(90, 16);
            this.prcDesclbl.TabIndex = 0;
            this.prcDesclbl.Text = "Description:";
            // 
            // prcPricelbl
            // 
            this.prcPricelbl.AutoSize = true;
            this.prcPricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prcPricelbl.Location = new System.Drawing.Point(19, 142);
            this.prcPricelbl.Name = "prcPricelbl";
            this.prcPricelbl.Size = new System.Drawing.Size(47, 16);
            this.prcPricelbl.TabIndex = 0;
            this.prcPricelbl.Text = "Price:";
            // 
            // txtProcedureName
            // 
            this.txtProcedureName.ForeColor = System.Drawing.Color.Gray;
            this.txtProcedureName.Location = new System.Drawing.Point(22, 49);
            this.txtProcedureName.Name = "txtProcedureName";
            this.txtProcedureName.Size = new System.Drawing.Size(242, 20);
            this.txtProcedureName.TabIndex = 0;
            this.txtProcedureName.Text = "Enter procedure name";
            this.txtProcedureName.Enter += new System.EventHandler(this.txtProcedureName_Enter);
            this.txtProcedureName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcedureName_KeyPress);
            this.txtProcedureName.Leave += new System.EventHandler(this.txtProcedureName_Leave);
            // 
            // txtProcedureDescription
            // 
            this.txtProcedureDescription.ForeColor = System.Drawing.Color.Gray;
            this.txtProcedureDescription.Location = new System.Drawing.Point(22, 106);
            this.txtProcedureDescription.Multiline = true;
            this.txtProcedureDescription.Name = "txtProcedureDescription";
            this.txtProcedureDescription.Size = new System.Drawing.Size(242, 33);
            this.txtProcedureDescription.TabIndex = 1;
            this.txtProcedureDescription.Text = "Enter procedure description";
            this.txtProcedureDescription.Enter += new System.EventHandler(this.txtProcedureDescription_Enter);
            this.txtProcedureDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcedureDescription_KeyPress);
            this.txtProcedureDescription.Leave += new System.EventHandler(this.txtProcedureDescription_Leave);
            // 
            // txtProcedurePrice
            // 
            this.txtProcedurePrice.ForeColor = System.Drawing.Color.Gray;
            this.txtProcedurePrice.Location = new System.Drawing.Point(22, 160);
            this.txtProcedurePrice.Name = "txtProcedurePrice";
            this.txtProcedurePrice.Size = new System.Drawing.Size(242, 20);
            this.txtProcedurePrice.TabIndex = 2;
            this.txtProcedurePrice.Text = "Enter procedure price";
            this.txtProcedurePrice.Enter += new System.EventHandler(this.txtProcedurePrice_Enter);
            this.txtProcedurePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcedurePrice_KeyPress);
            this.txtProcedurePrice.Leave += new System.EventHandler(this.txtProcedurePrice_Leave);
            // 
            // addPrcbtn
            // 
            this.addPrcbtn.BackColor = System.Drawing.Color.Teal;
            this.addPrcbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrcbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addPrcbtn.Location = new System.Drawing.Point(349, 86);
            this.addPrcbtn.Name = "addPrcbtn";
            this.addPrcbtn.Size = new System.Drawing.Size(123, 32);
            this.addPrcbtn.TabIndex = 4;
            this.addPrcbtn.Text = "Add";
            this.addPrcbtn.UseVisualStyleBackColor = false;
            this.addPrcbtn.Click += new System.EventHandler(this.addPrcbtn_Click);
            // 
            // updatePrcbtn
            // 
            this.updatePrcbtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.updatePrcbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePrcbtn.ForeColor = System.Drawing.Color.Black;
            this.updatePrcbtn.Location = new System.Drawing.Point(349, 148);
            this.updatePrcbtn.Name = "updatePrcbtn";
            this.updatePrcbtn.Size = new System.Drawing.Size(123, 32);
            this.updatePrcbtn.TabIndex = 5;
            this.updatePrcbtn.Text = "Update";
            this.updatePrcbtn.UseVisualStyleBackColor = false;
            this.updatePrcbtn.Click += new System.EventHandler(this.updatePrcbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deletePrcbtn);
            this.groupBox1.Controls.Add(this.txtProcedureMinutes);
            this.groupBox1.Controls.Add(this.prcMinuteslbl);
            this.groupBox1.Controls.Add(this.updatePrcbtn);
            this.groupBox1.Controls.Add(this.addPrcbtn);
            this.groupBox1.Controls.Add(this.txtProcedurePrice);
            this.groupBox1.Controls.Add(this.txtProcedureDescription);
            this.groupBox1.Controls.Add(this.txtProcedureName);
            this.groupBox1.Controls.Add(this.prcPricelbl);
            this.groupBox1.Controls.Add(this.prcDesclbl);
            this.groupBox1.Controls.Add(this.prcNamelbl);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(273, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 249);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procedures Area";
            // 
            // deletePrcbtn
            // 
            this.deletePrcbtn.BackColor = System.Drawing.Color.Red;
            this.deletePrcbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePrcbtn.ForeColor = System.Drawing.Color.Wheat;
            this.deletePrcbtn.Location = new System.Drawing.Point(349, 203);
            this.deletePrcbtn.Name = "deletePrcbtn";
            this.deletePrcbtn.Size = new System.Drawing.Size(123, 32);
            this.deletePrcbtn.TabIndex = 6;
            this.deletePrcbtn.Text = "Delete";
            this.deletePrcbtn.UseVisualStyleBackColor = false;
            this.deletePrcbtn.Click += new System.EventHandler(this.deletePrcbtn_Click);
            // 
            // txtProcedureMinutes
            // 
            this.txtProcedureMinutes.ForeColor = System.Drawing.Color.Gray;
            this.txtProcedureMinutes.Location = new System.Drawing.Point(22, 215);
            this.txtProcedureMinutes.Name = "txtProcedureMinutes";
            this.txtProcedureMinutes.Size = new System.Drawing.Size(242, 20);
            this.txtProcedureMinutes.TabIndex = 3;
            this.txtProcedureMinutes.Text = "Enter appointment duration";
            this.txtProcedureMinutes.Enter += new System.EventHandler(this.txtProcedureMinutes_Enter);
            this.txtProcedureMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcedureMinutes_KeyPress);
            this.txtProcedureMinutes.Leave += new System.EventHandler(this.txtProcedureMinutes_Leave);
            // 
            // prcMinuteslbl
            // 
            this.prcMinuteslbl.AutoSize = true;
            this.prcMinuteslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prcMinuteslbl.ForeColor = System.Drawing.Color.Teal;
            this.prcMinuteslbl.Location = new System.Drawing.Point(19, 196);
            this.prcMinuteslbl.Name = "prcMinuteslbl";
            this.prcMinuteslbl.Size = new System.Drawing.Size(64, 16);
            this.prcMinuteslbl.TabIndex = 6;
            this.prcMinuteslbl.Text = "Minutes:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // Searchtb
            // 
            this.Searchtb.Location = new System.Drawing.Point(21, 143);
            this.Searchtb.Name = "Searchtb";
            this.Searchtb.Size = new System.Drawing.Size(181, 20);
            this.Searchtb.TabIndex = 7;
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Searchbtn.BackgroundImage")));
            this.Searchbtn.Location = new System.Drawing.Point(208, 139);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(34, 32);
            this.Searchbtn.TabIndex = 8;
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // LoadItemBackAfterSearch
            // 
            this.LoadItemBackAfterSearch.BackColor = System.Drawing.Color.Teal;
            this.LoadItemBackAfterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadItemBackAfterSearch.Location = new System.Drawing.Point(21, 577);
            this.LoadItemBackAfterSearch.Name = "LoadItemBackAfterSearch";
            this.LoadItemBackAfterSearch.Size = new System.Drawing.Size(221, 35);
            this.LoadItemBackAfterSearch.TabIndex = 9;
            this.LoadItemBackAfterSearch.Text = "Load Items Back";
            this.LoadItemBackAfterSearch.UseVisualStyleBackColor = false;
            this.LoadItemBackAfterSearch.Click += new System.EventHandler(this.LoadItemBackAfterSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(836, 647);
            this.Controls.Add(this.LoadItemBackAfterSearch);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Searchtb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stockitemsLB);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beauty Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox stockitemsLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label proPricelbl;
        private System.Windows.Forms.Label proDesclbl;
        private System.Windows.Forms.Label proNamelbl;
        private System.Windows.Forms.Button addProbtn;
        private System.Windows.Forms.Button updateProbtn;
        private System.Windows.Forms.Button deleteProbtn;
        private System.Windows.Forms.Label prcNamelbl;
        private System.Windows.Forms.Label prcDesclbl;
        private System.Windows.Forms.Label prcPricelbl;
        private System.Windows.Forms.TextBox txtProcedureName;
        private System.Windows.Forms.TextBox txtProcedureDescription;
        private System.Windows.Forms.TextBox txtProcedurePrice;
        private System.Windows.Forms.Button addPrcbtn;
        private System.Windows.Forms.Button updatePrcbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deletePrcbtn;
        private System.Windows.Forms.TextBox txtProcedureMinutes;
        private System.Windows.Forms.Label prcMinuteslbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox Searchtb;
        private System.Windows.Forms.Button LoadItemBackAfterSearch;
    }
}

