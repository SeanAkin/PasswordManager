namespace PasswordManager.Forms
{
    partial class Accounts
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete Account";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 389);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(497, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Show/Hide";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Accounts";
            this.Text = "Accounts";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private ListView listView1;
        private Button button3;
        private Button button5;
    }
}