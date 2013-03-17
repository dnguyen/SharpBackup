using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBackup
{
    public delegate void FileCopiedHandler(FileBackup fileBackup);

    public class Backup
    {
        private String name;
        private String mainPath;
        private String backupPath;
        private bool isDirectory;

        // Files to create backups for
        private List<FileBackup> fileBackups;

        public event FileCopiedHandler OnFileCopied;

        public String MainPath { get { return mainPath; } }

        public int FileCount
        {
            get { return fileBackups.Count; }
        }

        public Backup(String name, String mainPath, String backupPath, bool isDirectory)
        {
            this.name = name;
            this.mainPath = mainPath;
            this.backupPath = backupPath;
            this.isDirectory = isDirectory;
            fileBackups = new List<FileBackup>();
        }

        public void SetFilePaths()
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

                    fileBackups.Add(fileBackup);
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
                fileBackups.Add(fileBackup);
            }
        }

        public void CopyFilesToBackupPath()
        {
            foreach (FileBackup fileBackup in fileBackups)
            {
                File.Copy(fileBackup.OriginalPath, fileBackup.NewBackupPath, true);
                if (OnFileCopied != null)
                    OnFileCopied(fileBackup);
            }
        }
    }
}
