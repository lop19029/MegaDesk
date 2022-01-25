namespace MegaDesk
{
    partial class AddQuote
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
            this.backMenuBtn = new System.Windows.Forms.Button();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.drawersInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.makeQuoteBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.clientNameInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.rushOptionInput = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.surfaceInput = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // backMenuBtn
            // 
            this.backMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backMenuBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backMenuBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backMenuBtn.Location = new System.Drawing.Point(161, 313);
            this.backMenuBtn.Name = "backMenuBtn";
            this.backMenuBtn.Size = new System.Drawing.Size(116, 36);
            this.backMenuBtn.TabIndex = 0;
            this.backMenuBtn.Text = "Back to menu";
            this.backMenuBtn.UseVisualStyleBackColor = false;
            this.backMenuBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // widthInput
            // 
            this.widthInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.widthInput.Location = new System.Drawing.Point(97, 208);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(99, 29);
            this.widthInput.TabIndex = 1;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Make a Quote";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depth";
            // 
            // depthInput
            // 
            this.depthInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depthInput.Location = new System.Drawing.Point(97, 253);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(99, 29);
            this.depthInput.TabIndex = 4;
            this.depthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthInput_KeyPress);
            this.depthInput.Validating += new System.ComponentModel.CancelEventHandler(this.depthInput_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(266, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of Drawers";
            // 
            // drawersInput
            // 
            this.drawersInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drawersInput.Location = new System.Drawing.Point(420, 208);
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(128, 29);
            this.drawersInput.TabIndex = 6;
            this.drawersInput.Validating += new System.ComponentModel.CancelEventHandler(this.drawersInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(266, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Surface Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(39, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Customize your desk";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // makeQuoteBtn
            // 
            this.makeQuoteBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.makeQuoteBtn.Enabled = false;
            this.makeQuoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeQuoteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.makeQuoteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.makeQuoteBtn.Location = new System.Drawing.Point(39, 313);
            this.makeQuoteBtn.Name = "makeQuoteBtn";
            this.makeQuoteBtn.Size = new System.Drawing.Size(116, 36);
            this.makeQuoteBtn.TabIndex = 11;
            this.makeQuoteBtn.Text = "Make quote";
            this.makeQuoteBtn.UseVisualStyleBackColor = false;
            this.makeQuoteBtn.Click += new System.EventHandler(this.makeQuoteBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(39, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Client name";
            // 
            // clientNameInput
            // 
            this.clientNameInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientNameInput.Location = new System.Drawing.Point(146, 54);
            this.clientNameInput.Name = "clientNameInput";
            this.clientNameInput.Size = new System.Drawing.Size(402, 29);
            this.clientNameInput.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(39, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Deliver in";
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // rushOptionInput
            // 
            this.rushOptionInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rushOptionInput.FormattingEnabled = true;
            this.rushOptionInput.Location = new System.Drawing.Point(146, 100);
            this.rushOptionInput.Name = "rushOptionInput";
            this.rushOptionInput.Size = new System.Drawing.Size(119, 29);
            this.rushOptionInput.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(271, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "days.";
            // 
            // surfaceInput
            // 
            this.surfaceInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surfaceInput.FormattingEnabled = true;
            this.surfaceInput.Location = new System.Drawing.Point(420, 253);
            this.surfaceInput.Name = "surfaceInput";
            this.surfaceInput.Size = new System.Drawing.Size(128, 29);
            this.surfaceInput.TabIndex = 17;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.surfaceInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rushOptionInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clientNameInput);
            this.Controls.Add(this.makeQuoteBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.backMenuBtn);
            this.MaximizeBox = false;
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backMenuBtn;
        private TextBox widthInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox depthInput;
        private Label label4;
        private TextBox drawersInput;
        private Label label5;
        private Label label6;
        private Button makeQuoteBtn;
        private Label label7;
        private TextBox clientNameInput;
        private Label label8;
        private ErrorProvider errorProviderApp;
        private ComboBox rushOptionInput;
        private Label label9;
        private ComboBox surfaceInput;
    }
}