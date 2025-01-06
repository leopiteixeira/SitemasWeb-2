using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DesktopApp
{
    partial class frmUser
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
            components = new System.ComponentModel.Container();
            btnBuscarUsuario = new Button();
            label1 = new Label();
            txtBuscarUsuario = new TextBox();
            dgvUser = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            adicionarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            tsmiGerenciarUsuario = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.Location = new Point(601, 53);
            btnBuscarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(262, 31);
            btnBuscarUsuario.TabIndex = 1;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.UseVisualStyleBackColor = true;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 57);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 2;
            label1.Text = "Nome do usuário: ";
            label1.Click += label1_Click;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(189, 53);
            txtBuscarUsuario.Margin = new Padding(3, 4, 3, 4);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(405, 27);
            txtBuscarUsuario.TabIndex = 3;
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(14, 107);
            dgvUser.Margin = new Padding(3, 4, 3, 4);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.Size = new Size(849, 181);
            dgvUser.TabIndex = 4;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { adicionarUsuárioToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(197, 28);
            // 
            // adicionarUsuárioToolStripMenuItem
            // 
            adicionarUsuárioToolStripMenuItem.MergeIndex = 1;
            adicionarUsuárioToolStripMenuItem.Name = "adicionarUsuárioToolStripMenuItem";
            adicionarUsuárioToolStripMenuItem.Size = new Size(196, 24);
            adicionarUsuárioToolStripMenuItem.Text = "Adicionar Usuário";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiGerenciarUsuario, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(875, 30);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiGerenciarUsuario
            // 
            tsmiGerenciarUsuario.Name = "tsmiGerenciarUsuario";
            tsmiGerenciarUsuario.Size = new Size(138, 24);
            tsmiGerenciarUsuario.Text = "Gerenciar usuário";
            tsmiGerenciarUsuario.Click += tsmiGerenciarUsuario_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(139, 24);
            toolStripMenuItem1.Text = "Adicionar usuário";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 300);
            label2.Name = "label2";
            label2.Size = new Size(409, 17);
            label2.TabIndex = 6;
            label2.Text = "Desenvolvido por Leonardo Pinto Teixeira e Gabriel Coutinho dos Santos";
            label2.Click += label2_Click;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 329);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Controls.Add(dgvUser);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(label1);
            Controls.Add(btnBuscarUsuario);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador de Usuários";
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBuscarUsuario;
        private Label label1;
        private TextBox txtBuscarUsuario;
        private DataGridView dgvUser;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem adicionarUsuárioToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiGerenciarUsuario;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label label2;
    }
}
