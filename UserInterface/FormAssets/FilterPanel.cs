using DataReferenceLibrary.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Forms;

namespace UserInterface.FormAssets
{
    class FilterPanel : TableLayoutPanel
    {
        private string _FilterColumnName;
        private string _FilterDataType;
        private string _FilterMatchType;
        private string _FilterMatchValue;
        private string _LowerValueToMatch;
        private string _HigherValueToMatch;

        private Button _deleteButton;

        public string FilterColumnName
        {
            get { return _FilterColumnName; }
            set { _FilterColumnName = value; Invalidate(); }
        }
        public string FilterDataType
        {
            get { return _FilterDataType; }
            set { _FilterDataType = value; Invalidate(); }
        }
        public string FilterMatchType
        {
            get { return _FilterMatchType; }
            set { _FilterMatchType = value; Invalidate(); }
        }
        public string FilterMatchValue
        {
            get { return _FilterMatchValue; }
            set { _FilterMatchValue = value; Invalidate(); }
        }
        public string LowerValueToMatch
        {
            get { return _LowerValueToMatch; }
            set { _LowerValueToMatch = value; Invalidate(); }
        }
        public string HigherValueToMatch
        {
            get { return _HigherValueToMatch; }
            set { _HigherValueToMatch = value; Invalidate(); }
        }
        public Button DeleteButton
        {
            get { return _deleteButton; }
            set { _deleteButton = value; Invalidate(); }
        }

        public FilterPanel(string _FilterColumnName, string _FilterDataType, string _FilterMatchType, string _FilterMatchValue, string _LowerValueToMatch, string _HigherValueToMatch)
        {

            //Some Filters will have "Match Value" filled, but not Lower/Higher. Code below is to adjust the string values of the panels to reflect this
            this.FilterColumnName = _FilterColumnName;
            this.FilterDataType = _FilterDataType;
            this.FilterMatchType = _FilterMatchType;
            this.FilterMatchValue = _FilterMatchValue;
            this.LowerValueToMatch = _LowerValueToMatch;
            this.HigherValueToMatch = _HigherValueToMatch;
            this.DeleteButton = _deleteButton;

            Width = 292;
            Height = 40;
            this.BackColor = Color.Pink;


            // Define the third Column String - Applicable when there is a higher and lower value
            string CombinationString = "";

            if (!string.IsNullOrWhiteSpace(FilterMatchValue))
            {
                CombinationString = this.FilterMatchValue;
            }

            else
            {
                if (this.FilterDataType == "DateTime")
                {
                    CombinationString = this.LowerValueToMatch + Environment.NewLine + this.HigherValueToMatch;
                }
                if (this.FilterDataType == "Double")
                {
                    CombinationString = this.LowerValueToMatch + Environment.NewLine + this.HigherValueToMatch;
                }
            }

            //TODO - Add If Code to automatically get the Match Type (In between, less than, etc) and move it out of the form



            int columns = 4;
            int rows = 1;

            this.ColumnCount = columns;
            this.RowCount = rows;

            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));    // Column Name being Filtered
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));    // Match Type (Greater, equal, less than)
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));    // Value(s) to match
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));    // Holds the Close Button
            //
            // lblFilterColumnName
            //
            Label lblFilterColumnName = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = this.FilterColumnName
            };
            //
            // lblFilterMatchType
            //
            Label lblFilterMatchType = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = this.FilterMatchType
            };
            //
            // lblFilterMatchValue
            //
            Label lblFilterMatchValue = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                //Text = this.FilterMatchValue
                Text = CombinationString
            };
            this.Controls.Add(lblFilterColumnName, 0, 0);
            this.Controls.Add(lblFilterMatchType, 1, 0);
            this.Controls.Add(lblFilterMatchValue, 2, 0);
        }
    }
}
