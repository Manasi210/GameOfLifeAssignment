using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousZombieShooter : MonoBehaviour
{
    public GameObject gun;              // The gun object from which the ray will shoot
    public float shootRange = 10f;      // How far the ray will go
    public ZombieKillCounter killCounter; // Reference to the kill counter

    void Update()
    {
        // Continuously call the ShootZombie method every frame
        ShootZombie();
    }

    void ShootZombie()
    {
        RaycastHit hit;

        // Cast a ray from the gun's position going forward
        if (Physics.Raycast(gun.transform.position, gun.transform.forward, out hit, shootRange))
        {
            // Check if the hit object has the tag "Zombie"
            if (hit.collider.CompareTag("Zombie"))
            {
                // Instantiate the death effect at the zombie's position
                Destroy(hit.collider.gameObject);  // Destroy the zombie object

                // Update the kill counter
                killCounter.ZombieKilled();
            }
        }
    }
}
