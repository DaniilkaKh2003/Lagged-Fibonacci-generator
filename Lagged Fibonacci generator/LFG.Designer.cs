namespace Lagged_Fibonacci_generator
{
    partial class LFG
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LFG));
            this.Close = new System.Windows.Forms.Button();
            this.K = new System.Windows.Forms.ComboBox();
            this.J = new System.Windows.Forms.ComboBox();
            this.SRN = new System.Windows.Forms.TextBox();
            this.Mod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputS = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Save_Image = new System.Windows.Forms.Button();
            this.To_Graph = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Seed = new System.Windows.Forms.TextBox();
            this.Generator = new System.Windows.Forms.PictureBox();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Generator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Close.BackColor = System.Drawing.Color.White;
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Image = global::Lagged_Fibonacci_generator.Properties.Resources.close;
            this.Close.Location = new System.Drawing.Point(950, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(38, 38);
            this.Close.TabIndex = 49;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // K
            // 
            this.K.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.K.FormattingEnabled = true;
            this.K.Items.AddRange(new object[] {
            "10",
            "17",
            "55"});
            this.K.Location = new System.Drawing.Point(134, 113);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(172, 45);
            this.K.TabIndex = 48;
            this.K.SelectedIndexChanged += new System.EventHandler(this.K_SelectedIndexChanged);
            // 
            // J
            // 
            this.J.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.J.FormattingEnabled = true;
            this.J.Items.AddRange(new object[] {
            "7",
            "5",
            "24"});
            this.J.Location = new System.Drawing.Point(134, 62);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(172, 45);
            this.J.TabIndex = 47;
            this.J.SelectedIndexChanged += new System.EventHandler(this.J_SelectedIndexChanged);
            // 
            // SRN
            // 
            this.SRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SRN.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SRN.Location = new System.Drawing.Point(12, 535);
            this.SRN.Name = "SRN";
            this.SRN.Size = new System.Drawing.Size(976, 50);
            this.SRN.TabIndex = 46;
            this.SRN.TextChanged += new System.EventHandler(this.SRN_TextChanged);
            // 
            // Mod
            // 
            this.Mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mod.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mod.Location = new System.Drawing.Point(134, 164);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(172, 45);
            this.Mod.TabIndex = 2;
            this.Mod.TextChanged += new System.EventHandler(this.Mod_TextChanged);
            this.Mod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mod_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.label5.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 45);
            this.label5.TabIndex = 44;
            this.label5.Text = "Mod:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.label4.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(976, 53);
            this.label4.TabIndex = 43;
            this.label4.Text = "Generated sequence of 30 random numbers:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputS
            // 
            this.outputS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outputS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.outputS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputS.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputS.ForeColor = System.Drawing.Color.White;
            this.outputS.Location = new System.Drawing.Point(12, 423);
            this.outputS.Name = "outputS";
            this.outputS.Size = new System.Drawing.Size(294, 53);
            this.outputS.TabIndex = 42;
            this.outputS.Text = "OUTPUT THE SEQUENCE";
            this.outputS.UseVisualStyleBackColor = false;
            this.outputS.Click += new System.EventHandler(this.outputS_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(12, 354);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(294, 53);
            this.Clear.TabIndex = 41;
            this.Clear.Text = "CLEAR SETTINGS";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save_Image
            // 
            this.Save_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Image.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Save_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.Save_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Image.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_Image.ForeColor = System.Drawing.Color.White;
            this.Save_Image.Location = new System.Drawing.Point(12, 285);
            this.Save_Image.Name = "Save_Image";
            this.Save_Image.Size = new System.Drawing.Size(294, 53);
            this.Save_Image.TabIndex = 40;
            this.Save_Image.Text = "SAVE IMAGE";
            this.Save_Image.UseVisualStyleBackColor = false;
            this.Save_Image.Click += new System.EventHandler(this.Save_Image_Click);
            // 
            // To_Graph
            // 
            this.To_Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.To_Graph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.To_Graph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.To_Graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.To_Graph.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.To_Graph.ForeColor = System.Drawing.Color.White;
            this.To_Graph.Location = new System.Drawing.Point(12, 216);
            this.To_Graph.Name = "To_Graph";
            this.To_Graph.Size = new System.Drawing.Size(294, 53);
            this.To_Graph.TabIndex = 39;
            this.To_Graph.Text = "TO GRAPH";
            this.To_Graph.UseVisualStyleBackColor = false;
            this.To_Graph.Click += new System.EventHandler(this.To_Graph_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.label3.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 45);
            this.label3.TabIndex = 38;
            this.label3.Text = "k:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.label2.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 45);
            this.label2.TabIndex = 37;
            this.label2.Text = "j:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 45);
            this.label1.TabIndex = 36;
            this.label1.Text = "Seed:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Seed
            // 
            this.Seed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Seed.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Seed.Location = new System.Drawing.Point(134, 12);
            this.Seed.Name = "Seed";
            this.Seed.Size = new System.Drawing.Size(811, 45);
            this.Seed.TabIndex = 1;
            this.Seed.TextChanged += new System.EventHandler(this.Seed_TextChanged);
            this.Seed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Seed_KeyPress);
            // 
            // Generator
            // 
            this.Generator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Generator.Location = new System.Drawing.Point(0, 0);
            this.Generator.Name = "Generator";
            this.Generator.Size = new System.Drawing.Size(1000, 600);
            this.Generator.TabIndex = 34;
            this.Generator.TabStop = false;
            // 
            // Graph
            // 
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            this.Graph.Location = new System.Drawing.Point(312, 63);
            this.Graph.Name = "Graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Black;
            series1.Name = "Random numbers";
            this.Graph.Series.Add(series1);
            this.Graph.Size = new System.Drawing.Size(676, 413);
            this.Graph.TabIndex = 50;
            title1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Random numbers";
            title1.Text = "Graph of random numbers";
            this.Graph.Titles.Add(title1);
            this.Graph.Click += new System.EventHandler(this.Graph_Click);
            // 
            // LFG
            // 
            this.AcceptButton = this.To_Graph;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.K);
            this.Controls.Add(this.J);
            this.Controls.Add(this.SRN);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputS);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Save_Image);
            this.Controls.Add(this.To_Graph);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Seed);
            this.Controls.Add(this.Generator);
            this.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LFG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LFG";
            ((System.ComponentModel.ISupportInitialize)(this.Generator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ComboBox K;
        private System.Windows.Forms.ComboBox J;
        private System.Windows.Forms.TextBox SRN;
        private System.Windows.Forms.TextBox Mod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button outputS;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save_Image;
        private System.Windows.Forms.Button To_Graph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Seed;
        private System.Windows.Forms.PictureBox Generator;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
    }
}