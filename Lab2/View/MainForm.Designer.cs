
namespace Lab2.View
{
    partial class MainForm
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
            this.lbxRooms = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInstr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWorkers = new System.Windows.Forms.Label();
            this.btClone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxRooms
            // 
            this.lbxRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxRooms.FormattingEnabled = true;
            this.lbxRooms.ItemHeight = 20;
            this.lbxRooms.Location = new System.Drawing.Point(24, 129);
            this.lbxRooms.Name = "lbxRooms";
            this.lbxRooms.Size = new System.Drawing.Size(587, 404);
            this.lbxRooms.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(675, 234);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(148, 45);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add Room";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemove.Location = new System.Drawing.Point(675, 313);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(148, 45);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "Remove Room";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кількість інструментів";
            // 
            // labelInstr
            // 
            this.labelInstr.AutoSize = true;
            this.labelInstr.Location = new System.Drawing.Point(639, 30);
            this.labelInstr.Name = "labelInstr";
            this.labelInstr.Size = new System.Drawing.Size(13, 13);
            this.labelInstr.TabIndex = 7;
            this.labelInstr.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Кількість співробітників";
            // 
            // labelWorkers
            // 
            this.labelWorkers.AutoSize = true;
            this.labelWorkers.Location = new System.Drawing.Point(639, 72);
            this.labelWorkers.Name = "labelWorkers";
            this.labelWorkers.Size = new System.Drawing.Size(13, 13);
            this.labelWorkers.TabIndex = 9;
            this.labelWorkers.Text = "0";
            // 
            // btClone
            // 
            this.btClone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClone.Location = new System.Drawing.Point(675, 417);
            this.btClone.Name = "btClone";
            this.btClone.Size = new System.Drawing.Size(148, 45);
            this.btClone.TabIndex = 10;
            this.btClone.Text = "Clone Room";
            this.btClone.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 569);
            this.Controls.Add(this.btClone);
            this.Controls.Add(this.labelWorkers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelInstr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbxRooms);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxRooms;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelInstr;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelWorkers;
        private System.Windows.Forms.Button btClone;
    }
}