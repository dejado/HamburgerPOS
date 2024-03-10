using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HamburgerPOS
{
    public partial class Base : Form
    {
        private const int TableCount = 6;
        //상수 설정하여 개수를 고정함

        public Base()
        {
            InitializeComponent();
            LabelEvent();
            dataContainer = new DataContainer();
        }

        private DataContainer dataContainer;
        //data를 주고 받을 수 있도록 선언
        public Base(DataContainer data)
        {
            this.dataContainer = data;

            InitializeComponent();
            LabelEvent();
            TablePrice(dataContainer.table, dataContainer.price);
            TableMenu(dataContainer.table,dataContainer.menu);
        }
        private void LabelEvent()
        {
            // 이미 생성된 라벨에 이벤트 핸들러 추가
            for (int i = 1; i <= TableCount; i++)
            {
                // 라벨 이름을 이용하여 라벨 찾기
                Control[] controls = Controls.Find("orderTable" + i.ToString(), true);

                if (controls.Length > 0 && controls[0] is Label)
                {
                    // 라벨에 클릭 이벤트 핸들러 등록
                    ((Label)controls[0]).Click += Label_Click;
                }
            }

            // 이미 생성된 라벨에 이벤트 핸들러 추가
            for (int i = 1; i <= TableCount; i++)
            {
                // 라벨 이름을 이용하여 라벨 찾기
                Control[] controls = Controls.Find("orderTakeout" + i.ToString(), true);

                if (controls.Length > 0 && controls[0] is Label)
                {
                    // 라벨에 클릭 이벤트 핸들러 등록
                    ((Label)controls[0]).Click += Label_Click;
                }
            }
        }
        private void TablePrice(List<string> table, List<int> price)
        {
            for (int i = 0; i < table.Count; i++)
            {
                // 라벨의 텍스트 변경
                string tableName = table[i].Substring(0, table[i].Length - 1);
                string tableNum = table[i].Substring(table[i].Length - 1);

                // controls 변수를 전역으로 선언
                Control[] controls = null;

                // 라벨 이름을 이용하여 라벨 찾기
                if (tableName.Equals("table"))
                    controls = Controls.Find("price_lb" + tableNum, true);
                else if (tableName.Equals("takeout"))
                    controls = Controls.Find("label" + tableNum, true);


                if (controls.Length > 0 && controls[0] is Label)
                {
                    ((Label)controls[0]).Text =price[i].ToString()+"원" ;
                }
            }
        }
        private void TableMenu(List<string> table,List<string>menu)
        {
            for (int i = 0; i < table.Count; i++)
            {
                // 라벨의 텍스트 변경
                string tableName = table[i].Substring(0, table[i].Length - 1);
                string tableNum = table[i].Substring(table[i].Length - 1);

                // controls 변수를 전역으로 선언
                Control[] controls = null;

                // 라벨 이름을 이용하여 라벨 찾기
                if (tableName.Equals("table"))
                    controls = Controls.Find("orderTable" + tableNum, true);
                else if (tableName.Equals("takeout"))
                    controls = Controls.Find("orderTakeout" + tableNum, true);

                if (controls.Length > 0 && controls[0] is Label)
                {
                    ((Label)controls[0]).Text = menu[i];
                }

            }
        }
            private void Label_Click(object sender, EventArgs e)
        {
            // 클릭된 라벨에 따라 다른 동작을 수행하고 싶다면
            // sender를 이용하여 어떤 라벨이 클릭되었는지 확인할 수 있습니다.
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // 라벨의 텍스트 변경
                string tableName = clickedLabel.Text.Substring(0, clickedLabel.Text.Length - 1);
                string tableNum = clickedLabel.Text.Substring(clickedLabel.Text.Length - 1);

                string table="";
                // 라벨 이름을 이용하여 라벨 찾기
                if (tableName.Equals("orderTable"))
                    table = "table" + tableNum;
                else if (tableName.Equals("orderTakeout"))
                    table = "takeout" + tableNum;

                if (!dataContainer.table.Contains(table))
                    dataContainer.table.Add(table);

                // Form2를 열거나 다른 동작을 수행할 수 있습니다.
                Order formOrder = new Order(dataContainer);
                formOrder.Show();
                this.Hide();
            }
        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Base_Load(object sender, EventArgs e)
        {
            this.lbNowDate.Text = DateTime.Now.ToString("yyyy.mm.dd");
            this.lbNowTime.Text = DateTime.Now.ToString("tt hh:mm:ss");
        }
    }

}
