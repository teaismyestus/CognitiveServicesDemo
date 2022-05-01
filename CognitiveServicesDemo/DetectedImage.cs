using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveServicesDemo
{
   public class DetectedImage
    {
        public Guid ImageID { get; set; }
        public byte[] ByteData { get; set; }
        public Stream StreamData { get; set; }

    }
}
