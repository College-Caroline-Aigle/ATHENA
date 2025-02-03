﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CartesAcces2024
{
    public partial class frmSelectionNiveau : Form
    {
        public frmSelectionNiveau()
        {
            InitializeComponent();

            // Valeurs par défaut
            switch(Globale.LogicielEdt)
            {
                case Globale.LogicielsEdt.IndexEducation:
                    rdbIE.Checked = true;
                    break;
                case Globale.LogicielsEdt.UnDeuxTemps:
                    rdbUdt.Checked = true;
                    break;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool classeChecked = true;
            bool logicielChecked = true;

            if (rdbUdt.Checked)
                Globale.LogicielEdt = Globale.LogicielsEdt.UnDeuxTemps;
            else if (rdbIE.Checked)
                Globale.LogicielEdt = Globale.LogicielsEdt.IndexEducation;
            else
                logicielChecked = false;

            if (rdb3eme.Checked)
            {
                Globale.Classe = 3;
            }

            else if (rdb4eme.Checked)
            {
                Globale.Classe = 4;
            }

            else if (rdb5eme.Checked)
            {
                Globale.Classe = 5;
            }

            else if (rdb6eme.Checked)
            {
                Globale.Classe = 6;
            }

            else if (rdbClasses.Checked)
            {
                Globale.Classe = 7;
            }

            else if (rdbTousEleves.Checked)
            {
                Globale.Classe = 8;
            }

            else
            {
                classeChecked = false;
            }

            if(classeChecked && logicielChecked)
            {
                if (Globale.Classe == 7)
                    PdfGs.ImporterEdtClassesUniquement();
                else
                    PdfGs.ImporterEdtUnNiveau();
                Close();
            }
            else
                MessageBox.Show("Veuillez selectionner une section ET un logiciel.");

        }

        private void gpbClasse_Enter(object sender, EventArgs e)
        {

        }
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
