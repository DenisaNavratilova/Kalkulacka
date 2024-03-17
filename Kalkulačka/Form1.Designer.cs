namespace Kalkulačka
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.jedna = new System.Windows.Forms.Button();
            this.ctyri = new System.Windows.Forms.Button();
            this.sedm = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.osm = new System.Windows.Forms.Button();
            this.pet = new System.Windows.Forms.Button();
            this.dva = new System.Windows.Forms.Button();
            this.nula = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.devet = new System.Windows.Forms.Button();
            this.sest = new System.Windows.Forms.Button();
            this.tri = new System.Windows.Forms.Button();
            this.deleno = new System.Windows.Forms.Button();
            this.krat = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.rovnase = new System.Windows.Forms.Button();
            this.carka = new System.Windows.Forms.Button();
            this.mocnina = new System.Windows.Forms.Button();
            this.odmocnina = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.textBox1.MaxLength = 12;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(318, 60);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // jedna
            // 
            this.jedna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jedna.Location = new System.Drawing.Point(12, 231);
            this.jedna.Name = "jedna";
            this.jedna.Size = new System.Drawing.Size(75, 39);
            this.jedna.TabIndex = 6;
            this.jedna.Text = "1";
            this.jedna.UseVisualStyleBackColor = true;
            this.jedna.Click += new System.EventHandler(this.jedna_Click);
            // 
            // ctyri
            // 
            this.ctyri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctyri.Location = new System.Drawing.Point(12, 186);
            this.ctyri.Name = "ctyri";
            this.ctyri.Size = new System.Drawing.Size(75, 39);
            this.ctyri.TabIndex = 7;
            this.ctyri.Text = "4";
            this.ctyri.UseVisualStyleBackColor = true;
            this.ctyri.Click += new System.EventHandler(this.ctyri_Click);
            // 
            // sedm
            // 
            this.sedm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sedm.Location = new System.Drawing.Point(12, 141);
            this.sedm.Name = "sedm";
            this.sedm.Size = new System.Drawing.Size(75, 39);
            this.sedm.TabIndex = 8;
            this.sedm.Text = "7";
            this.sedm.UseVisualStyleBackColor = true;
            this.sedm.Click += new System.EventHandler(this.sedm_Click);
            // 
            // CE
            // 
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CE.Location = new System.Drawing.Point(12, 96);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(75, 39);
            this.CE.TabIndex = 9;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C.Location = new System.Drawing.Point(93, 96);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(75, 39);
            this.C.TabIndex = 10;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // osm
            // 
            this.osm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osm.Location = new System.Drawing.Point(93, 141);
            this.osm.Name = "osm";
            this.osm.Size = new System.Drawing.Size(75, 39);
            this.osm.TabIndex = 11;
            this.osm.Text = "8";
            this.osm.UseVisualStyleBackColor = true;
            this.osm.Click += new System.EventHandler(this.osm_Click);
            // 
            // pet
            // 
            this.pet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pet.Location = new System.Drawing.Point(93, 186);
            this.pet.Name = "pet";
            this.pet.Size = new System.Drawing.Size(75, 39);
            this.pet.TabIndex = 12;
            this.pet.Text = "5";
            this.pet.UseVisualStyleBackColor = true;
            this.pet.Click += new System.EventHandler(this.pet_Click);
            // 
            // dva
            // 
            this.dva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dva.Location = new System.Drawing.Point(93, 231);
            this.dva.Name = "dva";
            this.dva.Size = new System.Drawing.Size(75, 39);
            this.dva.TabIndex = 13;
            this.dva.Text = "2";
            this.dva.UseVisualStyleBackColor = true;
            this.dva.Click += new System.EventHandler(this.dva_Click);
            // 
            // nula
            // 
            this.nula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nula.Location = new System.Drawing.Point(93, 276);
            this.nula.Name = "nula";
            this.nula.Size = new System.Drawing.Size(75, 39);
            this.nula.TabIndex = 14;
            this.nula.Text = "0";
            this.nula.UseVisualStyleBackColor = true;
            this.nula.Click += new System.EventHandler(this.nula_Click);
            // 
            // backspace
            // 
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backspace.Location = new System.Drawing.Point(174, 96);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(75, 39);
            this.backspace.TabIndex = 15;
            this.backspace.Text = "←";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // devet
            // 
            this.devet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.devet.Location = new System.Drawing.Point(174, 141);
            this.devet.Name = "devet";
            this.devet.Size = new System.Drawing.Size(75, 39);
            this.devet.TabIndex = 16;
            this.devet.Text = "9";
            this.devet.UseVisualStyleBackColor = true;
            this.devet.Click += new System.EventHandler(this.devet_Click);
            // 
            // sest
            // 
            this.sest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sest.Location = new System.Drawing.Point(174, 186);
            this.sest.Name = "sest";
            this.sest.Size = new System.Drawing.Size(75, 39);
            this.sest.TabIndex = 17;
            this.sest.Text = "6";
            this.sest.UseVisualStyleBackColor = true;
            this.sest.Click += new System.EventHandler(this.sest_Click);
            // 
            // tri
            // 
            this.tri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tri.Location = new System.Drawing.Point(174, 231);
            this.tri.Name = "tri";
            this.tri.Size = new System.Drawing.Size(75, 39);
            this.tri.TabIndex = 18;
            this.tri.Text = "3";
            this.tri.UseVisualStyleBackColor = true;
            this.tri.Click += new System.EventHandler(this.tri_Click);
            // 
            // deleno
            // 
            this.deleno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleno.Location = new System.Drawing.Point(255, 96);
            this.deleno.Name = "deleno";
            this.deleno.Size = new System.Drawing.Size(75, 39);
            this.deleno.TabIndex = 20;
            this.deleno.Text = "/";
            this.deleno.UseVisualStyleBackColor = true;
            this.deleno.Click += new System.EventHandler(this.deleno_Click);
            // 
            // krat
            // 
            this.krat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.krat.Location = new System.Drawing.Point(255, 141);
            this.krat.Name = "krat";
            this.krat.Size = new System.Drawing.Size(75, 39);
            this.krat.TabIndex = 21;
            this.krat.Text = "x";
            this.krat.UseVisualStyleBackColor = true;
            this.krat.Click += new System.EventHandler(this.krat_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minus.Location = new System.Drawing.Point(255, 186);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 39);
            this.minus.TabIndex = 22;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plus.Location = new System.Drawing.Point(255, 231);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 39);
            this.plus.TabIndex = 23;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // rovnase
            // 
            this.rovnase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rovnase.Location = new System.Drawing.Point(255, 276);
            this.rovnase.Name = "rovnase";
            this.rovnase.Size = new System.Drawing.Size(75, 39);
            this.rovnase.TabIndex = 24;
            this.rovnase.Text = "=";
            this.rovnase.UseVisualStyleBackColor = true;
            this.rovnase.Click += new System.EventHandler(this.rovnase_Click);
            // 
            // carka
            // 
            this.carka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carka.Location = new System.Drawing.Point(12, 276);
            this.carka.Name = "carka";
            this.carka.Size = new System.Drawing.Size(75, 39);
            this.carka.TabIndex = 25;
            this.carka.Text = ",";
            this.carka.UseVisualStyleBackColor = true;
            this.carka.Click += new System.EventHandler(this.carka_Click);
            // 
            // mocnina
            // 
            this.mocnina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mocnina.Location = new System.Drawing.Point(174, 278);
            this.mocnina.Name = "mocnina";
            this.mocnina.Size = new System.Drawing.Size(33, 37);
            this.mocnina.TabIndex = 26;
            this.mocnina.Text = "^2";
            this.mocnina.UseVisualStyleBackColor = true;
            this.mocnina.Click += new System.EventHandler(this.mocnina_Click);
            // 
            // odmocnina
            // 
            this.odmocnina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odmocnina.Location = new System.Drawing.Point(213, 278);
            this.odmocnina.Name = "odmocnina";
            this.odmocnina.Size = new System.Drawing.Size(36, 37);
            this.odmocnina.TabIndex = 27;
            this.odmocnina.Text = "√";
            this.odmocnina.UseVisualStyleBackColor = true;
            this.odmocnina.Click += new System.EventHandler(this.odmocnina_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Standardní";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odmocnina);
            this.Controls.Add(this.mocnina);
            this.Controls.Add(this.carka);
            this.Controls.Add(this.rovnase);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.krat);
            this.Controls.Add(this.deleno);
            this.Controls.Add(this.tri);
            this.Controls.Add(this.sest);
            this.Controls.Add(this.devet);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.nula);
            this.Controls.Add(this.dva);
            this.Controls.Add(this.pet);
            this.Controls.Add(this.osm);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.sedm);
            this.Controls.Add(this.ctyri);
            this.Controls.Add(this.jedna);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.Name = "Form1";
            this.Text = "Kalkulačka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button jedna;
        private System.Windows.Forms.Button ctyri;
        private System.Windows.Forms.Button sedm;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button osm;
        private System.Windows.Forms.Button pet;
        private System.Windows.Forms.Button dva;
        private System.Windows.Forms.Button nula;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button devet;
        private System.Windows.Forms.Button sest;
        private System.Windows.Forms.Button tri;
        private System.Windows.Forms.Button deleno;
        private System.Windows.Forms.Button krat;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button rovnase;
        private System.Windows.Forms.Button carka;
        private System.Windows.Forms.Button mocnina;
        private System.Windows.Forms.Button odmocnina;
        private System.Windows.Forms.Label label1;
    }
}

