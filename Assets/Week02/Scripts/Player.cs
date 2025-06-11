using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAD176.P1.ClassActivities.Week2.NerfGunSystem
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private Inventory inventory;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                // eNABLE item in inventory
                inventory.EquipNerfGun();
            }
        }
    }
}
