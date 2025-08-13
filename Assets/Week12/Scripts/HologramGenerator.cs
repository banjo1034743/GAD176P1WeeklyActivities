using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GAD176.P2.ClassActivities.Week10.Holograms;

public class HologramGenerator : MonoBehaviour
{
    private Vector3 _positionToGenerateHologram = Vector3.zero;

    private int _amountToMoveGenerationPositonForward = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject retrievedHologram = HologramPoolManager.Instance.GetPooledHologram().gameObject;

            Debug.Log("Generated hologram: " + retrievedHologram.name);
            retrievedHologram.transform.position = new Vector3(_positionToGenerateHologram.x, _positionToGenerateHologram.y, _positionToGenerateHologram.z + _amountToMoveGenerationPositonForward);
            retrievedHologram.gameObject.SetActive(true);

            _amountToMoveGenerationPositonForward++;
        }
    }
}
