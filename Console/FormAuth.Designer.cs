
namespace Console
{
    partial class FormAuth
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
            System.Windows.Forms.Label motDePasseLabel;
            System.Windows.Forms.Label userNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuth));
            this.gestionCabinetDataSet = new Console.GestionCabinetDataSet();
            this.administrateursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administrateursTableAdapter = new Console.GestionCabinetDataSetTableAdapters.AdministrateursTableAdapter();
            this.tableAdapterManager = new Console.GestionCabinetDataSetTableAdapters.TableAdapterManager();
            this.administrateursBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.administrateursBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.motDePasseTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            motDePasseLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrateursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrateursBindingNavigator)).BeginInit();
            this.administrateursBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // motDePasseLabel
            // 
            motDePasseLabel.AutoSize = true;
            motDePasseLabel.Location = new System.Drawing.Point(276, 213);
            motDePasseLabel.Name = "motDePasseLabel";
            motDePasseLabel.Size = new System.Drawing.Size(100, 17);
            motDePasseLabel.TabIndex = 5;
            motDePasseLabel.Text = "Mot De Passe:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(276, 175);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(83, 17);
            userNameLabel.TabIndex = 7;
            userNameLabel.Text = "User Name:";
            userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // gestionCabinetDataSet
            // 
            this.gestionCabinetDataSet.DataSetName = "GestionCabinetDataSet";
            this.gestionCabinetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // administrateursBindingSource
            // 
            this.administrateursBindingSource.DataMember = "Administrateurs";
            this.administrateursBindingSource.DataSource = this.gestionCabinetDataSet;
            // 
            // administrateursTableAdapter
            // 
            this.administrateursTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrateursTableAdapter = this.administrateursTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultationsTableAdapter = null;
            this.tableAdapterManager.MedecinsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.RendezvousTableAdapter = null;
            this.tableAdapterManager.SpecialitesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Console.GestionCabinetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // administrateursBindingNavigator
            // 
            this.administrateursBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.administrateursBindingNavigator.BindingSource = this.administrateursBindingSource;
            this.administrateursBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.administrateursBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.administrateursBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.administrateursBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.administrateursBindingNavigatorSaveItem});
            this.administrateursBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.administrateursBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.administrateursBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.administrateursBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.administrateursBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.administrateursBindingNavigator.Name = "administrateursBindingNavigator";
            this.administrateursBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.administrateursBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.administrateursBindingNavigator.TabIndex = 0;
            this.administrateursBindingNavigator.Text = "bindingNavigator1";
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
            // administrateursBindingNavigatorSaveItem
            // 
            this.administrateursBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.administrateursBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("administrateursBindingNavigatorSaveItem.Image")));
            this.administrateursBindingNavigatorSaveItem.Name = "administrateursBindingNavigatorSaveItem";
            this.administrateursBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.administrateursBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.administrateursBindingNavigatorSaveItem.Click += new System.EventHandler(this.administrateursBindingNavigatorSaveItem_Click);
            // 
            // motDePasseTextBox
            // 
            this.motDePasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.administrateursBindingSource, "MotDePasse", true));
            this.motDePasseTextBox.Location = new System.Drawing.Point(402, 210);
            this.motDePasseTextBox.Name = "motDePasseTextBox";
            this.motDePasseTextBox.Size = new System.Drawing.Size(100, 22);
            this.motDePasseTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Connecxion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.administrateursBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(365, 172);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.userNameTextBox.TabIndex = 8;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(motDePasseLabel);
            this.Controls.Add(this.motDePasseTextBox);
            this.Controls.Add(this.administrateursBindingNavigator);
            this.Name = "FormAuth";
            this.Text = "FormAuth";
            this.Load += new System.EventHandler(this.FormAuth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrateursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrateursBindingNavigator)).EndInit();
            this.administrateursBindingNavigator.ResumeLayout(false);
            this.administrateursBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GestionCabinetDataSet gestionCabinetDataSet;
        private System.Windows.Forms.BindingSource administrateursBindingSource;
        private GestionCabinetDataSetTableAdapters.AdministrateursTableAdapter administrateursTableAdapter;
        private GestionCabinetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator administrateursBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton administrateursBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox motDePasseTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userNameTextBox;
    }
}