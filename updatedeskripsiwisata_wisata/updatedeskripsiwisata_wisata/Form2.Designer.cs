namespace updatedeskripsiwisata_wisata
{
    partial class Form2
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
            Simpanbutton = new Button();
            Updatebutton = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            id = new Label();
            id_wisata = new ComboBox();
            SuspendLayout();
            // 
            // Simpanbutton
            // 
            Simpanbutton.Location = new Point(647, 370);
            Simpanbutton.Name = "Simpanbutton";
            Simpanbutton.Size = new Size(112, 34);
            Simpanbutton.TabIndex = 55;
            Simpanbutton.Text = "Save";
            Simpanbutton.UseVisualStyleBackColor = true;
            Simpanbutton.Click += Simpanbutton_Click;
            // 
            // Updatebutton
            // 
            Updatebutton.Location = new Point(502, 370);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(112, 34);
            Updatebutton.TabIndex = 54;
            Updatebutton.Text = "Cancel";
            Updatebutton.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(181, 101);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(568, 252);
            textBox4.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 101);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 52;
            label4.Text = "Deskripsi";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(41, 47);
            id.Name = "id";
            id.Size = new Size(71, 25);
            id.TabIndex = 47;
            id.Text = "Id Desc";
            // 
            // id_wisata
            // 
            id_wisata.FormattingEnabled = true;
            id_wisata.Location = new Point(181, 47);
            id_wisata.Name = "id_wisata";
            id_wisata.Size = new Size(74, 33);
            id_wisata.TabIndex = 46;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Simpanbutton);
            Controls.Add(Updatebutton);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(id);
            Controls.Add(id_wisata);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Simpanbutton;
        private Button Updatebutton;
        private TextBox textBox4;
        private Label label4;
        private Label id;
        private ComboBox id_wisata;
    }
}