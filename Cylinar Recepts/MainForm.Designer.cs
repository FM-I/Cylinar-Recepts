
namespace Cylinar_Recepts
{
    partial class MainForm
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openModerationBtn = new System.Windows.Forms.Button();
            this.refreshUserBtn = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userReceptsListBox = new System.Windows.Forms.ListBox();
            this.receptDeleteBtn = new System.Windows.Forms.Button();
            this.receptChangeBtn = new System.Windows.Forms.Button();
            this.receptAddBtn = new System.Windows.Forms.Button();
            this.ReceptsPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.receptTypesBox = new System.Windows.Forms.ComboBox();
            this.receptOpenBtn = new System.Windows.Forms.Button();
            this.receptsListBox = new System.Windows.Forms.ListBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.MainTabContainer = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.ReceptsPage.SuspendLayout();
            this.MainTabContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.openModerationBtn);
            this.tabPage2.Controls.Add(this.refreshUserBtn);
            this.tabPage2.Controls.Add(this.userNameLabel);
            this.tabPage2.Controls.Add(this.userReceptsListBox);
            this.tabPage2.Controls.Add(this.receptDeleteBtn);
            this.tabPage2.Controls.Add(this.receptChangeBtn);
            this.tabPage2.Controls.Add(this.receptAddBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(553, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Користувач";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openModerationBtn
            // 
            this.openModerationBtn.Location = new System.Drawing.Point(472, 6);
            this.openModerationBtn.Name = "openModerationBtn";
            this.openModerationBtn.Size = new System.Drawing.Size(78, 22);
            this.openModerationBtn.TabIndex = 6;
            this.openModerationBtn.Text = "Відкрити";
            this.openModerationBtn.UseVisualStyleBackColor = true;
            this.openModerationBtn.Visible = false;
            this.openModerationBtn.Click += new System.EventHandler(this.receptOpenBtn_Click);
            // 
            // refreshUserBtn
            // 
            this.refreshUserBtn.Location = new System.Drawing.Point(472, 38);
            this.refreshUserBtn.Name = "refreshUserBtn";
            this.refreshUserBtn.Size = new System.Drawing.Size(78, 22);
            this.refreshUserBtn.TabIndex = 5;
            this.refreshUserBtn.Text = "Обновити";
            this.refreshUserBtn.UseVisualStyleBackColor = true;
            this.refreshUserBtn.Click += new System.EventHandler(this.refreshUserBtn_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(6, 22);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(49, 24);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "User";
            // 
            // userReceptsListBox
            // 
            this.userReceptsListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userReceptsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userReceptsListBox.FormattingEnabled = true;
            this.userReceptsListBox.ItemHeight = 20;
            this.userReceptsListBox.Location = new System.Drawing.Point(3, 77);
            this.userReceptsListBox.Name = "userReceptsListBox";
            this.userReceptsListBox.Size = new System.Drawing.Size(547, 344);
            this.userReceptsListBox.TabIndex = 3;
            // 
            // receptDeleteBtn
            // 
            this.receptDeleteBtn.Location = new System.Drawing.Point(472, 6);
            this.receptDeleteBtn.Name = "receptDeleteBtn";
            this.receptDeleteBtn.Size = new System.Drawing.Size(78, 22);
            this.receptDeleteBtn.TabIndex = 2;
            this.receptDeleteBtn.Text = "Видалити";
            this.receptDeleteBtn.UseVisualStyleBackColor = true;
            this.receptDeleteBtn.Click += new System.EventHandler(this.receptDeleteBtn_Click);
            // 
            // receptChangeBtn
            // 
            this.receptChangeBtn.Location = new System.Drawing.Point(388, 6);
            this.receptChangeBtn.Name = "receptChangeBtn";
            this.receptChangeBtn.Size = new System.Drawing.Size(78, 22);
            this.receptChangeBtn.TabIndex = 1;
            this.receptChangeBtn.Text = "Редагувати";
            this.receptChangeBtn.UseVisualStyleBackColor = true;
            this.receptChangeBtn.Click += new System.EventHandler(this.receptChangeBtn_Click);
            // 
            // receptAddBtn
            // 
            this.receptAddBtn.Location = new System.Drawing.Point(304, 6);
            this.receptAddBtn.Name = "receptAddBtn";
            this.receptAddBtn.Size = new System.Drawing.Size(78, 22);
            this.receptAddBtn.TabIndex = 0;
            this.receptAddBtn.Text = "Додати";
            this.receptAddBtn.UseVisualStyleBackColor = true;
            this.receptAddBtn.Click += new System.EventHandler(this.receptAddBtn_Click);
            // 
            // ReceptsPage
            // 
            this.ReceptsPage.Controls.Add(this.label1);
            this.ReceptsPage.Controls.Add(this.refreshBtn);
            this.ReceptsPage.Controls.Add(this.receptTypesBox);
            this.ReceptsPage.Controls.Add(this.receptOpenBtn);
            this.ReceptsPage.Controls.Add(this.receptsListBox);
            this.ReceptsPage.Controls.Add(this.findBtn);
            this.ReceptsPage.Controls.Add(this.findTextBox);
            this.ReceptsPage.Location = new System.Drawing.Point(4, 22);
            this.ReceptsPage.Name = "ReceptsPage";
            this.ReceptsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReceptsPage.Size = new System.Drawing.Size(553, 424);
            this.ReceptsPage.TabIndex = 0;
            this.ReceptsPage.Text = "Головна";
            this.ReceptsPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Тип рецепту";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(474, 51);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 22);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "Обновити";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // receptTypesBox
            // 
            this.receptTypesBox.FormattingEnabled = true;
            this.receptTypesBox.Location = new System.Drawing.Point(100, 6);
            this.receptTypesBox.Name = "receptTypesBox";
            this.receptTypesBox.Size = new System.Drawing.Size(151, 21);
            this.receptTypesBox.TabIndex = 5;
            this.receptTypesBox.SelectedIndexChanged += new System.EventHandler(this.receptTypesBox_SelectedIndexChanged);
            // 
            // receptOpenBtn
            // 
            this.receptOpenBtn.Location = new System.Drawing.Point(393, 51);
            this.receptOpenBtn.Name = "receptOpenBtn";
            this.receptOpenBtn.Size = new System.Drawing.Size(75, 22);
            this.receptOpenBtn.TabIndex = 4;
            this.receptOpenBtn.Text = "Відкрити";
            this.receptOpenBtn.UseVisualStyleBackColor = true;
            this.receptOpenBtn.Click += new System.EventHandler(this.receptOpenBtn_Click);
            // 
            // receptsListBox
            // 
            this.receptsListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.receptsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receptsListBox.FormattingEnabled = true;
            this.receptsListBox.ItemHeight = 20;
            this.receptsListBox.Location = new System.Drawing.Point(3, 77);
            this.receptsListBox.Name = "receptsListBox";
            this.receptsListBox.Size = new System.Drawing.Size(547, 344);
            this.receptsListBox.TabIndex = 2;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(474, 6);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 21);
            this.findBtn.TabIndex = 1;
            this.findBtn.Text = "Пошук";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(283, 7);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(185, 20);
            this.findTextBox.TabIndex = 0;
            this.findTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.findTextBox_PreviewKeyDown);
            // 
            // MainTabContainer
            // 
            this.MainTabContainer.Controls.Add(this.ReceptsPage);
            this.MainTabContainer.Controls.Add(this.tabPage2);
            this.MainTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabContainer.Location = new System.Drawing.Point(0, 0);
            this.MainTabContainer.Name = "MainTabContainer";
            this.MainTabContainer.SelectedIndex = 0;
            this.MainTabContainer.Size = new System.Drawing.Size(561, 450);
            this.MainTabContainer.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.MainTabContainer);
            this.MinimumSize = new System.Drawing.Size(577, 489);
            this.Name = "MainForm";
            this.Text = "Кулінарні рецепти";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ReceptsPage.ResumeLayout(false);
            this.ReceptsPage.PerformLayout();
            this.MainTabContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage ReceptsPage;
        private System.Windows.Forms.Button receptOpenBtn;
        private System.Windows.Forms.ListBox receptsListBox;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.TabControl MainTabContainer;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.ListBox userReceptsListBox;
        private System.Windows.Forms.Button receptDeleteBtn;
        private System.Windows.Forms.Button receptChangeBtn;
        private System.Windows.Forms.Button receptAddBtn;
        private System.Windows.Forms.ComboBox receptTypesBox;
        private System.Windows.Forms.Button refreshUserBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button openModerationBtn;
        private System.Windows.Forms.Label label1;
    }
}

