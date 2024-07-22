using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer
{
    public class Destination
    {
        private string? _duration;
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Location { get; set; }
        public string Duration
        {
            get => _duration!;
            set
            {
                _duration = string.IsNullOrEmpty(value) ? "0" : value;

                // Parse the duration string to an integer (in minutes)
                DestinationDuration = int.TryParse(_duration.Split(' ')[0], out int parsedDuration) ? parsedDuration : 0;
            }
        }
        public int DestinationDuration { get; set; }
        public string? Description { get; set; }
    }
}
