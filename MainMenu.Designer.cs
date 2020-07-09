namespace KnightsTour
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.start = new System.Windows.Forms.Button();
            this.col = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.row = new System.Windows.Forms.TextBox();
            this.runs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nonIntel = new System.Windows.Forms.RadioButton();
            this.heuristics = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Font = new System.Drawing.Font("Niagara Solid", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(128, 272);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(167, 46);
            this.start.TabIndex = 0;
            this.start.Text = "Tour!";
            this.start.UseCompatibleTextRendering = true;
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // col
            // 
            this.col.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.col.Font = new System.Drawing.Font("Niagara Solid", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col.Location = new System.Drawing.Point(223, 120);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(52, 32);
            this.col.TabIndex = 1;
            this.col.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(123, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(144, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Row";
            // 
            // row
            // 
            this.row.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.row.Font = new System.Drawing.Font("Niagara Solid", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row.Location = new System.Drawing.Point(223, 77);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(52, 32);
            this.row.TabIndex = 4;
            this.row.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // runs
            // 
            this.runs.AccessibleDescription = "";
            this.runs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.runs.Font = new System.Drawing.Font("Niagara Solid", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runs.Location = new System.Drawing.Point(223, 38);
            this.runs.Name = "runs";
            this.runs.Size = new System.Drawing.Size(52, 32);
            this.runs.TabIndex = 5;
            this.runs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Niagara Solid", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(139, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Runs";
            // 
            // nonIntel
            // 
            this.nonIntel.AutoSize = true;
            this.nonIntel.BackColor = System.Drawing.Color.Transparent;
            this.nonIntel.Checked = true;
            this.nonIntel.Font = new System.Drawing.Font("Niagara Solid", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonIntel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nonIntel.Location = new System.Drawing.Point(147, 167);
            this.nonIntel.Name = "nonIntel";
            this.nonIntel.Size = new System.Drawing.Size(128, 34);
            this.nonIntel.TabIndex = 7;
            this.nonIntel.TabStop = true;
            this.nonIntel.Text = "Non-Intelligent";
            this.nonIntel.UseVisualStyleBackColor = false;
            // 
            // heuristics
            // 
            this.heuristics.AutoSize = true;
            this.heuristics.BackColor = System.Drawing.Color.Transparent;
            this.heuristics.Font = new System.Drawing.Font("Niagara Solid", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heuristics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.heuristics.Location = new System.Drawing.Point(165, 217);
            this.heuristics.Name = "heuristics";
            this.heuristics.Size = new System.Drawing.Size(94, 34);
            this.heuristics.TabIndex = 8;
            this.heuristics.Text = "Heuristic";
            this.heuristics.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KnightsTour.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(420, 351);
            this.Controls.Add(this.heuristics);
            this.Controls.Add(this.nonIntel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.runs);
            this.Controls.Add(this.row);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.col);
            this.Controls.Add(this.start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knights Tour";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox col;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox row;
        private System.Windows.Forms.TextBox runs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton nonIntel;
        private System.Windows.Forms.RadioButton heuristics;
    }
}

