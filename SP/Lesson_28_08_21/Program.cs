using System;
using System.Runtime.InteropServices;

namespace Lesson_28_08_21
{
    static class MessageBox
    {
        // #define MB_OK 1 
        // int MessageBoxW(void *parent, const wchar_t *text, const wchar_t *title, int buttons);
        [DllImport("user32.dll", EntryPoint = "MessageBoxW", CharSet = CharSet.Unicode)]
        public static extern int Show(IntPtr hParent, string text, string title, int buttons);
    }

    static class C
    {
        [DllImport("msvcrt.dll", EntryPoint = "printf", CharSet = CharSet.Ansi)]
        public static extern int PrintFromat(string format, __arglist);
    }

    class Program
    {
        static void Main(string[] args)
        {
            PInvoke.Kernel32.Beep(300,500);
            //Console.ReadKey();
            //Console.WriteLine(MessageBox.Show(IntPtr.Zero, "Salam hormetli bash proqramchi Senan bey","Senan bey",3));
            //C.PrintFromat("%d sayda insan %s",__arglist(12,"end"));

        }
    }
}
