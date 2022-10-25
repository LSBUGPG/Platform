using System.IO;
using UnityEngine;

public class Log : MonoBehaviour
{
    public Rigidbody platform;
    public CharacterController player;

    StreamWriter log;

    void Start()
    {
        log = new StreamWriter("log.csv");
        log.WriteLine("Platform, Player");
    }

    void Update()
    {
        log.WriteLine($"{platform.velocity.y}, {player.velocity.y}");
    }

    private void OnDestroy()
    {
        log.Close();
    }
}
