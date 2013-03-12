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
        private List<String> mainPaths;
        private String backupPath;

        public Backup(String name, String[] mainPaths, String backupPath)
        {
            this.mainPaths = new List<String>();

            this.name = name;
            foreach (String path in mainPaths)
            {
                this.mainPaths.Add(path);
            }

            this.backupPath = backupPath;
        }
    }
}
