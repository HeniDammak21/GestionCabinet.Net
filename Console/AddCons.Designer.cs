
namespace Console
{
    partial class AddCons
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
            System.Windows.Forms.Label dateConsLabel;
            System.Windows.Forms.Label recapConsLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCons));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.gestionCabinetDataSet = new Console.GestionCabinetDataSet();
            this.consultationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultationsTableAdapter = new Console.GestionCabinetDataSetTableAdapters.ConsultationsTableAdapter();
            this.tableAdapterManager = new Console.GestionCabinetDataSetTableAdapters.TableAdapterManager();
            this.patientsTableAdapter = new Console.GestionCabinetDataSetTableAdapters.PatientsTableAdapter();
            this.consultationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dateConsTextBox = new System.Windows.Forms.TextBox();
            this.recapConsTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dateConsLabel = new System.Windows.Forms.Label();
            recapConsLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultationsBindingNavigator)).BeginInit();
            this.consultationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateConsLabel
            // 
            dateConsLabel.AutoSize = true;
            dateConsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateConsLabel.Location = new System.Drawing.Point(98, 216);
            dateConsLabel.Name = "dateConsLabel";
            dateConsLabel.Size = new System.Drawing.Size(202, 29);
            dateConsLabel.TabIndex = 58;
            dateConsLabel.Text = "Date Consultation";
            // 
            // recapConsLabel
            // 
            recapConsLabel.AutoSize = true;
            recapConsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            recapConsLabel.Location = new System.Drawing.Point(98, 267);
            recapConsLabel.Name = "recapConsLabel";
            recapConsLabel.Size = new System.Drawing.Size(222, 29);
            recapConsLabel.TabIndex = 60;
            recapConsLabel.Text = "Recap Consultation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(98, 327);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(164, 29);
            label2.TabIndex = 66;
            label2.Text = "Name Patient ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(140, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 46);
            this.label1.TabIndex = 40;
            this.label1.Text = "Add Consultation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(36, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Back";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(219)))), ((int)(((byte)(222)))));
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(35, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 33);
            this.button7.TabIndex = 54;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // gestionCabinetDataSet
            // 
            this.gestionCabinetDataSet.DataSetName = "GestionCabinetDataSet";
            this.gestionCabinetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultationsBindingSource
            // 
            this.consultationsBindingSource.DataMember = "Consultations";
            this.consultationsBindingSource.DataSource = this.gestionCabinetDataSet;
            // 
            // consultationsTableAdapter
            // 
            this.consultationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrateursTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultationsTableAdapter = this.consultationsTableAdapter;
            this.tableAdapterManager.MedecinsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.RendezvousTableAdapter = null;
            this.tableAdapterManager.SpecialitesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Console.GestionCabinetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // consultationsBindingNavigator
            // 
            this.consultationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultationsBindingNavigator.BindingSource = this.consultationsBindingSource;
            this.consultationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultationsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.consultationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.consultationsBindingNavigatorSaveItem});
            this.consultationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultationsBindingNavigator.Name = "consultationsBindingNavigator";
            this.consultationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultationsBindingNavigator.Size = new System.Drawing.Size(605, 31);
            this.consultationsBindingNavigator.TabIndex = 56;
            this.consultationsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // consultationsBindingNavigatorSaveItem
            // 
            this.consultationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultationsBindingNavigatorSaveItem.Image")));
            this.consultationsBindingNavigatorSaveItem.Name = "consultationsBindingNavigatorSaveItem";
            this.consultationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.consultationsBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.consultationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultationsBindingNavigatorSaveItem_Click);
            // 
            // dateConsTextBox
            // 
            this.dateConsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultationsBindingSource, "dateCons", true));
            this.dateConsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateConsTextBox.Location = new System.Drawing.Point(333, 211);
            this.dateConsTextBox.Name = "dateConsTextBox";
            this.dateConsTextBox.Size = new System.Drawing.Size(186, 34);
            this.dateConsTextBox.TabIndex = 59;
            this.dateConsTextBox.TextChanged += new System.EventHandler(this.dateConsTextBox_TextChanged);
            // 
            // recapConsTextBox
            // 
            this.recapConsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultationsBindingSource, "recapCons", true));
            this.recapConsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recapConsTextBox.Location = new System.Drawing.Point(333, 264);
            this.recapConsTextBox.Name = "recapConsTextBox";
            this.recapConsTextBox.Size = new System.Drawing.Size(186, 34);
            this.recapConsTextBox.TabIndex = 61;
            this.recapConsTextBox.TextChanged += new System.EventHandler(this.recapConsTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(442, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 64;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientsBindingSource, "PatientID", true));
            this.comboBox1.DataSource = this.patientsBindingSource;
            this.comboBox1.DisplayMember = "prenomPat";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(333, 324);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 37);
            this.comboBox1.TabIndex = 65;
            this.comboBox1.ValueMember = "PatientID";
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.gestionCabinetDataSet;
            // 
            // AddCons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(219)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(605, 581);
            this.Controls.Add(label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(dateConsLabel);
            this.Controls.Add(this.dateConsTextBox);
            this.Controls.Add(recapConsLabel);
            this.Controls.Add(this.recapConsTextBox);
            this.Controls.Add(this.consultationsBindingNavigator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Name = "AddCons";
            this.Text = "AddCons";
            this.Load += new System.EventHandler(this.AddCons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultationsBindingNavigator)).EndInit();
            this.consultationsBindingNavigator.ResumeLayout(false);
            this.consultationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private GestionCabinetDataSet gestionCabinetDataSet;
        private System.Windows.Forms.BindingSource consultationsBindingSource;
        private GestionCabinetDataSetTableAdapters.ConsultationsTableAdapter consultationsTableAdapter;
        private GestionCabinetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultationsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton consultationsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dateConsTextBox;
        private System.Windows.Forms.TextBox recapConsTextBox;
        private System.Windows.Forms.Button button1;
        private GestionCabinetDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource patientsBindingSource;
    }
}