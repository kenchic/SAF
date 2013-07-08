using System;
using Telerik.Web.UI;

namespace SAFAppWeb.sistema.menus
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RadPanelItem dateItem = new RadPanelItem();
            dateItem.Text = "Current Date";
            dateItem.CssClass = "MainItem";
            dateItem.Expanded = true;
            RadPanelBar1.Items.Add(dateItem);

            RadPanelItem yearItem = new RadPanelItem();
            yearItem.Text = "Year : " + DateTime.Now.Year.ToString();
            dateItem.Items.Add(yearItem);

            RadPanelItem monthItem = new RadPanelItem();
            monthItem.Text = "Month : " + DateTime.Now.Month.ToString();
            dateItem.Items.Add(monthItem);

            RadPanelItem dayItem = new RadPanelItem();
            dayItem.Text = "Day : " + DateTime.Now.Day.ToString();
            dateItem.Items.Add(dayItem);

            RadPanelItem timeItem = new RadPanelItem();
            timeItem.Text = "Current Time";
            timeItem.CssClass = "MainItem";
            RadPanelBar1.Items.Add(timeItem);

            RadPanelItem hourItem = new RadPanelItem();
            hourItem.Text = "Hours : " + DateTime.Now.Hour.ToString();
            timeItem.Items.Add(hourItem);

            RadPanelItem minuteItem = new RadPanelItem();
            minuteItem.Text = "Minutes : " + DateTime.Now.Minute.ToString();
            timeItem.Items.Add(minuteItem);

            RadPanelItem secondItem = new RadPanelItem();
            secondItem.Text = "Seconds : " + DateTime.Now.Second.ToString();
            timeItem.Items.Add(secondItem);
        }
    }
}