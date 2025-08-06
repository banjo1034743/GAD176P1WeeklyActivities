using UnityEngine;

namespace GAD176.P2.ClassActivities.Week10.Holograms
{
    public class Hologram : MonoBehaviour
    {
        [SerializeField] private int health = 2;
        [SerializeField] private static float speed = 10f;

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

        private void Start()
        {
            //print("GameObject name: " + gameObject.name + ". Health (normal): [" + health + "] . Speed (static): [" + speed + "].");

            speed = Random.Range(1, 10);

            print("GameObject name: " + gameObject.name + " . Speed (static): [" + speed + "].");
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                print("GameObject name: " + gameObject.name + " . Speed (static): [" + speed + "].");
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                print("Game time: " + GameManager.Instance.gameTime);
            }
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
