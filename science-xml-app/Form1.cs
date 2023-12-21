using science_xml_app.Strategy;
using System.Xml.Serialization;

namespace science_xml_app
{
    public partial class Form1 : Form
    {
        private XmlToHtmlConvertService _htmlService;
        private IEnumerable<Scientific> _data;
        private IEnumerable<Scientific> _groupedData;

        private string _filepath;

        public Form1()
        {
            this._htmlService = new XmlToHtmlConvertService();

            this._data = new List<Scientific>();
            this._groupedData = new List<Scientific>();

            InitializeComponent();

            _filepath = string.Empty;
            this.saxButton.Checked = true;
        }

        private void xmlTranformButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "XSLT Files|*.xslt|All Files|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var xsltFilePath = dialog.FileName;

                var htmlDialog = new SaveFileDialog();
                if (htmlDialog.ShowDialog() == DialogResult.OK)
                {
                    this._htmlService.XmlToHTML(this._filepath, xsltFilePath, htmlDialog.FileName + ".html");

                    MessageBox.Show("Converted to HTML file.");
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Filter = "XML Files|*.xml|All Files|*.*";
            dialog.Title = "Select an XML File";

            this.Clear();


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _filepath = dialog.FileName;
                this.Load(dialog.FileName);
                this.RefreshTextBox();
            }
        }

        private void Clear()
        {
            this.contentTextBox.Clear();
            this._data = new List<Scientific>();
            this._groupedData = new List<Scientific>();
            this.cafedraComboBox.Items.Clear();
            this.faculcyComboBox.Items.Clear();
            this.levelsComboBox.Items.Clear();
            this.cafedraComboBox.SelectedIndex = -1;
            this.faculcyComboBox.SelectedIndex = -1;
            this.levelsComboBox.SelectedIndex = -1;
            this.cafedraComboBox.Text = "";
            this.faculcyComboBox.Text = "";
            this.levelsComboBox.Text = "";
        }

        private void Load(string xmlFilePath)
        {
            IStrategy strategy = null!;
            if (this.saxButton.Checked)
            {
                strategy = new SAXStrategy();
            }
            else
            {
                if (this.domButton.Checked)
                {
                    strategy = new DOMStrategy();
                }
                else
                {
                    strategy = new LINQStrategy();
                }
            }

            var data = strategy.ProcessXML(xmlFilePath);
            this.Visualize(data, firstLoad: true);

        }

        private void Visualize(IEnumerable<Scientific> scientifics, bool firstLoad = false)
        {
            if (firstLoad)
            {
                this._data = scientifics;
            }

            this.contentTextBox.Text = "";

            foreach (var scientific in scientifics)
            {
                string scientificsInText = "";

                scientificsInText += $"ID = {scientific.Id}\n";
                scientificsInText += $"FullName = {scientific.FullName}\n";
                scientificsInText += $"Faculcy = {scientific.Faculcy}\n";
                scientificsInText += $"Cafedra = {scientific.Cafedra}\n";
                scientificsInText += $"Level = {scientific.Level}\n";
                scientificsInText += $"WhenGotLevel = {scientific.WhenGotLevel}\n\n";

                this.contentTextBox.Text += scientificsInText;
            }


        }

        private void RefreshTextBox()
        {
            var cafedras = this._data.Select(x => x.Cafedra).Distinct().ToList();
            this.cafedraComboBox.Items.Add("");
            this.cafedraComboBox.Items.AddRange(cafedras.ToArray());

            var faculcies = this._data.Select(x => x.Faculcy).Distinct().ToList();
            this.faculcyComboBox.Items.Add("");
            this.faculcyComboBox.Items.AddRange(faculcies.ToArray());

            var levels = this._data.Select(x => x.Level).Distinct().ToList();
            this.levelsComboBox.Items.Add("");
            this.levelsComboBox.Items.AddRange(levels.ToArray());
        }

        private void ConvertXmlToHTML(string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<Scientific>));

            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, _groupedData);
            }
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e) => this.ProcessGroupingDataByCriteria();

        private void ProcessGroupingDataByCriteria()
        {
            var cafedra = cafedraComboBox.SelectedItem?.ToString();
            var faculcy = faculcyComboBox.SelectedItem?.ToString();
            var level = levelsComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(cafedra) || !string.IsNullOrEmpty(faculcy) || !string.IsNullOrEmpty(level))
            {
                this._groupedData = this._data.Where(x =>
                        (string.IsNullOrEmpty(cafedra) || x.Cafedra == cafedra) &&
                        (string.IsNullOrEmpty(faculcy) || x.Faculcy == faculcy) &&
                        (string.IsNullOrEmpty(level) || x.Level == level)).ToList();
            }
            else
            {
                this._groupedData = this._data;
            }

            this.Visualize(this._groupedData);
        }

        private void faculcyComboBox_SelectedIndexChanged(object sender, EventArgs e) => this.ProcessGroupingDataByCriteria();

        private void departamentComboBox_SelectedIndexChanged(object sender, EventArgs e) => this.ProcessGroupingDataByCriteria();

        private void clearButton_Click(object sender, EventArgs e) => Clear();

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "XML Files|*.xml|All Files|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = dialog.FileName;

                ConvertXmlToHTML(filePath);

                MessageBox.Show("Xml was saved");
            }
        }
    }
}