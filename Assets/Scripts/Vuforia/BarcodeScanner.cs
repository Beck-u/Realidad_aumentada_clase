using UnityEngine;
using Vuforia;

public class BarcodeScanner : MonoBehaviour
{
    BarcodeBehaviour mBarCodeBehavior;
    public static string urllink; // al ser estático todas las instancias cambian a una misma (?) para que no haya demasiadas instancias.
    public GameObject Button;
    void Start()
    {
        mBarCodeBehavior = GetComponent<BarcodeBehaviour>();
    }

    void Update()
    {
        if(mBarCodeBehavior != null && mBarCodeBehavior.InstanceData != null)
        {
            urllink = mBarCodeBehavior.InstanceData.Text;
            //Debug.Log(mBarCodeBehavior.InstanceData.Text);
            Button.SetActive(true);

            if (Button == true && Input.GetButtonDown("Fire1"))
                //Debug.Log("BUTTON TRUE");
                OpenURL();
                
        }
        else
            Button.SetActive(false);
    }

    void OpenURL () // public void OnClick()
    {
        //Application.OpenURL(mBarCodeBehavior.InstanceData.Text);
        Application.OpenURL(urllink);
    }
}

/*
 
barcode behaviour detecta si lee un qr y lo guarda dentro de la variable instancedata.
m --> significa que refiere a otra clase (es la estandarización)
este script se agrega al componente de barcode outline que agregamos en el inspector 

if (Input.GetButtonDown("Fire 1"))
   Application.OpenURL(mBarCodeBehavior.InstanceData.Text);

 */