using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.Linq;

namespace WokyTool.通用
{
    public class PDF字串寫入元件      //TODO 全形半形計算優化
    {
        public Rectangle 範圍{ get; set; }

        public Font 字體 { get; set; }

        private int _每行字數 = 0;
        private int _可用行數 = 0;
        private List<Rectangle> _可用範圍 = new List<Rectangle>();

        public PDF字串寫入元件(Rectangle 範圍_, Font 字體_)
        {
            this.範圍 = 範圍_;
            this.字體 = 字體_;

            _每行字數 = (int)(範圍_.Width / 字體_.Size);

            float MaxY_ = 範圍_.Top - 字體_.Size;
            float MinY_ = 範圍_.Bottom;
            while(MaxY_ >= MinY_)
            {
                _可用範圍.Add(new Rectangle(範圍_.Left, MaxY_, 範圍_.Right, MaxY_ + 字體_.Size + 10));
                MaxY_ -= (字體_.Size + 1); 
            }

            _可用行數 = _可用範圍.Count;
        }

        public void 處理(PdfWriter PdfWriter_, string 字串_)
        {
            if(string.IsNullOrEmpty(字串_))
                return;

            PdfContentByte PdfContentByte_ = PdfWriter_.DirectContent;

            string 目前字串_ = 字串_;
            int 目前行數_ = 0;
            while(目前行數_ < _可用行數 && 目前字串_ != null)
            {
                if(目前字串_.Length <= _每行字數)
                {
                    寫入(PdfContentByte_, 目前字串_, _可用範圍.ElementAt(目前行數_++));
                    目前字串_ = null;
                }
                else if(目前行數_ == (_可用行數 - 1))
                {
                    string 剪下字串_ = 目前字串_.Substring(0, _每行字數 - 3) + "...";
                    寫入(PdfContentByte_, 剪下字串_, _可用範圍.ElementAt(目前行數_++));

                    目前字串_ = null;
                }
                else
                {
                    string 剪下字串_ = 目前字串_.Substring(0, _每行字數);
                    寫入(PdfContentByte_, 剪下字串_, _可用範圍.ElementAt(目前行數_++));

                    目前字串_ = 目前字串_.Substring(_每行字數);
                }
            }
        }

        private void 寫入(PdfContentByte PCB_, string 字串_, Rectangle 範圍_)
        {
            Phrase Phrase_ = new Phrase(字串_, 字體);

            ColumnText ColumnText_ = new ColumnText(PCB_);
            ColumnText_.SetSimpleColumn(範圍_);
            ColumnText_.SetText(Phrase_);
            ColumnText_.Alignment = Element.ALIGN_LEFT;
            ColumnText_.Go();
        }
    }
}
