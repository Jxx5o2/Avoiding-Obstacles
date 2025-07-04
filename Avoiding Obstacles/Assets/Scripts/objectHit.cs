using UnityEngine;

public class objectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Something hit me!");
    }
}
