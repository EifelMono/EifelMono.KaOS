using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using EifelMono.KaOS.Extensions;

namespace EifelMono.KaOS.Tools
{
    public static partial class Tools
    {
        public static async Task LocalDotBackupFile(string filename, int days = 30)
        {
            Func<DateTime, string> DateFilename = (timestamp) =>
            {
                string backupDir = Path.Combine(Path.GetDirectoryName(filename), $".backup", $"{Path.GetFileName(filename)}");
                if (!OS.System.IO.Directory.Exists(backupDir))
                    OS.System.IO.Directory.CreateDirectory(backupDir);
                var listOfNames = new List<string>();
                var filenameExtenstion = Path.GetExtension(filename);
                for (int index = 0; index < 30; index++)
                    listOfNames.Add(DateTime.Now.AddDays(-index).ToString("yyyyMMdd") + filenameExtenstion);
                foreach (var file in OS.System.IO.Directory.GetFiles(backupDir))
                {
                    var foundFilename = Path.GetFileName(file);
                    if (!listOfNames.Contains(foundFilename))
                        try
                        {
                            var foundDatePartFilename = foundFilename.Before("-");
                            if (!string.IsNullOrEmpty(foundDatePartFilename))
                                foundDatePartFilename += filenameExtenstion;
                            if (!listOfNames.Contains(foundDatePartFilename))
                                OS.System.IO.File.Delete(file);
                        }
                        catch (Exception ex)
                        {
                            ex.LogException();
                        }
                }
                return Path.Combine(backupDir, timestamp.ToString("yyyyMMdd-HHmmss") + Path.GetExtension(filename));
            };

            if (OS.System.IO.File.Exists(filename))
            {
                var savedFilename = Path.ChangeExtension(filename, "." + DateTime.Now.ToString("yyyyMMddHHmmssfff"));
                try
                {
                    OS.System.IO.File.Copy(filename, savedFilename, true);
                    await Task.Run(() =>
                     {
                         try
                         {
                             var backupFilename = DateFilename(DateTime.Now); // clears the original filename
                             OS.System.IO.File.Copy(savedFilename, backupFilename, true);
                             // File with original filename also to backup to.....
                             OS.System.IO.File.Copy(filename, Path.Combine(Path.GetDirectoryName(backupFilename), Path.GetFileName(filename)), true);
                         }
                         catch (Exception ex)
                         {
                             ex.LogException();
                         }
                     });
                }
                catch (Exception ex)
                {
                    ex.LogException();
                }
                finally
                {
                    try
                    {
                        if (OS.System.IO.File.Exists(savedFilename))
                            OS.System.IO.File.Delete(savedFilename);
                    }
                    catch (Exception ex)
                    {
                        ex.LogException();
                    }
                }
            }
        }
    }
}
