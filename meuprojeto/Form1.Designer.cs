namespace MeuProjeto
{
    partial class frmPrincipal
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
            this.btnNovoSimples = new System.Windows.Forms.Button();
            this.btnNovoComposto = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroCompostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioCompostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovoSimples
            // 
            this.btnNovoSimples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNovoSimples.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovoSimples.Location = new System.Drawing.Point(433, 262);
            this.btnNovoSimples.Name = "btnNovoSimples";
            this.btnNovoSimples.Size = new System.Drawing.Size(94, 45);
            this.btnNovoSimples.TabIndex = 1;
            this.btnNovoSimples.Text = "Novo Produto Simples";
            this.btnNovoSimples.UseVisualStyleBackColor = false;
            this.btnNovoSimples.Click += new System.EventHandler(this.btnNovoSimples_Click);
            // 
            // btnNovoComposto
            // 
            this.btnNovoComposto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNovoComposto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovoComposto.Location = new System.Drawing.Point(541, 263);
            this.btnNovoComposto.Name = "btnNovoComposto";
            this.btnNovoComposto.Size = new System.Drawing.Size(94, 44);
            this.btnNovoComposto.TabIndex = 2;
            this.btnNovoComposto.Text = "Novo Produto Composto";
            this.btnNovoComposto.UseVisualStyleBackColor = false;
            this.btnNovoComposto.Click += new System.EventHandler(this.btnNovoComposto_Click);
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNovoPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovoPedido.Location = new System.Drawing.Point(325, 263);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(94, 45);
            this.btnNovoPedido.TabIndex = 3;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoPedidoToolStripMenuItem,
            this.atualizarPedidoToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // novoPedidoToolStripMenuItem
            // 
            this.novoPedidoToolStripMenuItem.Name = "novoPedidoToolStripMenuItem";
            this.novoPedidoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.novoPedidoToolStripMenuItem.Text = "Novo Pedido";
            this.novoPedidoToolStripMenuItem.Click += new System.EventHandler(this.novoPedidoToolStripMenuItem_Click);
            // 
            // atualizarPedidoToolStripMenuItem
            // 
            this.atualizarPedidoToolStripMenuItem.Name = "atualizarPedidoToolStripMenuItem";
            this.atualizarPedidoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.atualizarPedidoToolStripMenuItem.Text = "Atualizar Pedido";
            this.atualizarPedidoToolStripMenuItem.Click += new System.EventHandler(this.atualizarPedidoToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.atualizarToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroSimplesToolStripMenuItem,
            this.cadastroCompostoToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // cadastroSimplesToolStripMenuItem
            // 
            this.cadastroSimplesToolStripMenuItem.Name = "cadastroSimplesToolStripMenuItem";
            this.cadastroSimplesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cadastroSimplesToolStripMenuItem.Text = "Produto Simples ";
            this.cadastroSimplesToolStripMenuItem.Click += new System.EventHandler(this.cadastroSimplesToolStripMenuItem_Click);
            // 
            // cadastroCompostoToolStripMenuItem
            // 
            this.cadastroCompostoToolStripMenuItem.Name = "cadastroCompostoToolStripMenuItem";
            this.cadastroCompostoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cadastroCompostoToolStripMenuItem.Text = "Produto Composto";
            this.cadastroCompostoToolStripMenuItem.Click += new System.EventHandler(this.cadastroCompostoToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatórioSimplesToolStripMenuItem,
            this.gerarRelatórioCompostoToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // gerarRelatórioSimplesToolStripMenuItem
            // 
            this.gerarRelatórioSimplesToolStripMenuItem.Name = "gerarRelatórioSimplesToolStripMenuItem";
            this.gerarRelatórioSimplesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.gerarRelatórioSimplesToolStripMenuItem.Text = "Gerar Relatório Simples";
            // 
            // gerarRelatórioCompostoToolStripMenuItem
            // 
            this.gerarRelatórioCompostoToolStripMenuItem.Name = "gerarRelatórioCompostoToolStripMenuItem";
            this.gerarRelatórioCompostoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.gerarRelatórioCompostoToolStripMenuItem.Text = "Gerar Relatório Composto";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 319);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.btnNovoComposto);
            this.Controls.Add(this.btnNovoSimples);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Controle De Estoque";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNovoSimples;
        private System.Windows.Forms.Button btnNovoComposto;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroCompostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioCompostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
    }
}

