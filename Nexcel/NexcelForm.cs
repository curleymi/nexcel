///
/// NexcelForm.cs
/// Created 11/2/20
///

using static Nexcel.Extensions.Controls;
using System.Linq;
using System.Windows.Forms;
using System;

namespace Nexcel
{
    public partial class NexcelForm : Form
    {
        private static readonly object _lock = new object();

        private bool firstSheetCreated = false;
        private const string FirstSheetName = "Sheet1";

        public NexcelForm() {
            InitializeComponent();
            addSheetIndexComboBox.SelectedIndex = 0;
            HandleCreated += ThreadSafeCreateFirstSheetHandler;
            sheetTabControl.SelectedIndexChanged += (s, e) => sheetComboBox.SelectedIndex = sheetTabControl.SelectedIndex;
        }

        private void ThreadSafeCreateFirstSheetHandler(object sender, EventArgs e) {
            if (!firstSheetCreated) {
                lock (_lock) {
                    if (!firstSheetCreated) {
                        sheetTabControl.BeginInvoke(new Action(() => AddSheet(FirstSheetName)));
                        firstSheetCreated = true;
                    }
                }
            }
        }

        private void RefreshSheetInfo(int selectedIndex) {
            sheetComboBox.DataSource = sheetTabControl.TabPages().Select(tp => tp.Text).ToList();
            addSheetIndexComboBox.SelectedIndex = 1;
            if (selectedIndex >= 0) {
                sheetComboBox.SelectedIndex = selectedIndex;
                sheetTabControl.SelectedIndex = selectedIndex;
            }
        }

        private void AddSheet(string name) {
            if (string.IsNullOrEmpty(name)) {
                return;
            }
            if (sheetTabControl.TabPages().Any(tp => tp.Text.Equals(name))) {
                // todo: display error
                return;
            }
            var tp = new TabPage(name);
            // do some init
            var newSheetIndex = sheetTabControl.TabPages.Count == 0 ? 0 :
                sheetComboBox.SelectedIndex + addSheetIndexComboBox.SelectedIndex;
            sheetTabControl.TabPages.Insert(newSheetIndex, tp);
            RefreshSheetInfo(newSheetIndex);
            deleteSheetButton.Enabled = true;
            addSheetTextBox.Clear();
        }

        private void decreaseSheetIndexButton_Click(object sender, EventArgs e) {
            if (sheetTabControl.TabCount > 1) {
                var i = sheetTabControl.SelectedIndex;
                if (i > 0) {
                    var tp = sheetTabControl.TabPages().ToList()[i];
                    sheetTabControl.TabPages.RemoveAt(i--);
                    sheetTabControl.TabPages.Insert(i, tp);
                    RefreshSheetInfo(i);
                }
            }
        }

        private void increaseSheetIndexButton_Click(object sender, EventArgs e) {
            if (sheetTabControl.TabCount > 1) {
                var i = sheetTabControl.SelectedIndex;
                if (i >= 0 && i < sheetTabControl.TabCount - 1) {
                    var tp = sheetTabControl.TabPages().ToList()[i];
                    sheetTabControl.TabPages.RemoveAt(i++);
                    sheetTabControl.TabPages.Insert(i, tp);
                    RefreshSheetInfo(i);
                }
            }
        }

        private void addSheetButton_Click(object sender, EventArgs e) {
            AddSheet(addSheetTextBox.Text);
        }

        private void deleteSheetButton_Click(object sender, EventArgs e) {
            if (sheetTabControl.TabPages.Count > 0) {
                sheetTabControl.TabPages.RemoveAt(sheetTabControl.SelectedIndex);
                RefreshSheetInfo(sheetTabControl.SelectedIndex);
            }
            if (sheetTabControl.TabPages.Count == 0) {
                addSheetIndexComboBox.SelectedIndex = 0;
                deleteSheetButton.Enabled = false;
                if (string.IsNullOrEmpty(addSheetTextBox.Text)) {
                    addSheetTextBox.Text = FirstSheetName;
                }
            }
        }
    }
}
