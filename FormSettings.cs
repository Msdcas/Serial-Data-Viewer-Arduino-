using Arduino_Serial_Data_Viewer.Classes;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace Arduino_Serial_Data_Viewer
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private int numPlot = -1;
        private int numCurve = -1;

        private void FormSettings_Load(object sender, EventArgs e)
        {
            // picture combobox
            for (int i = 0; i < CPaintManager.GetPaintersNames().Count(); i++)
                cbPictures.Items.Add($"Plot number {i}");

            foreach (SymbolType symbolType in Enum.GetValues(typeof(SymbolType)))
            {
                comboBoxCurveSymbolType.Items.Add(symbolType.ToString());
            }
            
            foreach (Color c in Common.ContrastColor)
                cbCurveColor.Items.Add(c.Name);
        }

        private void cbPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            numPlot = int.Parse(cbPictures.Text.Last().ToString()); //get i from: Plot number {i}

            // выводим данные об области отображения
            tbPictureTittle.Text = CPaintManager.GetPaintersNames()[numPlot];
            tbPictureXAxisName.Text = CPaintManager.GetNameAxis(numPlot, 'x');
            tbYAxisName.Text = CPaintManager.GetNameAxis(numPlot, 'y');

            cbCurveFromPicture.Items.Clear();
            for (int i = 0; i < CPaintManager.GetCountCurveOnPainter(numPlot); i++)
                cbCurveFromPicture.Items.Add(CPaintManager.GetCurveTittle(numPlot, i));
        }

        private void cbCurveFromPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            numCurve = cbCurveFromPicture.SelectedIndex;

            tbCurveTittle.Text = CPaintManager.GetCurveTittle(numPlot, numCurve);
            comboBoxCurveSymbolType.Text = CPaintManager.GetCurveSymbolType(numPlot, numCurve).ToString();
            var c = CPaintManager.GetCurveColor(numPlot, numCurve).Name;
            cbCurveColor.Text = c;
            mtbCountOfCurvePoints.Text = CPaintManager.GetCountCurvePoints(numPlot, numCurve).ToString();
        }

        private void bApplyPlot_Click(object sender, EventArgs e)
        {
            if (numPlot == -1) return;

            if (!string.IsNullOrEmpty(tbPictureTittle.Text))
                CPaintManager.SetPainterName(numPlot, tbPictureTittle.Text);

            if (!string.IsNullOrEmpty(tbYAxisName.Text))
                CPaintManager.SetNameAxis(numPlot, 'y', tbYAxisName.Text);

            if (!string.IsNullOrEmpty(tbPictureXAxisName.Text))
                CPaintManager.SetNameAxis(numPlot, 'x', tbPictureXAxisName.Text);
        }

        private void bApplyCurve_Click(object sender, EventArgs e)
        {
            if (numCurve == -1) return;

            CPaintManager.SetCurveSettings(numPlot, numCurve, tbCurveTittle.Text,
                Color.FromName(cbCurveColor.Text),
                (SymbolType)Enum.Parse(typeof(SymbolType), comboBoxCurveSymbolType.Text, true));

            object selectedItem = cbCurveFromPicture.SelectedItem;
            if (selectedItem != null)
            {
                int selectedIndex = cbCurveFromPicture.SelectedIndex;
                cbCurveFromPicture.Items[selectedIndex] = selectedItem.ToString().
                    Replace(cbCurveFromPicture.Text, tbCurveTittle.Text);
            }
            //CPainterManager.SetCountPoints4Curve(numPlot, numCurve, int.Parse(mtbCountOfCurvePoints.Text));

            //if (!string.IsNullOrEmpty(tbCurveTittle.Text))
            //    CPainterManager.SetCurveTittle(numPlot, numCurve, tbCurveTittle.Text);

            //CPainterManager.SetColorCurve(numPlot, numCurve, Color.FromName(cbCurveColor.Text));

            //var type = (SymbolType)Enum.Parse(typeof(SymbolType), comboBoxCurveSymbolType.Text, true);
            //CPainterManager.SetCurveSymbolType(numPlot, numCurve, type);
        }

    }
}
