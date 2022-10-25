using OpenCover.Framework.Model;
using System.IO;
using System.Text;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController player;
    public float mass = 1.0f;
    internal Vector3 velocity;
    private float speed = 2.0f;
    private float jumpHeight = 1.0f;
    bool grounded = false;

    void Update()
    {
        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * Physics.gravity.y);
        }

        velocity.y += Physics.gravity.y * Time.deltaTime;
        player.Move(velocity * Time.deltaTime);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        grounded = true;
        Rigidbody other = hit.rigidbody;
        velocity = other.velocity;
        player.transform.position += hit.moveDirection * hit.moveLength;
    }
}
