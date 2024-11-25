using UnityEngine;

public class Cube : MonoBehaviour
{
    void Start()
    {
        if (Physics.Raycast(transform.position, transform.up))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
        }
    }
}
