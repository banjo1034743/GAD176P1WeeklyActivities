using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAD176.P1.ClassActivities.Week2.NerfGunSystem
{
    public class NerfGun : MonoBehaviour
    {
        // Properties needed
        // Can hold up to 2
        [SerializeField] private float ammunitionCapacity = 2;
        // Deals 1 damage points
        [SerializeField] private int dartDamage = 1;

        // Functionalities needed

        // Can fire bullets. Bullets fired from Nerf Gun can be fired at others, damagaing them
        public void FireDart()
        {
            Debug.Log("Fired dart from " + gameObject.name);
        }
        // Bullets can be replenished to continue firing at others
        public void Reload()
        {
            Debug.Log("Reloaded darts for " + gameObject.name);
        }
    }
}
