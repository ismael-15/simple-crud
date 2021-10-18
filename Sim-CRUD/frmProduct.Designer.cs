
namespace Sim_CRUD
{
    partial class frmProduct
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.INew = new MetroFramework.Controls.MetroLink();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabForm = new MetroFramework.Controls.MetroTabPage();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.IblId = new MetroFramework.Controls.MetroLabel();
            this.tabData = new MetroFramework.Controls.MetroTabPage();
            this.dtgProduct = new System.Windows.Forms.DataGridView();
            this.actions = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.tabs.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).BeginInit();
            this.actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(98, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "PRODUCT";
            // 
            // INew
            // 
            this.INew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.INew.Location = new System.Drawing.Point(201, 42);
            this.INew.Name = "INew";
            this.INew.Size = new System.Drawing.Size(102, 25);
            this.INew.TabIndex = 1;
            this.INew.Text = "_New product";
            this.INew.UseSelectable = true;
            this.INew.Click += new System.EventHandler(this.INew_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabForm);
            this.tabs.Controls.Add(this.tabData);
            this.tabs.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tabs.Location = new System.Drawing.Point(98, 83);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 1;
            this.tabs.Size = new System.Drawing.Size(591, 307);
            this.tabs.TabIndex = 2;
            this.tabs.UseSelectable = true;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.btnCancel);
            this.tabForm.Controls.Add(this.btnSave);
            this.tabForm.Controls.Add(this.txtPrecio);
            this.tabForm.Controls.Add(this.txtDescripcion);
            this.tabForm.Controls.Add(this.txtName);
            this.tabForm.Controls.Add(this.txtId);
            this.tabForm.Controls.Add(this.metroLabel5);
            this.tabForm.Controls.Add(this.metroLabel4);
            this.tabForm.Controls.Add(this.metroLabel3);
            this.tabForm.Controls.Add(this.IblId);
            this.tabForm.HorizontalScrollbarBarColor = true;
            this.tabForm.HorizontalScrollbarHighlightOnWheel = false;
            this.tabForm.HorizontalScrollbarSize = 10;
            this.tabForm.Location = new System.Drawing.Point(4, 34);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(583, 269);
            this.tabForm.TabIndex = 0;
            this.tabForm.Text = "PRODUCT FORM";
            this.tabForm.VerticalScrollbarBarColor = true;
            this.tabForm.VerticalScrollbarHighlightOnWheel = false;
            this.tabForm.VerticalScrollbarSize = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(418, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.White;
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(305, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = MetroFramework.MetroColorStyle.White;
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrecio
            // 
            // 
            // 
            // 
            this.txtPrecio.CustomButton.Image = null;
            this.txtPrecio.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtPrecio.CustomButton.Name = "";
            this.txtPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecio.CustomButton.TabIndex = 1;
            this.txtPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecio.CustomButton.UseSelectable = true;
            this.txtPrecio.CustomButton.Visible = false;
            this.txtPrecio.Lines = new string[0];
            this.txtPrecio.Location = new System.Drawing.Point(171, 182);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.ShortcutsEnabled = true;
            this.txtPrecio.Size = new System.Drawing.Size(210, 23);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.UseSelectable = true;
            this.txtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.CustomButton.Image = null;
            this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtDescripcion.CustomButton.Name = "";
            this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.CustomButton.TabIndex = 1;
            this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcion.CustomButton.UseSelectable = true;
            this.txtDescripcion.CustomButton.Visible = false;
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(171, 121);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(149, 23);
            this.txtDescripcion.TabIndex = 8;
            this.txtDescripcion.UseSelectable = true;
            this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(171, 70);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(114, 23);
            this.txtName.TabIndex = 7;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(171, 13);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(75, 23);
            this.txtId.TabIndex = 6;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(32, 182);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Precio";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(32, 125);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Descripcion";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Nombre";
            // 
            // IblId
            // 
            this.IblId.AutoSize = true;
            this.IblId.Location = new System.Drawing.Point(32, 18);
            this.IblId.Name = "IblId";
            this.IblId.Size = new System.Drawing.Size(70, 19);
            this.IblId.TabIndex = 2;
            this.IblId.Text = "Product Id";
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.dtgProduct);
            this.tabData.HorizontalScrollbarBarColor = true;
            this.tabData.HorizontalScrollbarHighlightOnWheel = false;
            this.tabData.HorizontalScrollbarSize = 10;
            this.tabData.Location = new System.Drawing.Point(4, 34);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(583, 269);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "PRODUCT LIST";
            this.tabData.VerticalScrollbarBarColor = true;
            this.tabData.VerticalScrollbarHighlightOnWheel = false;
            this.tabData.VerticalScrollbarSize = 10;
            // 
            // dtgProduct
            // 
            this.dtgProduct.AllowUserToAddRows = false;
            this.dtgProduct.AllowUserToDeleteRows = false;
            this.dtgProduct.AllowUserToResizeColumns = false;
            this.dtgProduct.AllowUserToResizeRows = false;
            this.dtgProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProduct.BackgroundColor = System.Drawing.Color.White;
            this.dtgProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduct.ContextMenuStrip = this.actions;
            this.dtgProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgProduct.Location = new System.Drawing.Point(3, 14);
            this.dtgProduct.MultiSelect = false;
            this.dtgProduct.Name = "dtgProduct";
            this.dtgProduct.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgProduct.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProduct.Size = new System.Drawing.Size(577, 232);
            this.dtgProduct.TabIndex = 2;
            this.dtgProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduct_CellContentClick);
            // 
            // actions
            // 
            this.actions.BackColor = System.Drawing.Color.White;
            this.actions.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.actions.Name = "actions";
            this.actions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.actions.ShowImageMargin = false;
            this.actions.Size = new System.Drawing.Size(156, 70);
            this.actions.Style = MetroFramework.MetroColorStyle.Purple;
            this.actions.UseCustomBackColor = true;
            this.actions.UseCustomForeColor = true;
            this.actions.UseStyleColors = true;
            this.actions.UseWaitCursor = true;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(685, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.Style = MetroFramework.MetroColorStyle.White;
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseCustomBackColor = true;
            this.btnExit.UseSelectable = true;
            this.btnExit.UseStyleColors = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(854, 480);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.INew);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIBRARY-PRODUCT";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.tabs.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).EndInit();
            this.actions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink INew;
        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroTabPage tabForm;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtPrecio;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel IblId;
        private MetroFramework.Controls.MetroTabPage tabData;
        private System.Windows.Forms.DataGridView dtgProduct;
        private MetroFramework.Controls.MetroButton btnExit;
        public MetroFramework.Controls.MetroContextMenu actions;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

