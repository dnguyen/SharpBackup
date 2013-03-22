using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBackup
{
    // TODO: Merge with Backup class.
    class SyncedBackup
    {
        private String name;
        private String backupPath;
        private List<String> mainPaths = new List<string>();

        public String BackupPath
        {
            get { return backupPath; }
        }

        public SyncedBackup(String name, String backupPath)
        {
            this.name = name;
            this.backupPath = backupPath;
        }

        public void addMainPath(String path)
        {
            mainPaths.Add(path);
        }

        public void CopyFilesToBackupPath()
        {
            foreach (String mainPath in mainPaths)
            {
                // Check if the path is a directory or file.
                // If it's a directory, get all directories and files within it.
                if (Directory.Exists(mainPath))
                {
                    String[] directoriesPaths = Directory.GetDirectories(mainPath, "*", SearchOption.AllDirectories);
                    String[] filePaths = Directory.GetFiles(mainPath, "*", SearchOption.AllDirectories);

                    // Create directories in backup path
                    foreach (String directoryPath in directoriesPaths)
                    {
                        String newBackupPath = directoryPath.Replace(mainPath, backupPath);
                        Directory.CreateDirectory(newBackupPath);
                    }
                    // Copy files over to the backup path
                    foreach (String filePath in filePaths)
                    {
                        String newBackupPath = filePath.Replace(mainPath, backupPath);
                        Console.WriteLine("*" + backupPath);
                        var fileBackup = new FileBackup
                                             {
                                                 OriginalPath = filePath,
                                                 NewBackupPath = newBackupPath
                                             };

                        File.Copy(filePath, newBackupPath, true);
                    }
                }
                    // If it's a file, just create a copy of the file to the backup path.
                else if (File.Exists(mainPath))
                {
                    var fileBackup = new FileBackup()
                                         {
                                             OriginalPath = mainPath,
                                             NewBackupPath = backupPath + "\\" + Path.GetFileName(mainPath)
                                         };
                    File.Copy(mainPath, fileBackup.NewBackupPath, true);
                }
            }
        }
    }
}
