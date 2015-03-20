namespace CharacterEditor
{
    partial class CharacterEditor
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.HumorLabel = new System.Windows.Forms.Label();
            this.InteligenceLabel = new System.Windows.Forms.Label();
            this.EnergyLabel = new System.Windows.Forms.Label();
            this.WitLabel = new System.Windows.Forms.Label();
            this.CharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.HumorTextBox = new System.Windows.Forms.TextBox();
            this.InteligenceTextBox = new System.Windows.Forms.TextBox();
            this.EnergyTextBox = new System.Windows.Forms.TextBox();
            this.WitTextBox = new System.Windows.Forms.TextBox();
            this.CharacterClassGroupBox = new System.Windows.Forms.GroupBox();
            this.CoffeeGuyButton = new System.Windows.Forms.RadioButton();
            this.WittyGuyButton = new System.Windows.Forms.RadioButton();
            this.SmartassGuyButton = new System.Windows.Forms.RadioButton();
            this.LowJokesGuyButton = new System.Windows.Forms.RadioButton();
            this.StatChangesGroupBox = new System.Windows.Forms.GroupBox();
            this.IncreasedStatGroupBox = new System.Windows.Forms.GroupBox();
            this.IncreaseWitButton = new System.Windows.Forms.RadioButton();
            this.IncreaseEnergyButton = new System.Windows.Forms.RadioButton();
            this.IncreaseInteligenceButton = new System.Windows.Forms.RadioButton();
            this.IncreaseHumorButton = new System.Windows.Forms.RadioButton();
            this.DecreasedStatGroupBox = new System.Windows.Forms.GroupBox();
            this.DecreaseWitButton = new System.Windows.Forms.RadioButton();
            this.DecreaseEnergyButton = new System.Windows.Forms.RadioButton();
            this.DecreaseInteligenceButton = new System.Windows.Forms.RadioButton();
            this.DecreaseHumorButton = new System.Windows.Forms.RadioButton();
            this.CreateCharacterButton = new System.Windows.Forms.Button();
            this.WriteProgressBar = new System.Windows.Forms.ProgressBar();
            this.CharacterClassGroupBox.SuspendLayout();
            this.StatChangesGroupBox.SuspendLayout();
            this.IncreasedStatGroupBox.SuspendLayout();
            this.DecreasedStatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(87, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Character Name:";
            // 
            // HumorLabel
            // 
            this.HumorLabel.AutoSize = true;
            this.HumorLabel.Location = new System.Drawing.Point(6, 22);
            this.HumorLabel.Name = "HumorLabel";
            this.HumorLabel.Size = new System.Drawing.Size(41, 13);
            this.HumorLabel.TabIndex = 1;
            this.HumorLabel.Text = "Humor:";
            // 
            // InteligenceLabel
            // 
            this.InteligenceLabel.AutoSize = true;
            this.InteligenceLabel.Location = new System.Drawing.Point(6, 49);
            this.InteligenceLabel.Name = "InteligenceLabel";
            this.InteligenceLabel.Size = new System.Drawing.Size(62, 13);
            this.InteligenceLabel.TabIndex = 2;
            this.InteligenceLabel.Text = "Inteligence:";
            // 
            // EnergyLabel
            // 
            this.EnergyLabel.AutoSize = true;
            this.EnergyLabel.Location = new System.Drawing.Point(6, 76);
            this.EnergyLabel.Name = "EnergyLabel";
            this.EnergyLabel.Size = new System.Drawing.Size(46, 13);
            this.EnergyLabel.TabIndex = 3;
            this.EnergyLabel.Text = "Energy: ";
            // 
            // WitLabel
            // 
            this.WitLabel.AutoSize = true;
            this.WitLabel.Location = new System.Drawing.Point(6, 103);
            this.WitLabel.Name = "WitLabel";
            this.WitLabel.Size = new System.Drawing.Size(26, 13);
            this.WitLabel.TabIndex = 4;
            this.WitLabel.Text = "Wit:";
            // 
            // CharacterNameTextBox
            // 
            this.CharacterNameTextBox.Location = new System.Drawing.Point(105, 12);
            this.CharacterNameTextBox.Name = "CharacterNameTextBox";
            this.CharacterNameTextBox.Size = new System.Drawing.Size(274, 20);
            this.CharacterNameTextBox.TabIndex = 5;
            // 
            // HumorTextBox
            // 
            this.HumorTextBox.Location = new System.Drawing.Point(80, 19);
            this.HumorTextBox.Name = "HumorTextBox";
            this.HumorTextBox.Size = new System.Drawing.Size(28, 20);
            this.HumorTextBox.TabIndex = 6;
            this.HumorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InteligenceTextBox
            // 
            this.InteligenceTextBox.Location = new System.Drawing.Point(80, 46);
            this.InteligenceTextBox.Name = "InteligenceTextBox";
            this.InteligenceTextBox.Size = new System.Drawing.Size(28, 20);
            this.InteligenceTextBox.TabIndex = 7;
            this.InteligenceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EnergyTextBox
            // 
            this.EnergyTextBox.Location = new System.Drawing.Point(80, 73);
            this.EnergyTextBox.Name = "EnergyTextBox";
            this.EnergyTextBox.Size = new System.Drawing.Size(28, 20);
            this.EnergyTextBox.TabIndex = 8;
            this.EnergyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WitTextBox
            // 
            this.WitTextBox.Location = new System.Drawing.Point(80, 100);
            this.WitTextBox.Name = "WitTextBox";
            this.WitTextBox.Size = new System.Drawing.Size(28, 20);
            this.WitTextBox.TabIndex = 9;
            this.WitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CharacterClassGroupBox
            // 
            this.CharacterClassGroupBox.Controls.Add(this.CoffeeGuyButton);
            this.CharacterClassGroupBox.Controls.Add(this.WittyGuyButton);
            this.CharacterClassGroupBox.Controls.Add(this.SmartassGuyButton);
            this.CharacterClassGroupBox.Controls.Add(this.LowJokesGuyButton);
            this.CharacterClassGroupBox.Location = new System.Drawing.Point(12, 38);
            this.CharacterClassGroupBox.Name = "CharacterClassGroupBox";
            this.CharacterClassGroupBox.Size = new System.Drawing.Size(367, 42);
            this.CharacterClassGroupBox.TabIndex = 10;
            this.CharacterClassGroupBox.TabStop = false;
            this.CharacterClassGroupBox.Text = "Character Class";
            // 
            // CoffeeGuyButton
            // 
            this.CoffeeGuyButton.AutoSize = true;
            this.CoffeeGuyButton.Location = new System.Drawing.Point(283, 19);
            this.CoffeeGuyButton.Name = "CoffeeGuyButton";
            this.CoffeeGuyButton.Size = new System.Drawing.Size(78, 17);
            this.CoffeeGuyButton.TabIndex = 3;
            this.CoffeeGuyButton.Text = "Coffee Guy";
            this.CoffeeGuyButton.UseVisualStyleBackColor = true;
            // 
            // WittyGuyButton
            // 
            this.WittyGuyButton.AutoSize = true;
            this.WittyGuyButton.Location = new System.Drawing.Point(206, 19);
            this.WittyGuyButton.Name = "WittyGuyButton";
            this.WittyGuyButton.Size = new System.Drawing.Size(71, 17);
            this.WittyGuyButton.TabIndex = 2;
            this.WittyGuyButton.Text = "Witty Guy";
            this.WittyGuyButton.UseVisualStyleBackColor = true;
            // 
            // SmartassGuyButton
            // 
            this.SmartassGuyButton.AutoSize = true;
            this.SmartassGuyButton.Checked = true;
            this.SmartassGuyButton.Location = new System.Drawing.Point(6, 19);
            this.SmartassGuyButton.Name = "SmartassGuyButton";
            this.SmartassGuyButton.Size = new System.Drawing.Size(90, 17);
            this.SmartassGuyButton.TabIndex = 0;
            this.SmartassGuyButton.TabStop = true;
            this.SmartassGuyButton.Text = "Smartass Guy";
            this.SmartassGuyButton.UseVisualStyleBackColor = true;
            // 
            // LowJokesGuyButton
            // 
            this.LowJokesGuyButton.AutoSize = true;
            this.LowJokesGuyButton.Location = new System.Drawing.Point(102, 19);
            this.LowJokesGuyButton.Name = "LowJokesGuyButton";
            this.LowJokesGuyButton.Size = new System.Drawing.Size(98, 17);
            this.LowJokesGuyButton.TabIndex = 1;
            this.LowJokesGuyButton.Text = "Low Jokes Guy";
            this.LowJokesGuyButton.UseVisualStyleBackColor = true;
            // 
            // StatChangesGroupBox
            // 
            this.StatChangesGroupBox.Controls.Add(this.HumorLabel);
            this.StatChangesGroupBox.Controls.Add(this.InteligenceLabel);
            this.StatChangesGroupBox.Controls.Add(this.WitTextBox);
            this.StatChangesGroupBox.Controls.Add(this.EnergyLabel);
            this.StatChangesGroupBox.Controls.Add(this.EnergyTextBox);
            this.StatChangesGroupBox.Controls.Add(this.WitLabel);
            this.StatChangesGroupBox.Controls.Add(this.InteligenceTextBox);
            this.StatChangesGroupBox.Controls.Add(this.HumorTextBox);
            this.StatChangesGroupBox.Location = new System.Drawing.Point(12, 86);
            this.StatChangesGroupBox.Name = "StatChangesGroupBox";
            this.StatChangesGroupBox.Size = new System.Drawing.Size(114, 126);
            this.StatChangesGroupBox.TabIndex = 11;
            this.StatChangesGroupBox.TabStop = false;
            this.StatChangesGroupBox.Text = "Stat Changes";
            // 
            // IncreasedStatGroupBox
            // 
            this.IncreasedStatGroupBox.Controls.Add(this.IncreaseWitButton);
            this.IncreasedStatGroupBox.Controls.Add(this.IncreaseEnergyButton);
            this.IncreasedStatGroupBox.Controls.Add(this.IncreaseInteligenceButton);
            this.IncreasedStatGroupBox.Controls.Add(this.IncreaseHumorButton);
            this.IncreasedStatGroupBox.Location = new System.Drawing.Point(157, 86);
            this.IncreasedStatGroupBox.Name = "IncreasedStatGroupBox";
            this.IncreasedStatGroupBox.Size = new System.Drawing.Size(90, 111);
            this.IncreasedStatGroupBox.TabIndex = 12;
            this.IncreasedStatGroupBox.TabStop = false;
            this.IncreasedStatGroupBox.Text = "Increased Stat";
            // 
            // IncreaseWitButton
            // 
            this.IncreaseWitButton.AutoSize = true;
            this.IncreaseWitButton.Location = new System.Drawing.Point(6, 88);
            this.IncreaseWitButton.Name = "IncreaseWitButton";
            this.IncreaseWitButton.Size = new System.Drawing.Size(41, 17);
            this.IncreaseWitButton.TabIndex = 3;
            this.IncreaseWitButton.Text = "Wit";
            this.IncreaseWitButton.UseVisualStyleBackColor = true;
            // 
            // IncreaseEnergyButton
            // 
            this.IncreaseEnergyButton.AutoSize = true;
            this.IncreaseEnergyButton.Location = new System.Drawing.Point(6, 65);
            this.IncreaseEnergyButton.Name = "IncreaseEnergyButton";
            this.IncreaseEnergyButton.Size = new System.Drawing.Size(58, 17);
            this.IncreaseEnergyButton.TabIndex = 2;
            this.IncreaseEnergyButton.Text = "Energy";
            this.IncreaseEnergyButton.UseVisualStyleBackColor = true;
            // 
            // IncreaseInteligenceButton
            // 
            this.IncreaseInteligenceButton.AutoSize = true;
            this.IncreaseInteligenceButton.Location = new System.Drawing.Point(6, 42);
            this.IncreaseInteligenceButton.Name = "IncreaseInteligenceButton";
            this.IncreaseInteligenceButton.Size = new System.Drawing.Size(77, 17);
            this.IncreaseInteligenceButton.TabIndex = 1;
            this.IncreaseInteligenceButton.Text = "Inteligence";
            this.IncreaseInteligenceButton.UseVisualStyleBackColor = true;
            // 
            // IncreaseHumorButton
            // 
            this.IncreaseHumorButton.AutoSize = true;
            this.IncreaseHumorButton.Checked = true;
            this.IncreaseHumorButton.Location = new System.Drawing.Point(6, 19);
            this.IncreaseHumorButton.Name = "IncreaseHumorButton";
            this.IncreaseHumorButton.Size = new System.Drawing.Size(56, 17);
            this.IncreaseHumorButton.TabIndex = 0;
            this.IncreaseHumorButton.TabStop = true;
            this.IncreaseHumorButton.Text = "Humor";
            this.IncreaseHumorButton.UseVisualStyleBackColor = true;
            // 
            // DecreasedStatGroupBox
            // 
            this.DecreasedStatGroupBox.Controls.Add(this.DecreaseWitButton);
            this.DecreasedStatGroupBox.Controls.Add(this.DecreaseEnergyButton);
            this.DecreasedStatGroupBox.Controls.Add(this.DecreaseInteligenceButton);
            this.DecreasedStatGroupBox.Controls.Add(this.DecreaseHumorButton);
            this.DecreasedStatGroupBox.Location = new System.Drawing.Point(253, 86);
            this.DecreasedStatGroupBox.Name = "DecreasedStatGroupBox";
            this.DecreasedStatGroupBox.Size = new System.Drawing.Size(95, 111);
            this.DecreasedStatGroupBox.TabIndex = 13;
            this.DecreasedStatGroupBox.TabStop = false;
            this.DecreasedStatGroupBox.Text = "Decreased Stat";
            // 
            // DecreaseWitButton
            // 
            this.DecreaseWitButton.AutoSize = true;
            this.DecreaseWitButton.Location = new System.Drawing.Point(6, 88);
            this.DecreaseWitButton.Name = "DecreaseWitButton";
            this.DecreaseWitButton.Size = new System.Drawing.Size(41, 17);
            this.DecreaseWitButton.TabIndex = 3;
            this.DecreaseWitButton.Text = "Wit";
            this.DecreaseWitButton.UseVisualStyleBackColor = true;
            // 
            // DecreaseEnergyButton
            // 
            this.DecreaseEnergyButton.AutoSize = true;
            this.DecreaseEnergyButton.Location = new System.Drawing.Point(6, 65);
            this.DecreaseEnergyButton.Name = "DecreaseEnergyButton";
            this.DecreaseEnergyButton.Size = new System.Drawing.Size(58, 17);
            this.DecreaseEnergyButton.TabIndex = 2;
            this.DecreaseEnergyButton.Text = "Energy";
            this.DecreaseEnergyButton.UseVisualStyleBackColor = true;
            // 
            // DecreaseInteligenceButton
            // 
            this.DecreaseInteligenceButton.AutoSize = true;
            this.DecreaseInteligenceButton.Location = new System.Drawing.Point(6, 42);
            this.DecreaseInteligenceButton.Name = "DecreaseInteligenceButton";
            this.DecreaseInteligenceButton.Size = new System.Drawing.Size(77, 17);
            this.DecreaseInteligenceButton.TabIndex = 1;
            this.DecreaseInteligenceButton.Text = "Inteligence";
            this.DecreaseInteligenceButton.UseVisualStyleBackColor = true;
            // 
            // DecreaseHumorButton
            // 
            this.DecreaseHumorButton.AutoSize = true;
            this.DecreaseHumorButton.Checked = true;
            this.DecreaseHumorButton.Location = new System.Drawing.Point(6, 19);
            this.DecreaseHumorButton.Name = "DecreaseHumorButton";
            this.DecreaseHumorButton.Size = new System.Drawing.Size(56, 17);
            this.DecreaseHumorButton.TabIndex = 0;
            this.DecreaseHumorButton.TabStop = true;
            this.DecreaseHumorButton.Text = "Humor";
            this.DecreaseHumorButton.UseVisualStyleBackColor = true;
            // 
            // CreateCharacterButton
            // 
            this.CreateCharacterButton.Location = new System.Drawing.Point(12, 218);
            this.CreateCharacterButton.Name = "CreateCharacterButton";
            this.CreateCharacterButton.Size = new System.Drawing.Size(114, 23);
            this.CreateCharacterButton.TabIndex = 14;
            this.CreateCharacterButton.Text = "Create Character";
            this.CreateCharacterButton.UseVisualStyleBackColor = true;
            this.CreateCharacterButton.Click += new System.EventHandler(this.CreateCharacterButton_Click);
            // 
            // WriteProgressBar
            // 
            this.WriteProgressBar.Location = new System.Drawing.Point(132, 218);
            this.WriteProgressBar.Name = "WriteProgressBar";
            this.WriteProgressBar.Size = new System.Drawing.Size(247, 23);
            this.WriteProgressBar.TabIndex = 15;
            // 
            // CharacterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 253);
            this.Controls.Add(this.WriteProgressBar);
            this.Controls.Add(this.CreateCharacterButton);
            this.Controls.Add(this.DecreasedStatGroupBox);
            this.Controls.Add(this.IncreasedStatGroupBox);
            this.Controls.Add(this.StatChangesGroupBox);
            this.Controls.Add(this.CharacterClassGroupBox);
            this.Controls.Add(this.CharacterNameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "CharacterEditor";
            this.ShowIcon = false;
            this.Text = "Character Editor";
            this.CharacterClassGroupBox.ResumeLayout(false);
            this.CharacterClassGroupBox.PerformLayout();
            this.StatChangesGroupBox.ResumeLayout(false);
            this.StatChangesGroupBox.PerformLayout();
            this.IncreasedStatGroupBox.ResumeLayout(false);
            this.IncreasedStatGroupBox.PerformLayout();
            this.DecreasedStatGroupBox.ResumeLayout(false);
            this.DecreasedStatGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label HumorLabel;
        private System.Windows.Forms.Label InteligenceLabel;
        private System.Windows.Forms.Label EnergyLabel;
        private System.Windows.Forms.Label WitLabel;
        private System.Windows.Forms.TextBox CharacterNameTextBox;
        private System.Windows.Forms.TextBox HumorTextBox;
        private System.Windows.Forms.TextBox InteligenceTextBox;
        private System.Windows.Forms.TextBox EnergyTextBox;
        private System.Windows.Forms.TextBox WitTextBox;
        private System.Windows.Forms.GroupBox CharacterClassGroupBox;
        private System.Windows.Forms.RadioButton CoffeeGuyButton;
        private System.Windows.Forms.RadioButton WittyGuyButton;
        private System.Windows.Forms.RadioButton SmartassGuyButton;
        private System.Windows.Forms.RadioButton LowJokesGuyButton;
        private System.Windows.Forms.GroupBox StatChangesGroupBox;
        private System.Windows.Forms.GroupBox IncreasedStatGroupBox;
        private System.Windows.Forms.RadioButton IncreaseWitButton;
        private System.Windows.Forms.RadioButton IncreaseEnergyButton;
        private System.Windows.Forms.RadioButton IncreaseInteligenceButton;
        private System.Windows.Forms.RadioButton IncreaseHumorButton;
        private System.Windows.Forms.GroupBox DecreasedStatGroupBox;
        private System.Windows.Forms.RadioButton DecreaseInteligenceButton;
        private System.Windows.Forms.RadioButton DecreaseHumorButton;
        private System.Windows.Forms.RadioButton DecreaseWitButton;
        private System.Windows.Forms.RadioButton DecreaseEnergyButton;
        private System.Windows.Forms.Button CreateCharacterButton;
        private System.Windows.Forms.ProgressBar WriteProgressBar;
    }
}

