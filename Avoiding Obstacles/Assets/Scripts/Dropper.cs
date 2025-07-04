using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeTowait = 2f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeTowait)
        {
            myRigidbody.useGravity = true;
            myMeshRenderer.enabled = true;
        }
    }
}