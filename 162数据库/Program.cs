using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162数据库
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 旧解释

            //DBA 数据库管理员
            //MDBS 数据库管理系统  
            //数据库表重复 叫数据冗余
            //主键表和外键表只是相对关系（外键也有可能成为另外一个表的主键）
            //启动服务 -- net start + 服务名（如果服务名有空格，则用[]把服务括起来）

            //bit表示布尔类型：在写程序的时候只能用1（true）或0（false）来表示，但是在设计器中只能用true或false单词来表示

            //存储字符串的几种数据类型
            //char(10) [固定长度]可以存储10个字母、5个汉字
            //nchar(10) [可变长度]可以存储10个字母、10个汉字，因为每个字符都是按照unicode方法来存储


            //varchar(10)
            //nvarchar(10)

            //varchar(max)
            //nvarchar(max)

            //text
            //ntext

            //=============varchar与char的区别=================

            //----可变长度，表示该列最多存储10个字节，如果实际存储不够10个字节，则会在存储的时候会自动计算一下实际的存储个数，而动态的改变长度。[节省空间]
            //varchar(10)
            //'zxh'

            //--固定长度，表示在数据库中存储的时候占用10个字节的空间，如果超出10则报错，如果不够10个则用空格补全。[比较浪费空间]
            //char(10)
            //'zxh'


            //==================nchar(10)、char(10)区别==================
            //char(10)[可以存储10个字母或5个汉字，可以写8000]用来存储数据的时候，英文占1个字节，中文占2个字节。
            //nchar(10)[可以存储10个字母或10个汉字，因为每个字符都是按照unicode方法来存储的，可以写4000]用来存储的时候，无论存储的是英文还是中文都是每个字符占2个字节。

            //char和nchar的小括号的最大长度可以写8000



            //不建议使用text或ntext，推荐使用varchar(max)或nvarchar(max)

            // 
            #endregion

            //带var和不带var的区别：
            //char(10) 固定长度
            //varchar(10) 可变长度

            //带n和不带n的区别：
            //char(10) 存储10个字母、5个汉字
            //nchar(10) 存储10个字母、10个汉字

        }
    }
}
