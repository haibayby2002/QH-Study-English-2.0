using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QHStudyEnglish
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        void SetToolTip_Init()
        {
            // Navigator
            tooltTip.SetToolTip(btnBack, "Back");
            tooltTip.SetToolTip(btnFoward, "Foward");

            //Function------------------------------------------------------------------
            tooltTip.SetToolTip(btnAddVocaSet, "Thêm bộ từ mới");
            tooltTip.SetToolTip(btnRemoveVocaSet, "Xóa bộ từ đã chọn");
            tooltTip.SetToolTip(btnEditVocaSet, "Chỉnh sửa bộ từ");

            //Thêm bộ từ nhanh
            tooltTip.SetToolTip(btnOpenVocaSet, "Mở bộ từ có sãn để thêm");
            tooltTip.SetToolTip(btnCamera, "Đọc ảnh để thêm bộ từ");
            tooltTip.SetToolTip(btnAddByRegex, "Đọc ảnh dùng biểu thức chính quy");
            /* ---------------------------------------------------------------------- */

            //Learn-------------------------------------------------------------------
            tooltTip.SetToolTip(btnPractice, "Luyện tập từ vựng");
            tooltTip.SetToolTip(btnLearn, "Học từ vựng");
            /* ---------------------------------------------------------------------- */
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetToolTip_Init();
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvMyVocaSet.View = (View)(cmbView.SelectedIndex);
            lsvRecommendedVocaSet.View = (View)(cmbView.SelectedIndex);
        }
    }
}
