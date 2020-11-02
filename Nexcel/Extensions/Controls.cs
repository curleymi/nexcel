using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Nexcel.Extensions
{
    internal static class Controls
    {
        internal static IEnumerable<TabPage> TabPages(this TabControl tc) => tc.TabPages.Cast<TabPage>();
    }
}
