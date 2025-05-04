using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCommander_WinLegacy
{
    /// <summary>
    /// Represents a UI element in an application that can be automated
    /// </summary>
    public class AppUIElement
    {
        public string Name { get; set; } = string.Empty;
        public string ElementType { get; set; } = string.Empty;
        public string AutomationId { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public bool IsTarget { get; set; }
    }
}
