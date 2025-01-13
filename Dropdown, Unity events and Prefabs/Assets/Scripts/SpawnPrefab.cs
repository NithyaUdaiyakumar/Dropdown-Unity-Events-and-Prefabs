using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnPrefab : MonoBehaviour
{
    public TMP_Dropdown dropdown; // Assign your Dropdown UI element
    public GameObject[] prefabs; // Assign the prefabs in the Inspector
    public Button spawnButton; // Assign your Button UI element

    void Start()
    {
        // Add listener to spawn button
        spawnButton.onClick.AddListener(SpawnSelectedPrefab);
    }

    void SpawnSelectedPrefab()
    {
        int selectedIndex = dropdown.value;

        if (selectedIndex >= 0 && selectedIndex < prefabs.Length)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-5f, 5f), 0,Random.Range(-5f, 5f));

            Instantiate(prefabs[selectedIndex], randomPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Invalid selection or prefab not assigned.");
        }
    }
}
