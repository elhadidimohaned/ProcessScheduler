using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace FirstApp
{
    public partial class Form2 : Form
    {
        /*public class Process
        {
            public string name;
            public float arrival;
            public float burst;
            public int priority;
        }*/
        
        public Form2()
        {
            InitializeComponent();
            drawChart();
           // draw();

        }


        /* void draw()
         {


            System.Windows.Forms.DataVisualization.Charting.Series[] series = new System.Windows.Forms.DataVisualization.Charting.Series[Form1.i];


             for (int i = 0; i < Form1.i; i++)
             {
                // Console.WriteLine(Form1.processName[i]);
                 series[i] = new System.Windows.Forms.DataVisualization.Charting.Series();
                 series[i].ChartArea = "ChartArea1";
                 series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
                 series[i].Legend = "Legend1";
                 series[i].Name = Form1.schuduler1.processName[i];
                 chart1.Series.Add(series[i]);

                 chart1.Series[Form1.schuduler1.processName[i]].Points.AddXY("Process", Form1.schuduler1.processDuration[i]);
                 chart1.Series[Form1.schuduler1.processName[i]].Label = Form1.schuduler1.processName[i];
             }
         }*/
      void drawChart()
        {
            double sum = 0;
            System.Windows.Forms.DataVisualization.Charting.Series[] series = new System.Windows.Forms.DataVisualization.Charting.Series[Form1.schuduler1.processDuration.Count];
            for (int i = 0; i < Form1.schuduler1.processDuration.Count; i++)
            {
                series[i] = new System.Windows.Forms.DataVisualization.Charting.Series();
                series[i].ChartArea = "ChartArea1";
                series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
                series[i].Legend = "Legend1";
                series[i].Name = Form1.schuduler1.processName[i];
                series[i].Font = new System.Drawing.Font("Times", 6f);

                if (chart1.Series.IsUniqueName(series[i].Name))
                {
                    chart1.Series.Add(series[i]);
                    chart1.Series[series[i].Name].Points.Add(new DataPoint() { AxisLabel = "Process", XValue = 1, YValues = new double[] { sum, sum + Form1.schuduler1.processDuration[i] } });
                    chart1.Series[series[i].Name].Label = Form1.schuduler1.processName[i];
                    
                }
                else
                {
                    chart1.Series[series[i].Name].Points.Add(new DataPoint() { AxisLabel = "Process", XValue = 1, YValues = new double[] { sum, sum + Form1.schuduler1.processDuration[i] } });

                }
                sum += Form1.schuduler1.processDuration[i];
                chart1.ChartAreas[0].AxisY.CustomLabels.Add(sum - (Form1.schuduler1.processDuration[i] / 2), sum + Form1.schuduler1.processDuration[i] - (Form1.schuduler1.processDuration[i] / 2), Convert.ToString(sum));
            }
            averageTime.Text = Convert.ToString(Form1.schuduler1.avgTime);
        }
            private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
