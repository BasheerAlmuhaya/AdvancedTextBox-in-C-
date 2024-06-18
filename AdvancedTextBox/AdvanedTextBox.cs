using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;


namespace AdvancedTextBox
{
    class AdvanedTextBox : TextBox
    {

        private Pen penBorder;
        private Color IdelColor = Color.DarkGray;
        private Color FocusedColor = Color.Red;
        private String placeHolder = "";
        private Color OldForColor = Color.Black;
        private bool IsFocused = false;
        private bool isPassword = false;
        private String passwordChart = "";



        public AdvanedTextBox()
            : base()
        {
            SetStyle(ControlStyles.UserPaint, true);
            OldForColor = this.ForeColor;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (IsFocused)
            SetFocusedBorder(e);
            else
                SetIdelBorder(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            IsFocused = true;
            
            if (this.Text == PlaceHolder)
            {
                this.Text = "";
                this.ForeColor = OldForColor;
            }
            Refresh();
            base.OnEnter(e);
            
        }

        protected override void OnLeave(EventArgs e)
        {
            IsFocused = false;

            if (this.Text == "")
            {
                this.Text = placeHolder;
                this.ForeColor = Color.LightGray;
            }
            else
            {
                this.ForeColor = OldForColor;
            }
            
            base.OnLeave(e);
            Refresh();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
{


    if (isPassword)
    {

        if (e.KeyChar.GetHashCode().ToString() == "524296")
        {
            if (Tag.ToString().Length != 0)
            {
                Tag = Tag.ToString().Substring(0, Tag.ToString().Length - 1);
                Text = "";
                for (int i = 0; i < Tag.ToString().Length; i++)
                {
                    Text += passwordChart;
                }
            }
            return;
        }
        else if (e.KeyChar.GetHashCode().ToString() == "851981") return;


        Tag += e.KeyChar.ToString();
        e.Handled = true;
        Text = "";
        for (int i = 0; i < Tag.ToString().Length; i++)
        {
            Text += passwordChart;
        }


    }

}


        private void SetFocusedBorder(PaintEventArgs e)
        {
            penBorder = new Pen(FocusedColor, 1);
            Rectangle rectBorder = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            e.Graphics.DrawRectangle(penBorder, rectBorder);
            Rectangle textRect = new Rectangle(e.ClipRectangle.X+1 , e.ClipRectangle.Y+1 , e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            e.Graphics.DrawString(Text, Font, Brushes.Black, textRect);
            //TextRenderer.DrawText(e.Graphics, Text, Font, textRect, this.ForeColor, this.BackColor, TextFormatFlags.ModifyString);
        }

        private void SetIdelBorder(PaintEventArgs e)
        {
            penBorder = new Pen(IdelColor, 1);  
            Rectangle rectBorder = new Rectangle(e.ClipRectangle.X , e.ClipRectangle.Y , e.ClipRectangle.Width-1, e.ClipRectangle.Height-1);
            e.Graphics.DrawRectangle(penBorder, rectBorder);
            
            Rectangle textRect = new Rectangle(e.ClipRectangle.X+1, e.ClipRectangle.Y+1, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            e.Graphics.DrawString(Text, Font, Brushes.Black, textRect);
            //TextRenderer.DrawText(e.Graphics, Text, Font, textRect, this.ForeColor, this.BackColor, TextFormatFlags.ModifyString);
        }





        public Color IdelBorderColor
        {
            set
            {
                IdelColor = value;
                Refresh();
            }

            get
            {
                return IdelColor;
            }
        }

        public Color FocusedlBorderColor
        {
            set
            {
                FocusedColor = value;
                Refresh();
            }

            get
            {
                return FocusedColor;
            }
        }

        public String PlaceHolder
        {
            set
            {
                placeHolder = value;
                Text = placeHolder;
                Refresh();
            }

            get
            {
                return placeHolder;
            }
        }
        
        public String Designer
        {
            get
            {
                return "Emran Al Hadad";
            }
            
        }

        public String MyPasswordChart
        {

            set
            {
                passwordChart = value;
            }

            get
            {
                return passwordChart;
            }
        }

        public bool ISPassword
        {

            set
            {
                isPassword = value;
            }

            get
            {
                return isPassword;
            }
        }

        public override bool Multiline
        {
            get
            {
                return base.Multiline;
            }
            
        }
}
        }
    

