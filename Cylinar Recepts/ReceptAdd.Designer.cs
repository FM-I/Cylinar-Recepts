
namespace Cylinar_Recepts
{
    partial class ReceptAdd
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
            this.receptNameBox = new System.Windows.Forms.TextBox();
            this.receptTypesBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.receptDescBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ingredientsData = new System.Windows.Forms.DataGridView();
            this.ingrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingrCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingrUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.removeIngredient = new System.Windows.Forms.Button();
            this.addIngredient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsData)).BeginInit();
            this.SuspendLayout();
            // 
            // receptNameBox
            // 
            this.receptNameBox.Location = new System.Drawing.Point(154, 21);
            this.receptNameBox.MaxLength = 100;
            this.receptNameBox.Name = "receptNameBox";
            this.receptNameBox.Size = new System.Drawing.Size(193, 20);
            this.receptNameBox.TabIndex = 0;
            // 
            // receptTypesBox
            // 
            this.receptTypesBox.FormattingEnabled = true;
            this.receptTypesBox.Location = new System.Drawing.Point(154, 47);
            this.receptTypesBox.Name = "receptTypesBox";
            this.receptTypesBox.Size = new System.Drawing.Size(193, 21);
            this.receptTypesBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Назва рецепту";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип рецепту";
            // 
            // receptDescBox
            // 
            this.receptDescBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receptDescBox.Location = new System.Drawing.Point(154, 92);
            this.receptDescBox.Name = "receptDescBox";
            this.receptDescBox.Size = new System.Drawing.Size(634, 205);
            this.receptDescBox.TabIndex = 4;
            this.receptDescBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Рецепт";
            // 
            // ingredientsData
            // 
            this.ingredientsData.AllowUserToAddRows = false;
            this.ingredientsData.AllowUserToDeleteRows = false;
            this.ingredientsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingrName,
            this.ingrCount,
            this.ingrUnit});
            this.ingredientsData.Location = new System.Drawing.Point(154, 303);
            this.ingredientsData.Name = "ingredientsData";
            this.ingredientsData.Size = new System.Drawing.Size(344, 197);
            this.ingredientsData.TabIndex = 6;
            // 
            // ingrName
            // 
            this.ingrName.HeaderText = "Назва ігредієнту";
            this.ingrName.MaxInputLength = 30;
            this.ingrName.Name = "ingrName";
            // 
            // ingrCount
            // 
            this.ingrCount.HeaderText = "Кількість";
            this.ingrCount.MaxInputLength = 5;
            this.ingrCount.Name = "ingrCount";
            // 
            // ingrUnit
            // 
            this.ingrUnit.HeaderText = "Мірна одиниця";
            this.ingrUnit.Name = "ingrUnit";
            this.ingrUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ingrUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Інгредієнти";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(624, 21);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(79, 36);
            this.confirmBtn.TabIndex = 8;
            this.confirmBtn.Text = "Підтвердити";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(709, 21);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(79, 36);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // removeIngredient
            // 
            this.removeIngredient.Location = new System.Drawing.Point(504, 345);
            this.removeIngredient.Name = "removeIngredient";
            this.removeIngredient.Size = new System.Drawing.Size(79, 36);
            this.removeIngredient.TabIndex = 10;
            this.removeIngredient.Text = "Видалити";
            this.removeIngredient.UseVisualStyleBackColor = true;
            this.removeIngredient.Click += new System.EventHandler(this.removeIngredient_Click);
            // 
            // addIngredient
            // 
            this.addIngredient.Location = new System.Drawing.Point(504, 303);
            this.addIngredient.Name = "addIngredient";
            this.addIngredient.Size = new System.Drawing.Size(79, 36);
            this.addIngredient.TabIndex = 11;
            this.addIngredient.Text = "Додати";
            this.addIngredient.UseVisualStyleBackColor = true;
            this.addIngredient.Click += new System.EventHandler(this.addIngredient_Click);
            // 
            // ReceptAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.addIngredient);
            this.Controls.Add(this.removeIngredient);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ingredientsData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.receptDescBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receptTypesBox);
            this.Controls.Add(this.receptNameBox);
            this.MinimumSize = new System.Drawing.Size(816, 551);
            this.Name = "ReceptAdd";
            this.Text = "Додати рецепт";
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox receptNameBox;
        private System.Windows.Forms.ComboBox receptTypesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox receptDescBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ingredientsData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button removeIngredient;
        private System.Windows.Forms.Button addIngredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingrCount;
        private System.Windows.Forms.DataGridViewComboBoxColumn ingrUnit;
    }
}