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
            this.label1 = new System.Windows.Forms.Label();
            this.playerrb1 = new System.Windows.Forms.RadioButton();
            this.playerrb2 = new System.Windows.Forms.RadioButton();
            this.playerrb3 = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.betbtn = new System.Windows.Forms.Button();
            this.betupdown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.carupdown = new System.Windows.Forms.NumericUpDown();
            this.racebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.player3Label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.carpb4 = new System.Windows.Forms.PictureBox();
            this.carPb3 = new System.Windows.Forms.PictureBox();
            this.carPB2 = new System.Windows.Forms.PictureBox();
            this.carPB1 = new System.Windows.Forms.PictureBox();
            this.raceTrackPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.betupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bett here";
            // 
            // playerrb1
            // 
            this.playerrb1.AutoSize = true;
            this.playerrb1.Checked = true;
            this.playerrb1.Location = new System.Drawing.Point(9, 476);
            this.playerrb1.Name = "playerrb1";
            this.playerrb1.Size = new System.Drawing.Size(37, 17);
            this.playerrb1.TabIndex = 6;
            this.playerrb1.TabStop = true;
            this.playerrb1.Text = "gill";
            this.playerrb1.UseVisualStyleBackColor = true;
            this.playerrb1.CheckedChanged += new System.EventHandler(this.playerrb1_CheckedChanged);
            // 
            // playerrb2
            // 
            this.playerrb2.AutoSize = true;
            this.playerrb2.Location = new System.Drawing.Point(9, 503);
            this.playerrb2.Name = "playerrb2";
            this.playerrb2.Size = new System.Drawing.Size(63, 17);
            this.playerrb2.TabIndex = 7;
            this.playerrb2.TabStop = true;
            this.playerrb2.Text = "askaran";
            this.playerrb2.UseVisualStyleBackColor = true;
            this.playerrb2.CheckedChanged += new System.EventHandler(this.playerrb2_CheckedChanged);
            // 
            // playerrb3
            // 
            this.playerrb3.AutoSize = true;
            this.playerrb3.Location = new System.Drawing.Point(9, 527);
            this.playerrb3.Name = "playerrb3";
            this.playerrb3.Size = new System.Drawing.Size(49, 17);
            this.playerrb3.TabIndex = 8;
            this.playerrb3.TabStop = true;
            this.playerrb3.Text = "simer";
            this.playerrb3.UseVisualStyleBackColor = true;
            this.playerrb3.CheckedChanged += new System.EventHandler(this.playerrb3_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(12, 453);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(38, 13);
            this.minimumBetLabel.TabIndex = 9;
            this.minimumBetLabel.Text = "minbet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "name";
            // 
            // betbtn
            // 
            this.betbtn.Location = new System.Drawing.Point(66, 568);
            this.betbtn.Name = "betbtn";
            this.betbtn.Size = new System.Drawing.Size(46, 20);
            this.betbtn.TabIndex = 11;
            this.betbtn.Text = "Bets";
            this.betbtn.UseVisualStyleBackColor = true;
            this.betbtn.Click += new System.EventHandler(this.betbtn_Click);
            // 
            // betupdown
            // 
            this.betupdown.Location = new System.Drawing.Point(127, 570);
            this.betupdown.Name = "betupdown";
            this.betupdown.Size = new System.Drawing.Size(43, 20);
            this.betupdown.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "bucks on racer number";
            // 
            // carupdown
            // 
            this.carupdown.Location = new System.Drawing.Point(367, 568);
            this.carupdown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.carupdown.Name = "carupdown";
            this.carupdown.Size = new System.Drawing.Size(41, 20);
            this.carupdown.TabIndex = 14;
            this.carupdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.carupdown.ValueChanged += new System.EventHandler(this.carUpDown_ValueChanged);
            // 
            // racebtn
            // 
            this.racebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.racebtn.Location = new System.Drawing.Point(558, 478);
            this.racebtn.Name = "racebtn";
            this.racebtn.Size = new System.Drawing.Size(153, 95);
            this.racebtn.TabIndex = 15;
            this.racebtn.Text = "Race!";
            this.racebtn.UseVisualStyleBackColor = true;
            this.racebtn.Click += new System.EventHandler(this.Racebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 35);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bets";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(309, 453);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(69, 13);
            this.player1Label.TabIndex = 17;
            this.player1Label.Text = "scorebord gill";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(309, 478);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(101, 13);
            this.player2Label.TabIndex = 18;
            this.player2Label.Text = "scoreboard askaran";
            this.player2Label.Click += new System.EventHandler(this.player2Label_Click);
            // 
            // player3Label
            // 
            this.player3Label.AutoSize = true;
            this.player3Label.Location = new System.Drawing.Point(309, 527);
            this.player3Label.Name = "player3Label";
            this.player3Label.Size = new System.Drawing.Size(87, 13);
            this.player3Label.TabIndex = 19;
            this.player3Label.Text = "scoreboard simer";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // carpb4
            // 
            this.carpb4.Image = global::CarRace.Properties.Resources._0c3d3a1e1403b36c2120361ea93e03a799a96035;
            this.carpb4.Location = new System.Drawing.Point(15, 320);
            this.carpb4.Name = "carpb4";
            this.carpb4.Size = new System.Drawing.Size(87, 54);
            this.carpb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carpb4.TabIndex = 4;
            this.carpb4.TabStop = false;
            // 
            // carPb3
            // 
            this.carPb3.Image = global::CarRace.Properties.Resources._0c3d3a1e1403b36c2120361ea93e03a799a96035;
            this.carPb3.Location = new System.Drawing.Point(15, 213);
            this.carPb3.Name = "carPb3";
            this.carPb3.Size = new System.Drawing.Size(87, 54);
            this.carPb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPb3.TabIndex = 3;
            this.carPb3.TabStop = false;
            // 
            // carPB2
            // 
            this.carPB2.Image = global::CarRace.Properties.Resources._0c3d3a1e1403b36c2120361ea93e03a799a96035;
            this.carPB2.Location = new System.Drawing.Point(15, 119);
            this.carPB2.Name = "carPB2";
            this.carPB2.Size = new System.Drawing.Size(87, 54);
            this.carPB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPB2.TabIndex = 2;
            this.carPB2.TabStop = false;
            // 
            // carPB1
            // 
            this.carPB1.Image = global::CarRace.Properties.Resources._0c3d3a1e1403b36c2120361ea93e03a799a96035;
            this.carPB1.Location = new System.Drawing.Point(15, 22);
            this.carPB1.Name = "carPB1";
            this.carPB1.Size = new System.Drawing.Size(87, 54);
            this.carPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPB1.TabIndex = 1;
            this.carPB1.TabStop = false;
            // 
            // raceTrackPictureBox
            // 
            this.raceTrackPictureBox.Image = global::CarRace.Properties.Resources.road;
            this.raceTrackPictureBox.Location = new System.Drawing.Point(9, 8);
            this.raceTrackPictureBox.Name = "raceTrackPictureBox";
            this.raceTrackPictureBox.Size = new System.Drawing.Size(718, 384);
            this.raceTrackPictureBox.TabIndex = 0;
            this.raceTrackPictureBox.TabStop = false;
            // 
            // maingame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 603);
            this.Controls.Add(this.player3Label);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.racebtn);
            this.Controls.Add(this.carupdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.betupdown);
            this.Controls.Add(this.betbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minimumBetLabel);
            this.Controls.Add(this.playerrb3);
            this.Controls.Add(this.playerrb2);
            this.Controls.Add(this.playerrb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carpb4);
            this.Controls.Add(this.carPb3);
            this.Controls.Add(this.carPB2);
            this.Controls.Add(this.carPB1);
            this.Controls.Add(this.raceTrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "maingame";
            this.Text = "Car Race";
            ((System.ComponentModel.ISupportInitialize)(this.betupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrackPictureBox;
        private System.Windows.Forms.PictureBox carPB1;
        private System.Windows.Forms.PictureBox carPB2;
        private System.Windows.Forms.PictureBox carPb3;
        private System.Windows.Forms.PictureBox carpb4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton playerrb1;
        private System.Windows.Forms.RadioButton playerrb2;
        private System.Windows.Forms.RadioButton playerrb3;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button betbtn;
        private System.Windows.Forms.NumericUpDown betupdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown carupdown;
        private System.Windows.Forms.Button racebtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player3Label;
        private System.Windows.Forms.Timer timer1;
    }
}

