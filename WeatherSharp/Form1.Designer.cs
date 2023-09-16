namespace WeatherSharp
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
            this.btnTestAPI = new System.Windows.Forms.Button();
            this.txtAPIOK = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputCity = new System.Windows.Forms.TextBox();
            this.btnSearchCity = new System.Windows.Forms.Button();
            this.responseBox = new System.Windows.Forms.RichTextBox();
            this.citiesDataGrid = new System.Windows.Forms.DataGridView();
            this.cbViewAPIRes = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTestAPI
            // 
            this.btnTestAPI.Location = new System.Drawing.Point(12, 377);
            this.btnTestAPI.Name = "btnTestAPI";
            this.btnTestAPI.Size = new System.Drawing.Size(105, 40);
            this.btnTestAPI.TabIndex = 0;
            this.btnTestAPI.Text = "Test connection";
            this.btnTestAPI.UseVisualStyleBackColor = true;
            this.btnTestAPI.Click += new System.EventHandler(this.btnTestApi_clicked);
            // 
            // txtAPIOK
            // 
            this.txtAPIOK.AutoSize = true;
            this.txtAPIOK.Location = new System.Drawing.Point(123, 390);
            this.txtAPIOK.Name = "txtAPIOK";
            this.txtAPIOK.Size = new System.Drawing.Size(38, 15);
            this.txtAPIOK.TabIndex = 1;
            this.txtAPIOK.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // inputCity
            // 
            this.inputCity.Location = new System.Drawing.Point(12, 12);
            this.inputCity.Name = "inputCity";
            this.inputCity.Size = new System.Drawing.Size(364, 23);
            this.inputCity.TabIndex = 3;
            // 
            // btnSearchCity
            // 
            this.btnSearchCity.Location = new System.Drawing.Point(382, 9);
            this.btnSearchCity.Name = "btnSearchCity";
            this.btnSearchCity.Size = new System.Drawing.Size(75, 27);
            this.btnSearchCity.TabIndex = 4;
            this.btnSearchCity.Text = "Lookup";
            this.btnSearchCity.UseVisualStyleBackColor = true;
            this.btnSearchCity.Click += new System.EventHandler(this.btnSearchCity_Click);
            // 
            // responseBox
            // 
            this.responseBox.Location = new System.Drawing.Point(463, 9);
            this.responseBox.Name = "responseBox";
            this.responseBox.Size = new System.Drawing.Size(385, 405);
            this.responseBox.TabIndex = 5;
            this.responseBox.Text = "";
            // 
            // citiesDataGrid
            // 
            this.citiesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesDataGrid.Location = new System.Drawing.Point(12, 42);
            this.citiesDataGrid.Name = "citiesDataGrid";
            this.citiesDataGrid.RowTemplate.Height = 25;
            this.citiesDataGrid.Size = new System.Drawing.Size(445, 329);
            this.citiesDataGrid.TabIndex = 6;
            // 
            // cbViewAPIRes
            // 
            this.cbViewAPIRes.AutoSize = true;
            this.cbViewAPIRes.Location = new System.Drawing.Point(168, 390);
            this.cbViewAPIRes.Name = "cbViewAPIRes";
            this.cbViewAPIRes.Size = new System.Drawing.Size(122, 19);
            this.cbViewAPIRes.TabIndex = 7;
            this.cbViewAPIRes.Text = "View API response";
            this.cbViewAPIRes.UseVisualStyleBackColor = true;
            this.cbViewAPIRes.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 493);
            this.Controls.Add(this.cbViewAPIRes);
            this.Controls.Add(this.citiesDataGrid);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.btnSearchCity);
            this.Controls.Add(this.inputCity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAPIOK);
            this.Controls.Add(this.btnTestAPI);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestAPI;
        private System.Windows.Forms.Label txtAPIOK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputCity;
        private System.Windows.Forms.Button btnSearchCity;
        private System.Windows.Forms.RichTextBox responseBox;
        private System.Windows.Forms.DataGridView citiesDataGrid;
        private System.Windows.Forms.CheckBox cbViewAPIRes;
    }
}

