namespace Pokedex.Wf
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            labelTitle = new Label();
            buttonManagerElement = new Button();
            buttonManagerPokemons = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe Fluent Icons", 40F);
            labelTitle.Location = new Point(91, -20);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new Padding(10);
            labelTitle.Size = new Size(200, 74);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Pokédex";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonManagerElement
            // 
            buttonManagerElement.Location = new Point(185, 83);
            buttonManagerElement.Name = "buttonManagerElement";
            buttonManagerElement.Size = new Size(146, 107);
            buttonManagerElement.TabIndex = 1;
            buttonManagerElement.Text = "Gestion des éléments";
            buttonManagerElement.UseVisualStyleBackColor = true;
            buttonManagerElement.Click += buttonManagerElement_Click;
            // 
            // buttonManagerPokemons
            // 
            buttonManagerPokemons.Location = new Point(12, 83);
            buttonManagerPokemons.Name = "buttonManagerPokemons";
            buttonManagerPokemons.Size = new Size(146, 107);
            buttonManagerPokemons.TabIndex = 2;
            buttonManagerPokemons.Text = "Gestion des pokémons";
            buttonManagerPokemons.UseVisualStyleBackColor = true;
            buttonManagerPokemons.Click += buttonManagerPokemons_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(349, 205);
            Controls.Add(buttonManagerPokemons);
            Controls.Add(buttonManagerElement);
            Controls.Add(labelTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "Pokedex";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonManagerElement;
        private Button buttonManagerPokemons;
    }
}
