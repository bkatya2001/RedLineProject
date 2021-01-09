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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.baseDetailLengthInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.baseDetailWidthInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.edgeInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.detailWidthInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.detailLengthInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.detailCountInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.detailListView = new MaterialSkin.Controls.MaterialListView();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Размеры ДСП";
            // 
            // baseDetailLengthInput
            // 
            this.baseDetailLengthInput.Depth = 0;
            this.baseDetailLengthInput.Hint = "";
            this.baseDetailLengthInput.Location = new System.Drawing.Point(3, 73);
            this.baseDetailLengthInput.MaxLength = 32767;
            this.baseDetailLengthInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.baseDetailLengthInput.Name = "baseDetailLengthInput";
            this.baseDetailLengthInput.PasswordChar = '\0';
            this.baseDetailLengthInput.SelectedText = "";
            this.baseDetailLengthInput.SelectionLength = 0;
            this.baseDetailLengthInput.SelectionStart = 0;
            this.baseDetailLengthInput.Size = new System.Drawing.Size(94, 23);
            this.baseDetailLengthInput.TabIndex = 0;
            this.baseDetailLengthInput.TabStop = false;
            this.baseDetailLengthInput.Text = "0";
            this.baseDetailLengthInput.UseSystemPasswordChar = false;
            // 
            // baseDetailWidthInput
            // 
            this.baseDetailWidthInput.Depth = 0;
            this.baseDetailWidthInput.Hint = "";
            this.baseDetailWidthInput.Location = new System.Drawing.Point(184, 73);
            this.baseDetailWidthInput.MaxLength = 32767;
            this.baseDetailWidthInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.baseDetailWidthInput.Name = "baseDetailWidthInput";
            this.baseDetailWidthInput.PasswordChar = '\0';
            this.baseDetailWidthInput.SelectedText = "";
            this.baseDetailWidthInput.SelectionLength = 0;
            this.baseDetailWidthInput.SelectionStart = 0;
            this.baseDetailWidthInput.Size = new System.Drawing.Size(94, 23);
            this.baseDetailWidthInput.TabIndex = 2;
            this.baseDetailWidthInput.TabStop = false;
            this.baseDetailWidthInput.Text = "0";
            this.baseDetailWidthInput.UseSystemPasswordChar = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.materialLabel2);
            this.flowLayoutPanel1.Controls.Add(this.detailListView);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(394, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 446);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(101, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Ваши детали";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 140);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(151, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Диаметр фрезы, мм";
            // 
            // edgeInput
            // 
            this.edgeInput.Depth = 0;
            this.edgeInput.Hint = "";
            this.edgeInput.Location = new System.Drawing.Point(3, 178);
            this.edgeInput.MaxLength = 32767;
            this.edgeInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.edgeInput.Name = "edgeInput";
            this.edgeInput.PasswordChar = '\0';
            this.edgeInput.SelectedText = "";
            this.edgeInput.SelectionLength = 0;
            this.edgeInput.SelectionStart = 0;
            this.edgeInput.Size = new System.Drawing.Size(94, 23);
            this.edgeInput.TabIndex = 9;
            this.edgeInput.TabStop = false;
            this.edgeInput.Text = "0";
            this.edgeInput.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(184, 35);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(95, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Ширина, мм";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(3, 35);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(84, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Длина, мм";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(533, 546);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(110, 36);
            this.materialFlatButton1.TabIndex = 12;
            this.materialFlatButton1.Text = "Рассчитать";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(3, 280);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(84, 19);
            this.materialLabel6.TabIndex = 17;
            this.materialLabel6.Text = "Длина, мм";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(184, 280);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(95, 19);
            this.materialLabel7.TabIndex = 16;
            this.materialLabel7.Text = "Ширина, мм";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(3, 245);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(127, 19);
            this.materialLabel8.TabIndex = 14;
            this.materialLabel8.Text = "Размеры детали";
            // 
            // detailWidthInput
            // 
            this.detailWidthInput.Depth = 0;
            this.detailWidthInput.Hint = "";
            this.detailWidthInput.Location = new System.Drawing.Point(184, 318);
            this.detailWidthInput.MaxLength = 32767;
            this.detailWidthInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.detailWidthInput.Name = "detailWidthInput";
            this.detailWidthInput.PasswordChar = '\0';
            this.detailWidthInput.SelectedText = "";
            this.detailWidthInput.SelectionLength = 0;
            this.detailWidthInput.SelectionStart = 0;
            this.detailWidthInput.Size = new System.Drawing.Size(94, 23);
            this.detailWidthInput.TabIndex = 15;
            this.detailWidthInput.TabStop = false;
            this.detailWidthInput.Text = "0";
            this.detailWidthInput.UseSystemPasswordChar = false;
            // 
            // detailLengthInput
            // 
            this.detailLengthInput.Depth = 0;
            this.detailLengthInput.Hint = "";
            this.detailLengthInput.Location = new System.Drawing.Point(3, 318);
            this.detailLengthInput.MaxLength = 32767;
            this.detailLengthInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.detailLengthInput.Name = "detailLengthInput";
            this.detailLengthInput.PasswordChar = '\0';
            this.detailLengthInput.SelectedText = "";
            this.detailLengthInput.SelectionLength = 0;
            this.detailLengthInput.SelectionStart = 0;
            this.detailLengthInput.Size = new System.Drawing.Size(94, 23);
            this.detailLengthInput.TabIndex = 13;
            this.detailLengthInput.TabStop = false;
            this.detailLengthInput.Text = "0";
            this.detailLengthInput.UseSystemPasswordChar = false;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(4, 461);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(94, 32);
            this.materialFlatButton2.TabIndex = 18;
            this.materialFlatButton2.Text = "Добавить";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.materialLabel9, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialFlatButton2, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.detailWidthInput, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel7, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.detailLengthInput, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.baseDetailLengthInput, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.baseDetailWidthInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.edgeInput, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.detailCountInput, 0, 12);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.14301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.14301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.14301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.14301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.14301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.14301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.14301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.14301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.14301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.14301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.14301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.14301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.140868F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.14301F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 499);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(3, 385);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(157, 19);
            this.materialLabel9.TabIndex = 20;
            this.materialLabel9.Text = "Количество деталей";
            // 
            // detailCountInput
            // 
            this.detailCountInput.Depth = 0;
            this.detailCountInput.Hint = "";
            this.detailCountInput.Location = new System.Drawing.Point(3, 423);
            this.detailCountInput.MaxLength = 32767;
            this.detailCountInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.detailCountInput.Name = "detailCountInput";
            this.detailCountInput.PasswordChar = '\0';
            this.detailCountInput.SelectedText = "";
            this.detailCountInput.SelectionLength = 0;
            this.detailCountInput.SelectionStart = 0;
            this.detailCountInput.Size = new System.Drawing.Size(94, 23);
            this.detailCountInput.TabIndex = 21;
            this.detailCountInput.TabStop = false;
            this.detailCountInput.Text = "1";
            this.detailCountInput.UseSystemPasswordChar = false;
            // 
            // detailListView
            // 
            this.detailListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailListView.Depth = 0;
            this.detailListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.detailListView.FullRowSelect = true;
            this.detailListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.detailListView.HideSelection = false;
            this.detailListView.Location = new System.Drawing.Point(3, 22);
            this.detailListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.detailListView.MouseState = MaterialSkin.MouseState.OUT;
            this.detailListView.Name = "detailListView";
            this.detailListView.OwnerDraw = true;
            this.detailListView.Size = new System.Drawing.Size(235, 421);
            this.detailListView.TabIndex = 1;
            this.detailListView.UseCompatibleStateImageBehavior = false;
            this.detailListView.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "RedLine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField baseDetailLengthInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField baseDetailWidthInput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField edgeInput;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField detailWidthInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField detailLengthInput;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField detailCountInput;
        private MaterialSkin.Controls.MaterialListView detailListView;
    }
}

