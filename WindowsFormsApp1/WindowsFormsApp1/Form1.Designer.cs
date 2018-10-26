namespace WindowsFormsApp1
{
    partial class Form1
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
			this.nyKategori = new System.Windows.Forms.Button();
			this.Rubrik = new System.Windows.Forms.Label();
			this.lvPodLista = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lbKtRubrik = new System.Windows.Forms.Label();
			this.lbKategori = new System.Windows.Forms.ListBox();
			this.tbKategori = new System.Windows.Forms.TextBox();
			this.sparaKategori = new System.Windows.Forms.Button();
			this.tabortKategori = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbUrl = new System.Windows.Forms.TextBox();
			this.nyPodcast = new System.Windows.Forms.Button();
			this.sparaPodcast = new System.Windows.Forms.Button();
			this.tabortPodcast = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nyKategori
			// 
			this.nyKategori.Location = new System.Drawing.Point(498, 263);
			this.nyKategori.Name = "nyKategori";
			this.nyKategori.Size = new System.Drawing.Size(75, 23);
			this.nyKategori.TabIndex = 0;
			this.nyKategori.Text = "Ny";
			this.nyKategori.UseVisualStyleBackColor = true;
			// 
			// Rubrik
			// 
			this.Rubrik.AutoSize = true;
			this.Rubrik.Font = new System.Drawing.Font("Comic Sans MS", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Rubrik.Location = new System.Drawing.Point(2, -2);
			this.Rubrik.Name = "Rubrik";
			this.Rubrik.Size = new System.Drawing.Size(188, 56);
			this.Rubrik.TabIndex = 1;
			this.Rubrik.Text = "Podcast ";
			this.Rubrik.Click += new System.EventHandler(this.label1_Click);
			// 
			// lvPodLista
			// 
			this.lvPodLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvPodLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvPodLista.Location = new System.Drawing.Point(12, 57);
			this.lvPodLista.Name = "lvPodLista";
			this.lvPodLista.Size = new System.Drawing.Size(406, 170);
			this.lvPodLista.TabIndex = 2;
			this.lvPodLista.UseCompatibleStateImageBehavior = false;
			this.lvPodLista.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Avsnitt";
			this.columnHeader1.Width = 74;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Namn";
			this.columnHeader2.Width = 112;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Frekvens";
			this.columnHeader3.Width = 90;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Kategori";
			this.columnHeader4.Width = 106;
			// 
			// lbKtRubrik
			// 
			this.lbKtRubrik.AutoSize = true;
			this.lbKtRubrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbKtRubrik.Location = new System.Drawing.Point(495, 31);
			this.lbKtRubrik.Name = "lbKtRubrik";
			this.lbKtRubrik.Size = new System.Drawing.Size(86, 18);
			this.lbKtRubrik.TabIndex = 4;
			this.lbKtRubrik.Text = "Kategorier";
			// 
			// lbKategori
			// 
			this.lbKategori.FormattingEnabled = true;
			this.lbKategori.Items.AddRange(new object[] {
            ""});
			this.lbKategori.Location = new System.Drawing.Point(498, 57);
			this.lbKategori.Name = "lbKategori";
			this.lbKategori.Size = new System.Drawing.Size(265, 173);
			this.lbKategori.TabIndex = 5;
			this.lbKategori.SelectedIndexChanged += new System.EventHandler(this.lbKategori_SelectedIndexChanged);
			// 
			// tbKategori
			// 
			this.tbKategori.Location = new System.Drawing.Point(498, 237);
			this.tbKategori.Name = "tbKategori";
			this.tbKategori.Size = new System.Drawing.Size(265, 20);
			this.tbKategori.TabIndex = 6;
			// 
			// sparaKategori
			// 
			this.sparaKategori.Location = new System.Drawing.Point(590, 263);
			this.sparaKategori.Name = "sparaKategori";
			this.sparaKategori.Size = new System.Drawing.Size(75, 23);
			this.sparaKategori.TabIndex = 7;
			this.sparaKategori.Text = "Spara";
			this.sparaKategori.UseVisualStyleBackColor = true;
			// 
			// tabortKategori
			// 
			this.tabortKategori.Location = new System.Drawing.Point(688, 263);
			this.tabortKategori.Name = "tabortKategori";
			this.tabortKategori.Size = new System.Drawing.Size(75, 23);
			this.tabortKategori.TabIndex = 8;
			this.tabortKategori.Text = "Ta bort";
			this.tabortKategori.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "URL:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(158, 240);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Uppdateringsfrekvens:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(348, 240);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Kategori:";
			// 
			// tbUrl
			// 
			this.tbUrl.Location = new System.Drawing.Point(12, 275);
			this.tbUrl.Name = "tbUrl";
			this.tbUrl.Size = new System.Drawing.Size(134, 20);
			this.tbUrl.TabIndex = 12;
			this.tbUrl.Text = "https://...";
			// 
			// nyPodcast
			// 
			this.nyPodcast.Location = new System.Drawing.Point(174, 336);
			this.nyPodcast.Name = "nyPodcast";
			this.nyPodcast.Size = new System.Drawing.Size(75, 23);
			this.nyPodcast.TabIndex = 13;
			this.nyPodcast.Text = "Ny";
			this.nyPodcast.UseVisualStyleBackColor = true;
			// 
			// sparaPodcast
			// 
			this.sparaPodcast.Location = new System.Drawing.Point(255, 336);
			this.sparaPodcast.Name = "sparaPodcast";
			this.sparaPodcast.Size = new System.Drawing.Size(75, 23);
			this.sparaPodcast.TabIndex = 14;
			this.sparaPodcast.Text = "Spara";
			this.sparaPodcast.UseVisualStyleBackColor = true;
			// 
			// tabortPodcast
			// 
			this.tabortPodcast.Location = new System.Drawing.Point(336, 336);
			this.tabortPodcast.Name = "tabortPodcast";
			this.tabortPodcast.Size = new System.Drawing.Size(75, 23);
			this.tabortPodcast.TabIndex = 15;
			this.tabortPodcast.Text = "Ta bort";
			this.tabortPodcast.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabortPodcast);
			this.Controls.Add(this.sparaPodcast);
			this.Controls.Add(this.nyPodcast);
			this.Controls.Add(this.tbUrl);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tabortKategori);
			this.Controls.Add(this.sparaKategori);
			this.Controls.Add(this.tbKategori);
			this.Controls.Add(this.lbKategori);
			this.Controls.Add(this.lbKtRubrik);
			this.Controls.Add(this.lvPodLista);
			this.Controls.Add(this.Rubrik);
			this.Controls.Add(this.nyKategori);
			this.Name = "Form1";
			this.Text = "https://...";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button nyKategori;
		private System.Windows.Forms.Label Rubrik;
		private System.Windows.Forms.ListView lvPodLista;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Label lbKtRubrik;
		private System.Windows.Forms.ListBox lbKategori;
		private System.Windows.Forms.TextBox tbKategori;
		private System.Windows.Forms.Button sparaKategori;
		private System.Windows.Forms.Button tabortKategori;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbUrl;
		private System.Windows.Forms.Button nyPodcast;
		private System.Windows.Forms.Button sparaPodcast;
		private System.Windows.Forms.Button tabortPodcast;
	}
}

