using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnPrefab : MonoBehaviour
{
    public TMP_Dropdown dropdown; 
    public GameObject[] prefabs; 
    public Button spawnButton; 

    void Start()
    {
        spawnButton.onClick.AddListener(SpawnSelectedPrefab);
    }

    void SpawnSelectedPrefab()
    {
        int selectedIndex = dropdown.value;

        if (selectedIndex >= 0 && selectedIndex < prefabs.Length)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), 0,Random.Range(-5f, 5f));
            Instantiate(prefabs[selectedIndex], randomPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Invalid selection or prefab not assigned.");
        }
    }
}
