using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0.0f;
    [SerializeField] float yAngle = 2.0f;
    [SerializeField] float zAngle = 0.0f;
    
    void Start()
    {
        
    }

        void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
