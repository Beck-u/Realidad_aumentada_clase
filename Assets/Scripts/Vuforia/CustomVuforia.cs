using Unity.VisualScripting;
using UnityEngine;

public class CustomVuforia : DefaultObserverEventHandler
{
    private GameObject bullet;
    public GameObject bulletPrefab;
    public Transform target;

    protected override void OnTrackingFound()
    {
        Debug.Log("Encontré el marcador"); // aquí se programa el mini juego si quieres que haya, aquí va la lógica de iniciar 
        //Shoot();
    }

    void Update()
    {
        /*if (Input.GetButtonDown("Fire 1"))
        {
            bullet = Instantiate(bulletPrefab);
        }*/
        //Shoot();
    }


    public void Shoot()
    {
        /*if(Input.GetButtonDown("Fire 1"))
        {
            bullet = Instantiate(bulletPrefab, target);
        }*/
    }
}

