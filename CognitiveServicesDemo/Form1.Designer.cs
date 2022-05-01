
namespace CognitiveServicesDemo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourcePictureBox = new System.Windows.Forms.PictureBox();
            this.uploadSourceImage = new System.Windows.Forms.Button();
            this.destinationPictureBox = new System.Windows.Forms.PictureBox();
            this.uploadDestination = new System.Windows.Forms.Button();
            this.compareButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sourcePictureBox
            // 
            this.sourcePictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sourcePictureBox.Location = new System.Drawing.Point(12, 29);
            this.sourcePictureBox.Name = "sourcePictureBox";
            this.sourcePictureBox.Size = new System.Drawing.Size(443, 456);
            this.sourcePictureBox.TabIndex = 0;
            this.sourcePictureBox.TabStop = false;
            // 
            // uploadSourceImage
            // 
            this.uploadSourceImage.Location = new System.Drawing.Point(105, 510);
            this.uploadSourceImage.Name = "uploadSourceImage";
            this.uploadSourceImage.Size = new System.Drawing.Size(173, 33);
            this.uploadSourceImage.TabIndex = 1;
            this.uploadSourceImage.Text = "Yükle";
            this.uploadSourceImage.UseVisualStyleBackColor = true;
            this.uploadSourceImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // destinationPictureBox
            // 
            this.destinationPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.destinationPictureBox.Location = new System.Drawing.Point(798, 29);
            this.destinationPictureBox.Name = "destinationPictureBox";
            this.destinationPictureBox.Size = new System.Drawing.Size(410, 456);
            this.destinationPictureBox.TabIndex = 3;
            this.destinationPictureBox.TabStop = false;
            // 
            // uploadDestination
            // 
            this.uploadDestination.Location = new System.Drawing.Point(933, 510);
            this.uploadDestination.Name = "uploadDestination";
            this.uploadDestination.Size = new System.Drawing.Size(195, 33);
            this.uploadDestination.TabIndex = 4;
            this.uploadDestination.Text = "Yükle";
            this.uploadDestination.UseVisualStyleBackColor = true;
            this.uploadDestination.Click += new System.EventHandler(this.uploadDestination_Click);
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(550, 245);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(169, 40);
            this.compareButton.TabIndex = 5;
            this.compareButton.Text = "Karşılaştır";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_ClickAsync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 651);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.uploadDestination);
            this.Controls.Add(this.destinationPictureBox);
            this.Controls.Add(this.uploadSourceImage);
            this.Controls.Add(this.sourcePictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Azure CognitiveServices Face Compare Demo";
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sourcePictureBox;
        private System.Windows.Forms.Button uploadSourceImage;
        private System.Windows.Forms.PictureBox destinationPictureBox;
        private System.Windows.Forms.Button uploadDestination;
        private System.Windows.Forms.Button compareButton;
    }
}

