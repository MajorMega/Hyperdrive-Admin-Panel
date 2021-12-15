using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdminPanel : MonoBehaviour
{
    private const string restartComputerFilename = "restart_computers.bat";
    private const string shutdownComputerFilename = "shutdown_computers.bat";

    public void RestartComputers()
    {
        RunBatchFile("test.bat");        
    }

    public void Shutdown()
    {
        RunBatchFile("test.bat");
    }

    public void UpdateVolume(float volume)
    {
    }

    void RunBatchFile(string filename)
    {
        System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo();
        processInfo.UseShellExecute = false;
        processInfo.RedirectStandardOutput = true;
        processInfo.CreateNoWindow = true;
        processInfo.FileName = Application.dataPath + "\\" + filename;
        processInfo.WorkingDirectory = Application.dataPath;

        System.Diagnostics.Process process = System.Diagnostics.Process.Start(processInfo);
    }
}
