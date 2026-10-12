using TMPro;
using UnityEngine;

public class ItemCollection : MonoBehaviour
{
    private int items = 0;

    public TextMeshProUGUI textoItem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Item")
        {
            items++;
            textoItem.text = "Llaves: " + items.ToString();
            Destroy(other.gameObject);
        }

        if (items >= 5 && other.transform.tag == "Portón")
        {
            Destroy(other.gameObject);
        }
    }


    void Update()
    {

    }
}
