namespace RedLineProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.baseDetailLengthInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.baseDetailWidthInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.detailListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.edgeInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.detailWidthInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.detailLengthInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.detailCountInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.helpLabel = new MaterialSkin.Controls.MaterialLabel();
            this.supportButton = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseDetailLengthInput
            // 
            this.baseDetailLengthInput.Depth = 0;
            this.baseDetailLengthInput.Hint = "";
            resources.ApplyResources(this.baseDetailLengthInput, "baseDetailLengthInput");
            this.baseDetailLengthInput.MaxLength = 32767;
            this.baseDetailLengthInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.baseDetailLengthInput.Name = "baseDetailLengthInput";
            this.baseDetailLengthInput.PasswordChar = '\0';
            this.baseDetailLengthInput.SelectedText = "";
            this.baseDetailLengthInput.SelectionLength = 0;
            this.baseDetailLengthInput.SelectionStart = 0;
            this.baseDetailLengthInput.TabStop = false;
            this.baseDetailLengthInput.UseSystemPasswordChar = false;
            // 
            // baseDetailWidthInput
            // 
            this.baseDetailWidthInput.Depth = 0;
            this.baseDetailWidthInput.Hint = "";
            resources.ApplyResources(this.baseDetailWidthInput, "baseDetailWidthInput");
            this.baseDetailWidthInput.MaxLength = 32767;
            this.baseDetailWidthInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.baseDetailWidthInput.Name = "baseDetailWidthInput";
            this.baseDetailWidthInput.PasswordChar = '\0';
            this.baseDetailWidthInput.SelectedText = "";
            this.baseDetailWidthInput.SelectionLength = 0;
            this.baseDetailWidthInput.SelectionStart = 0;
            this.baseDetailWidthInput.TabStop = false;
            this.baseDetailWidthInput.UseSystemPasswordChar = false;
            // 
            // detailListView
            // 
            this.detailListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.detailListView.Depth = 0;
            resources.ApplyResources(this.detailListView, "detailListView");
            this.detailListView.FullRowSelect = true;
            this.detailListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.detailListView.HideSelection = false;
            this.detailListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.detailListView.MouseState = MaterialSkin.MouseState.OUT;
            this.detailListView.Name = "detailListView";
            this.detailListView.OwnerDraw = true;
            this.detailListView.UseCompatibleStateImageBehavior = false;
            this.detailListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // edgeInput
            // 
            this.edgeInput.Depth = 0;
            this.edgeInput.Hint = "";
            resources.ApplyResources(this.edgeInput, "edgeInput");
            this.edgeInput.MaxLength = 32767;
            this.edgeInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.edgeInput.Name = "edgeInput";
            this.edgeInput.PasswordChar = '\0';
            this.edgeInput.SelectedText = "";
            this.edgeInput.SelectionLength = 0;
            this.edgeInput.SelectionStart = 0;
            this.edgeInput.TabStop = false;
            this.edgeInput.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            resources.ApplyResources(this.materialLabel4, "materialLabel4");
            this.materialLabel4.Depth = 0;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            // 
            // materialLabel5
            // 
            resources.ApplyResources(this.materialLabel5, "materialLabel5");
            this.materialLabel5.Depth = 0;
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            // 
            // materialFlatButton1
            // 
            resources.ApplyResources(this.materialFlatButton1, "materialFlatButton1");
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialLabel6
            // 
            resources.ApplyResources(this.materialLabel6, "materialLabel6");
            this.materialLabel6.Depth = 0;
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            // 
            // materialLabel7
            // 
            resources.ApplyResources(this.materialLabel7, "materialLabel7");
            this.materialLabel7.Depth = 0;
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            // 
            // detailWidthInput
            // 
            this.detailWidthInput.Depth = 0;
            this.detailWidthInput.Hint = "";
            resources.ApplyResources(this.detailWidthInput, "detailWidthInput");
            this.detailWidthInput.MaxLength = 32767;
            this.detailWidthInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.detailWidthInput.Name = "detailWidthInput";
            this.detailWidthInput.PasswordChar = '\0';
            this.detailWidthInput.SelectedText = "";
            this.detailWidthInput.SelectionLength = 0;
            this.detailWidthInput.SelectionStart = 0;
            this.detailWidthInput.TabStop = false;
            this.detailWidthInput.UseSystemPasswordChar = false;
            // 
            // detailLengthInput
            // 
            this.detailLengthInput.Depth = 0;
            this.detailLengthInput.Hint = "";
            resources.ApplyResources(this.detailLengthInput, "detailLengthInput");
            this.detailLengthInput.MaxLength = 32767;
            this.detailLengthInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.detailLengthInput.Name = "detailLengthInput";
            this.detailLengthInput.PasswordChar = '\0';
            this.detailLengthInput.SelectedText = "";
            this.detailLengthInput.SelectionLength = 0;
            this.detailLengthInput.SelectionStart = 0;
            this.detailLengthInput.TabStop = false;
            this.detailLengthInput.UseSystemPasswordChar = false;
            // 
            // materialFlatButton2
            // 
            resources.ApplyResources(this.materialFlatButton2, "materialFlatButton2");
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CausesValidation = false;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.materialFlatButton2, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.detailWidthInput, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.baseDetailWidthInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.detailLengthInput, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.edgeInput, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.baseDetailLengthInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.detailCountInput, 1, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // detailCountInput
            // 
            this.detailCountInput.Depth = 0;
            this.detailCountInput.Hint = "";
            resources.ApplyResources(this.detailCountInput, "detailCountInput");
            this.detailCountInput.MaxLength = 32767;
            this.detailCountInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.detailCountInput.Name = "detailCountInput";
            this.detailCountInput.PasswordChar = '\0';
            this.detailCountInput.SelectedText = "";
            this.detailCountInput.SelectionLength = 0;
            this.detailCountInput.SelectionStart = 0;
            this.detailCountInput.TabStop = false;
            this.detailCountInput.UseSystemPasswordChar = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.detailListView);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // helpLabel
            // 
            this.helpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.helpLabel.Depth = 0;
            resources.ApplyResources(this.helpLabel, "helpLabel");
            this.helpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.helpLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Click += new System.EventHandler(this.helpLabel_Click);
            // 
            // supportButton
            // 
            this.supportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.supportButton.Depth = 0;
            resources.ApplyResources(this.supportButton, "supportButton");
            this.supportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.supportButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.supportButton.Name = "supportButton";
            this.supportButton.Click += new System.EventHandler(this.supportButton_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.supportButton);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField baseDetailLengthInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField baseDetailWidthInput;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField edgeInput;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField detailWidthInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField detailLengthInput;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField detailCountInput;
        private MaterialSkin.Controls.MaterialListView detailListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel helpLabel;
        private MaterialSkin.Controls.MaterialLabel supportButton;
    }
}

