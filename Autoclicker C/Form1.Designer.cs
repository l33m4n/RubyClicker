namespace Autoclicker_C
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.siticoneLabel2 = new ns1.SiticoneLabel();
            this.CPSValue = new ns1.SiticoneLabel();
            this.Autoclicker = new System.Windows.Forms.Timer(this.components);
            this.btnToggle = new ns1.SiticoneButton();
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.randomTB = new ns1.SiticoneMetroTrackBar();
            this.bindBtn = new ns1.SiticoneButton();
            this.Binding = new System.Windows.Forms.Timer(this.components);
            this.RMBclick = new ns1.SiticoneCheckBox();
            this.siticoneLabel3 = new ns1.SiticoneLabel();
            this.randomtrackbar = new ns1.SiticoneMetroTrackBar();
            this.randometer = new ns1.SiticoneLabel();
            this.siticoneLabel5 = new ns1.SiticoneLabel();
            this.siticoneLabel4 = new ns1.SiticoneLabel();
            this.CPSvalue2 = new ns1.SiticoneLabel();
            this.siticoneButton1 = new ns1.SiticoneButton();
            this.CPSTrackbar1 = new ns1.SiticoneMetroTrackBar();
            this.SuspendLayout();
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.siticoneLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel2.Location = new System.Drawing.Point(12, 141);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(77, 23);
            this.siticoneLabel2.TabIndex = 1;
            this.siticoneLabel2.Text = "Click CPS:";
            // 
            // CPSValue
            // 
            this.CPSValue.BackColor = System.Drawing.Color.Transparent;
            this.CPSValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CPSValue.ForeColor = System.Drawing.Color.White;
            this.CPSValue.Location = new System.Drawing.Point(95, 141);
            this.CPSValue.Name = "CPSValue";
            this.CPSValue.Size = new System.Drawing.Size(54, 23);
            this.CPSValue.TabIndex = 4;
            this.CPSValue.Text = "10 CPS";
            // 
            // Autoclicker
            // 
            this.Autoclicker.Enabled = true;
            this.Autoclicker.Tick += new System.EventHandler(this.Autoclicker_Tick);
            // 
            // btnToggle
            // 
            this.btnToggle.ButtonMode = ns5.ButtonMode.ToogleButton;
            this.btnToggle.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnToggle.CheckedState.Parent = this.btnToggle;
            this.btnToggle.CustomImages.Parent = this.btnToggle;
            this.btnToggle.FillColor = System.Drawing.Color.LightCoral;
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.ForeColor = System.Drawing.Color.White;
            this.btnToggle.HoveredState.Parent = this.btnToggle;
            this.btnToggle.Location = new System.Drawing.Point(12, 69);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.ShadowDecoration.Parent = this.btnToggle;
            this.btnToggle.Size = new System.Drawing.Size(91, 31);
            this.btnToggle.TabIndex = 5;
            this.btnToggle.Text = "Enable";
            this.btnToggle.TextChanged += new System.EventHandler(this.btnToggle_TextChanged);
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Interval = 150;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // randomTB
            // 
            this.randomTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.randomTB.HoveredState.Parent = this.randomTB;
            this.randomTB.Location = new System.Drawing.Point(22, 253);
            this.randomTB.Maximum = 30;
            this.randomTB.Name = "randomTB";
            this.randomTB.Size = new System.Drawing.Size(300, 23);
            this.randomTB.TabIndex = 6;
            this.randomTB.ThumbColor = System.Drawing.Color.Red;
            this.randomTB.Value = 8;
            this.randomTB.Visible = false;
            this.randomTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.randomTB_Scroll);
            // 
            // bindBtn
            // 
            this.bindBtn.CheckedState.FillColor = System.Drawing.Color.Red;
            this.bindBtn.CheckedState.Parent = this.bindBtn;
            this.bindBtn.CustomImages.Parent = this.bindBtn;
            this.bindBtn.FillColor = System.Drawing.Color.LightCoral;
            this.bindBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindBtn.ForeColor = System.Drawing.Color.White;
            this.bindBtn.HoveredState.Parent = this.bindBtn;
            this.bindBtn.Location = new System.Drawing.Point(12, 106);
            this.bindBtn.Name = "bindBtn";
            this.bindBtn.ShadowDecoration.Parent = this.bindBtn;
            this.bindBtn.Size = new System.Drawing.Size(91, 29);
            this.bindBtn.TabIndex = 7;
            this.bindBtn.Text = "None";
            this.bindBtn.Click += new System.EventHandler(this.bindBtn_Click);
            this.bindBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bindBtn_KeyDown);
            // 
            // Binding
            // 
            this.Binding.Enabled = true;
            this.Binding.Tick += new System.EventHandler(this.Binding_Tick);
            // 
            // RMBclick
            // 
            this.RMBclick.AutoSize = true;
            this.RMBclick.CheckedState.BorderColor = System.Drawing.Color.LightCoral;
            this.RMBclick.CheckedState.BorderRadius = 2;
            this.RMBclick.CheckedState.BorderThickness = 0;
            this.RMBclick.CheckedState.FillColor = System.Drawing.Color.LightCoral;
            this.RMBclick.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMBclick.ForeColor = System.Drawing.Color.White;
            this.RMBclick.Location = new System.Drawing.Point(109, 69);
            this.RMBclick.Name = "RMBclick";
            this.RMBclick.Size = new System.Drawing.Size(61, 21);
            this.RMBclick.TabIndex = 8;
            this.RMBclick.Text = "RMB?";
            this.RMBclick.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RMBclick.UncheckedState.BorderRadius = 2;
            this.RMBclick.UncheckedState.BorderThickness = 0;
            this.RMBclick.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RMBclick.UseVisualStyleBackColor = true;
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.siticoneLabel3.Location = new System.Drawing.Point(22, 230);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(140, 17);
            this.siticoneLabel3.TabIndex = 9;
            this.siticoneLabel3.Text = "randomization visualized";
            this.siticoneLabel3.Visible = false;
            // 
            // randomtrackbar
            // 
            this.randomtrackbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.randomtrackbar.HoveredState.Parent = this.randomtrackbar;
            this.randomtrackbar.Location = new System.Drawing.Point(136, 201);
            this.randomtrackbar.Maximum = 6;
            this.randomtrackbar.Minimum = 1;
            this.randomtrackbar.Name = "randomtrackbar";
            this.randomtrackbar.Size = new System.Drawing.Size(192, 23);
            this.randomtrackbar.TabIndex = 10;
            this.randomtrackbar.ThumbColor = System.Drawing.Color.Red;
            this.randomtrackbar.Value = 6;
            this.randomtrackbar.Visible = false;
            this.randomtrackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.randomtrackbar_Scroll);
            // 
            // randometer
            // 
            this.randometer.BackColor = System.Drawing.Color.Transparent;
            this.randometer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randometer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.randometer.Location = new System.Drawing.Point(349, 181);
            this.randometer.Name = "randometer";
            this.randometer.Size = new System.Drawing.Size(9, 15);
            this.randometer.TabIndex = 11;
            this.randometer.Text = "4";
            this.randometer.Visible = false;
            // 
            // siticoneLabel5
            // 
            this.siticoneLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.siticoneLabel5.Location = new System.Drawing.Point(15, 203);
            this.siticoneLabel5.Name = "siticoneLabel5";
            this.siticoneLabel5.Size = new System.Drawing.Size(115, 17);
            this.siticoneLabel5.TabIndex = 12;
            this.siticoneLabel5.Text = "Click Randomization";
            this.siticoneLabel5.Visible = false;
            // 
            // siticoneLabel4
            // 
            this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.siticoneLabel4.Location = new System.Drawing.Point(201, 230);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(73, 17);
            this.siticoneLabel4.TabIndex = 13;
            this.siticoneLabel4.Text = "Current CPS:";
            this.siticoneLabel4.Visible = false;
            // 
            // CPSvalue2
            // 
            this.CPSvalue2.BackColor = System.Drawing.Color.Transparent;
            this.CPSvalue2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPSvalue2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CPSvalue2.Location = new System.Drawing.Point(280, 230);
            this.CPSvalue2.Name = "CPSvalue2";
            this.CPSvalue2.Size = new System.Drawing.Size(9, 15);
            this.CPSvalue2.TabIndex = 14;
            this.CPSvalue2.Text = "4";
            this.CPSvalue2.Visible = false;
            this.CPSvalue2.Click += new System.EventHandler(this.CPSvalue2_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.ButtonMode = ns5.ButtonMode.ToogleButton;
            this.siticoneButton1.CheckedState.FillColor = System.Drawing.Color.Red;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.LightCoral;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(212, 69);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(62, 31);
            this.siticoneButton1.TabIndex = 15;
            this.siticoneButton1.Text = "Destruct";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // CPSTrackbar1
            // 
            this.CPSTrackbar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.CPSTrackbar1.Location = new System.Drawing.Point(12, 170);
            this.CPSTrackbar1.Maximum = 20;
            this.CPSTrackbar1.Minimum = 6;
            this.CPSTrackbar1.Name = "CPSTrackbar1";
            this.CPSTrackbar1.Size = new System.Drawing.Size(262, 23);
            this.CPSTrackbar1.TabIndex = 17;
            this.CPSTrackbar1.ThumbColor = System.Drawing.Color.Red;
            this.CPSTrackbar1.Value = 8;
            this.CPSTrackbar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(286, 199);
            this.Controls.Add(this.CPSTrackbar1);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.CPSvalue2);
            this.Controls.Add(this.siticoneLabel4);
            this.Controls.Add(this.siticoneLabel5);
            this.Controls.Add(this.randometer);
            this.Controls.Add(this.randomtrackbar);
            this.Controls.Add(this.siticoneLabel3);
            this.Controls.Add(this.RMBclick);
            this.Controls.Add(this.bindBtn);
            this.Controls.Add(this.randomTB);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.CPSValue);
            this.Controls.Add(this.siticoneLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "Ruby V3";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.SiticoneLabel siticoneLabel2;
        private ns1.SiticoneLabel CPSValue;
        private System.Windows.Forms.Timer Autoclicker;
        private ns1.SiticoneButton btnToggle;
        private System.Windows.Forms.Timer Random;
        private ns1.SiticoneMetroTrackBar randomTB;
        private ns1.SiticoneButton bindBtn;
        private System.Windows.Forms.Timer Binding;
        private ns1.SiticoneCheckBox RMBclick;
        private ns1.SiticoneLabel siticoneLabel3;
        private ns1.SiticoneMetroTrackBar randomtrackbar;
        private ns1.SiticoneLabel randometer;
        private ns1.SiticoneLabel siticoneLabel5;
        private ns1.SiticoneLabel siticoneLabel4;
        private ns1.SiticoneLabel CPSvalue2;
        private ns1.SiticoneButton siticoneButton1;
        private ns1.SiticoneMetroTrackBar CPSTrackbar1;
    }
}

