using System;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public class MyDateTimePicker : System.Windows.Forms.DateTimePicker   
	{
        public enum 時間類型
        {
            最小值,
            最大值,
        };

        private DateTimePickerFormat oldFormat = DateTimePickerFormat.Long;
		private string oldCustomFormat = null;
		private bool bIsNull = true;

        public MyDateTimePicker()
            : base()
		{
		}

        public 時間類型 類型 { get; set; }

		public new DateTime Value 
		{
			get 
			{
                if (bIsNull)
                    return DateTime.MinValue;
                else if (類型 == 時間類型.最小值)
                    return new DateTime(base.Value.Year, base.Value.Month, base.Value.Day, 0, 0, 0, 0);
                else
                    return new DateTime(base.Value.Year, base.Value.Month, base.Value.Day, 23, 59, 59, 999);
			}
			set 
			{
				if (value == DateTime.MinValue)
				{
					if (bIsNull == false) 
					{
						oldFormat = this.Format;
						oldCustomFormat = this.CustomFormat;
						bIsNull = true;
					}

					this.Format = DateTimePickerFormat.Custom;
					this.CustomFormat = " ";
				}
				else 
				{
					if (bIsNull) 
					{
						this.Format = oldFormat;
						this.CustomFormat = oldCustomFormat;
						bIsNull = false;
					}
					base.Value = value;
				}
			}
		}

		protected override void OnCloseUp(EventArgs eventargs)
		{
			if (Control.MouseButtons == MouseButtons.None) 
			{
				if (bIsNull) 
				{
					this.Format = oldFormat;
					this.CustomFormat = oldCustomFormat;
					bIsNull = false;
				}
			}
			base.OnCloseUp (eventargs);
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown (e);

			if (e.KeyCode == Keys.Delete)
				this.Value = DateTime.MinValue; //@@ todo 無法刪除
		}
	}
}
