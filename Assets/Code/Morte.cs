using UnityEngine;

public class Morte : MonoBehaviour
{
    public Vector3 spawn;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("MATA"))
        {
            transform.position = spawn;
        }
    }
    void Update()
    {
        
    }
}
