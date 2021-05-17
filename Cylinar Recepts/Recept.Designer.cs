
namespace Cylinar_Recepts
{
    partial class Recept
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
            this.receptNameLabel = new System.Windows.Forms.Label();
            this.ingredientsData = new System.Windows.Forms.DataGridView();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.receptTypeLabel = new System.Windows.Forms.Label();
            this.receptAurhorLabel = new System.Windows.Forms.Label();
            this.receptPrintBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.rejectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsData)).BeginInit();
            this.SuspendLayout();
            // 
            // receptNameLabel
            // 
            this.receptNameLabel.AutoSize = true;
            this.receptNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receptNameLabel.Location = new System.Drawing.Point(12, 9);
            this.receptNameLabel.Name = "receptNameLabel";
            this.receptNameLabel.Size = new System.Drawing.Size(126, 24);
            this.receptNameLabel.TabIndex = 0;
            this.receptNameLabel.Text = "Recept Name";
            // 
            // ingredientsData
            // 
            this.ingredientsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsData.Location = new System.Drawing.Point(12, 104);
            this.ingredientsData.Name = "ingredientsData";
            this.ingredientsData.Size = new System.Drawing.Size(323, 334);
            this.ingredientsData.TabIndex = 1;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionBox.Location = new System.Drawing.Point(341, 104);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(415, 334);
            this.descriptionBox.TabIndex = 2;
            this.descriptionBox.Text = "";
            // 
            // receptTypeLabel
            // 
            this.receptTypeLabel.AutoSize = true;
            this.receptTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receptTypeLabel.Location = new System.Drawing.Point(13, 43);
            this.receptTypeLabel.Name = "receptTypeLabel";
            this.receptTypeLabel.Size = new System.Drawing.Size(86, 18);
            this.receptTypeLabel.TabIndex = 3;
            this.receptTypeLabel.Text = "Recept type";
            // 
            // receptAurhorLabel
            // 
            this.receptAurhorLabel.AutoSize = true;
            this.receptAurhorLabel.Location = new System.Drawing.Point(13, 73);
            this.receptAurhorLabel.Name = "receptAurhorLabel";
            this.receptAurhorLabel.Size = new System.Drawing.Size(75, 13);
            this.receptAurhorLabel.TabIndex = 4;
            this.receptAurhorLabel.Text = "Recept author";
            // 
            // receptPrintBtn
            // 
            this.receptPrintBtn.Location = new System.Drawing.Point(676, 12);
            this.receptPrintBtn.Name = "receptPrintBtn";
            this.receptPrintBtn.Size = new System.Drawing.Size(80, 23);
            this.receptPrintBtn.TabIndex = 5;
            this.receptPrintBtn.Text = "Друк";
            this.receptPrintBtn.UseVisualStyleBackColor = true;
            this.receptPrintBtn.Click += new System.EventHandler(this.receptPrintBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(590, 42);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(80, 22);
            this.confirmBtn.TabIndex = 6;
            this.confirmBtn.Text = "Підтвердити";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Visible = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // rejectBtn
            // 
            this.rejectBtn.Location = new System.Drawing.Point(676, 41);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.Size = new System.Drawing.Size(80, 23);
            this.rejectBtn.TabIndex = 7;
            this.rejectBtn.Text = "Видалити";
            this.rejectBtn.UseVisualStyleBackColor = true;
            this.rejectBtn.Visible = false;
            this.rejectBtn.Click += new System.EventHandler(this.rejectBtn_Click);
            // 
            // Recept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 446);
            this.Controls.Add(this.rejectBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.receptPrintBtn);
            this.Controls.Add(this.receptAurhorLabel);
            this.Controls.Add(this.receptTypeLabel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.ingredientsData);
            this.Controls.Add(this.receptNameLabel);
            this.MinimumSize = new System.Drawing.Size(784, 485);
            this.Name = "Recept";
            this.Text = "Рецепт";
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label receptNameLabel;
        private System.Windows.Forms.DataGridView ingredientsData;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Label receptTypeLabel;
        private System.Windows.Forms.Label receptAurhorLabel;
        private System.Windows.Forms.Button receptPrintBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button rejectBtn;
    }
}