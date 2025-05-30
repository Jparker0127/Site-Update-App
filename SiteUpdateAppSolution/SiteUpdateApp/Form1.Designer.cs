namespace SiteUpdateApp
{
    partial class Form1
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
            btnSelectBuild = new Button();
            lblBuild = new Label();
            btnBackup = new Button();
            btnAppPools = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // btnSelectBuild
            // 
            btnSelectBuild.Location = new Point(12, 12);
            btnSelectBuild.Name = "btnSelectBuild";
            btnSelectBuild.Size = new Size(122, 23);
            btnSelectBuild.TabIndex = 0;
            btnSelectBuild.Text = "Select Build";
            btnSelectBuild.UseVisualStyleBackColor = true;
            btnSelectBuild.Click += btnSelectBuild_Click;
            // 
            // lblBuild
            // 
            lblBuild.AutoSize = true;
            lblBuild.BackColor = SystemColors.ControlLightLight;
            lblBuild.BorderStyle = BorderStyle.Fixed3D;
            lblBuild.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuild.Location = new Point(159, 16);
            lblBuild.Name = "lblBuild";
            lblBuild.Size = new Size(35, 19);
            lblBuild.TabIndex = 1;
            lblBuild.Text = "Path";
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(12, 81);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(122, 23);
            btnBackup.TabIndex = 2;
            btnBackup.Text = "Backup";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnAppPools
            // 
            btnAppPools.Location = new Point(12, 184);
            btnAppPools.Name = "btnAppPools";
            btnAppPools.Size = new Size(122, 23);
            btnAppPools.TabIndex = 3;
            btnAppPools.Text = "List App Pools";
            btnAppPools.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 389);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update Sites";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 424);
            Controls.Add(btnUpdate);
            Controls.Add(btnAppPools);
            Controls.Add(btnBackup);
            Controls.Add(lblBuild);
            Controls.Add(btnSelectBuild);
            Name = "Form1";
            Text = "Site Update Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectBuild;
        private Label lblBuild;
        private Button btnBackup;
        private Button btnAppPools;
        private Button btnUpdate;
    }
}
