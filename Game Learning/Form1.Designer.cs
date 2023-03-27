namespace Game_Learning
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LTitulo = new System.Windows.Forms.Label();
            this.LPlay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LCountdown = new System.Windows.Forms.Label();
            this.PBTopo1 = new System.Windows.Forms.PictureBox();
            this.PBTopo2 = new System.Windows.Forms.PictureBox();
            this.PBTopo4 = new System.Windows.Forms.PictureBox();
            this.PBTopo3 = new System.Windows.Forms.PictureBox();
            this.LScore = new System.Windows.Forms.Label();
            this.PBTopo5 = new System.Windows.Forms.PictureBox();
            this.BaseTick = new System.Windows.Forms.Timer(this.components);
            this.TimeForKillingTopos = new System.Windows.Forms.Timer(this.components);
            this.LTime = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.PBTopo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTopo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTopo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTopo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTopo5)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            resources.ApplyResources(this.LTitulo, "LTitulo");
            this.LTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LTitulo.ForeColor = System.Drawing.Color.Black;
            this.LTitulo.Name = "LTitulo";
            // 
            // LPlay
            // 
            resources.ApplyResources(this.LPlay, "LPlay");
            this.LPlay.BackColor = System.Drawing.Color.Transparent;
            this.LPlay.Name = "LPlay";
            this.LPlay.Click += new System.EventHandler(this.LPlay_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LCountdown
            // 
            resources.ApplyResources(this.LCountdown, "LCountdown");
            this.LCountdown.BackColor = System.Drawing.Color.Transparent;
            this.LCountdown.ForeColor = System.Drawing.Color.Black;
            this.LCountdown.Name = "LCountdown";
            // 
            // PBTopo1
            // 
            this.PBTopo1.BackColor = System.Drawing.Color.Transparent;
            this.PBTopo1.Image = global::Game_Learning.Properties.Resources.agujero;
            resources.ApplyResources(this.PBTopo1, "PBTopo1");
            this.PBTopo1.Name = "PBTopo1";
            this.PBTopo1.TabStop = false;
            this.PBTopo1.Click += new System.EventHandler(this.PBTopo1_Click);
            // 
            // PBTopo2
            // 
            this.PBTopo2.BackColor = System.Drawing.Color.Transparent;
            this.PBTopo2.Image = global::Game_Learning.Properties.Resources.agujero;
            resources.ApplyResources(this.PBTopo2, "PBTopo2");
            this.PBTopo2.Name = "PBTopo2";
            this.PBTopo2.TabStop = false;
            this.PBTopo2.Click += new System.EventHandler(this.PBTopo2_Click);
            // 
            // PBTopo4
            // 
            this.PBTopo4.BackColor = System.Drawing.Color.Transparent;
            this.PBTopo4.Image = global::Game_Learning.Properties.Resources.agujero;
            resources.ApplyResources(this.PBTopo4, "PBTopo4");
            this.PBTopo4.Name = "PBTopo4";
            this.PBTopo4.TabStop = false;
            this.PBTopo4.Click += new System.EventHandler(this.PBTopo4_Click);
            // 
            // PBTopo3
            // 
            this.PBTopo3.BackColor = System.Drawing.Color.Transparent;
            this.PBTopo3.Image = global::Game_Learning.Properties.Resources.agujero;
            resources.ApplyResources(this.PBTopo3, "PBTopo3");
            this.PBTopo3.Name = "PBTopo3";
            this.PBTopo3.TabStop = false;
            this.PBTopo3.Click += new System.EventHandler(this.PBTopo3_Click);
            // 
            // LScore
            // 
            resources.ApplyResources(this.LScore, "LScore");
            this.LScore.BackColor = System.Drawing.Color.Transparent;
            this.LScore.Name = "LScore";
            this.LScore.Click += new System.EventHandler(this.LScore_Click);
            // 
            // PBTopo5
            // 
            this.PBTopo5.BackColor = System.Drawing.Color.Transparent;
            this.PBTopo5.Image = global::Game_Learning.Properties.Resources.agujero;
            resources.ApplyResources(this.PBTopo5, "PBTopo5");
            this.PBTopo5.Name = "PBTopo5";
            this.PBTopo5.TabStop = false;
            this.PBTopo5.Click += new System.EventHandler(this.PBTopo5_Click);
            // 
            // BaseTick
            // 
            this.BaseTick.Interval = 1000;
            this.BaseTick.Tick += new System.EventHandler(this.BaseTick_Tick);
            // 
            // TimeForKillingTopos
            // 
            this.TimeForKillingTopos.Interval = 1000;
            this.TimeForKillingTopos.Tick += new System.EventHandler(this.TimeForKillingTopos_Tick);
            // 
            // LTime
            // 
            resources.ApplyResources(this.LTime, "LTime");
            this.LTime.BackColor = System.Drawing.Color.Transparent;
            this.LTime.Name = "LTime";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Game_Learning.Properties.Resources.fondos;
            this.ControlBox = false;
            this.Controls.Add(this.LTime);
            this.Controls.Add(this.PBTopo5);
            this.Controls.Add(this.LScore);
            this.Controls.Add(this.PBTopo3);
            this.Controls.Add(this.PBTopo4);
            this.Controls.Add(this.PBTopo2);
            this.Controls.Add(this.PBTopo1);
            this.Controls.Add(this.LCountdown);
            this.Controls.Add(this.LPlay);
            this.Controls.Add(this.LTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PBTopo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTopo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTopo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTopo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTopo5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LPlay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LCountdown;
        private System.Windows.Forms.PictureBox PBTopo1;
        private System.Windows.Forms.PictureBox PBTopo2;
        private System.Windows.Forms.PictureBox PBTopo4;
        private System.Windows.Forms.PictureBox PBTopo3;
        private System.Windows.Forms.Label LScore;
        private System.Windows.Forms.PictureBox PBTopo5;
        private System.Windows.Forms.Timer BaseTick;
        private System.Windows.Forms.Timer TimeForKillingTopos;
        private System.Windows.Forms.Label LTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

