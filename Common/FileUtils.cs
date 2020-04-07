using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Common
{
    public class FileUtils
    {
        /// <summary>
        /// 得到一个文件的大小
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static long GetSize(string fileName)
        {
            if (File.Exists(fileName)) return new FileInfo(fileName).Length;
            else return 0;
        }
        /// <summary>
        /// 以Windows方式展示文件大小
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string DisplaySize(long size)
        {
            string m_strSize = "";
            long FactSize = size;
            if (FactSize < 1024.00)
                m_strSize = String.Format("{0:F2} 字节", FactSize);
            else if (FactSize >= 1024.00 && FactSize < 1048576)
                m_strSize = String.Format("{0:F2} KB", (FactSize / 1024.00));
            else if (FactSize >= 1048576 && FactSize < 1073741824)
                m_strSize = String.Format("{0:F2} MB", (FactSize / 1024.00 / 1024.00));
            else if (FactSize >= 1073741824)
                m_strSize = String.Format("{0:F2} GB", (FactSize / 1024.00 / 1024.00 / 1024.00));
            return m_strSize;
        }

        public static string FilterDangerCharacter(string virtualPath)
        {
            if (string.IsNullOrEmpty(virtualPath))
            {
                return virtualPath;
            }
            else
            {
                foreach (char i in Path.GetInvalidFileNameChars())
                {
                    virtualPath = virtualPath.RemoveLineBreaks().Replace(i, '_');
                }
                return virtualPath;
            }
        }

        public static string RemoveBlank(string fileName)
        {
            return fileName.Replace(" ", "");
        }

        public static string GetIcon(string ext)
        {
            switch (ext.ToLower())
            {
                case ".txt":
                case ".text":
                    return "txt";
                case ".xls":
                case ".xlsx":
                case ".csv":
                    return "xls";
                case ".doc":
                case ".docx":
                case ".dot":
                case ".wps":
                case ".rtf":
                    return "doc";
                case ".ppt":
                case ".pptx":
                case ".pot":
                    return "ppt";
                case ".7z":
                    return "7z";
                case ".rar":
                    return "rar";
                case ".zip":
                case ".z":
                    return "zip";
                case ".html":
                case ".htm":
                case ".mht":
                case ".mhtml":
                    return "html";
                case ".exe":
                case ".bat":
                    return "exe";
                case ".ttf":
                case ".ttc":
                case ".fon":
                    return "font";
                case ".pdf":
                    return "pdf";
                case ".swf":
                    return "swf";
                case ".mp3":
                case ".rm":
                case ".wma":
                case ".3gp":
                case ".asx":
                    return "music";
                case ".jpg":
                case ".jpeg":
                    return "jpg";
                case ".gif":
                    return "gif";
                case ".png":
                    return "png";
                case ".bmp":
                    return "bmp";
                default: return "unkown";
            }
        }
        /// <summary>
        /// 清空指定的文件夹，但不删除文件夹
        /// </summary>
        /// <param name="dir"></param>
        public static void DeleteFolder(string dir)
        {
            foreach (string d in Directory.GetFileSystemEntries(dir))
            {
                if (System.IO.File.Exists(d))
                {
                    try
                    {
                        FileInfo fi = new FileInfo(d);
                        if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                            fi.Attributes = FileAttributes.Normal;
                        System.IO.File.Delete(d);//直接删除其中的文件  
                    }
                    catch
                    {
                        //删不掉也无所谓
                    }
                }
                else
                {
                    DirectoryInfo d1 = new DirectoryInfo(d);
                    if (d1.GetFiles().Length != 0)
                    {
                        DeleteFolder(d1.FullName);////递归删除子文件夹
                    }
                    Directory.Delete(d);
                }
            }
        }
        /// <summary>
        /// 清空目录
        /// </summary>
        /// <param name="di"></param>
        public static void EmptyDir(DirectoryInfo di)
        {
            if (di.Exists)
            {
                foreach (var file in di.GetFiles())
                {
                    if (file.IsReadOnly)
                    {
                        file.IsReadOnly = false;
                    }
                    try
                    {
                        file.Delete();
                    }
                    catch
                    {
                        //Logger.LogWarn(string.Format("{0} can not be deleted.", file.FullName));
                    }
                }
                foreach (var subdir in di.GetDirectories())
                {
                    EmptyDir(subdir);
                    int retryTimes = 0;
                    while (Directory.Exists(subdir.FullName) && retryTimes < 10)
                    {
                        try
                        {
                            subdir.Delete();
                        }
                        catch (Exception ex)
                        {
                            //Logger.LogWarn(string.Format("EmptyDir,{0}删除时发生错误,{1}。", subdir.FullName, ex.Message));
                        }
                        System.Threading.Thread.Sleep(100);
                        retryTimes++;
                    }
                }
            }
        }
        /// <summary>
        /// 清空目录
        /// </summary>
        /// <param name="dir"></param>
        public static void EmptyDir(string dir)
        {
            EmptyDir(new DirectoryInfo(dir));
        }
        /// <summary>
        /// 删除目录
        /// </summary>
        /// <param name="di"></param>
        public static void DeleteDir(DirectoryInfo di)
        {
            if (di.Exists)
            {
                EmptyDir(di);
                int retryTimes = 0;
                while (Directory.Exists(di.FullName) && retryTimes < 10)
                {
                    try
                    {
                        di.Delete();
                    }
                    catch (Exception ex)
                    {
                        //Logger.LogWarn(string.Format("DeleteDir,{0}删除时发生错误,{1}。", di.FullName, ex.Message));
                    }
                    System.Threading.Thread.Sleep(100);
                    retryTimes++;
                }
            }
        }
        /// <summary>
        /// 删除目录
        /// </summary>
        /// <param name="dir"></param>
        public static void DeleteDir(string dir)
        {
            DeleteDir(new DirectoryInfo(dir));
        }
    }
}
