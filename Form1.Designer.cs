namespace PokemonManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabCadastrar = new TabPage();
            btnCadastrar = new Button();
            txtCuriosidade = new TextBox();
            txtDescricao = new TextBox();
            txtTipo = new TextBox();
            txtNome = new TextBox();
            lblCuriosidade = new Label();
            lblDescricao = new Label();
            lblTipo = new Label();
            lblNome = new Label();
            tabMostrar = new TabPage();
            lstPokedex = new ListBox();
            tabControl.SuspendLayout();
            tabCadastrar.SuspendLayout();
            tabMostrar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabCadastrar);
            tabControl.Controls.Add(tabMostrar);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(384, 261);
            tabControl.TabIndex = 0;
            // 
            // tabCadastrar
            // 
            tabCadastrar.Controls.Add(btnCadastrar);
            tabCadastrar.Controls.Add(txtCuriosidade);
            tabCadastrar.Controls.Add(txtDescricao);
            tabCadastrar.Controls.Add(txtTipo);
            tabCadastrar.Controls.Add(txtNome);
            tabCadastrar.Controls.Add(lblCuriosidade);
            tabCadastrar.Controls.Add(lblDescricao);
            tabCadastrar.Controls.Add(lblTipo);
            tabCadastrar.Controls.Add(lblNome);
            tabCadastrar.Location = new Point(4, 24);
            tabCadastrar.Name = "tabCadastrar";
            tabCadastrar.Padding = new Padding(3);
            tabCadastrar.Size = new Size(376, 233);
            tabCadastrar.TabIndex = 0;
            tabCadastrar.Text = "Cadastrar Pokémon";
            tabCadastrar.UseVisualStyleBackColor = true;
            tabCadastrar.Click += tabCadastrar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(110, 180);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(200, 23);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCuriosidade
            // 
            txtCuriosidade.Location = new Point(110, 140);
            txtCuriosidade.Name = "txtCuriosidade";
            txtCuriosidade.Size = new Size(200, 23);
            txtCuriosidade.TabIndex = 7;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(110, 100);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(200, 23);
            txtDescricao.TabIndex = 6;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(110, 60);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(200, 23);
            txtTipo.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(110, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 4;
            // 
            // lblCuriosidade
            // 
            lblCuriosidade.AutoSize = true;
            lblCuriosidade.Location = new Point(10, 140);
            lblCuriosidade.Name = "lblCuriosidade";
            lblCuriosidade.Size = new Size(73, 15);
            lblCuriosidade.TabIndex = 3;
            lblCuriosidade.Text = "Curiosidade:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(10, 100);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(10, 60);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(33, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(10, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // tabMostrar
            // 
            tabMostrar.Controls.Add(lstPokedex);
            tabMostrar.Location = new Point(4, 24);
            tabMostrar.Name = "tabMostrar";
            tabMostrar.Padding = new Padding(3);
            tabMostrar.Size = new Size(376, 233);
            tabMostrar.TabIndex = 1;
            tabMostrar.Text = "Mostrar Pokédex";
            tabMostrar.UseVisualStyleBackColor = true;
            tabMostrar.Enter += tabMostrar_Enter;
            // 
            // lstPokedex
            // 
            lstPokedex.Dock = DockStyle.Fill;
            lstPokedex.FormattingEnabled = true;
            lstPokedex.ItemHeight = 15;
            lstPokedex.Location = new Point(3, 3);
            lstPokedex.Name = "lstPokedex";
            lstPokedex.Size = new Size(370, 227);
            lstPokedex.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "Pokémon Manager";
            tabControl.ResumeLayout(false);
            tabCadastrar.ResumeLayout(false);
            tabCadastrar.PerformLayout();
            tabMostrar.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TabPage tabMostrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCuriosidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCuriosidade;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ListBox lstPokedex;
    }
}
