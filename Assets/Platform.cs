using UnityEngine;

public class Platform : MonoBehaviour
{
    new public Rigidbody rigidbody;
    public float duration;
    public float distance;
    Vector3 start;

    private void Start()
    {
        start = transform.position;
    }

    private void Update()
    {
        Vector3 position = start + Vector3.up * Mathf.PingPong(Time.time, duration) * distance;
        rigidbody.MovePosition(position);
    }
}
