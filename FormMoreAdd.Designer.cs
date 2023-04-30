namespace ProjectCarsTheLast
{
    partial class FormMoreAdd
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
            this.btnOk = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCarName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labNameCar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOk.Location = new System.Drawing.Point(413, 315);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(267, 68);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPrice.Location = new System.Drawing.Point(383, 172);
            this.tbPrice.Multiline = true;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(260, 48);
            this.tbPrice.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(41, 173);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(260, 48);
            this.tbName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(465, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ціна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Назва";
            // 
            // tbCarName
            // 
            this.tbCarName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCarName.Location = new System.Drawing.Point(753, 172);
            this.tbCarName.Multiline = true;
            this.tbCarName.Name = "tbCarName";
            this.tbCarName.Size = new System.Drawing.Size(260, 48);
            this.tbCarName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(817, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 45);
            this.label3.TabIndex = 11;
            this.label3.Text = "Машина";
            // 
            // labNameCar
            // 
            this.labNameCar.AutoSize = true;
            this.labNameCar.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labNameCar.Location = new System.Drawing.Point(452, -4);
            this.labNameCar.Name = "labNameCar";
            this.labNameCar.Size = new System.Drawing.Size(88, 106);
            this.labNameCar.TabIndex = 12;
            this.labNameCar.Text = "0";
            // 
            // FormMoreAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 450);
            this.Controls.Add(this.labNameCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCarName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMoreAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMoreAdd";
            this.Load += new System.EventHandler(this.FormMoreAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOk;
        private TextBox tbPrice;
        private TextBox tbName;
        private Label label2;
        private Label label1;
        private TextBox tbCarName;
        private Label label3;
        private Label labNameCar;
    }
}