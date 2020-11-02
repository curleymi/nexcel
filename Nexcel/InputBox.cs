using System.Windows.Forms;

namespace Nexcel
{
    public partial class InputBox : Form
    {
        public string InputResult => inputTextBox.Text;
        public bool OKClicked { get; private set; } = false;
        
        public InputBox(string title, string message) {
            InitializeComponent();
            
            Text = title;
            textLabel.Text = message;
            okButton.Click += (s, e) => { OKClicked = true; Close(); };
        }

        internal static string Show(IWin32Window owner, string title, string message) {
            var ib = new InputBox(title, message);
            ib.ShowDialog(owner);
            var res = ib.OKClicked ? ib.InputResult : null;
            ib.Dispose();
            return res;
        }
    }
}
