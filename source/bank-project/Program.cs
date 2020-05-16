using System;
using System.Windows.Forms;
using System.Drawing;
using bankproject.Forms.FormLogIn;
using bankproject.Forms;


namespace bankproject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(System.Environment.CurrentDirectory);
            Application.Run(new FormLogin());
        }
    }
}
