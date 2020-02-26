using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public static class 字串 
    {
        public static string 空 = "";
        public static string 空白 = "空白";
        public static string 錯誤 = "錯誤";
        public static string 混和 = "混和";
        public static string 警告 = "警告";
        public static string 無 = "無";
        public static string 正確 = "(OK)";
        public static string 自動填寫 = "自動填寫";
        public static string 確認 = "確認";
        public static string 保密字串 = "*******";
        public static string 未定義 = "未定義";
        public static string 不篩選 = "不篩選";

        public static string 雜支 = "雜支";
        public static string 進貨 = "進貨";

        public static string 匯入確認 = "匯入確認";
        public static string 匯入內容 = "是否匯入指定檔案";
        public static string 匯入錯誤 = "資料有錯，是否放棄";
        public static string 名稱不合法 = "名稱不合法";
        public static string 匯入異常 = "匯入異常";
        public static string 物件不存在 = "物件不存在";

        public static string 結算確認 = "結算確認";
        public static string 結算支出內容 = "是否結算目前支出";

        public static string TW = "TW";

        public static string 新竹貨運 = "新竹貨運";
        public static string 新竹物流 = "新竹物流";
        public static string 宅配通 = "宅配通";
        public static string 全速配 = "全速配";

        public static string 商品 = "商品";
        public static string 單品 = "單品";

        public static string 標頭_錯誤 = "(錯誤)";

        public static string 設定成功 = "設定成功";

        public static string 儲存確認 = "儲存確認";
        public static string 儲存確認內容 = "是否儲存目前修改";
        public static string 儲存失敗 = "儲存失敗";

        public static string 更新確認 = "更新確認";
        public static string 更新確認內容 = "是否更新資料";
        public static string 更新失敗 = "更新失敗";

        public static string 操作失敗 = "操作失敗";

        public static string 排序前儲存確認內容 = "排序前，是否儲存目前修改";

        public static string 資料異動 = "資料異動";
        public static string 資料異動內容 = "資料已修改，請重新開啟視窗檢視新資料，當前修改將不予處理";

        public static string 指定詳細視窗索引失敗 = "找不到目標資料，請確認目前沒有進行篩選";

        public static string 密碼不可無空白 = "密碼不可無空白";
        public static string 密碼輸入不一致 = "密碼輸入不一致";

        public static string 功能尚未實作 = "功能尚未實作";

        public static string 折扣 = "折扣";

        public static string 讀取確認 = "讀取確認";

        public static string 尚未取得 = "尚未取得";

        public static string 多字測試 = "人之初性本善性相近習相遠苟不教性乃遷教之道貴以專昔孟母擇鄰處子不學斷機杼竇燕山有義方教五子名俱揚養不教父之過教不嚴師之惰子不學非所宜幼不學老何為玉不琢不成器人不學不知義為人子方少時親師友習禮儀香九齡能溫席孝於親所當執融四歲能讓梨弟於長宜先知首孝悌次見聞知某數識某文一而十十而百百而千千而萬三才者天地人三光者日月星三綱者君臣義父子親夫婦順曰春夏曰秋冬此四時運不窮曰南北曰西東此四方應乎中曰水火木金土此五行本乎數曰仁義禮智信此五常不容紊稻梁菽麥黍稷此六穀人所食馬牛羊雞犬豕此六畜人所飼曰喜怒曰哀懼愛惡欲七情具匏土革木石金與絲竹乃八音高曾祖父而身身而子子而孫自子孫至玄曾乃九族人之倫父子恩夫婦從兄則友弟則恭長幼序友與朋君則敬臣則忠此十義人所同凡訓蒙須講究詳訓詁明句讀為學者必有初小學終至四書論語者二十篇　群弟子記善言孟子者七篇止　講道德說仁義作中庸子思筆中不偏庸不易作大學乃曾子自修齊至平治孝經通四書熟如六經始可讀詩書易禮春秋　號六經當講求有連山有歸藏有周易三易詳有典謨有訓誥有誓命書之奧我周公作周禮著六官存治體大小戴註禮記述聖言禮樂備曰國風曰雅頌號四詩當諷詠詩既亡春秋作寓褒貶別善惡三傳者有公羊有左氏有穀梁經既明方讀子撮其要記其事五子者有荀揚文中子及老莊經子通讀諸史考世系知終始自羲農至黃帝號三皇居上世唐有虞號二帝相揖遜稱盛世夏有禹商有湯周文武稱三王夏傳子家天下四百載遷夏社湯伐夏國號商六百載至紂亡周武王始誅紂八百載最長久周轍東王綱墜逞干戈尚游說始春秋終戰國五霸強七雄出嬴秦氏始兼并傳二世楚漢爭高祖興漢業建至孝平王莽篡光武興為東漢四百年終於獻魏蜀吳爭漢鼎號三國迄兩晉宋齊繼梁陳承為南朝都金陵北元魏分東西宇文周與高齊迨至隋一土宇不再傳失統緒唐高祖起義師除隋亂創國基二十傳三百載梁滅之國乃改梁唐晉及漢周稱五代皆有由炎宋興受周禪十八傳南北混遼與金皆稱帝元滅金絕宋世輿圖廣超前代九十年國祚廢太祖興國大明號洪武都金陵迨成祖遷燕京十六世至崇禎閹禍後寇內訌闖逆變神器終廿二史全在茲載治亂知興衰讀史者考實錄通古今若親目口而誦心而惟朝於斯夕於斯昔仲尼師項橐古聖賢尚勤學趙中令讀魯論彼既仕學且勤披蒲編削竹簡彼無書且知勉頭懸梁錐刺骨彼不教自勤苦如囊螢如映雪家雖貧學不輟如負薪如掛角身雖勞猶苦卓蘇老泉二十七始發憤讀書籍彼既老猶悔遲爾小生宜早思若梁灝八十二對大廷魁多士彼既成眾稱異爾小生宜立志瑩八歲能詠詩泌七歲能賦碁彼穎悟人稱奇爾幼學當效之蔡文姬能辨琴謝道韞能詠吟彼女子且聰敏爾男子當自警唐劉晏方七歲舉神童作正字彼雖幼身己仕爾幼學勉而致有為者亦若是犬守夜雞司晨茍不學曷為人蠶吐絲蜂釀蜜人不學不如物幼而學壯而行上致君下澤民揚名聲顯父母光於前裕於後人遺子金滿籯我教子惟一經勤有功戲無益戒之哉宜勉力";
    }
}
