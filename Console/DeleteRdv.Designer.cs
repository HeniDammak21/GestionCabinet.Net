
namespace Console
{
    partial class DeleteRdv
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
            System.Windows.Forms.Label rendezvousIDLabel;
            System.Windows.Forms.Label dateRdvLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteRdv));
            this.gestionCabinetDataSet = new Console.GestionCabinetDataSet();
            this.rendezvousBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rendezvousTableAdapter = new Console.GestionCabinetDataSetTableAdapters.RendezvousTableAdapter();
            this.tableAdapterManager = new Console.GestionCabinetDataSetTableAdapters.TableAdapterManager();
            this.medecinsTableAdapter = new Console.GestionCabinetDataSetTableAdapters.MedecinsTableAdapter();
            this.patientsTableAdapter = new Console.GestionCabinetDataSetTableAdapters.PatientsTableAdapter();
            this.rendezvousBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rendezvousBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rendezvousIDTextBox = new System.Windows.Forms.TextBox();
            this.dateRdvTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.medecinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            rendezvousIDLabel = new System.Windows.Forms.Label();
            dateRdvLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousBindingNavigator)).BeginInit();
            this.rendezvousBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rendezvousIDLabel
            // 
            rendezvousIDLabel.AutoSize = true;
            rendezvousIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rendezvousIDLabel.Location = new System.Drawing.Point(71, 186);
            rendezvousIDLabel.Name = "rendezvousIDLabel";
            rendezvousIDLabel.Size = new System.Drawing.Size(177, 29);
            rendezvousIDLabel.TabIndex = 81;
            rendezvousIDLabel.Text = "Appointment ID";
            // 
            // dateRdvLabel
            // 
            dateRdvLabel.AutoSize = true;
            dateRdvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateRdvLabel.Location = new System.Drawing.Point(71, 250);
            dateRdvLabel.Name = "dateRdvLabel";
            dateRdvLabel.Size = new System.Drawing.Size(204, 29);
            dateRdvLabel.TabIndex = 82;
            dateRdvLabel.Text = "Date Appointment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(71, 304);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(164, 29);
            label2.TabIndex = 83;
            label2.Text = "Name Patient ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(71, 365);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 29);
            label3.TabIndex = 84;
            label3.Text = "Name Doctor";
            // 
            // gestionCabinetDataSet
            // 
            this.gestionCabinetDataSet.DataSetName = "GestionCabinetDataSet";
            this.gestionCabinetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rendezvousBindingSource
            // 
            this.rendezvousBindingSource.DataMember = "Rendezvous";
            this.rendezvousBindingSource.DataSource = this.gestionCabinetDataSet;
            // 
            // rendezvousTableAdapter
            // 
            this.rendezvousTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrateursTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultationsTableAdapter = null;
            this.tableAdapterManager.MedecinsTableAdapter = this.medecinsTableAdapter;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.RendezvousTableAdapter = this.rendezvousTableAdapter;
            this.tableAdapterManager.SpecialitesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Console.GestionCabinetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medecinsTableAdapter
            // 
            this.medecinsTableAdapter.ClearBeforeFill = true;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // rendezvousBindingNavigator
            // 
            this.rendezvousBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rendezvousBindingNavigator.BindingSource = this.rendezvousBindingSource;
            this.rendezvousBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rendezvousBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rendezvousBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rendezvousBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rendezvousBindingNavigatorSaveItem});
            this.rendezvousBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rendezvousBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rendezvousBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rendezvousBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rendezvousBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rendezvousBindingNavigator.Name = "rendezvousBindingNavigator";
            this.rendezvousBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rendezvousBindingNavigator.Size = new System.Drawing.Size(605, 31);
            this.rendezvousBindingNavigator.TabIndex = 0;
            this.rendezvousBindingNavigator.Text = "bindingNavigator1";
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
            // rendezvousBindingNavigatorSaveItem
            // 
            this.rendezvousBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rendezvousBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rendezvousBindingNavigatorSaveItem.Image")));
            this.rendezvousBindingNavigatorSaveItem.Name = "rendezvousBindingNavigatorSaveItem";
            this.rendezvousBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.rendezvousBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.rendezvousBindingNavigatorSaveItem.Click += new System.EventHandler(this.rendezvousBindingNavigatorSaveItem_Click);
            // 
            // rendezvousIDTextBox
            // 
            this.rendezvousIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rendezvousBindingSource, "RendezvousID", true));
            this.rendezvousIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rendezvousIDTextBox.Location = new System.Drawing.Point(281, 191);
            this.rendezvousIDTextBox.Name = "rendezvousIDTextBox";
            this.rendezvousIDTextBox.Size = new System.Drawing.Size(203, 34);
            this.rendezvousIDTextBox.TabIndex = 2;
            // 
            // dateRdvTextBox
            // 
            this.dateRdvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rendezvousBindingSource, "dateRdv", true));
            this.dateRdvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRdvTextBox.Location = new System.Drawing.Point(281, 245);
            this.dateRdvTextBox.Name = "dateRdvTextBox";
            this.dateRdvTextBox.Size = new System.Drawing.Size(203, 34);
            this.dateRdvTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(440, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
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
            this.comboBox1.Location = new System.Drawing.Point(281, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 37);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "PatientID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.gestionCabinetDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medecinsBindingSource, "MedecinID", true));
            this.comboBox2.DataSource = this.medecinsBindingSource;
            this.comboBox2.DisplayMember = "prenomMed";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(281, 365);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 37);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.ValueMember = "MedecinID";
            // 
            // medecinsBindingSource
            // 
            this.medecinsBindingSource.DataMember = "Medecins";
            this.medecinsBindingSource.DataSource = this.gestionCabinetDataSet;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(219)))), ((int)(((byte)(222)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(12, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 33);
            this.button2.TabIndex = 80;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(156, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 46);
            this.label1.TabIndex = 79;
            this.label1.Text = "Delete Appointment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(12, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 78;
            this.label6.Text = "Back";
            // 
            // DeleteRdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(219)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(605, 581);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(rendezvousIDLabel);
            this.Controls.Add(dateRdvLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rendezvousIDTextBox);
            this.Controls.Add(this.dateRdvTextBox);
            this.Controls.Add(this.rendezvousBindingNavigator);
            this.Name = "DeleteRdv";
            this.Text = "DeleteRdv";
            this.Load += new System.EventHandler(this.DeleteRdv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousBindingNavigator)).EndInit();
            this.rendezvousBindingNavigator.ResumeLayout(false);
            this.rendezvousBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GestionCabinetDataSet gestionCabinetDataSet;
        private System.Windows.Forms.BindingSource rendezvousBindingSource;
        private GestionCabinetDataSetTableAdapters.RendezvousTableAdapter rendezvousTableAdapter;
        private GestionCabinetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rendezvousBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rendezvousBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox rendezvousIDTextBox;
        private System.Windows.Forms.TextBox dateRdvTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private GestionCabinetDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private GestionCabinetDataSetTableAdapters.MedecinsTableAdapter medecinsTableAdapter;
        private System.Windows.Forms.BindingSource medecinsBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}