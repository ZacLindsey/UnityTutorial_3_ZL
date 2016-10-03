using UnityEngine;
using System.Collections;

public class rotatorandStuff : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere*10.0f;
    }
}
