using UnityEngine;

namespace GAD176.P2.ClassActivities.Week10.Holograms
{
    public class HologramManager : MonoBehaviour
    {
        // List as we dont know how many there could be
        //[SerializeField] private List<GameObject> Holograms = new List<GameObject>();

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //foreach (GameObject hologram in Holograms)
                //{
                //    hologram.SetActive(false);
                //}

                HologramEvents.onSpacebarPressed?.Invoke();
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                //foreach (GameObject hologram in Holograms)
                //{
                //    hologram.SetActive(false);
                //}

                Debug.Log("Attempt at showing holograms");
                HologramEvents.onZButtonPressed?.Invoke();
            }
        }
    }
}