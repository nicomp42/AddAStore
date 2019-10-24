namespace AddAStore
{
    partial class frmAddAStore
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEmpl = new System.Windows.Forms.ListBox();
            this.groceryStoreSimulatorDataSet = new AddAStore.GroceryStoreSimulatorDataSet();
            this.groceryStoreSimulatorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groceryStoreSimulatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryStoreSimulatorDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(782, 508);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(268, 41);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(150, 22);
            this.txtStore.TabIndex = 1;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(268, 69);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(150, 22);
            this.txtAddress1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Store";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address 1";
            // 
            // lbEmpl
            // 
            this.lbEmpl.FormattingEnabled = true;
            this.lbEmpl.ItemHeight = 16;
            this.lbEmpl.Location = new System.Drawing.Point(268, 211);
            this.lbEmpl.Name = "lbEmpl";
            this.lbEmpl.Size = new System.Drawing.Size(455, 84);
            this.lbEmpl.TabIndex = 5;
            this.lbEmpl.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groceryStoreSimulatorDataSet
            // 
            this.groceryStoreSimulatorDataSet.DataSetName = "GroceryStoreSimulatorDataSet";
            this.groceryStoreSimulatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groceryStoreSimulatorDataSetBindingSource
            // 
            this.groceryStoreSimulatorDataSetBindingSource.DataSource = this.groceryStoreSimulatorDataSet;
            this.groceryStoreSimulatorDataSetBindingSource.Position = 0;
            // 
            // frmAddAStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 552);
            this.Controls.Add(this.lbEmpl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmAddAStore";
            this.Text = "Add a Store";
            this.Load += new System.EventHandler(this.frmAddAStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groceryStoreSimulatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryStoreSimulatorDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbEmpl;
        private GroceryStoreSimulatorDataSet groceryStoreSimulatorDataSet;
        private System.Windows.Forms.BindingSource groceryStoreSimulatorDataSetBindingSource;
    }
}

