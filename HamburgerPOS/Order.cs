using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace HamburgerPOS
{
    public partial class Order : Form
    {
        private DataContainer dataContainer;

        public Order(DataContainer data)
        {
            InitializeComponent();
            //dataContainer = new DataContainer();

            this.dataContainer = data;
            lbTableNum.Text = dataContainer.table[dataContainer.table.Count-1];

            // 이미 생성된 버튼에 이벤트 핸들러 추가
            for (int i = 1; i <= 4; i++)
            {
                // 라벨 이름을 이용하여 라벨 찾기
                System.Windows.Forms.Control[] controls = Controls.Find("bt" + i.ToString(), true);

                if (controls.Length > 0 && controls[0] is System.Windows.Forms.Button)
                {
                    // 라벨에 클릭 이벤트 핸들러 등록
                    ((System.Windows.Forms.Button)controls[0]).Click += Button_Click;
                }
            }
            DrawList(1);
            OrderMenuSet();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            // 클릭된 라벨에 따라 다른 동작을 수행하고 싶다면
            // sender를 이용하여 어떤 라벨이 클릭되었는지 확인할 수 있습니다.
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            if (clickedButton != null)
            {
                // 버튼의 이름에서 마지막 문자를 추출하고 정수로 변환
                if (int.TryParse(clickedButton.Name[clickedButton.Name.Length - 1].ToString(), out int num))
                {
                    DrawList(num);
                }
                else
                {
                    // 정수로 변환 실패 시 예외 처리 또는 로그 등을 수행
                    MessageBox.Show("버튼 이름에서 숫자를 추출할 수 없습니다.");
                }
            }
        }
        private void drawListColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            //헤더는 기본적인 그리기를 사용
            e.DrawDefault = true;
        }
        private void lv_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
        private void lv_ColumnClick(object sender, ColumnClickEventArgs e)
        {


        }
        // 엑셀 파일 경로
        string path = "C:\\Users\\user\\Desktop\\c#\\HamburgerPOS\\HamburgerPOS\\bin\\Debug\\MenuList.xlsx";

        int Category;
        private void DrawList(int category)
        {
            Category = category;
            MenuListView.Clear();

            MenuListView.GridLines = true;
            MenuListView.View = View.Details;
            MenuListView.FullRowSelect = true;

            ColumnHeader columnHeader_name = new System.Windows.Forms.ColumnHeader();
            ColumnHeader columnHeader_single = new System.Windows.Forms.ColumnHeader();
            ColumnHeader columnHeader_set = new System.Windows.Forms.ColumnHeader();

            columnHeader_name.Width = 200;
            columnHeader_set.Width = 120;
            columnHeader_single.Width = 120;

            switch (category)
            {
                case 1:
                    columnHeader_name.Text = "햄버거";
                    columnHeader_single.Text = "단품";
                    columnHeader_set.Text = "세트";
                    break;
                case 2:
                    columnHeader_name.Text = "치킨";
                    columnHeader_single.Text = "small";
                    columnHeader_set.Text = "large";
                    break;
                case 3:
                    columnHeader_name.Text = "사이드";
                    columnHeader_single.Text = "10조각";
                    columnHeader_set.Text = "20조각";
                    break;
                case 4:
                    columnHeader_name.Text = "음료";
                    columnHeader_single.Text = "핫";
                    columnHeader_set.Text = "아이스";
                    break;

            }
            MenuListView.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(drawListColumnHeader);
            MenuListView.DrawItem += new DrawListViewItemEventHandler(lv_DrawItem);
            MenuListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader_name, columnHeader_single, columnHeader_set });
            try
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workBook = excelApp.Workbooks.Open(path); // 엑셀 파일 열기
                Excel.Worksheet workSheet = workBook.Sheets[category]; // 첫 번째 시트 선택

                Excel.Range range = workSheet.UsedRange; // 사용 중인 셀 범위 가져오기

                string[] sTemp = { "", "", "" };
                ListViewItem newitem = new ListViewItem(sTemp);

                for (int row = 2; row <= range.Rows.Count; row++) // 행 반복
                {
                    string[] sTTemp = new string[3];

                    for (int column = 4; column <= range.Columns.Count; column++) // 열 반복
                    {
                        string str = (string)(range.Cells[row, column] as Excel.Range).Value2; // 셀 데이터 가져오기
                        sTTemp[column - 4] = str;
                    }

                    newitem = new ListViewItem(sTTemp);
                    MenuListView.Items.Add(newitem);
                }

                workBook.Close(true); // 워크북 닫기
                excelApp.Quit(); // 엑셀 어플리케이션 종료

                // 해제
                Marshal.ReleaseComObject(range);
                Marshal.ReleaseComObject(workSheet);
                Marshal.ReleaseComObject(workBook);
                Marshal.ReleaseComObject(excelApp);
            }
            catch (Exception ex)
            {
                // 파일을 찾지 못한 경우 예외 처리
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // 파일 필터 설정 (Excel 파일만 선택 가능하도록)
                openFileDialog.Filter = "Excel 파일 (*.xlsx)|*.xlsx|모든 파일 (*.*)|*.*";

                // 대화 상자를 통해 파일을 선택하도록 함
                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // 선택된 파일 경로로 재귀적으로 DrawList 메서드 호출
                    MessageBox.Show("엑셀을 불러오는데 성공했습니다.");
                    path = openFileDialog.FileName;
                    DrawList(category);
                }
            }


        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Base formBase = new Base();
            formBase.Show();
            //show가 아니라 showdialog 사용할떄
            //ShowDialog()는 모달 대화상자를 열 때 사용되며, 모달 대화상자가 닫히기 전에는 코드가 다음으로 진행되지 않습니다.
            //따라서 formBase를 닫지 않으면 Order이 닫히지 않는다.
            this.Close();
        }
        private void OrderMenuSet()
        {
            OrderListView.View = View.Details;
            OrderListView.GridLines = true;
            OrderListView.FullRowSelect = true;
            OrderListView.CheckBoxes = true;

            OrderListView.Columns.Add("메뉴", 150);
            OrderListView.Columns.Add("가격", 100);
            OrderListView.Columns.Add("수량", 100);
        }

        private void MenuListView_MouseClick(object sender, MouseEventArgs e)
        {
            string[] sTemp = new string[3];
            ListViewItem newitem = new ListViewItem(sTemp);
            // 클릭한 위치의 아이템 정보 확인
            ListViewItem clickedItem = MenuListView.GetItemAt(e.X, e.Y);

            if (clickedItem != null)
            {
                int index = clickedItem.Index;
                sTemp[0] = MenuListView.Items[index].SubItems[0].Text;

                string answer = string.Empty;
                if (Category == 1)
                    answer = "세트 메뉴를 선택하시겠습니까?";
                else if (Category == 2)
                    answer = "Large 사이즈로 선택하겠습니까?";
                else if (Category == 3)
                    answer = "20조각 선택하겠습니까?";
                else
                    answer = "아이스를 선택하겠습니까?";

                if (MessageBox.Show(answer, "사이즈 선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    sTemp[1] = MenuListView.Items[index].SubItems[2].Text;
                else
                    sTemp[1] = MenuListView.Items[index].SubItems[1].Text;

                sTemp[2] = "1";
                newitem = new ListViewItem(sTemp);
                OrderListView.Items.Add(newitem);
                SumPrice();
            }
        }

        int price = 0;
        private void SumPrice()
        {
            price = 0;
            string sTemp, sTemp1;

            for (int i = 0; i < OrderListView.Items.Count; i++)
            {
                sTemp = OrderListView.Items[i].SubItems[2].Text;
                sTemp1 = OrderListView.Items[i].SubItems[1].Text;

                /*\D: 숫자가 아닌 문자를 나타냅니다.
                  @ 기호는 C#에서 문자열 리터럴을 사용할 때 이스케이프 문자를 무시하는 문자열 리터럴 식별자입니다.
                숫자가 아닌 문자는 모두 ""로 대체(제거)
                */
                string sTemp2 = Regex.Replace(sTemp1, @"\D", "");

                int tempValue, tempValue1;
                if (int.TryParse(sTemp, out tempValue) && int.TryParse(sTemp2, out tempValue1))
                {
                    price += tempValue * tempValue1;
                }
                else
                {
                    MessageBox.Show("형식변환에 실패했습니다.");
                }
            }

            lbPrice.Text = "총 금액: " + price.ToString() + "원";

        }

        private void Order_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("yyyy.mm.dd");
        }

        private void btAllCancel_Click(object sender, EventArgs e)
        {
            OrderListView.Items.Clear();
            SumPrice();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            // 체크된 항목이 있는지 확인
            if (OrderListView.CheckedItems.Count > 0)
            {
                foreach (ListViewItem checkedItem in OrderListView.CheckedItems)
                {
                    OrderListView.Items.Remove(checkedItem);
                }
            }
            SumPrice();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (OrderListView.CheckedItems.Count > 0)
            {
                foreach (ListViewItem checkedItem in OrderListView.CheckedItems)
                {
                    int num = int.Parse(checkedItem.SubItems[2].Text);
                    // 각 체크된 항목의 인덱스 구하기
                    int index = OrderListView.Items.IndexOf(checkedItem);
                    OrderListView.Items[index].SubItems[2].Text = (++num).ToString();
                    checkedItem.Checked= false;
                }
            }
            SumPrice();
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            if(OrderListView.CheckedItems.Count > 0)
            {
                foreach (ListViewItem checkedItem in OrderListView.CheckedItems)
                {
                    int num = int.Parse(checkedItem.SubItems[2].Text);
                    // 각 체크된 항목의 인덱스 구하기
                    int index = OrderListView.Items.IndexOf(checkedItem);
                    if(num>1)
                        OrderListView.Items[index].SubItems[2].Text = (--num).ToString();
                    else
                        OrderListView.Items.Remove(checkedItem);
                    checkedItem.Checked = false;
                }
            }
            SumPrice();

        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            SumPrice();
            dataContainer.price.Add(price);
            string Menu="";
            for (int i = 0; i < OrderListView.Items.Count; i++)
            {
                Menu+=OrderListView.Items[i].SubItems[0].Text+"*";
                Menu += OrderListView.Items[i].SubItems[1].Text + "*";
                Menu += OrderListView.Items[i].SubItems[2].Text + "\n";
            }
            dataContainer.menu.Add (Menu);

            Base formBase = new Base(dataContainer);
            formBase.Show();
            this.Close();
        }

    }

}
