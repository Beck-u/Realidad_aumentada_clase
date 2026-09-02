using System.Drawing;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Bullet : MonoBehaviour
{
    public Transform poscam;
    public Rigidbody rb;
    public float force = 5f;
    Camera cam;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
        /*mousePos.x = mousePosition.x;
        mousePos.y = mousePosition.y;*/
    }

    // Update is called once per frame
    void Update()
    {
        /*point = cam.ScreenToWorldPoint(Input.mousePosition);
         kmpkmkmñ,m
         
         
         */
        rb.AddForce(poscam.forward * force);
    }
}
