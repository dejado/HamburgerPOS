namespace HamburgerPOS
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuListView = new System.Windows.Forms.ListView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OrderListView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btAllCancel = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTableNum = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuListView
            // 
            this.MenuListView.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MenuListView.HideSelection = false;
            this.MenuListView.Location = new System.Drawing.Point(432, 119);
            this.MenuListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuListView.Name = "MenuListView";
            this.MenuListView.OwnerDraw = true;
            this.MenuListView.Size = new System.Drawing.Size(548, 433);
            this.MenuListView.TabIndex = 10;
            this.MenuListView.UseCompatibleStateImageBehavior = false;
            this.MenuListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MenuListView_MouseClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.bt1);
            this.flowLayoutPanel2.Controls.Add(this.bt2);
            this.flowLayoutPanel2.Controls.Add(this.bt3);
            this.flowLayoutPanel2.Controls.Add(this.bt4);
            this.flowLayoutPanel2.Controls.Add(this.MenuPanel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(432, 59);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(548, 67);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt1.Location = new System.Drawing.Point(2, 2);
            this.bt1.Margin = new System.Windows.Forms.Padding(2);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(132, 52);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "버거";
            this.bt1.UseVisualStyleBackColor = false;
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt2.Location = new System.Drawing.Point(138, 2);
            this.bt2.Margin = new System.Windows.Forms.Padding(2);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(132, 52);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "치킨";
            this.bt2.UseVisualStyleBackColor = false;
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt4.Location = new System.Drawing.Point(410, 2);
            this.bt4.Margin = new System.Windows.Forms.Padding(2);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(132, 52);
            this.bt4.TabIndex = 4;
            this.bt4.Text = "음료";
            this.bt4.UseVisualStyleBackColor = false;
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt3.Location = new System.Drawing.Point(274, 2);
            this.bt3.Margin = new System.Windows.Forms.Padding(2);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(132, 52);
            this.bt3.TabIndex = 3;
            this.bt3.Text = "사이드";
            this.bt3.UseVisualStyleBackColor = false;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Location = new System.Drawing.Point(2, 58);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(511, 439);
            this.MenuPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.OrderListView);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(2, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 493);
            this.panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 297);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 25);
            this.textBox1.TabIndex = 7;
            // 
            // OrderListView
            // 
            this.OrderListView.GridLines = true;
            this.OrderListView.HideSelection = false;
            this.OrderListView.Location = new System.Drawing.Point(0, 2);
            this.OrderListView.Margin = new System.Windows.Forms.Padding(2);
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.Size = new System.Drawing.Size(428, 285);
            this.OrderListView.TabIndex = 0;
            this.OrderListView.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btAllCancel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btCancel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btMinus, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btAdd, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btOrder, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(243, 285);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(181, 200);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btAllCancel
            // 
            this.btAllCancel.Location = new System.Drawing.Point(2, 162);
            this.btAllCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btAllCancel.Name = "btAllCancel";
            this.btAllCancel.Size = new System.Drawing.Size(176, 35);
            this.btAllCancel.TabIndex = 5;
            this.btAllCancel.Text = "전체취소";
            this.btAllCancel.UseVisualStyleBackColor = true;
            this.btAllCancel.Click += new System.EventHandler(this.btAllCancel_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(2, 122);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(176, 35);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "취소";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(2, 82);
            this.btMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(176, 35);
            this.btMinus.TabIndex = 3;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(2, 42);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(176, 35);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btOrder
            // 
            this.btOrder.Location = new System.Drawing.Point(2, 2);
            this.btOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(176, 35);
            this.btOrder.TabIndex = 1;
            this.btOrder.Text = "주문하기";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Controls.Add(this.lbTableNum);
            this.panel2.Controls.Add(this.btBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 55);
            this.panel2.TabIndex = 9;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button12.Location = new System.Drawing.Point(845, 2);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(135, 52);
            this.button12.TabIndex = 9;
            this.button12.Text = "결제하기";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // lbPrice
            // 
            this.lbPrice.Location = new System.Drawing.Point(581, 5);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(120, 48);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "총 금액 : ";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(387, 4);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(120, 48);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "TimeDate";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTableNum
            // 
            this.lbTableNum.Location = new System.Drawing.Point(154, 5);
            this.lbTableNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTableNum.Name = "lbTableNum";
            this.lbTableNum.Size = new System.Drawing.Size(120, 48);
            this.lbTableNum.TabIndex = 6;
            this.lbTableNum.Text = "table_num";
            this.lbTableNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btBack.Location = new System.Drawing.Point(2, 2);
            this.btBack.Margin = new System.Windows.Forms.Padding(2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(135, 52);
            this.btBack.TabIndex = 6;
            this.btBack.Text = "뒤로가기";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.MenuListView);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Order";
            this.Text = "Order";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView MenuListView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView OrderListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btAllCancel;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTableNum;
        private System.Windows.Forms.Button btBack;
    }
}