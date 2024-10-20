namespace A1_game
{
    partial class MemGame
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
            btn_new = new Button();
            lbl_player = new Label();
            lbl_turns = new Label();
            lbl_status = new Label();
            SuspendLayout();
            // 
            // btn_new
            // 
            btn_new.BackColor = Color.RosyBrown;
            btn_new.FlatStyle = FlatStyle.Popup;
            btn_new.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_new.ForeColor = SystemColors.ControlLightLight;
            btn_new.Location = new Point(984, 52);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(340, 122);
            btn_new.TabIndex = 1;
            btn_new.Text = "New Game";
            btn_new.UseVisualStyleBackColor = false;
            btn_new.Click += btn_new_Click;
            // 
            // lbl_player
            // 
            lbl_player.AutoSize = true;
            lbl_player.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_player.Location = new Point(984, 322);
            lbl_player.Name = "lbl_player";
            lbl_player.Size = new Size(175, 54);
            lbl_player.TabIndex = 2;
            lbl_player.Text = "Player 1";
            // 
            // lbl_turns
            // 
            lbl_turns.AutoSize = true;
            lbl_turns.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_turns.Location = new Point(984, 443);
            lbl_turns.Name = "lbl_turns";
            lbl_turns.Size = new Size(337, 54);
            lbl_turns.TabIndex = 3;
            lbl_turns.Text = "Number of turns";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbl_status.ForeColor = Color.Brown;
            lbl_status.Location = new Point(150, 30);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(670, 144);
            lbl_status.TabIndex = 4;
            lbl_status.Text = "Memory Game\r\nClick 'New Game' to start";
            lbl_status.TextAlign = ContentAlignment.TopCenter;
            // 
            // MemGame
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 1094);
            Controls.Add(lbl_status);
            Controls.Add(lbl_turns);
            Controls.Add(lbl_player);
            Controls.Add(btn_new);
            Name = "MemGame";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_new;
        private Label lbl_player;
        private Label lbl_turns;
        private Label lbl_status;
    }
}
