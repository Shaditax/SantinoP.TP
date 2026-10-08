using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    [SerializeField] private Transform objetivo;

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - objetivo.position;
    }

    private void FixedUpdate()
    {
        transform.position = objetivo.position + offset;
    }
}
