namespace aula09Estacionamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            BTNretirar = new Button();
            BTNestacionar = new Button();
            txtplaca = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            lblcarrosestacionados = new Label();
            label2 = new Label();
            listView1 = new ListView();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(BTNretirar);
            panel1.Controls.Add(BTNestacionar);
            panel1.Controls.Add(txtplaca);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(22, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 230);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(43, 169);
            button3.Name = "button3";
            button3.Size = new Size(208, 35);
            button3.TabIndex = 4;
            button3.Text = "Fechar estacionamento";
            button3.UseVisualStyleBackColor = true;
            // 
            // BTNretirar
            // 
            BTNretirar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BTNretirar.Location = new Point(158, 121);
            BTNretirar.Name = "BTNretirar";
            BTNretirar.Size = new Size(93, 35);
            BTNretirar.TabIndex = 3;
            BTNretirar.Text = "Retirar";
            BTNretirar.UseVisualStyleBackColor = true;
            BTNretirar.Click += BTNretirar_Click;
            // 
            // BTNestacionar
            // 
            BTNestacionar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BTNestacionar.Location = new Point(43, 121);
            BTNestacionar.Name = "BTNestacionar";
            BTNestacionar.Size = new Size(93, 35);
            BTNestacionar.TabIndex = 2;
            BTNestacionar.Text = "Estacionar";
            BTNestacionar.UseVisualStyleBackColor = true;
            BTNestacionar.Click += BTNestacionar_Click;
            // 
            // txtplaca
            // 
            txtplaca.Location = new Point(43, 54);
            txtplaca.Name = "txtplaca";
            txtplaca.Size = new Size(221, 23);
            txtplaca.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 26);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 0;
            label4.Text = "Digite a placa :";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblcarrosestacionados);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(listView1);
            panel2.Location = new Point(394, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(345, 230);
            panel2.TabIndex = 1;
            // 
            // lblcarrosestacionados
            // 
            lblcarrosestacionados.AutoSize = true;
            lblcarrosestacionados.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblcarrosestacionados.Location = new Point(146, 41);
            lblcarrosestacionados.Name = "lblcarrosestacionados";
            lblcarrosestacionados.Size = new Size(18, 20);
            lblcarrosestacionados.TabIndex = 2;
            lblcarrosestacionados.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 41);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Veiculos :";
            label2.Click += label2_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(48, 71);
            listView1.Name = "listView1";
            listView1.Size = new Size(251, 145);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 52);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Operações";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 52);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 3;
            label3.Text = "Listagem de veiculos";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label lblcarrosestacionados;
        private Label label2;
        private ListView listView1;
        private Label label4;
        private Label label3;
        private Button button3;
        private Button BTNretirar;
        private Button BTNestacionar;
        private TextBox txtplaca;
    }
}