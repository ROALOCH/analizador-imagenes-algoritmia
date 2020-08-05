using System.Drawing;
using System.Windows.Forms;

namespace iP_Etapa2{
    public partial class Maximize : Form{
        public Maximize(Bitmap b){
            InitializeComponent();
            pictureBoxDisplay.Image = b;
        }
    }
}
