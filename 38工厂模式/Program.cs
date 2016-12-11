using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你喜欢的笔记本电脑名称：");
            string brand = Console.ReadLine();
            NoteBook nb = CreateNoteBook(brand);
            nb.Show();
            Console.ReadKey();

        }

        //创建笔记本的工厂
        public static NoteBook CreateNoteBook(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "lenovo":
                    nb = new Lenovo();
                    break;
            }
            return nb;
        }

    }
    abstract class NoteBook
    {
        public abstract void Show();
    }
    class Lenovo : NoteBook
    {

        public override void Show()
        {
            Console.WriteLine("联想笔记本。");
        }
    }
}
