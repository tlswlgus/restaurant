using System.Diagnostics;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        String[,] menu = new String[,]
            {
                { "Ratatouille","Colorful vegetable stew with herbs", "100.00", "Main" },
                { "Duck à l'Orange", "Crispy duck in a zesty orange glaze", "75.54", "Main" },
                { "Steak", "Meat", "200.50", "Main" },
                { "Lemonade", "Beverge","50.00", "Beverage"},
                { "Chocolate Ice Cream", "Sweety", "80.00", "Dessert" },
                { "Cake d’Alsace","Bacon, Gruyère, and caramelized onion loaf","150.00","Appetizer;"}

            };
        int arMenu;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlPopup.Left = (this.Size.Width - pnlPopup.Size.Width) / 2;
            pnlPopup.Top = (this.Size.Height - pnlPopup.Size.Height) / 2;

            for (int i = 0; i < menu.GetLength(0); i++)
            {
                Panel pnlMenu = new Panel();

                pnlMenu.Size = new Size(250, 270);
                pnlMenu.BorderStyle = BorderStyle.FixedSingle;
                flpnlMenu.Controls.Add(pnlMenu);

                PictureBox picMenuPic = new PictureBox();

                picMenuPic.Size = new Size(100, 100);
                picMenuPic.Location = new Point(0, 12);
                picMenuPic.Left = (pnlMenu.Size.Width - picMenuPic.Size.Width) / 2;
                picMenuPic.Image = Properties.Resources.X;
                picMenuPic.SizeMode = PictureBoxSizeMode.StretchImage;
                pnlMenu.Controls.Add(picMenuPic);

                Label lblMenuFood = new Label();
                lblMenuFood.Text = menu[i, 0];
                lblMenuFood.AutoSize = true;
                lblMenuFood.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
                lblMenuFood.Location = new Point(0, 120);
                pnlMenu.Controls.Add(lblMenuFood);
                lblMenuFood.Left = (pnlMenu.Size.Width - lblMenuFood.Size.Width) / 2;

                Label lblMenuDesc = new Label();
                lblMenuDesc.Text = menu[i, 1];
                lblMenuDesc.MaximumSize = new Size(230, 0);
                lblMenuDesc.AutoSize = true;
                lblMenuDesc.Font = new Font("Segoe UI", 12);
                lblMenuDesc.Location = new Point(0, 152);
                pnlMenu.Controls.Add(lblMenuDesc);
                lblMenuDesc.Left = (pnlMenu.Size.Width - lblMenuDesc.Size.Width) / 2;

                Label lblMenuPrice = new Label();
                lblMenuPrice.Text = "₱ " + menu[i, 2];
                lblMenuPrice.AutoSize = true;
                lblMenuPrice.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                lblMenuPrice.Location = new Point(0, 225);
                pnlMenu.Controls.Add(lblMenuPrice);
                lblMenuPrice.Left = (pnlMenu.Size.Width - lblMenuPrice.Size.Width) / 8;

                Button btnDetail = new Button();
                btnDetail.Text = "Details ";
                btnDetail.Name = "btnDetail" + i;
                btnDetail.AutoSize = true;
                btnDetail.FlatStyle = FlatStyle.Flat;
                btnDetail.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                btnDetail.Location = new Point(0, 220);
                pnlMenu.Controls.Add(btnDetail);
                btnDetail.Left = (pnlMenu.Size.Width - btnDetail.Size.Width) - lblMenuPrice.Location.X;
                btnDetail.Click += btnDetailShow_Click;
            }
        }

        private void pnlTotal_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);

            Point startPoint = new Point(0, pnlTotal.Size.Height -2);
            Point endPoint = new Point(285, pnlTotal.Size.Height - 2);
            e.Graphics.DrawLine(pen, startPoint, endPoint);

            pen.Dispose();
        }

        private void btnDetailShow_Click(object sender, EventArgs e)
        {
            arMenu = int.Parse((((Button)sender).Name).Replace("btnDetail", "").Trim());
            lblDescName.Text = menu[arMenu, 0];
            lblDescBig.Text = menu[arMenu, 1];
            lblDescPrice.Text = "₱ " + menu[arMenu, 2];
            lblQuantity.Text = "0";
            flpnlMenu.Visible = false;
            pnlMenuDetail.Visible = true;

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblQuantity.Text) >= 1)
            {
                Panel pnlDetailOrder = new Panel();
                pnlDetailOrder.Size = new Size(285, 100);
                pnlDetailOrder.BorderStyle = BorderStyle.FixedSingle;
                flpnlDetail.Controls.Add(pnlDetailOrder);

                Label lblDetailFood = new Label();
                lblDetailFood.Text = menu[arMenu, 0];
                lblDetailFood.AutoSize = true;
                lblDetailFood.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                lblDetailFood.Location = new Point(93, 23);
                pnlDetailOrder.Controls.Add(lblDetailFood);

                Label lblDetailUnit = new Label();
                lblDetailUnit.Text = "₱ " + menu[arMenu, 2] + " x " + lblQuantity.Text;
                lblDetailUnit.AutoSize = true;
                lblDetailUnit.Font = new Font("Segoe UI", 12);
                lblDetailUnit.Location = new Point(93, 55);
                pnlDetailOrder.Controls.Add(lblDetailUnit);

                Label lblDetailTotal = new Label();
                lblDetailTotal.Text = String.Format("₱ {0:0.00}", double.Parse(menu[arMenu, 2]) * double.Parse(lblQuantity.Text));
                lblDetailTotal.AutoSize = true;
                lblDetailTotal.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblDetailTotal.Location = new Point(0, 55);
                pnlDetailOrder.Controls.Add(lblDetailTotal);
                lblDetailTotal.Left = (pnlDetailOrder.Size.Width - lblDetailTotal.Size.Width) - 10;

                lblTotalPrice.Text = String.Format("₱ {0:0.00}", double.Parse(lblDetailTotal.Text.Replace("₱", "").Trim()) + double.Parse(lblTotalPrice.Text.Replace("₱", "").Trim()));
                lblTotalPrice.Left = (pnlTotal.Size.Width - lblTotalPrice.Size.Width);
            }
            flpnlMenu.Visible = true;
            pnlMenuDetail.Visible = false;
        }


        private void pnlMenuDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrderPlus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lblQuantity.Text);
            if (quantity != 99)
            {
                lblQuantity.Text = (quantity + 1).ToString();
            }

        }

        private void btnOrderMinus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lblQuantity.Text);
            if (quantity != 0)
            {
                lblQuantity.Text = (quantity - 1).ToString();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            flpnlMenu.Controls.Clear();
            for (int i = 0; i < menu.GetLength(0); i++)
            {
                Panel pnlMenu = new Panel();

                pnlMenu.Size = new Size(250, 270);
                pnlMenu.BorderStyle = BorderStyle.FixedSingle;
                flpnlMenu.Controls.Add(pnlMenu);

                PictureBox picMenuPic = new PictureBox();

                picMenuPic.Size = new Size(100, 100);
                picMenuPic.Location = new Point(0, 12);
                picMenuPic.Left = (pnlMenu.Size.Width - picMenuPic.Size.Width) / 2;
                picMenuPic.Image = Properties.Resources.X;
                picMenuPic.SizeMode = PictureBoxSizeMode.StretchImage;
                pnlMenu.Controls.Add(picMenuPic);

                Label lblMenuFood = new Label();
                lblMenuFood.Text = menu[i, 0];
                lblMenuFood.AutoSize = true;
                lblMenuFood.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
                lblMenuFood.Location = new Point(0, 120);
                pnlMenu.Controls.Add(lblMenuFood);
                lblMenuFood.Left = (pnlMenu.Size.Width - lblMenuFood.Size.Width) / 2;

                Label lblMenuDesc = new Label();
                lblMenuDesc.Text = menu[i, 1];
                lblMenuDesc.MaximumSize = new Size(230, 0);
                lblMenuDesc.AutoSize = true;
                lblMenuDesc.Font = new Font("Segoe UI", 12);
                lblMenuDesc.Location = new Point(0, 152);
                pnlMenu.Controls.Add(lblMenuDesc);
                lblMenuDesc.Left = (pnlMenu.Size.Width - lblMenuDesc.Size.Width) / 2;

                Label lblMenuPrice = new Label();
                lblMenuPrice.Text = "₱ " + menu[i, 2];
                lblMenuPrice.AutoSize = true;
                lblMenuPrice.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                lblMenuPrice.Location = new Point(0, 225);
                pnlMenu.Controls.Add(lblMenuPrice);
                lblMenuPrice.Left = (pnlMenu.Size.Width - lblMenuPrice.Size.Width) / 8;

                Button btnDetail = new Button();
                btnDetail.Text = "Details ";
                btnDetail.Name = "btnDetail" + i;
                btnDetail.AutoSize = true;
                btnDetail.FlatStyle = FlatStyle.Flat;
                btnDetail.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                btnDetail.Location = new Point(0, 220);
                pnlMenu.Controls.Add(btnDetail);
                btnDetail.Left = (pnlMenu.Size.Width - btnDetail.Size.Width) - lblMenuPrice.Location.X;
                btnDetail.Click += btnDetailShow_Click;
            }
        }

        private void btnAppet_Click(object sender, EventArgs e)
        {
            flpnlMenu.Controls.Clear();
            for (int i = 0; i < menu.GetLength(0); i++)
            {
                if (menu[i, 3] == "Appetizer")
                {
                    Panel pnlMenu = new Panel();

                    pnlMenu.Size = new Size(250, 270);
                    pnlMenu.BorderStyle = BorderStyle.FixedSingle;
                    flpnlMenu.Controls.Add(pnlMenu);

                    PictureBox picMenuPic = new PictureBox();

                    picMenuPic.Size = new Size(100, 100);
                    picMenuPic.Location = new Point(0, 12);
                    picMenuPic.Left = (pnlMenu.Size.Width - picMenuPic.Size.Width) / 2;
                    picMenuPic.Image = Properties.Resources.X;
                    picMenuPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pnlMenu.Controls.Add(picMenuPic);

                    Label lblMenuFood = new Label();
                    lblMenuFood.Text = menu[i, 0];
                    lblMenuFood.AutoSize = true;
                    lblMenuFood.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
                    lblMenuFood.Location = new Point(0, 120);
                    pnlMenu.Controls.Add(lblMenuFood);
                    lblMenuFood.Left = (pnlMenu.Size.Width - lblMenuFood.Size.Width) / 2;

                    Label lblMenuDesc = new Label();
                    lblMenuDesc.Text = menu[i, 1];
                    lblMenuDesc.MaximumSize = new Size(230, 0);
                    lblMenuDesc.AutoSize = true;
                    lblMenuDesc.Font = new Font("Segoe UI", 12);
                    lblMenuDesc.Location = new Point(0, 152);
                    pnlMenu.Controls.Add(lblMenuDesc);
                    lblMenuDesc.Left = (pnlMenu.Size.Width - lblMenuDesc.Size.Width) / 2;

                    Label lblMenuPrice = new Label();
                    lblMenuPrice.Text = "₱ " + menu[i, 2];
                    lblMenuPrice.AutoSize = true;
                    lblMenuPrice.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                    lblMenuPrice.Location = new Point(0, 225);
                    pnlMenu.Controls.Add(lblMenuPrice);
                    lblMenuPrice.Left = (pnlMenu.Size.Width - lblMenuPrice.Size.Width) / 8;

                    Button btnDetail = new Button();
                    btnDetail.Text = "Details ";
                    btnDetail.Name = "btnDetail" + i;
                    btnDetail.AutoSize = true;
                    btnDetail.FlatStyle = FlatStyle.Flat;
                    btnDetail.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                    btnDetail.Location = new Point(0, 220);
                    pnlMenu.Controls.Add(btnDetail);
                    btnDetail.Left = (pnlMenu.Size.Width - btnDetail.Size.Width) - lblMenuPrice.Location.X;
                    btnDetail.Click += btnDetailShow_Click;
                }

            }
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            flpnlMenu.Controls.Clear();
            for (int i = 0; i < menu.GetLength(0); i++)
            {
                if (menu[i, 3] == "Main")
                {
                    Panel pnlMenu = new Panel();

                    pnlMenu.Size = new Size(250, 270);
                    pnlMenu.BorderStyle = BorderStyle.FixedSingle;
                    flpnlMenu.Controls.Add(pnlMenu);

                    PictureBox picMenuPic = new PictureBox();

                    picMenuPic.Size = new Size(100, 100);
                    picMenuPic.Location = new Point(0, 12);
                    picMenuPic.Left = (pnlMenu.Size.Width - picMenuPic.Size.Width) / 2;
                    picMenuPic.Image = Properties.Resources.X;
                    picMenuPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pnlMenu.Controls.Add(picMenuPic);

                    Label lblMenuFood = new Label();
                    lblMenuFood.Text = menu[i, 0];
                    lblMenuFood.AutoSize = true;
                    lblMenuFood.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
                    lblMenuFood.Location = new Point(0, 120);
                    pnlMenu.Controls.Add(lblMenuFood);
                    lblMenuFood.Left = (pnlMenu.Size.Width - lblMenuFood.Size.Width) / 2;

                    Label lblMenuDesc = new Label();
                    lblMenuDesc.Text = menu[i, 1];
                    lblMenuDesc.MaximumSize = new Size(230, 0);
                    lblMenuDesc.AutoSize = true;
                    lblMenuDesc.Font = new Font("Segoe UI", 12);
                    lblMenuDesc.Location = new Point(0, 152);
                    pnlMenu.Controls.Add(lblMenuDesc);
                    lblMenuDesc.Left = (pnlMenu.Size.Width - lblMenuDesc.Size.Width) / 2;

                    Label lblMenuPrice = new Label();
                    lblMenuPrice.Text = "₱ " + menu[i, 2];
                    lblMenuPrice.AutoSize = true;
                    lblMenuPrice.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                    lblMenuPrice.Location = new Point(0, 225);
                    pnlMenu.Controls.Add(lblMenuPrice);
                    lblMenuPrice.Left = (pnlMenu.Size.Width - lblMenuPrice.Size.Width) / 8;

                    Button btnDetail = new Button();
                    btnDetail.Text = "Details ";
                    btnDetail.Name = "btnDetail" + i;
                    btnDetail.AutoSize = true;
                    btnDetail.FlatStyle = FlatStyle.Flat;
                    btnDetail.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                    btnDetail.Location = new Point(0, 220);
                    pnlMenu.Controls.Add(btnDetail);
                    btnDetail.Left = (pnlMenu.Size.Width - btnDetail.Size.Width) - lblMenuPrice.Location.X;
                    btnDetail.Click += btnDetailShow_Click;
                }

            }
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            flpnlMenu.Controls.Clear();
            for (int i = 0; i < menu.GetLength(0); i++)
            {
                if (menu[i, 3] == "Dessert")
                {
                    Panel pnlMenu = new Panel();

                    pnlMenu.Size = new Size(250, 270);
                    pnlMenu.BorderStyle = BorderStyle.FixedSingle;
                    flpnlMenu.Controls.Add(pnlMenu);

                    PictureBox picMenuPic = new PictureBox();

                    picMenuPic.Size = new Size(100, 100);
                    picMenuPic.Location = new Point(0, 12);
                    picMenuPic.Left = (pnlMenu.Size.Width - picMenuPic.Size.Width) / 2;
                    picMenuPic.Image = Properties.Resources.X;
                    picMenuPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pnlMenu.Controls.Add(picMenuPic);

                    Label lblMenuFood = new Label();
                    lblMenuFood.Text = menu[i, 0];
                    lblMenuFood.AutoSize = true;
                    lblMenuFood.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
                    lblMenuFood.Location = new Point(0, 120);
                    pnlMenu.Controls.Add(lblMenuFood);
                    lblMenuFood.Left = (pnlMenu.Size.Width - lblMenuFood.Size.Width) / 2;

                    Label lblMenuDesc = new Label();
                    lblMenuDesc.Text = menu[i, 1];
                    lblMenuDesc.MaximumSize = new Size(230, 0);
                    lblMenuDesc.AutoSize = true;
                    lblMenuDesc.Font = new Font("Segoe UI", 12);
                    lblMenuDesc.Location = new Point(0, 152);
                    pnlMenu.Controls.Add(lblMenuDesc);
                    lblMenuDesc.Left = (pnlMenu.Size.Width - lblMenuDesc.Size.Width) / 2;

                    Label lblMenuPrice = new Label();
                    lblMenuPrice.Text = "₱ " + menu[i, 2];
                    lblMenuPrice.AutoSize = true;
                    lblMenuPrice.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                    lblMenuPrice.Location = new Point(0, 225);
                    pnlMenu.Controls.Add(lblMenuPrice);
                    lblMenuPrice.Left = (pnlMenu.Size.Width - lblMenuPrice.Size.Width) / 8;

                    Button btnDetail = new Button();
                    btnDetail.Text = "Details ";
                    btnDetail.Name = "btnDetail" + i;
                    btnDetail.AutoSize = true;
                    btnDetail.FlatStyle = FlatStyle.Flat;
                    btnDetail.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                    btnDetail.Location = new Point(0, 220);
                    pnlMenu.Controls.Add(btnDetail);
                    btnDetail.Left = (pnlMenu.Size.Width - btnDetail.Size.Width) - lblMenuPrice.Location.X;
                    btnDetail.Click += btnDetailShow_Click;
                }

            }
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            flpnlMenu.Controls.Clear();
            for (int i = 0; i < menu.GetLength(0); i++)
            {
                if (menu[i, 3] == "Beverage")
                {
                    Panel pnlMenu = new Panel();

                    pnlMenu.Size = new Size(250, 270);
                    pnlMenu.BorderStyle = BorderStyle.FixedSingle;
                    flpnlMenu.Controls.Add(pnlMenu);

                    PictureBox picMenuPic = new PictureBox();

                    picMenuPic.Size = new Size(100, 100);
                    picMenuPic.Location = new Point(0, 12);
                    picMenuPic.Left = (pnlMenu.Size.Width - picMenuPic.Size.Width) / 2;
                    picMenuPic.Image = Properties.Resources.X;
                    picMenuPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pnlMenu.Controls.Add(picMenuPic);

                    Label lblMenuFood = new Label();
                    lblMenuFood.Text = menu[i, 0];
                    lblMenuFood.AutoSize = true;
                    lblMenuFood.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
                    lblMenuFood.Location = new Point(0, 120);
                    pnlMenu.Controls.Add(lblMenuFood);
                    lblMenuFood.Left = (pnlMenu.Size.Width - lblMenuFood.Size.Width) / 2;

                    Label lblMenuDesc = new Label();
                    lblMenuDesc.Text = menu[i, 1];
                    lblMenuDesc.MaximumSize = new Size(230, 0);
                    lblMenuDesc.AutoSize = true;
                    lblMenuDesc.Font = new Font("Segoe UI", 12);
                    lblMenuDesc.Location = new Point(0, 152);
                    pnlMenu.Controls.Add(lblMenuDesc);
                    lblMenuDesc.Left = (pnlMenu.Size.Width - lblMenuDesc.Size.Width) / 2;

                    Label lblMenuPrice = new Label();
                    lblMenuPrice.Text = "₱ " + menu[i, 2];
                    lblMenuPrice.AutoSize = true;
                    lblMenuPrice.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                    lblMenuPrice.Location = new Point(0, 225);
                    pnlMenu.Controls.Add(lblMenuPrice);
                    lblMenuPrice.Left = (pnlMenu.Size.Width - lblMenuPrice.Size.Width) / 8;

                    Button btnDetail = new Button();
                    btnDetail.Text = "Details ";
                    btnDetail.Name = "btnDetail" + i;
                    btnDetail.AutoSize = true;
                    btnDetail.FlatStyle = FlatStyle.Flat;
                    btnDetail.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                    btnDetail.Location = new Point(0, 220);
                    pnlMenu.Controls.Add(btnDetail);
                    btnDetail.Left = (pnlMenu.Size.Width - btnDetail.Size.Width) - lblMenuPrice.Location.X;
                    btnDetail.Click += btnDetailShow_Click;
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
        }

        private void pnlClosePop_Click(object sender, EventArgs e)
        {
            pnlPopup.Visible = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            var uiHostNoLaunch = new UIHostNoLaunch();
            var tipInvocation = (ITipInvocation)uiHostNoLaunch;
            tipInvocation.Toggle(GetDesktopWindow());
            Marshal.ReleaseComObject(uiHostNoLaunch);
        }
        [ComImport, Guid("4ce576fa-83dc-4F88-951c-9d0782b4e376")]
        class UIHostNoLaunch
        {
        }

        [ComImport, Guid("37c994e7-432b-4834-a2f7-dce1f13b834b")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        interface ITipInvocation
        {
            void Toggle(IntPtr hwnd);
        }

        [DllImport("user32.dll", SetLastError = false)]
        static extern IntPtr GetDesktopWindow();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnlTopPopUp_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);

            Point startPoint = new Point(0, pnlTopPopUp.Size.Height - 2);
            Point endPoint = new Point(600, pnlTopPopUp.Size.Height - 2);
            e.Graphics.DrawLine(pen, startPoint, endPoint);

            pen.Dispose();
        }
    }
}
