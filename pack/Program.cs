using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ClientZipUnZip.BL;
using Microsoft.Win32;
using System.IO;

namespace pack
{
    static class Program
    {
        public static readonly Palau.UsingCompressUncompressSoapClient webServiceClient =
            new Palau.UsingCompressUncompressSoapClient();
        public static String virtualDisk;
        public static String realPath;
        public static String userIP;
        public static String settingskey = "SOFTWARE\\ClientUnZip\\Settings";

        static void OnInit(RegistryKey key)
        {
            virtualDisk = key.GetValue("VirtualDisk").ToString();
            realPath = key.GetValue("RealPath").ToString();
            userIP = key.GetValue("IP").ToString();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RegistryKey key = Registry.CurrentUser.OpenSubKey(settingskey);

            if (key == null)
            {
                MessageBox.Show(
                    "Не знайдено налаштувань. Потрібно запустити 'ClientZipAndZip' з правами адміністратора!",
                    "Fatel Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
            OnInit(key);

            /*string m = String.Empty;

            for (int i = 0; i < args.Length; i++)
            {
                m += args[i] + Environment.NewLine;
            }
            MessageBox.Show(m);*/
            /*if (args.Length > 0)
            {
                if (File.Exists(Application.StartupPath + "\\params.txt"))
                {
                    //MessageBox.Show("File exists");
                    FileInfo file = new FileInfo(Application.StartupPath + "\\params.txt");
                    DateTime createTime = file.CreationTime;

                    if (createTime.AddSeconds(5) < DateTime.Now)
                    {
                        file.Delete();
                        //MessageBox.Show("File delete");
                    }


                    using (StreamWriter writer =
                        new StreamWriter(Application.StartupPath + "\\params.txt", true,
                            Encoding.UTF8))
                    {
                        writer.WriteLine(args[0]);
                        //MessageBox.Show("File create or write");
                    }

                }
                else
                {
                    //MessageBox.Show("File not exists");

                    using (StreamWriter writer =
                        new StreamWriter(Application.StartupPath + "\\params.txt", true, Encoding.UTF8))
                    {
                        writer.WriteLine(args[0]);
                        //MessageBox.Show("File create or write");
                    }

                }
            }

            //if (args.Length > 0)
            //    return;

            if (File.Exists(Application.StartupPath + "\\params.txt"))
            {
                using (StreamReader reader = new StreamReader(Application.StartupPath + "\\params.txt"))
                {
                    List<String> itemsParam = new List<string>();
                    while (!reader.EndOfStream)
                        itemsParam.Add(reader.ReadLine());

                    args = itemsParam.ToArray();
                }
            }
            */

            try
            {
                Application.Run(new frmCompress(args));
            }
            catch (ObjectDisposedException odEx)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exit" + "\n" + ex.Message, "Program");
            }
        }
    }
}
