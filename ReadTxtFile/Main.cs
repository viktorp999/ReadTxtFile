using System.Windows.Forms;
using ReadTxtFile.Core;

namespace ReadTxtFile
{
    public partial class Main : Form
    {
        private IReadFile _readfile;
        private OpenFileDialog _filedialog;
        private string[] _textlines;
        
        public Main(IReadFile readfile = null)
        {
            _readfile = readfile ?? new ReadFile();
            _filedialog = new OpenFileDialog
            {
                Title = "Search Text files",
                InitialDirectory = @"C:\",
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt"
            };

            InitializeComponent();
        }

        public string[] ReadTxt()
        {
            if (_filedialog.ShowDialog() == DialogResult.OK)
            {
                _textlines = _readfile.Read(_filedialog.FileName);
            }

            return _textlines;
        }

        private void ReadTxtFile(object sender, MouseEventArgs e)
        {
            ReadTxt();
            TextOutput.Lines = _textlines;
        }
    }
}
