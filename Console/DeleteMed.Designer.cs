
namespace Console
{
    partial class DeleteMed
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
            System.Windows.Forms.Label medecinIDLabel;
            System.Windows.Forms.Label nomMedLabel;
            System.Windows.Forms.Label prenomMedLabel;
            System.Windows.Forms.Label numTelLabel;
            System.Windows.Forms.Label specialiteIDLabel;
            System.Windows.Forms.Label adreMedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMed));
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gestionCabinetDataSet = new Console.GestionCabinetDataSet();
            this.medecinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinsTableAdapter = new Console.GestionCabinetDataSetTableAdapters.MedecinsTableAdapter();
            this.tableAdapterManager = new Console.GestionCabinetDataSetTableAdapters.TableAdapterManager();
            this.specialitesTableAdapter = new Console.GestionCabinetDataSetTableAdapters.SpecialitesTableAdapter();
            this.medecinsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.medecinsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medecinIDTextBox = new System.Windows.Forms.TextBox();
            this.nomMedTextBox = new System.Windows.Forms.TextBox();
            this.prenomMedTextBox = new System.Windows.Forms.TextBox();
            this.numTelTextBox = new System.Windows.Forms.TextBox();
            this.adreMedTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.specialitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            medecinIDLabel = new System.Windows.Forms.Label();
            nomMedLabel = new System.Windows.Forms.Label();
            prenomMedLabel = new System.Windows.Forms.Label();
            numTelLabel = new System.Windows.Forms.Label();
            specialiteIDLabel = new System.Windows.Forms.Label();
            adreMedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsBindingNavigator)).BeginInit();
            this.medecinsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // medecinIDLabel
            // 
            medecinIDLabel.AutoSize = true;
            medecinIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medecinIDLabel.Location = new System.Drawing.Point(104, 164);
            medecinIDLabel.Name = "medecinIDLabel";
            medecinIDLabel.Size = new System.Drawing.Size(135, 29);
            medecinIDLabel.TabIndex = 70;
            medecinIDLabel.Text = "Medecin ID";
            // 
            // nomMedLabel
            // 
            nomMedLabel.AutoSize = true;
            nomMedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomMedLabel.Location = new System.Drawing.Point(104, 273);
            nomMedLabel.Name = "nomMedLabel";
            nomMedLabel.Size = new System.Drawing.Size(128, 29);
            nomMedLabel.TabIndex = 71;
            nomMedLabel.Text = "Last Name";
            // 
            // prenomMedLabel
            // 
            prenomMedLabel.AutoSize = true;
            prenomMedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomMedLabel.Location = new System.Drawing.Point(104, 216);
            prenomMedLabel.Name = "prenomMedLabel";
            prenomMedLabel.Size = new System.Drawing.Size(131, 29);
            prenomMedLabel.TabIndex = 72;
            prenomMedLabel.Text = "First Name";
            // 
            // numTelLabel
            // 
            numTelLabel.AutoSize = true;
            numTelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numTelLabel.Location = new System.Drawing.Point(104, 329);
            numTelLabel.Name = "numTelLabel";
            numTelLabel.Size = new System.Drawing.Size(176, 29);
            numTelLabel.TabIndex = 73;
            numTelLabel.Text = "Phone Number";
            // 
            // specialiteIDLabel
            // 
            specialiteIDLabel.AutoSize = true;
            specialiteIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialiteIDLabel.Location = new System.Drawing.Point(104, 380);
            specialiteIDLabel.Name = "specialiteIDLabel";
            specialiteIDLabel.Size = new System.Drawing.Size(126, 29);
            specialiteIDLabel.TabIndex = 74;
            specialiteIDLabel.Text = "Specialite ";
            // 
            // adreMedLabel
            // 
            adreMedLabel.AutoSize = true;
            adreMedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adreMedLabel.Location = new System.Drawing.Point(104, 434);
            adreMedLabel.Name = "adreMedLabel";
            adreMedLabel.Size = new System.Drawing.Size(108, 29);
            adreMedLabel.TabIndex = 75;
            adreMedLabel.Text = "Address ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(12, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Back";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(442, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 47;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gestionCabinetDataSet
            // 
            this.gestionCabinetDataSet.DataSetName = "GestionCabinetDataSet";
            this.gestionCabinetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medecinsBindingSource
            // 
            this.medecinsBindingSource.DataMember = "Medecins";
            this.medecinsBindingSource.DataSource = this.gestionCabinetDataSet;
            // 
            // medecinsTableAdapter
            // 
            this.medecinsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrateursTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultationsTableAdapter = null;
            this.tableAdapterManager.MedecinsTableAdapter = this.medecinsTableAdapter;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.RendezvousTableAdapter = null;
            this.tableAdapterManager.SpecialitesTableAdapter = this.specialitesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Console.GestionCabinetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specialitesTableAdapter
            // 
            this.specialitesTableAdapter.ClearBeforeFill = true;
            // 
            // medecinsBindingNavigator
            // 
            this.medecinsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medecinsBindingNavigator.BindingSource = this.medecinsBindingSource;
            this.medecinsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medecinsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medecinsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.medecinsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.medecinsBindingNavigatorSaveItem});
            this.medecinsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medecinsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medecinsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medecinsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medecinsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medecinsBindingNavigator.Name = "medecinsBindingNavigator";
            this.medecinsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medecinsBindingNavigator.Size = new System.Drawing.Size(605, 27);
            this.medecinsBindingNavigator.TabIndex = 50;
            this.medecinsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // medecinsBindingNavigatorSaveItem
            // 
            this.medecinsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medecinsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medecinsBindingNavigatorSaveItem.Image")));
            this.medecinsBindingNavigatorSaveItem.Name = "medecinsBindingNavigatorSaveItem";
            this.medecinsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.medecinsBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.medecinsBindingNavigatorSaveItem.Click += new System.EventHandler(this.medecinsBindingNavigatorSaveItem_Click);
            // 
            // medecinIDTextBox
            // 
            this.medecinIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinsBindingSource, "MedecinID", true));
            this.medecinIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecinIDTextBox.Location = new System.Drawing.Point(324, 164);
            this.medecinIDTextBox.Name = "medecinIDTextBox";
            this.medecinIDTextBox.Size = new System.Drawing.Size(165, 34);
            this.medecinIDTextBox.TabIndex = 51;
            this.medecinIDTextBox.TextChanged += new System.EventHandler(this.medecinIDTextBox_TextChanged);
            // 
            // nomMedTextBox
            // 
            this.nomMedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinsBindingSource, "nomMed", true));
            this.nomMedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomMedTextBox.Location = new System.Drawing.Point(324, 211);
            this.nomMedTextBox.Name = "nomMedTextBox";
            this.nomMedTextBox.Size = new System.Drawing.Size(165, 34);
            this.nomMedTextBox.TabIndex = 53;
            this.nomMedTextBox.TextChanged += new System.EventHandler(this.nomMedTextBox_TextChanged);
            // 
            // prenomMedTextBox
            // 
            this.prenomMedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinsBindingSource, "prenomMed", true));
            this.prenomMedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomMedTextBox.Location = new System.Drawing.Point(324, 266);
            this.prenomMedTextBox.Name = "prenomMedTextBox";
            this.prenomMedTextBox.Size = new System.Drawing.Size(165, 34);
            this.prenomMedTextBox.TabIndex = 55;
            this.prenomMedTextBox.TextChanged += new System.EventHandler(this.prenomMedTextBox_TextChanged);
            // 
            // numTelTextBox
            // 
            this.numTelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinsBindingSource, "numTel", true));
            this.numTelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTelTextBox.Location = new System.Drawing.Point(324, 324);
            this.numTelTextBox.Name = "numTelTextBox";
            this.numTelTextBox.Size = new System.Drawing.Size(165, 34);
            this.numTelTextBox.TabIndex = 57;
            this.numTelTextBox.TextChanged += new System.EventHandler(this.numTelTextBox_TextChanged);
            // 
            // adreMedTextBox
            // 
            this.adreMedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinsBindingSource, "adreMed", true));
            this.adreMedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adreMedTextBox.Location = new System.Drawing.Point(324, 434);
            this.adreMedTextBox.Name = "adreMedTextBox";
            this.adreMedTextBox.Size = new System.Drawing.Size(165, 34);
            this.adreMedTextBox.TabIndex = 61;
            this.adreMedTextBox.TextChanged += new System.EventHandler(this.adreMedTextBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.specialitesBindingSource, "SpecialiteID", true));
            this.comboBox1.DataSource = this.specialitesBindingSource;
            this.comboBox1.DisplayMember = "nomSpec";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(324, 372);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 37);
            this.comboBox1.TabIndex = 62;
            this.comboBox1.ValueMember = "SpecialiteID";
            // 
            // specialitesBindingSource
            // 
            this.specialitesBindingSource.DataMember = "Specialites";
            this.specialitesBindingSource.DataSource = this.gestionCabinetDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(172, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 46);
            this.label1.TabIndex = 69;
            this.label1.Text = "Delete Doctor";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(219)))), ((int)(((byte)(222)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(16, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 33);
            this.button2.TabIndex = 76;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(219)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(605, 581);
            this.Controls.Add(this.button2);
            this.Controls.Add(medecinIDLabel);
            this.Controls.Add(nomMedLabel);
            this.Controls.Add(prenomMedLabel);
            this.Controls.Add(numTelLabel);
            this.Controls.Add(specialiteIDLabel);
            this.Controls.Add(adreMedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.medecinIDTextBox);
            this.Controls.Add(this.nomMedTextBox);
            this.Controls.Add(this.prenomMedTextBox);
            this.Controls.Add(this.numTelTextBox);
            this.Controls.Add(this.adreMedTextBox);
            this.Controls.Add(this.medecinsBindingNavigator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Name = "DeleteMed";
            this.Text = "DeleteMedcs";
            this.Load += new System.EventHandler(this.DeleteMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsBindingNavigator)).EndInit();
            this.medecinsBindingNavigator.ResumeLayout(false);
            this.medecinsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private GestionCabinetDataSet gestionCabinetDataSet;
        private System.Windows.Forms.BindingSource medecinsBindingSource;
        private GestionCabinetDataSetTableAdapters.MedecinsTableAdapter medecinsTableAdapter;
        private GestionCabinetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medecinsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton medecinsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox medecinIDTextBox;
        private System.Windows.Forms.TextBox nomMedTextBox;
        private System.Windows.Forms.TextBox prenomMedTextBox;
        private System.Windows.Forms.TextBox numTelTextBox;
        private System.Windows.Forms.TextBox adreMedTextBox;
        private GestionCabinetDataSetTableAdapters.SpecialitesTableAdapter specialitesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource specialitesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}