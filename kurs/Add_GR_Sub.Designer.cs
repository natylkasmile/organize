namespace kurs
{
    partial class Add_GR_Sub
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
            this.B_ADD_G_SUB = new System.Windows.Forms.Button();
            this.TB_ADDG_S_GR = new System.Windows.Forms.TextBox();
            this.TB_AddG_S_SU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GV_Add_G_S = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Add_G_S)).BeginInit();
            this.SuspendLayout();
            // 
            // B_ADD_G_SUB
            // 
            this.B_ADD_G_SUB.Location = new System.Drawing.Point(197, 78);
            this.B_ADD_G_SUB.Name = "B_ADD_G_SUB";
            this.B_ADD_G_SUB.Size = new System.Drawing.Size(75, 23);
            this.B_ADD_G_SUB.TabIndex = 0;
            this.B_ADD_G_SUB.Text = "Добавить";
            this.B_ADD_G_SUB.UseVisualStyleBackColor = true;
            this.B_ADD_G_SUB.Click += new System.EventHandler(this.B_ADD_G_SUB_Click);
            // 
            // TB_ADDG_S_GR
            // 
            this.TB_ADDG_S_GR.Location = new System.Drawing.Point(172, 15);
            this.TB_ADDG_S_GR.Name = "TB_ADDG_S_GR";
            this.TB_ADDG_S_GR.Size = new System.Drawing.Size(100, 20);
            this.TB_ADDG_S_GR.TabIndex = 1;
            this.TB_ADDG_S_GR.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // TB_AddG_S_SU
            // 
            this.TB_AddG_S_SU.Location = new System.Drawing.Point(172, 42);
            this.TB_AddG_S_SU.Name = "TB_AddG_S_SU";
            this.TB_AddG_S_SU.Size = new System.Drawing.Size(100, 20);
            this.TB_AddG_S_SU.TabIndex = 2;
            this.TB_AddG_S_SU.Click += new System.EventHandler(this.TB_AddG_S_SU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Идентификатор группы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Идентификатор предмета";
            // 
            // GV_Add_G_S
            // 
            this.GV_Add_G_S.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_Add_G_S.Location = new System.Drawing.Point(8, 107);
            this.GV_Add_G_S.Name = "GV_Add_G_S";
            this.GV_Add_G_S.Size = new System.Drawing.Size(264, 132);
            this.GV_Add_G_S.TabIndex = 5;
            // 
            // Add_GR_Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.GV_Add_G_S);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_AddG_S_SU);
            this.Controls.Add(this.TB_ADDG_S_GR);
            this.Controls.Add(this.B_ADD_G_SUB);
            this.Name = "Add_GR_Sub";
            this.Text = "Add_GR_Sub";
            ((System.ComponentModel.ISupportInitialize)(this.GV_Add_G_S)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_ADD_G_SUB;
        private System.Windows.Forms.TextBox TB_ADDG_S_GR;
        private System.Windows.Forms.TextBox TB_AddG_S_SU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GV_Add_G_S;
    }
}