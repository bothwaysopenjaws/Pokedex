namespace Pokedex.Wf.Windows
{
    partial class FormManagerElement
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
            label1 = new Label();
            listBoxElements = new ListBox();
            labelElementName = new Label();
            textBoxElementName = new TextBox();
            buttonAddElement = new Button();
            buttonUpdateElement = new Button();
            buttonDeleteElement = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(87, 9);
            label1.Name = "label1";
            label1.Size = new Size(659, 72);
            label1.TabIndex = 0;
            label1.Text = "Gestionnaire des éléments";
            // 
            // listBoxElements
            // 
            listBoxElements.FormattingEnabled = true;
            listBoxElements.ItemHeight = 15;
            listBoxElements.Location = new Point(5, 77);
            listBoxElements.Name = "listBoxElements";
            listBoxElements.Size = new Size(183, 334);
            listBoxElements.TabIndex = 1;
            listBoxElements.SelectedIndexChanged += listBoxElements_SelectedIndexChanged;
            // 
            // labelElementName
            // 
            labelElementName.AutoSize = true;
            labelElementName.Location = new Point(208, 85);
            labelElementName.Name = "labelElementName";
            labelElementName.Size = new Size(43, 15);
            labelElementName.TabIndex = 2;
            labelElementName.Text = "Nom : ";
            // 
            // textBoxElementName
            // 
            textBoxElementName.Location = new Point(274, 82);
            textBoxElementName.Name = "textBoxElementName";
            textBoxElementName.Size = new Size(160, 23);
            textBoxElementName.TabIndex = 3;
            // 
            // buttonAddElement
            // 
            buttonAddElement.Location = new Point(8, 413);
            buttonAddElement.Name = "buttonAddElement";
            buttonAddElement.Size = new Size(178, 37);
            buttonAddElement.TabIndex = 4;
            buttonAddElement.Text = "Ajouter";
            buttonAddElement.UseVisualStyleBackColor = true;
            buttonAddElement.Click += buttonAddElement_Click;
            // 
            // buttonUpdateElement
            // 
            buttonUpdateElement.Location = new Point(208, 109);
            buttonUpdateElement.Name = "buttonUpdateElement";
            buttonUpdateElement.Size = new Size(111, 39);
            buttonUpdateElement.TabIndex = 5;
            buttonUpdateElement.Text = "Modifier";
            buttonUpdateElement.UseVisualStyleBackColor = true;
            buttonUpdateElement.Click += buttonUpdateElement_Click;
            // 
            // buttonDeleteElement
            // 
            buttonDeleteElement.Location = new Point(325, 109);
            buttonDeleteElement.Name = "buttonDeleteElement";
            buttonDeleteElement.Size = new Size(109, 39);
            buttonDeleteElement.TabIndex = 6;
            buttonDeleteElement.Text = "Supprimer";
            buttonDeleteElement.UseVisualStyleBackColor = true;
            buttonDeleteElement.Click += buttonDeleteElement_Click;
            // 
            // FormManagerElement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDeleteElement);
            Controls.Add(buttonUpdateElement);
            Controls.Add(buttonAddElement);
            Controls.Add(textBoxElementName);
            Controls.Add(labelElementName);
            Controls.Add(listBoxElements);
            Controls.Add(label1);
            Name = "FormManagerElement";
            Text = "FormManagerElement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxElements;
        private Label labelElementName;
        private TextBox textBoxElementName;
        private Button buttonAddElement;
        private Button buttonUpdateElement;
        private Button buttonDeleteElement;
    }
}