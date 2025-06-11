using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAD176.P1.ClassActivities.Week2.NerfGunSystem
{
    public class Inventory : MonoBehaviour
    {
        // Properties
        // Holds Nerf Guns and Darts
        [SerializeField] private NerfGun[] nerfGuns;

        // Can tell the Nerf Gun to "activate" (equiped)"
        public void EquipNerfGun()
        {
            nerfGuns[0].FireDart();
        }
    }
}
