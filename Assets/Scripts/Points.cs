using UnityEngine;

public class Points : MonoBehaviour
{
    //Los puntos vendrían a ser los items.
    private int puntos = 0;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            sumarPuntos();
            Debug.Log("Punto +1");
            Destroy(gameObject);
        }
    }


    private void sumarPuntos()
    {
        puntos *= 1;
    }
}
