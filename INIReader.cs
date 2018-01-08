using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Downloader
{
    internal class INIReader
    {
        public string path { get; set; }
        public string section { get; set; }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public INIReader(string FilePath, string Section = "")
        {
            this.path = FilePath;
            this.section = Section;
        }

        public void IniWriteValue(string Key, string Value, string Section = null)
        {
            if (Section == null)
                Section = this.section;

            WritePrivateProfileString(Section, Key, Value, this.path);
        }

        public string IniReadValue(string Key, string Default = "", string Section = null)
        {
            if (Section == null)
                Section = this.section;

            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, Default, temp, 255, this.path);
            return temp.ToString();
        }
    }
}
