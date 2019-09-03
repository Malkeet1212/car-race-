namespace carrace
{
    partial class maingame
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
            this.components = new System.ComponentModel.Container();
            this.label10 = new System.Windows.Forms.Label();
            this.JHONRABS = new System.Windows.Forms.RadioButton();
            this.LINDRBS = new System.Windows.Forms.RadioButton();
            this.ZACKRBS = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.betbtn = new System.Windows.Forms.Button();
            this.betplaceud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Racerud = new System.Windows.Forms.NumericUpDown();
            this.Gobtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.JHONLBS = new System.Windows.Forms.Label();
            this.LINDLBS = new System.Windows.Forms.Label();
            this.ZACKLBS = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.car4 = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.racePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.betplaceud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racerud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racePB)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 20.75F);
            this.label10.Location = new System.Drawing.Point(7, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 38);
            this.label10.TabIndex = 5;
            this.label10.Text = "Bets here";
            // 
            // JHONRABS
            // 
            this.JHONRABS.AutoSize = true;
            this.JHONRABS.Checked = true;
            this.JHONRABS.Location = new System.Drawing.Point(9, 476);
            this.JHONRABS.Name = "JHONRABS";
            this.JHONRABS.Size = new System.Drawing.Size(48, 17);
            this.JHONRABS.TabIndex = 6;
            this.JHONRABS.TabStop = true;
            this.JHONRABS.Text = "Jhon";
            this.JHONRABS.UseVisualStyleBackColor = true;
            // 
            // LINDRBS
            // 
            this.LINDRBS.AutoSize = true;
            this.LINDRBS.Location = new System.Drawing.Point(9, 503);
            this.LINDRBS.Name = "LINDRBS";
            this.LINDRBS.Size = new System.Drawing.Size(45, 17);
            this.LINDRBS.TabIndex = 7;
            this.LINDRBS.TabStop = true;
            this.LINDRBS.Text = "Lind";
            this.LINDRBS.UseVisualStyleBackColor = true;
            this.LINDRBS.CheckedChanged += new System.EventHandler(this.rbSam_CheckedChanged);
            // 
            // ZACKRBS
            // 
            this.ZACKRBS.AutoSize = true;
            this.ZACKRBS.Location = new System.Drawing.Point(9, 527);
            this.ZACKRBS.Name = "ZACKRBS";
            this.ZACKRBS.Size = new System.Drawing.Size(50, 17);
            this.ZACKRBS.TabIndex = 8;
            this.ZACKRBS.TabStop = true;
            this.ZACKRBS.Text = "Zack";
            this.ZACKRBS.UseVisualStyleBackColor = true;
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(12, 453);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(91, 13);
            this.minimumBetLabel.TabIndex = 9;
            this.minimumBetLabel.Text = "Minimum bet is 1$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "name";
            // 
            // betbtn
            // 
            this.betbtn.Location = new System.Drawing.Point(74, 579);
            this.betbtn.Name = "betbtn";
            this.betbtn.Size = new System.Drawing.Size(46, 20);
            this.betbtn.TabIndex = 11;
            this.betbtn.Text = "Bets";
            this.betbtn.UseVisualStyleBackColor = true;
            this.betbtn.Click += new System.EventHandler(this.beterbtn_Click);
            // 
            // betplaceud
            // 
            this.betplaceud.Location = new System.Drawing.Point(137, 580);
            this.betplaceud.Name = "betplaceud";
            this.betplaceud.Size = new System.Drawing.Size(43, 20);
            this.betplaceud.TabIndex = 12;
            this.betplaceud.ValueChanged += new System.EventHandler(this.Betplaceud_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "$ on car no";
            // 
            // Racerud
            // 
            this.Racerud.Location = new System.Drawing.Point(333, 577);
            this.Racerud.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Racerud.Name = "Racerud";
            this.Racerud.Size = new System.Drawing.Size(41, 20);
            this.Racerud.TabIndex = 14;
            this.Racerud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Racerud.ValueChanged += new System.EventHandler(this.Racerud_ValueChanged);
            // 
            // Gobtn
            // 
            this.Gobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gobtn.Font = new System.Drawing.Font("Myanmar Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gobtn.Location = new System.Drawing.Point(646, 487);
            this.Gobtn.Name = "Gobtn";
            this.Gobtn.Size = new System.Drawing.Size(301, 95);
            this.Gobtn.TabIndex = 15;
            this.Gobtn.Text = "Start";
            this.Gobtn.UseVisualStyleBackColor = true;
            this.Gobtn.Click += new System.EventHandler(this.Racerbtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Malgun Gothic", 20.75F);
            this.label12.Location = new System.Drawing.Point(306, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 38);
            this.label12.TabIndex = 16;
            this.label12.Text = "Place bet";
            // 
            // JHONLBS
            // 
            this.JHONLBS.AutoSize = true;
            this.JHONLBS.Location = new System.Drawing.Point(309, 466);
            this.JHONLBS.Name = "JHONLBS";
            this.JHONLBS.Size = new System.Drawing.Size(30, 13);
            this.JHONLBS.TabIndex = 17;
            this.JHONLBS.Text = "Jhon";
            // 
            // LINDLBS
            // 
            this.LINDLBS.AutoSize = true;
            this.LINDLBS.Location = new System.Drawing.Point(309, 495);
            this.LINDLBS.Name = "LINDLBS";
            this.LINDLBS.Size = new System.Drawing.Size(27, 13);
            this.LINDLBS.TabIndex = 18;
            this.LINDLBS.Text = "Lind";
            // 
            // ZACKLBS
            // 
            this.ZACKLBS.AutoSize = true;
            this.ZACKLBS.Location = new System.Drawing.Point(309, 527);
            this.ZACKLBS.Name = "ZACKLBS";
            this.ZACKLBS.Size = new System.Drawing.Size(32, 13);
            this.ZACKLBS.TabIndex = 19;
            this.ZACKLBS.Text = "Zack";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // car4
            // 
            this.car4.Image = global::CarRace.Properties.Resources.kisspng_car_sprite_small_flat_truck_vector_material_5a9576198db646_5112647815197445375805;
            this.car4.Location = new System.Drawing.Point(15, 321);
            this.car4.Name = "car4";
            this.car4.Size = new System.Drawing.Size(105, 75);
            this.car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car4.TabIndex = 4;
            this.car4.TabStop = false;
            // 
            // car3
            // 
            this.car3.Image = global::CarRace.Properties.Resources.kisspng_car_sprite_small_flat_truck_vector_material_5a9576198db646_5112647815197445375805;
            this.car3.Location = new System.Drawing.Point(16, 242);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(104, 64);
            this.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car3.TabIndex = 3;
            this.car3.TabStop = false;
            // 
            // car2
            // 
            this.car2.Image = global::CarRace.Properties.Resources.kisspng_car_sprite_small_flat_truck_vector_material_5a9576198db646_5112647815197445375805;
            this.car2.Location = new System.Drawing.Point(15, 128);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(105, 69);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 2;
            this.car2.TabStop = false;
            // 
            // car1
            // 
            this.car1.Image = global::CarRace.Properties.Resources.kisspng_car_sprite_small_flat_truck_vector_material_5a9576198db646_5112647815197445375805;
            this.car1.Location = new System.Drawing.Point(15, 22);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(105, 80);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 1;
            this.car1.TabStop = false;
            // 
            // racePB
            // 
            this.racePB.Image = global::CarRace.Properties.Resources.Toon_Road_Texture;
            this.racePB.Location = new System.Drawing.Point(9, 12);
            this.racePB.Name = "racePB";
            this.racePB.Size = new System.Drawing.Size(1068, 384);
            this.racePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racePB.TabIndex = 0;
            this.racePB.TabStop = false;
            // 
            // maingame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1089, 618);
            this.Controls.Add(this.ZACKLBS);
            this.Controls.Add(this.LINDLBS);
            this.Controls.Add(this.JHONLBS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Gobtn);
            this.Controls.Add(this.Racerud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.betplaceud);
            this.Controls.Add(this.betbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minimumBetLabel);
            this.Controls.Add(this.ZACKRBS);
            this.Controls.Add(this.LINDRBS);
            this.Controls.Add(this.JHONRABS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.car4);
            this.Controls.Add(this.car3);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.racePB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "maingame";
            this.Text = "Car Race";
            ((System.ComponentModel.ISupportInitialize)(this.betplaceud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racerud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racePB;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.PictureBox car4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton JHONRABS;
        private System.Windows.Forms.RadioButton LINDRBS;
        private System.Windows.Forms.RadioButton ZACKRBS;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button betbtn;
        private System.Windows.Forms.NumericUpDown betplaceud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Racerud;
        private System.Windows.Forms.Button Gobtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label JHONLBS;
        private System.Windows.Forms.Label LINDLBS;
        private System.Windows.Forms.Label ZACKLBS;
        private System.Windows.Forms.Timer timer1;
    }
}

