using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

public class CameraHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private RawImage cameraPreview;
    private WebCamTexture webCamTexture;
    private void Start()
    {
        StartCamera();
    }

    //hdtjearethbaterh
    private void StartCamera()
    {
        if (WebCamTexture.devices.Length == 0)
        {
            Debug.LogWarning("No devices found");
            return;
        }

        WebCamDevice cameraDevice = WebCamTexture.devices [0];

        webCamTexture  = new WebCamTexture(cameraDevice.name);
        cameraPreview.texture = webCamTexture;

        webCamTexture.Play();
    }


    private void OnDisable()
    {
        if (webCamTexture != null && webCamTexture.isPlaying)
        {
            webCamTexture.Stop();
        }
    }
}
