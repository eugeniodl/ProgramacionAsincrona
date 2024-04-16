namespace WinAsyncAwait
{
    partial class FrmAsyncAwait
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
            this.loadingGIF = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingGIF
            // 
            this.loadingGIF.Image = global::WinAsyncAwait.Properties.Resources.Loading_2;
            this.loadingGIF.Location = new System.Drawing.Point(225, 119);
            this.loadingGIF.Name = "loadingGIF";
            this.loadingGIF.Size = new System.Drawing.Size(205, 193);
            this.loadingGIF.TabIndex = 0;
            this.loadingGIF.TabStop = false;
            this.loadingGIF.Visible = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(45, 83);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(127, 34);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar proceso";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_ClickAsync);
            // 
            // FrmAsyncAwait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 356);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.loadingGIF);
            this.Name = "FrmAsyncAwait";
            this.Text = "FrmAsyncAwait";
            ((System.ComponentModel.ISupportInitialize)(this.loadingGIF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox loadingGIF;
        private Button btnIniciar;
    }
}