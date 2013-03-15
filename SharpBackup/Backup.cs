using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBackup
{
    class Backup
    {
        private String name;
        private String mainPath;
        private String backupPath;
        private bool isDirectory;

        public String MainPath { get { return mainPath; } }

        public Backup(String name, String mainPath, String backupPath, bool isDirectory)
        {
            this.name = name;
            this.mainPath = mainPath;
            this.backupPath = backupPath;
            this.isDirectory = isDirectory;
        }
    }
}
