﻿namespace ATHENA
{
    partial class frmSuppressionDeDonnées
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuppressionDeDonnées));
            this.btnSupprimerLesDonneesSelectionnees = new System.Windows.Forms.Button();
            this.btnToutSelectionner = new System.Windows.Forms.Button();
            this.btnSupprimerTouteLesDonnees = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.gbpElements = new System.Windows.Forms.GroupBox();
            this.clbElements = new System.Windows.Forms.CheckedListBox();
            this.gbpFiltres = new System.Windows.Forms.GroupBox();
            this.rdbNiveaux = new System.Windows.Forms.RadioButton();
            this.rdbClasses = new System.Windows.Forms.RadioButton();
            this.rdbEleve = new System.Windows.Forms.RadioButton();
            this.btnOuvrirEmpBDD = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbpRecherche = new System.Windows.Forms.GroupBox();
            this.lbRecherche = new System.Windows.Forms.ListBox();
            this.gbpElements.SuspendLayout();
            this.gbpFiltres.SuspendLayout();
            this.gbpRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupprimerLesDonneesSelectionnees
            // 
            this.btnSupprimerLesDonneesSelectionnees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSupprimerLesDonneesSelectionnees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimerLesDonneesSelectionnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSupprimerLesDonneesSelectionnees.ForeColor = System.Drawing.Color.Red;
            this.btnSupprimerLesDonneesSelectionnees.Location = new System.Drawing.Point(632, 482);
            this.btnSupprimerLesDonneesSelectionnees.Name = "btnSupprimerLesDonneesSelectionnees";
            this.btnSupprimerLesDonneesSelectionnees.Size = new System.Drawing.Size(374, 40);
            this.btnSupprimerLesDonneesSelectionnees.TabIndex = 12;
            this.btnSupprimerLesDonneesSelectionnees.Text = "🗑 Supprimer les données sélectionnées";
            this.btnSupprimerLesDonneesSelectionnees.UseVisualStyleBackColor = false;
            this.btnSupprimerLesDonneesSelectionnees.Click += new System.EventHandler(this.btnSupprimerLesDonneesSelectionnees_Click);
            // 
            // btnToutSelectionner
            // 
            this.btnToutSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnToutSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToutSelectionner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnToutSelectionner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnToutSelectionner.Location = new System.Drawing.Point(632, 436);
            this.btnToutSelectionner.Name = "btnToutSelectionner";
            this.btnToutSelectionner.Size = new System.Drawing.Size(374, 40);
            this.btnToutSelectionner.TabIndex = 11;
            this.btnToutSelectionner.Text = "Tout sélectionner";
            this.btnToutSelectionner.UseVisualStyleBackColor = false;
            this.btnToutSelectionner.Click += new System.EventHandler(this.btnToutSelectionner_Click);
            // 
            // btnSupprimerTouteLesDonnees
            // 
            this.btnSupprimerTouteLesDonnees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSupprimerTouteLesDonnees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimerTouteLesDonnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSupprimerTouteLesDonnees.ForeColor = System.Drawing.Color.Red;
            this.btnSupprimerTouteLesDonnees.Location = new System.Drawing.Point(632, 528);
            this.btnSupprimerTouteLesDonnees.Name = "btnSupprimerTouteLesDonnees";
            this.btnSupprimerTouteLesDonnees.Size = new System.Drawing.Size(374, 40);
            this.btnSupprimerTouteLesDonnees.TabIndex = 10;
            this.btnSupprimerTouteLesDonnees.Text = "🗑 Supprimer toutes les données";
            this.btnSupprimerTouteLesDonnees.UseVisualStyleBackColor = false;
            this.btnSupprimerTouteLesDonnees.Click += new System.EventHandler(this.btnSupprimerTouteLesDonnees_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReinitialiser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnReinitialiser.Location = new System.Drawing.Point(632, 390);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(374, 40);
            this.btnReinitialiser.TabIndex = 9;
            this.btnReinitialiser.Text = "Réinitialiser la sélection";
            this.btnReinitialiser.UseVisualStyleBackColor = false;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // gbpElements
            // 
            this.gbpElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gbpElements.Controls.Add(this.clbElements);
            this.gbpElements.ForeColor = System.Drawing.Color.White;
            this.gbpElements.Location = new System.Drawing.Point(41, 169);
            this.gbpElements.Name = "gbpElements";
            this.gbpElements.Size = new System.Drawing.Size(575, 405);
            this.gbpElements.TabIndex = 8;
            this.gbpElements.TabStop = false;
            this.gbpElements.Text = "Éléments à filtrer";
            // 
            // clbElements
            // 
            this.clbElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.clbElements.CheckOnClick = true;
            this.clbElements.ForeColor = System.Drawing.Color.White;
            this.clbElements.FormattingEnabled = true;
            this.clbElements.Location = new System.Drawing.Point(6, 21);
            this.clbElements.Name = "clbElements";
            this.clbElements.Size = new System.Drawing.Size(563, 378);
            this.clbElements.TabIndex = 0;
            // 
            // gbpFiltres
            // 
            this.gbpFiltres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gbpFiltres.Controls.Add(this.rdbNiveaux);
            this.gbpFiltres.Controls.Add(this.rdbClasses);
            this.gbpFiltres.Controls.Add(this.rdbEleve);
            this.gbpFiltres.ForeColor = System.Drawing.Color.White;
            this.gbpFiltres.Location = new System.Drawing.Point(41, 36);
            this.gbpFiltres.Name = "gbpFiltres";
            this.gbpFiltres.Size = new System.Drawing.Size(575, 122);
            this.gbpFiltres.TabIndex = 7;
            this.gbpFiltres.TabStop = false;
            this.gbpFiltres.Text = "Filtres de recherche";
            // 
            // rdbNiveaux
            // 
            this.rdbNiveaux.AutoSize = true;
            this.rdbNiveaux.Location = new System.Drawing.Point(400, 55);
            this.rdbNiveaux.Name = "rdbNiveaux";
            this.rdbNiveaux.Size = new System.Drawing.Size(79, 21);
            this.rdbNiveaux.TabIndex = 2;
            this.rdbNiveaux.Text = "Niveaux";
            this.rdbNiveaux.UseVisualStyleBackColor = true;
            this.rdbNiveaux.CheckedChanged += new System.EventHandler(this.rdbNiveaux_CheckedChanged);
            // 
            // rdbClasses
            // 
            this.rdbClasses.AutoSize = true;
            this.rdbClasses.Location = new System.Drawing.Point(252, 55);
            this.rdbClasses.Name = "rdbClasses";
            this.rdbClasses.Size = new System.Drawing.Size(78, 21);
            this.rdbClasses.TabIndex = 1;
            this.rdbClasses.Text = "Classes";
            this.rdbClasses.UseVisualStyleBackColor = true;
            this.rdbClasses.CheckedChanged += new System.EventHandler(this.rdbClasses_CheckedChanged);
            // 
            // rdbEleve
            // 
            this.rdbEleve.AutoSize = true;
            this.rdbEleve.Checked = true;
            this.rdbEleve.Location = new System.Drawing.Point(102, 55);
            this.rdbEleve.Name = "rdbEleve";
            this.rdbEleve.Size = new System.Drawing.Size(71, 21);
            this.rdbEleve.TabIndex = 0;
            this.rdbEleve.TabStop = true;
            this.rdbEleve.Text = "Eleves";
            this.rdbEleve.UseVisualStyleBackColor = true;
            this.rdbEleve.CheckedChanged += new System.EventHandler(this.rdbEleve_CheckedChanged);
            // 
            // btnOuvrirEmpBDD
            // 
            this.btnOuvrirEmpBDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnOuvrirEmpBDD.Enabled = false;
            this.btnOuvrirEmpBDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOuvrirEmpBDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOuvrirEmpBDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnOuvrirEmpBDD.Location = new System.Drawing.Point(632, 344);
            this.btnOuvrirEmpBDD.Name = "btnOuvrirEmpBDD";
            this.btnOuvrirEmpBDD.Size = new System.Drawing.Size(374, 40);
            this.btnOuvrirEmpBDD.TabIndex = 13;
            this.btnOuvrirEmpBDD.Text = "Ouvrir emplacement de la BDD";
            this.btnOuvrirEmpBDD.UseVisualStyleBackColor = false;
            this.btnOuvrirEmpBDD.Visible = false;
            this.btnOuvrirEmpBDD.Click += new System.EventHandler(this.btnOuvrirEmpBDD_Click);
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(797, 36);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(133, 28);
            this.lblCount.TabIndex = 20;
            this.lblCount.Text = "aucuin";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(628, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre d\'élèves :";
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.Color.White;
            this.txtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(769, 68);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(237, 26);
            this.txtRecherche.TabIndex = 22;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(628, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rechercher :";
            // 
            // gbpRecherche
            // 
            this.gbpRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gbpRecherche.Controls.Add(this.lbRecherche);
            this.gbpRecherche.ForeColor = System.Drawing.Color.White;
            this.gbpRecherche.Location = new System.Drawing.Point(625, 101);
            this.gbpRecherche.Name = "gbpRecherche";
            this.gbpRecherche.Size = new System.Drawing.Size(407, 223);
            this.gbpRecherche.TabIndex = 24;
            this.gbpRecherche.TabStop = false;
            this.gbpRecherche.Text = "Resultat de la Recherche";
            // 
            // lbRecherche
            // 
            this.lbRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbRecherche.ForeColor = System.Drawing.Color.White;
            this.lbRecherche.FormattingEnabled = true;
            this.lbRecherche.ItemHeight = 16;
            this.lbRecherche.Location = new System.Drawing.Point(8, 20);
            this.lbRecherche.Name = "lbRecherche";
            this.lbRecherche.Size = new System.Drawing.Size(392, 196);
            this.lbRecherche.TabIndex = 1;
            this.lbRecherche.SelectedIndexChanged += new System.EventHandler(this.lbRecherche_SelectedIndexChanged);
            // 
            // frmSuppressionDeDonnées
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1044, 609);
            this.Controls.Add(this.gbpRecherche);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOuvrirEmpBDD);
            this.Controls.Add(this.btnSupprimerLesDonneesSelectionnees);
            this.Controls.Add(this.btnToutSelectionner);
            this.Controls.Add(this.btnSupprimerTouteLesDonnees);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.gbpElements);
            this.Controls.Add(this.gbpFiltres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSuppressionDeDonnées";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Athena - Suppression de données";
            this.Load += new System.EventHandler(this.frmSuppressionDeDonnées_Load);
            this.gbpElements.ResumeLayout(false);
            this.gbpFiltres.ResumeLayout(false);
            this.gbpFiltres.PerformLayout();
            this.gbpRecherche.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimerLesDonneesSelectionnees;
        private System.Windows.Forms.Button btnToutSelectionner;
        private System.Windows.Forms.Button btnSupprimerTouteLesDonnees;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.GroupBox gbpElements;
        private System.Windows.Forms.CheckedListBox clbElements;
        private System.Windows.Forms.GroupBox gbpFiltres;
        private System.Windows.Forms.RadioButton rdbNiveaux;
        private System.Windows.Forms.RadioButton rdbClasses;
        private System.Windows.Forms.RadioButton rdbEleve;
        private System.Windows.Forms.Button btnOuvrirEmpBDD;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbpRecherche;
        private System.Windows.Forms.ListBox lbRecherche;
    }
}

/**
 * MIT License
 * 
 * Copyright (c) 2023, 2024 Collège Caroline Aigle
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 * 
 */