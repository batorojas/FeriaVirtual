namespace FeriaApp
{
    partial class vInicio
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProductos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProductos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProductos.Legends.Add(legend1);
            this.chartProductos.Location = new System.Drawing.Point(24, 78);
            this.chartProductos.Name = "chartProductos";
            this.chartProductos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProductos.Series.Add(series1);
            this.chartProductos.Size = new System.Drawing.Size(449, 246);
            this.chartProductos.TabIndex = 0;
            this.chartProductos.Text = "Productos más vendidos";
            // 
            // vInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartProductos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "vInicio";
            this.Size = new System.Drawing.Size(875, 543);
            this.Load += new System.EventHandler(this.vInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductos;

        #endregion
    }
}
