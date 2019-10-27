namespace stars_wars_game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.Rmovetimer = new System.Windows.Forms.Timer(this.components);
            this.Lmovetimer = new System.Windows.Forms.Timer(this.components);
            this.Umovetimer = new System.Windows.Forms.Timer(this.components);
            this.Dmovetimer = new System.Windows.Forms.Timer(this.components);
            this.munitiontimer = new System.Windows.Forms.Timer(this.components);
            this.moveenimestimer = new System.Windows.Forms.Timer(this.components);
            this.enimeshots = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Slabel = new System.Windows.Forms.Label();
            this.levelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(247, 431);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // Rmovetimer
            // 
            this.Rmovetimer.Interval = 5;
            this.Rmovetimer.Tick += new System.EventHandler(this.Rmovetimer_Tick);
            // 
            // Lmovetimer
            // 
            this.Lmovetimer.Interval = 5;
            this.Lmovetimer.Tick += new System.EventHandler(this.Lmovetimer_Tick);
            // 
            // Umovetimer
            // 
            this.Umovetimer.Interval = 5;
            this.Umovetimer.Tick += new System.EventHandler(this.Umovetimer_Tick);
            // 
            // Dmovetimer
            // 
            this.Dmovetimer.Interval = 5;
            this.Dmovetimer.Tick += new System.EventHandler(this.Dmovetimer_Tick);
            // 
            // munitiontimer
            // 
            this.munitiontimer.Enabled = true;
            this.munitiontimer.Interval = 20;
            this.munitiontimer.Tick += new System.EventHandler(this.Munitiontimer_Tick);
            // 
            // moveenimestimer
            // 
            this.moveenimestimer.Enabled = true;
            this.moveenimestimer.Tick += new System.EventHandler(this.Moveenimestimer_Tick);
            // 
            // enimeshots
            // 
            this.enimeshots.Enabled = true;
            this.enimeshots.Interval = 20;
            this.enimeshots.Tick += new System.EventHandler(this.Enimeshots_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 45F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "GAME OVER";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(183, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "REPLAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(183, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Slabel
            // 
            this.Slabel.BackColor = System.Drawing.Color.Transparent;
            this.Slabel.Font = new System.Drawing.Font("Imprint MT Shadow", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slabel.ForeColor = System.Drawing.Color.Snow;
            this.Slabel.Location = new System.Drawing.Point(3, 0);
            this.Slabel.Name = "Slabel";
            this.Slabel.Size = new System.Drawing.Size(161, 59);
            this.Slabel.TabIndex = 4;
            this.Slabel.Text = "SCORE";
            // 
            // levelabel
            // 
            this.levelabel.BackColor = System.Drawing.Color.Transparent;
            this.levelabel.Font = new System.Drawing.Font("Imprint MT Shadow", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelabel.ForeColor = System.Drawing.Color.Snow;
            this.levelabel.Location = new System.Drawing.Point(378, 0);
            this.levelabel.Name = "levelabel";
            this.levelabel.Size = new System.Drawing.Size(163, 59);
            this.levelabel.TabIndex = 5;
            this.levelabel.Text = "LEVEL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.levelabel);
            this.Controls.Add(this.Slabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer Rmovetimer;
        private System.Windows.Forms.Timer Lmovetimer;
        private System.Windows.Forms.Timer Umovetimer;
        private System.Windows.Forms.Timer Dmovetimer;
        private System.Windows.Forms.Timer munitiontimer;
        private System.Windows.Forms.Timer moveenimestimer;
        private System.Windows.Forms.Timer enimeshots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Slabel;
        private System.Windows.Forms.Label levelabel;
    }
}

