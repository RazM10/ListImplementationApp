using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListImplementationApp
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["listUser"] == null || ViewState["listInt"]==null)
            {
                //user define list
                List<Test> intList = new List<Test>();
                Test test1 = new Test();
                test1.Name = "A";
                test1.Number = 1;
                intList.Add(test1);
                Test test2 = new Test();
                test2.Name = "B";
                test2.Number = 2;
                intList.Add(test2);
                Test test3 = new Test();
                test3.Name = "C";
                test3.Number = 3;
                intList.Add(test3);

                ViewState["listUser"] = intList;
                //int type list
                List<int> aData=new List<int>();
                aData.Add(1);
                aData.Add(2);
                aData.Add(3);
                aData.Add(4);
                aData.Add(5);
                aData.Add(6);
                
                ViewState["listInt"] = aData;

                
            }
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            List<Test> userDefineList = (List<Test>)ViewState["listUser"];
            int temp = Convert.ToInt32(inputTextBox.Text);
            foreach (Test value in userDefineList)
            {
                if (value.Name == "B")
                {
                    value.Number = value.Number + temp;
                }
            }
            foreach (Test value in userDefineList)
            {
                if (value.Name == "B")
                {
                    Response.Write(value.Number);
                }
            }


            List<int> intList = (List<int>)ViewState["listInt"];
            int total = 0;

            bool i=intList.Contains(6);
            if (i)
            {
                foreach (int value in intList)
                {
                    total += value;
                }
            }
            int index=intList.IndexOf(6);
            intList[index] += 5;
            //Response.Write(intList[index]);
            outputTextBox.Text = total.ToString();
            intList.Remove(6);

        }
    }
}