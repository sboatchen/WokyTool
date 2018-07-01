using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.聯絡人;

namespace WokyTool.通用
{
    public class 聯絡人詳細視窗樣板 : 詳細視窗<聯絡人資料> { }
    public class 客戶詳細視窗樣板 : 詳細視窗<客戶資料> { }
    public class 子客戶詳細視窗樣板 : 詳細視窗<子客戶資料> { }

    public class 物品大類詳細視窗樣板 : 詳細視窗<物品大類資料> { }
    public class 物品小類詳細視窗樣板 : 詳細視窗<物品小類資料> { }
    public class 物品品牌詳細視窗樣板 : 詳細視窗<物品品牌資料> { }
    public class 物品詳細視窗樣板 : 詳細視窗<物品資料> { }

    /********************************/

    public class 聯絡人總覽視窗樣板 : 總覽視窗<聯絡人資料> { }
    public class 客戶總覽視窗樣板 : 總覽視窗<客戶資料> { }
    public class 子客戶總覽視窗樣板 : 總覽視窗<子客戶資料> { }

    public class 物品大類總覽視窗樣板 : 總覽視窗<物品大類資料> { }
    public class 物品小類總覽視窗樣板 : 總覽視窗<物品小類資料> { }
    public class 物品品牌總覽視窗樣板 : 總覽視窗<物品品牌資料> { }
    public class 物品總覽視窗樣板 : 總覽視窗<物品資料> { }
}
