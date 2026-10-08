using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movimiento")]
    [SerializeField] private float fuerzaMovimiento = 10f;
    [SerializeField] private float fuerzaSalto = 6f;

    private Rigidbody rb;
    private Vector3 direccionMovimiento;
    private bool tocandoPiso;
    private bool quiereSaltar;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        direccionMovimiento = new Vector3(horizontal, 0, vertical).normalized;

        if (Input.GetKeyDown(KeyCode.Space) && tocandoPiso)
        {
            quiereSaltar = true;
        }

    }

    private void FixedUpdate()
    {
        rb.AddForce(direccionMovimiento * fuerzaMovimiento);

        if (quiereSaltar)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);

            quiereSaltar = false;
            tocandoPiso = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            tocandoPiso = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            tocandoPiso = false;
        }
    }
}
