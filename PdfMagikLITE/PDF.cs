using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SharpShell.Attributes;
using SharpShell.SharpContextMenu;

namespace PdfMagikLITE {
    
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.ClassOfExtension, ".pdf")]
    public class PDF : SharpContextMenu {

        
    }
}
