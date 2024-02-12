using System.Windows.Forms;

namespace Telefono_de_rosalia
{
    partial class RosaliaTelefonoForm
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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NullButton = new System.Windows.Forms.Button();
            this.InvisibleButton = new System.Windows.Forms.Button();
            this.Number_1_Button = new System.Windows.Forms.Button();
            this.RosaliaDancePictureBox = new System.Windows.Forms.PictureBox();
            this.TelefonoPictureBox = new System.Windows.Forms.PictureBox();
            this.Number_2_Button = new System.Windows.Forms.Button();
            this.Number_3_Button = new System.Windows.Forms.Button();
            this.Number_4_Button = new System.Windows.Forms.Button();
            this.Number_5_Button = new System.Windows.Forms.Button();
            this.Number_6_Button = new System.Windows.Forms.Button();
            this.Number_7_Button = new System.Windows.Forms.Button();
            this.Number_8_Button = new System.Windows.Forms.Button();
            this.Number_9_Button = new System.Windows.Forms.Button();
            this.Number_0_Button = new System.Windows.Forms.Button();
            this.Number_Asterisk_Button = new System.Windows.Forms.Button();
            this.Number_Hashtag_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RosaliaDancePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NullButton
            // 
            this.NullButton.BackColor = System.Drawing.Color.Transparent;
            this.NullButton.FlatAppearance.BorderSize = 0;
            this.NullButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NullButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NullButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NullButton.ForeColor = System.Drawing.Color.Transparent;
            this.NullButton.Location = new System.Drawing.Point(90, 380);
            this.NullButton.Name = "NullButton";
            this.NullButton.Size = new System.Drawing.Size(49, 54);
            this.NullButton.TabIndex = 1;
            this.NullButton.UseVisualStyleBackColor = false;
            this.NullButton.Click += new System.EventHandler(this.NullButton_Click);
            // 
            // InvisibleButton
            // 
            this.InvisibleButton.BackColor = System.Drawing.Color.Transparent;
            this.InvisibleButton.FlatAppearance.BorderSize = 0;
            this.InvisibleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvisibleButton.Location = new System.Drawing.Point(331, 38);
            this.InvisibleButton.Name = "InvisibleButton";
            this.InvisibleButton.Size = new System.Drawing.Size(28, 28);
            this.InvisibleButton.TabIndex = 0;
            this.InvisibleButton.UseVisualStyleBackColor = false;
            // 
            // Number_1_Button
            // 
            this.Number_1_Button.BackColor = System.Drawing.Color.Transparent;
            this.Number_1_Button.FlatAppearance.BorderSize = 0;
            this.Number_1_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Number_1_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Number_1_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Number_1_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Number_1_Button.Location = new System.Drawing.Point(81, 458);
            this.Number_1_Button.Name = "Number_1_Button";
            this.Number_1_Button.Size = new System.Drawing.Size(49, 39);
            this.Number_1_Button.TabIndex = 5;
            this.Number_1_Button.UseVisualStyleBackColor = false;
            // 
            // RosaliaDancePictureBox
            // 
            this.RosaliaDancePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RosaliaDancePictureBox.Location = new System.Drawing.Point(81, 183);
            this.RosaliaDancePictureBox.Name = "RosaliaDancePictureBox";
            this.RosaliaDancePictureBox.Size = new System.Drawing.Size(216, 158);
            this.RosaliaDancePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RosaliaDancePictureBox.TabIndex = 2;
            this.RosaliaDancePictureBox.TabStop = false;
            this.RosaliaDancePictureBox.Visible = false;
            this.RosaliaDancePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RosaliaDancePictureBox_MouseDown);
            this.RosaliaDancePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RosaliaDancePictureBox_MouseMove);
            this.RosaliaDancePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RosaliaDancePictureBox_MouseUp);
            // 
            // TelefonoPictureBox
            // 
            this.TelefonoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TelefonoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TelefonoPictureBox.Image = global::Telefono_de_rosalia.Properties.Resources.Nokiarosalico;
            this.TelefonoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.TelefonoPictureBox.Name = "TelefonoPictureBox";
            this.TelefonoPictureBox.Size = new System.Drawing.Size(371, 704);
            this.TelefonoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TelefonoPictureBox.TabIndex = 0;
            this.TelefonoPictureBox.TabStop = false;
            this.TelefonoPictureBox.WaitOnLoad = true;
            this.TelefonoPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TelefonoPictureBox_MouseDown);
            this.TelefonoPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TelefonoPictureBox_MouseMove);
            this.TelefonoPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TelefonoPictureBox_MouseUp);
            // 
            // Number_2_Button
            // 
            this.Number_2_Button.BackColor = System.Drawing.Color.Transparent;
            this.Number_2_Button.FlatAppearance.BorderSize = 0;
            this.Number_2_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Number_2_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Number_2_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Number_2_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Number_2_Button.Location = new System.Drawing.Point(160, 469);
            this.Number_2_Button.Name = "Number_2_Button";
            this.Number_2_Button.Size = new System.Drawing.Size(58, 37);
            this.Number_2_Button.TabIndex = 6;
            this.Number_2_Button.UseVisualStyleBackColor = false;
            // 
            // Number_3_Button
            // 
            this.Number_3_Button.BackColor = System.Drawing.Color.Transparent;
            this.Number_3_Button.FlatAppearance.BorderSize = 0;
            this.Number_3_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Number_3_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Number_3_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Number_3_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Number_3_Button.Location = new System.Drawing.Point(248, 458);
            this.Number_3_Button.Name = "Number_3_Button";
            this.Number_3_Button.Size = new System.Drawing.Size(58, 37);
            this.Number_3_Button.TabIndex = 7;
            this.Number_3_Button.UseVisualStyleBackColor = false;
            // 
            // Number_4_Button
            // 
            this.Number_4_Button.BackColor = System.Drawing.Color.Transparent;
            this.Number_4_Button.FlatAppearance.BorderSize = 0;
            this.Number_4_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Number_4_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Number_4_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Number_4_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Number_4_Button.Location = new System.Drawing.Point(81, 504);
            this.Number_4_Button.Name = "Number_4_Button";
            this.Number_4_Button.Size = new System.Drawing.Size(58, 37);
            this.Number_4_Button.TabIndex = 8;
            this.Number_4_Button.UseVisualStyleBackColor = false;
            // 
            // Number_5_Button
            // 
            this.Number_5_Button.BackColor = System.Drawing.Color.Transparent;
            this.Number_5_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Number_5_Button.FlatAppearance.BorderSize = 0;
            this.Number_5_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Number_5_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Number_5_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Number_5_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Number_5_Button.Location = new System.Drawing.Point(161, 514);
            this.Number_5_Button.Name = "Number_5_Button";
            this.Number_5_Button.Size = new System.Drawing.Size(58, 37);
            this.Number_5_Button.TabIndex = 9;
            this.Number_5_Button.UseVisualStyleBackColor = false;
            // 
            // Number_6_Button
            // 
            this.Number_6_Button.BackColor = System.Drawing.Color.Transparent;
            this.Number_6_Button.FlatAppearance.BorderSize = 0;
            this.Number_6_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Number_6_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Number_6_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Number_6_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Number_6_Button.Location = new System.Drawing.Point(248, 504);
            this.Number_6_Button.Name = "Number_6_Button";
            this.Number_6_Button.Size = new System.Drawing.Size(58, 37);
            this.Number_6_Button.TabIndex = 10;
            this.Number_6_Button.UseVisualStyleBackColor = false;
            // 
            // Number_7_Button
            // 
            this.Number_7_Button.BackColor = System.Drawing.Color.Transparent;
            this.Number_7_Button.FlatAppearance.BorderSize = 0;
            this.Number_7_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Number_7_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Number_7_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Number_7_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Number_7_Button.Location = new System.Drawing.Point(81, 556);
            this.Number_7_Button.Name = "Number_7_Button";
            this.Number_7_Button.Size = new System.Drawing.Size(58, 37);
            this.Number_7_Button.TabIndex = 11;
            this.Number_7_Button.UseVisualStyleBackColor = false;
            // 
            // Number_8_Button
            // 
            this.Number_8_Button.BackColor = System.Drawing.Color.Transparent;
            this.Number_8_Button.FlatAppearance.BorderSize = 0;
            this.Number_8_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Number_8_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Number_8_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Number_8_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Number_8_Button.Location = new System.Drawing.Point(161, 567);
            this.Number_8_Button.Name = "Number_8_Button";
            this.Number_8_Button.Size = new System.Drawing.Size(58, 37);
            this.Number_8_Button.TabIndex = 12;
            this.Number_8_Button.UseVisualStyleBackColor = false;
            // 
            // Number_9_Button
            // 
            this.Number_9_Button.BackColor = System.Drawing.Color.Transparent;
            this.Number_9_Button.FlatAppearance.BorderSize = 0;
            this.Number_9_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Number_9_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Number_9_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Number_9_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Number_9_Button.Location = new System.Drawing.Point(239, 547);
            this.Number_9_Button.Name = "Number_9_Button";
            this.Number_9_Button.Size = new System.Drawing.Size(58, 46);
            this.Number_9_Button.TabIndex = 13;
            this.Number_9_Button.UseVisualStyleBackColor = false;
            // 
            // Number_0_Button
            // 
            this.Number_0_Button.BackColor = System.Drawing.Color.Transparent;
            this.Number_0_Button.FlatAppearance.BorderSize = 0;
            this.Number_0_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Number_0_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Number_0_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Number_0_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Number_0_Button.Location = new System.Drawing.Point(161, 610);
            this.Number_0_Button.Name = "Number_0_Button";
            this.Number_0_Button.Size = new System.Drawing.Size(58, 37);
            this.Number_0_Button.TabIndex = 14;
            this.Number_0_Button.UseVisualStyleBackColor = false;
            // 
            // Number_Asterisk_Button
            // 
            this.Number_Asterisk_Button.BackColor = System.Drawing.Color.Transparent;
            this.Number_Asterisk_Button.FlatAppearance.BorderSize = 0;
            this.Number_Asterisk_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Number_Asterisk_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Number_Asterisk_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Number_Asterisk_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Number_Asterisk_Button.Location = new System.Drawing.Point(81, 599);
            this.Number_Asterisk_Button.Name = "Number_Asterisk_Button";
            this.Number_Asterisk_Button.Size = new System.Drawing.Size(66, 39);
            this.Number_Asterisk_Button.TabIndex = 15;
            this.Number_Asterisk_Button.UseVisualStyleBackColor = false;
            // 
            // Number_Hashtag_Button
            // 
            this.Number_Hashtag_Button.BackColor = System.Drawing.Color.Transparent;
            this.Number_Hashtag_Button.FlatAppearance.BorderSize = 0;
            this.Number_Hashtag_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Number_Hashtag_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Number_Hashtag_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Number_Hashtag_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Number_Hashtag_Button.Location = new System.Drawing.Point(239, 599);
            this.Number_Hashtag_Button.Name = "Number_Hashtag_Button";
            this.Number_Hashtag_Button.Size = new System.Drawing.Size(58, 46);
            this.Number_Hashtag_Button.TabIndex = 16;
            this.Number_Hashtag_Button.UseVisualStyleBackColor = false;
            // 
            // RosaliaTelefonoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(371, 704);
            this.ControlBox = false;
            this.Controls.Add(this.Number_Hashtag_Button);
            this.Controls.Add(this.Number_Asterisk_Button);
            this.Controls.Add(this.Number_0_Button);
            this.Controls.Add(this.Number_9_Button);
            this.Controls.Add(this.Number_8_Button);
            this.Controls.Add(this.Number_7_Button);
            this.Controls.Add(this.Number_6_Button);
            this.Controls.Add(this.Number_5_Button);
            this.Controls.Add(this.Number_4_Button);
            this.Controls.Add(this.Number_2_Button);
            this.Controls.Add(this.Number_3_Button);
            this.Controls.Add(this.Number_1_Button);
            this.Controls.Add(this.RosaliaDancePictureBox);
            this.Controls.Add(this.NullButton);
            this.Controls.Add(this.TelefonoPictureBox);
            this.Controls.Add(this.InvisibleButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RosaliaTelefonoForm";
            this.ShowInTaskbar = false;
            this.Text = "Telefono de rosalia";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RosaliaTelefonoForm_FormClosing);
            this.Load += new System.EventHandler(this.RosaliaTelefonoForm_Load);
            this.Shown += new System.EventHandler(this.RosaliaTelefonoForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.RosaliaDancePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TelefonoPictureBox;
        private System.Windows.Forms.Button NullButton;
        private System.Windows.Forms.PictureBox RosaliaDancePictureBox;
        private System.Windows.Forms.Button InvisibleButton;
        private System.Windows.Forms.Button Number_1_Button;
        private System.Windows.Forms.Button Number_2_Button;
        private System.Windows.Forms.Button Number_3_Button;
        private System.Windows.Forms.Button Number_4_Button;
        private System.Windows.Forms.Button Number_6_Button;
        private System.Windows.Forms.Button Number_7_Button;
        private System.Windows.Forms.Button Number_8_Button;
        private System.Windows.Forms.Button Number_9_Button;
        private System.Windows.Forms.Button Number_0_Button;
        private System.Windows.Forms.Button Number_Asterisk_Button;
        private System.Windows.Forms.Button Number_Hashtag_Button;
        private System.Windows.Forms.Button Number_5_Button;
    }
}

