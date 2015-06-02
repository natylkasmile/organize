namespace kurs
{
    partial class BD_Group
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
            this.GV_BD_Group = new System.Windows.Forms.DataGridView();
            this.B_Add_Gr = new System.Windows.Forms.Button();
            this.B_Edit_GR = new System.Windows.Forms.Button();
            this.B_Del_Group = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BD_Group)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_BD_Group
            // 
            this.GV_BD_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BD_Group.Location = new System.Drawing.Point(7, 4);
            this.GV_BD_Group.Name = "GV_BD_Group";
            this.GV_BD_Group.Size = new System.Drawing.Size(240, 150);
            this.GV_BD_Group.TabIndex = 0;
            this.GV_BD_Group.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_BD_Group_CellClick_1);
            // 
            // B_Add_Gr
            // 
            this.B_Add_Gr.Location = new System.Drawing.Point(7, 186);
            this.B_Add_Gr.Name = "B_Add_Gr";
            this.B_Add_Gr.Size = new System.Drawing.Size(164, 23);
            this.B_Add_Gr.TabIndex = 1;
            this.B_Add_Gr.Text = "Добавить новую группу";
            this.B_Add_Gr.UseVisualStyleBackColor = true;
            this.B_Add_Gr.Click += new System.EventHandler(this.B_Add_Gr_Click);
            // 
            // B_Edit_GR
            // 
            this.B_Edit_GR.Location = new System.Drawing.Point(7, 215);
            this.B_Edit_GR.Name = "B_Edit_GR";
            this.B_Edit_GR.Size = new System.Drawing.Size(164, 23);
            this.B_Edit_GR.TabIndex = 2;
            this.B_Edit_GR.Text = "Редактровать группу";
            this.B_Edit_GR.UseVisualStyleBackColor = true;
            this.B_Edit_GR.Click += new System.EventHandler(this.button2_Click);
            // 
            // B_Del_Group
            // 
            this.B_Del_Group.Location = new System.Drawing.Point(7, 244);
            this.B_Del_Group.Name = "B_Del_Group";
            this.B_Del_Group.Size = new System.Drawing.Size(164, 23);
            this.B_Del_Group.TabIndex = 3;
            this.B_Del_Group.Text = "Удалить выбранную группу";
            this.B_Del_Group.UseVisualStyleBackColor = true;
            this.B_Del_Group.Click += new System.EventHandler(this.B_Del_Group_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 4;
            // 
            // BD_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 295);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.B_Del_Group);
            this.Controls.Add(this.B_Edit_GR);
            this.Controls.Add(this.B_Add_Gr);
            this.Controls.Add(this.GV_BD_Group);
            this.Name = "BD_Group";
            this.Text = "BD_Group";
            this.Load += new System.EventHandler(this.BD_Group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_BD_Group)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_BD_Group;
        private System.Windows.Forms.Button B_Add_Gr;
        private System.Windows.Forms.Button B_Edit_GR;
        private System.Windows.Forms.Button B_Del_Group;
        private System.Windows.Forms.TextBox textBox1;
    }
}