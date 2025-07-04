using UnityEngine;

public class objectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
    }
}
