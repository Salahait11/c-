namespace remise
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
            panel2 = new Panel();
            label1 = new Label();
            textBoxPrixUnitaire = new TextBox();
            textBoxQuantite = new TextBox();
            label2 = new Label();
            buttonCommander = new Button();
            dataGridViewCommandes = new DataGridView();
            prixunitaire = new DataGridViewTextBoxColumn();
            quantite = new DataGridViewTextBoxColumn();
            tauxRemise = new DataGridViewTextBoxColumn();
            montantBrut = new DataGridViewTextBoxColumn();
            remise = new DataGridViewTextBoxColumn();
            montantnet = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommandes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1250, 35);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 412);
            panel2.Name = "panel2";
            panel2.Size = new Size(1250, 38);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(26, 68);
            label1.Name = "label1";
            label1.Size = new Size(219, 36);
            label1.TabIndex = 2;
            label1.Text = "Le Prix Unitaire:";
            label1.Click += label1_Click;
            // 
            // textBoxPrixUnitaire
            // 
            textBoxPrixUnitaire.Location = new Point(35, 107);
            textBoxPrixUnitaire.Name = "textBoxPrixUnitaire";
            textBoxPrixUnitaire.Size = new Size(210, 31);
            textBoxPrixUnitaire.TabIndex = 3;
            textBoxPrixUnitaire.TextChanged += textBoxPrixUnitaire_TextChanged;
            // 
            // textBoxQuantite
            // 
            textBoxQuantite.Location = new Point(35, 199);
            textBoxQuantite.Name = "textBoxQuantite";
            textBoxQuantite.Size = new Size(210, 31);
            textBoxQuantite.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(26, 160);
            label2.Name = "label2";
            label2.Size = new Size(124, 36);
            label2.TabIndex = 4;
            label2.Text = "Quantite";
            label2.Click += label2_Click;
            // 
            // buttonCommander
            // 
            buttonCommander.BackColor = Color.Black;
            buttonCommander.ForeColor = SystemColors.ButtonHighlight;
            buttonCommander.Location = new Point(35, 252);
            buttonCommander.Name = "buttonCommander";
            buttonCommander.Size = new Size(198, 47);
            buttonCommander.TabIndex = 6;
            buttonCommander.Text = "Commander";
            buttonCommander.UseVisualStyleBackColor = false;
            buttonCommander.Click += button1_Click;
            // 
            // dataGridViewCommandes
            // 
            dataGridViewCommandes.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewCommandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCommandes.Columns.AddRange(new DataGridViewColumn[] { prixunitaire, quantite, tauxRemise, montantBrut, remise, montantnet });
            dataGridViewCommandes.GridColor = SystemColors.Window;
            dataGridViewCommandes.Location = new Point(265, 74);
            dataGridViewCommandes.Name = "dataGridViewCommandes";
            dataGridViewCommandes.RowHeadersWidth = 62;
            dataGridViewCommandes.Size = new Size(965, 225);
            dataGridViewCommandes.TabIndex = 7;
            dataGridViewCommandes.CellContentClick += dataGridViewCommandes_CellContentClick;
            // 
            // prixunitaire
            // 
            prixunitaire.HeaderText = "Prix Unitaire";
            prixunitaire.MinimumWidth = 8;
            prixunitaire.Name = "prixunitaire";
            prixunitaire.Width = 150;
            // 
            // quantite
            // 
            quantite.HeaderText = "Quantite";
            quantite.MinimumWidth = 8;
            quantite.Name = "quantite";
            quantite.Width = 150;
            // 
            // tauxRemise
            // 
            tauxRemise.HeaderText = "Taux Remise";
            tauxRemise.MinimumWidth = 8;
            tauxRemise.Name = "tauxRemise";
            tauxRemise.Width = 150;
            // 
            // montantBrut
            // 
            montantBrut.HeaderText = "Montant Brut";
            montantBrut.MinimumWidth = 8;
            montantBrut.Name = "montantBrut";
            montantBrut.Width = 150;
            // 
            // remise
            // 
            remise.HeaderText = "Remise";
            remise.MinimumWidth = 8;
            remise.Name = "remise";
            remise.Width = 150;
            // 
            // montantnet
            // 
            montantnet.HeaderText = "Montant Net";
            montantnet.MinimumWidth = 8;
            montantnet.Name = "montantnet";
            montantnet.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1250, 450);
            Controls.Add(dataGridViewCommandes);
            Controls.Add(buttonCommander);
            Controls.Add(textBoxQuantite);
            Controls.Add(label2);
            Controls.Add(textBoxPrixUnitaire);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommandes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox textBoxPrixUnitaire;
        private TextBox textBoxQuantite;
        private Label label2;
        private Button buttonCommander;
        private DataGridView dataGridViewCommandes;
        private DataGridViewTextBoxColumn prixunitaire;
        private DataGridViewTextBoxColumn quantite;
        private DataGridViewTextBoxColumn tauxRemise;
        private DataGridViewTextBoxColumn montantBrut;
        private DataGridViewTextBoxColumn remise;
        private DataGridViewTextBoxColumn montantnet;
    }
}
