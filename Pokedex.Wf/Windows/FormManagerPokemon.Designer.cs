namespace Pokedex.Wf.Windows
{
    partial class FormManagerPokemon
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
            listBoxPokemons = new ListBox();
            buttonAddPokemon = new Button();
            groupBoxUpdateDelete = new GroupBox();
            textBoxUpdatePokemonIdApi = new TextBox();
            labelUpdatePokemonIdApi = new Label();
            pictureBoxPokemon = new PictureBox();
            buttonDeletePokemon = new Button();
            buttonUpdatePokemon = new Button();
            labelUpdatePokemonElement = new Label();
            labelUpdatePokemonName = new Label();
            comboBoxUpdatePokemonElement = new ComboBox();
            textBoxUpdatePokemonName = new TextBox();
            groupBoxAdd = new GroupBox();
            buttonAddPokemonValidate = new Button();
            labelAddPokemonElement = new Label();
            labelAddPokemonName = new Label();
            comboBoxAddPokemonElement = new ComboBox();
            textBoxAddPokemonName = new TextBox();
            groupBoxUpdateDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).BeginInit();
            groupBoxAdd.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxPokemons
            // 
            listBoxPokemons.FormattingEnabled = true;
            listBoxPokemons.ItemHeight = 15;
            listBoxPokemons.Location = new Point(6, 6);
            listBoxPokemons.Name = "listBoxPokemons";
            listBoxPokemons.Size = new Size(190, 394);
            listBoxPokemons.TabIndex = 0;
            listBoxPokemons.SelectedIndexChanged += listBoxPokemons_SelectedIndexChanged;
            // 
            // buttonAddPokemon
            // 
            buttonAddPokemon.Location = new Point(5, 406);
            buttonAddPokemon.Name = "buttonAddPokemon";
            buttonAddPokemon.Size = new Size(191, 40);
            buttonAddPokemon.TabIndex = 1;
            buttonAddPokemon.Text = "Ajouter";
            buttonAddPokemon.UseVisualStyleBackColor = true;
            buttonAddPokemon.Click += buttonAddPokemon_Click;
            // 
            // groupBoxUpdateDelete
            // 
            groupBoxUpdateDelete.BackColor = Color.Transparent;
            groupBoxUpdateDelete.Controls.Add(textBoxUpdatePokemonIdApi);
            groupBoxUpdateDelete.Controls.Add(labelUpdatePokemonIdApi);
            groupBoxUpdateDelete.Controls.Add(pictureBoxPokemon);
            groupBoxUpdateDelete.Controls.Add(buttonDeletePokemon);
            groupBoxUpdateDelete.Controls.Add(buttonUpdatePokemon);
            groupBoxUpdateDelete.Controls.Add(labelUpdatePokemonElement);
            groupBoxUpdateDelete.Controls.Add(labelUpdatePokemonName);
            groupBoxUpdateDelete.Controls.Add(comboBoxUpdatePokemonElement);
            groupBoxUpdateDelete.Controls.Add(textBoxUpdatePokemonName);
            groupBoxUpdateDelete.Location = new Point(229, 12);
            groupBoxUpdateDelete.Name = "groupBoxUpdateDelete";
            groupBoxUpdateDelete.Size = new Size(568, 188);
            groupBoxUpdateDelete.TabIndex = 2;
            groupBoxUpdateDelete.TabStop = false;
            groupBoxUpdateDelete.Text = "Modification/Suppression";
            // 
            // textBoxUpdatePokemonIdApi
            // 
            textBoxUpdatePokemonIdApi.Location = new Point(181, 94);
            textBoxUpdatePokemonIdApi.Name = "textBoxUpdatePokemonIdApi";
            textBoxUpdatePokemonIdApi.Size = new Size(162, 23);
            textBoxUpdatePokemonIdApi.TabIndex = 7;
            // 
            // labelUpdatePokemonIdApi
            // 
            labelUpdatePokemonIdApi.AutoSize = true;
            labelUpdatePokemonIdApi.Location = new Point(125, 100);
            labelUpdatePokemonIdApi.Name = "labelUpdatePokemonIdApi";
            labelUpdatePokemonIdApi.Size = new Size(47, 15);
            labelUpdatePokemonIdApi.TabIndex = 6;
            labelUpdatePokemonIdApi.Text = "Id API : ";
            // 
            // pictureBoxPokemon
            // 
            pictureBoxPokemon.Location = new Point(404, 22);
            pictureBoxPokemon.Name = "pictureBoxPokemon";
            pictureBoxPokemon.Size = new Size(155, 150);
            pictureBoxPokemon.TabIndex = 4;
            pictureBoxPokemon.TabStop = false;
            // 
            // buttonDeletePokemon
            // 
            buttonDeletePokemon.Location = new Point(185, 135);
            buttonDeletePokemon.Name = "buttonDeletePokemon";
            buttonDeletePokemon.Size = new Size(162, 37);
            buttonDeletePokemon.TabIndex = 5;
            buttonDeletePokemon.Text = "Supprimer";
            buttonDeletePokemon.UseVisualStyleBackColor = true;
            buttonDeletePokemon.Click += buttonDeletePokemon_Click;
            // 
            // buttonUpdatePokemon
            // 
            buttonUpdatePokemon.Location = new Point(15, 135);
            buttonUpdatePokemon.Name = "buttonUpdatePokemon";
            buttonUpdatePokemon.Size = new Size(162, 37);
            buttonUpdatePokemon.TabIndex = 4;
            buttonUpdatePokemon.Text = "Mettre à jour";
            buttonUpdatePokemon.UseVisualStyleBackColor = true;
            buttonUpdatePokemon.Click += buttonUpdatePokemon_Click;
            // 
            // labelUpdatePokemonElement
            // 
            labelUpdatePokemonElement.AutoSize = true;
            labelUpdatePokemonElement.Location = new Point(119, 65);
            labelUpdatePokemonElement.Name = "labelUpdatePokemonElement";
            labelUpdatePokemonElement.Size = new Size(59, 15);
            labelUpdatePokemonElement.TabIndex = 3;
            labelUpdatePokemonElement.Text = "Élément : ";
            // 
            // labelUpdatePokemonName
            // 
            labelUpdatePokemonName.AutoSize = true;
            labelUpdatePokemonName.Location = new Point(134, 30);
            labelUpdatePokemonName.Name = "labelUpdatePokemonName";
            labelUpdatePokemonName.Size = new Size(43, 15);
            labelUpdatePokemonName.TabIndex = 2;
            labelUpdatePokemonName.Text = "Nom : ";
            // 
            // comboBoxUpdatePokemonElement
            // 
            comboBoxUpdatePokemonElement.FormattingEnabled = true;
            comboBoxUpdatePokemonElement.Location = new Point(181, 57);
            comboBoxUpdatePokemonElement.Name = "comboBoxUpdatePokemonElement";
            comboBoxUpdatePokemonElement.Size = new Size(164, 23);
            comboBoxUpdatePokemonElement.TabIndex = 1;
            // 
            // textBoxUpdatePokemonName
            // 
            textBoxUpdatePokemonName.Location = new Point(181, 22);
            textBoxUpdatePokemonName.Name = "textBoxUpdatePokemonName";
            textBoxUpdatePokemonName.Size = new Size(166, 23);
            textBoxUpdatePokemonName.TabIndex = 0;
            // 
            // groupBoxAdd
            // 
            groupBoxAdd.BackColor = Color.Transparent;
            groupBoxAdd.Controls.Add(buttonAddPokemonValidate);
            groupBoxAdd.Controls.Add(labelAddPokemonElement);
            groupBoxAdd.Controls.Add(labelAddPokemonName);
            groupBoxAdd.Controls.Add(comboBoxAddPokemonElement);
            groupBoxAdd.Controls.Add(textBoxAddPokemonName);
            groupBoxAdd.Location = new Point(229, 206);
            groupBoxAdd.Name = "groupBoxAdd";
            groupBoxAdd.Size = new Size(568, 232);
            groupBoxAdd.TabIndex = 3;
            groupBoxAdd.TabStop = false;
            groupBoxAdd.Text = "Ajout";
            // 
            // buttonAddPokemonValidate
            // 
            buttonAddPokemonValidate.Location = new Point(2, 117);
            buttonAddPokemonValidate.Name = "buttonAddPokemonValidate";
            buttonAddPokemonValidate.Size = new Size(349, 40);
            buttonAddPokemonValidate.TabIndex = 5;
            buttonAddPokemonValidate.Text = "Valider";
            buttonAddPokemonValidate.UseVisualStyleBackColor = true;
            buttonAddPokemonValidate.Click += buttonAddPokemonValidate_Click;
            // 
            // labelAddPokemonElement
            // 
            labelAddPokemonElement.AutoSize = true;
            labelAddPokemonElement.Location = new Point(122, 68);
            labelAddPokemonElement.Name = "labelAddPokemonElement";
            labelAddPokemonElement.Size = new Size(56, 15);
            labelAddPokemonElement.TabIndex = 4;
            labelAddPokemonElement.Text = "Élément :";
            // 
            // labelAddPokemonName
            // 
            labelAddPokemonName.AutoSize = true;
            labelAddPokemonName.Location = new Point(138, 30);
            labelAddPokemonName.Name = "labelAddPokemonName";
            labelAddPokemonName.Size = new Size(43, 15);
            labelAddPokemonName.TabIndex = 3;
            labelAddPokemonName.Text = "Nom : ";
            // 
            // comboBoxAddPokemonElement
            // 
            comboBoxAddPokemonElement.FormattingEnabled = true;
            comboBoxAddPokemonElement.Location = new Point(184, 60);
            comboBoxAddPokemonElement.Name = "comboBoxAddPokemonElement";
            comboBoxAddPokemonElement.Size = new Size(165, 23);
            comboBoxAddPokemonElement.TabIndex = 2;
            // 
            // textBoxAddPokemonName
            // 
            textBoxAddPokemonName.Location = new Point(184, 22);
            textBoxAddPokemonName.Name = "textBoxAddPokemonName";
            textBoxAddPokemonName.Size = new Size(166, 23);
            textBoxAddPokemonName.TabIndex = 1;
            // 
            // FormManagerPokemon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxAdd);
            Controls.Add(groupBoxUpdateDelete);
            Controls.Add(buttonAddPokemon);
            Controls.Add(listBoxPokemons);
            Name = "FormManagerPokemon";
            Text = "FormManagerPokemon";
            groupBoxUpdateDelete.ResumeLayout(false);
            groupBoxUpdateDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).EndInit();
            groupBoxAdd.ResumeLayout(false);
            groupBoxAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPokemons;
        private Button buttonAddPokemon;
        private GroupBox groupBoxUpdateDelete;
        private TextBox textBoxUpdatePokemonName;
        private GroupBox groupBoxAdd;
        private ComboBox comboBoxUpdatePokemonElement;
        private ComboBox comboBoxAddPokemonElement;
        private TextBox textBoxAddPokemonName;
        private Label labelUpdatePokemonName;
        private Label labelUpdatePokemonElement;
        private Label labelAddPokemonElement;
        private Label labelAddPokemonName;
        private Button buttonAddPokemonValidate;
        private Button buttonDeletePokemon;
        private Button buttonUpdatePokemon;
        private PictureBox pictureBoxPokemon;
        private TextBox textBoxUpdatePokemonIdApi;
        private Label labelUpdatePokemonIdApi;
    }
}