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
            this.button1 = new System.Windows.Forms.Button();
            this.inputCity = new System.Windows.Forms.TextBox();
            this.btnSearchCity = new System.Windows.Forms.Button();
            this.responseBox = new System.Windows.Forms.RichTextBox();
            this.citiesDataGrid = new System.Windows.Forms.DataGridView();
            this.cbViewAPIRes = new System.Windows.Forms.CheckBox();
            this.btnChkOnMap = new System.Windows.Forms.Button();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.gbWeather = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.Label();
            this.HTMLViewer = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.webView = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HTMLViewer)).BeginInit();
            this.webView.SuspendLayout();
            this.SuspendLayout();
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
            this.inputCity.Location = new System.Drawing.Point(5, 59);
            this.inputCity.Name = "inputCity";
            this.inputCity.Size = new System.Drawing.Size(364, 23);
            this.inputCity.TabIndex = 3;
            // 
            // btnSearchCity
            // 
            this.btnSearchCity.Location = new System.Drawing.Point(375, 59);
            this.btnSearchCity.Name = "btnSearchCity";
            this.btnSearchCity.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCity.TabIndex = 4;
            this.btnSearchCity.Text = "Lookup";
            this.btnSearchCity.UseVisualStyleBackColor = true;
            this.btnSearchCity.Click += new System.EventHandler(this.btnSearchCity_Click);
            // 
            // responseBox
            // 
            this.responseBox.Location = new System.Drawing.Point(176, 496);
            this.responseBox.Name = "responseBox";
            this.responseBox.Size = new System.Drawing.Size(172, 103);
            this.responseBox.TabIndex = 5;
            this.responseBox.Text = "";
            // 
            // citiesDataGrid
            // 
            this.citiesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesDataGrid.Location = new System.Drawing.Point(8, 88);
            this.citiesDataGrid.Name = "citiesDataGrid";
            this.citiesDataGrid.RowTemplate.Height = 25;
            this.citiesDataGrid.Size = new System.Drawing.Size(440, 329);
            this.citiesDataGrid.TabIndex = 6;
            // 
            // cbViewAPIRes
            // 
            this.cbViewAPIRes.AutoSize = true;
            this.cbViewAPIRes.Location = new System.Drawing.Point(312, 432);
            this.cbViewAPIRes.Name = "cbViewAPIRes";
            this.cbViewAPIRes.Size = new System.Drawing.Size(122, 19);
            this.cbViewAPIRes.TabIndex = 7;
            this.cbViewAPIRes.Text = "View API response";
            this.cbViewAPIRes.UseVisualStyleBackColor = true;
            this.cbViewAPIRes.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnChkOnMap
            // 
            this.btnChkOnMap.Location = new System.Drawing.Point(176, 424);
            this.btnChkOnMap.Name = "btnChkOnMap";
            this.btnChkOnMap.Size = new System.Drawing.Size(120, 40);
            this.btnChkOnMap.TabIndex = 9;
            this.btnChkOnMap.Text = "Check on map";
            this.btnChkOnMap.UseVisualStyleBackColor = true;
            this.btnChkOnMap.Click += new System.EventHandler(this.btnChkOnMap_Click);
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Location = new System.Drawing.Point(8, 424);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(161, 40);
            this.btnGetWeather.TabIndex = 10;
            this.btnGetWeather.Text = "Get weather";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // gbWeather
            // 
            this.gbWeather.Location = new System.Drawing.Point(24, 488);
            this.gbWeather.Name = "gbWeather";
            this.gbWeather.Size = new System.Drawing.Size(143, 118);
            this.gbWeather.TabIndex = 11;
            this.gbWeather.TabStop = false;
            this.gbWeather.Text = "Weather";
            // 
            // txtTitle
            // 
            this.txtTitle.CausesValidation = false;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(5, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(1259, 38);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "WeatherSharp v1.0 ";
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HTMLViewer
            // 
            this.HTMLViewer.AllowExternalDrop = true;
            this.HTMLViewer.CreationProperties = null;
            this.HTMLViewer.DefaultBackgroundColor = System.Drawing.Color.White;
            this.HTMLViewer.Location = new System.Drawing.Point(8, 16);
            this.HTMLViewer.Name = "HTMLViewer";
            this.HTMLViewer.Size = new System.Drawing.Size(784, 592);
            this.HTMLViewer.TabIndex = 8;
            this.HTMLViewer.ZoomFactor = 1D;
            // 
            // webView
            // 
            this.webView.Controls.Add(this.HTMLViewer);
            this.webView.Location = new System.Drawing.Point(464, 56);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(800, 616);
            this.webView.TabIndex = 12;
            this.webView.TabStop = false;
            this.webView.Text = "Web View";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 678);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.gbWeather);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.btnChkOnMap);
            this.Controls.Add(this.cbViewAPIRes);
            this.Controls.Add(this.citiesDataGrid);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.btnSearchCity);
            this.Controls.Add(this.inputCity);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HTMLViewer)).EndInit();
            this.webView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputCity;
        private System.Windows.Forms.Button btnSearchCity;
        private System.Windows.Forms.RichTextBox responseBox;
        private System.Windows.Forms.DataGridView citiesDataGrid;
        private System.Windows.Forms.CheckBox cbViewAPIRes;
        private System.Windows.Forms.Button btnChkOnMap;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.GroupBox gbWeather;
        private System.Windows.Forms.Label txtTitle;
        private Microsoft.Web.WebView2.WinForms.WebView2 HTMLViewer;
        private System.Windows.Forms.GroupBox webView;
    }
}

