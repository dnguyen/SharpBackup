using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBackup
{
    // TODO: Merge with Backup class.
    public class SyncedBackup
    {
        public String Name { get; set; }
        public String BackupPath { get; set; }
        public List<String> MainPaths = new List<string>();

        public SyncedBackup(String name, String backupPath)
        {
            Name = name;
            BackupPath = backupPath;
        }

        public void AddMainPath(String path)
        {
            MainPaths.Add(path);
        }

        public void CopyFilesToBackupPath()
        {
            foreach (String mainPath in MainPaths)
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
                        String newBackupPath = directoryPath.Replace(mainPath, BackupPath);
                        Directory.CreateDirectory(newBackupPath);
                    }
                    // Copy files over to the backup path
                    foreach (String filePath in filePaths)
                    {
                        String newBackupPath = filePath.Replace(mainPath, BackupPath);
                        Console.WriteLine("*" + BackupPath);
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
                                             NewBackupPath = BackupPath + "\\" + Path.GetFileName(mainPath)
                                         };
                    File.Copy(mainPath, fileBackup.NewBackupPath, true);
                }
            }
        }
    }
}
