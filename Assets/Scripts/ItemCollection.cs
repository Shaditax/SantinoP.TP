using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemCollection : MonoBehaviour
{
    public int item = 0;

    public TextMeshProUGUI textoItem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Item")
        {
            item++;
            textoItem.text = "Llaves: " + item.ToString();
            Destroy(other.gameObject);
        }

    }


    void Update()
    {
        if (item >= 8)
        {
            SceneManager.LoadScene("Ganaste");
        }
    }
}
