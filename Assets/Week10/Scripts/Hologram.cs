using UnityEngine;

namespace GAD176.P2.ClassActivities.Week10.Holograms
{
    public class Hologram : MonoBehaviour
    {
        private void OnEnable()
        {
            Debug.Log("Enabled");
            //HologramEvents.OnSpacebarPressed?.AddListener(HideTheHologram);
            HologramEvents.onSpacebarPressed += HideTheHologram;
            HologramEvents.onZButtonPressed += ShowTheHologram;
        }

        private void OnDisable()
        {
            //HologramEvents.OnSpacebarPressed?.RemoveListener(HideTheHologram);
            HologramEvents.onSpacebarPressed -= HideTheHologram;
            HologramEvents.onZButtonPressed -= ShowTheHologram;
        }

        private void HideTheHologram()
        {
            //gameObject.SetActive(false);
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }

        private void ShowTheHologram()
        {
            //gameObject.SetActive(true);
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
