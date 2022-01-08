using OpenCVForUnity.UnityUtils.Helper;
using System.IO;
using UnityEngine;

public class Photobooth : MonoBehaviour
{

    public WebCamTextureToMatHelper CamTextureToMatHelper;

    private int snapCount = 0;

    private void Start()
    {
        PlayerPrefs.DeleteAll();
        snapCount = PlayerPrefs.GetInt("snapCount");
    }

    public void SavePhotoToDisk()
    {
        snapCount++;
        PlayerPrefs.SetInt("snapCount", snapCount);

        string directory = Application.dataPath + "/../Photos/";

        if (!Directory.Exists(directory))
            Directory.CreateDirectory(directory);

        ScreenCapture.CaptureScreenshot(directory + "snap_" + snapCount + ".jpg");
    }

}
