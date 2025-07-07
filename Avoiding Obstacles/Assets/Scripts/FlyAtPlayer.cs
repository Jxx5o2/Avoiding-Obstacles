using System.Numerics;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float flyingSpeed = 0.1f;
    UnityEngine.Vector3 playerPosition; // 플레이어의 위치를 나타내는 변수 (Vector3 타입의 PlayerPosition이라는 변수)

    void Start()
    {
        playerPosition = player.transform.position;
    }


    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }

    }

    void MoveToPlayer()
    {
        transform.position =
        UnityEngine.Vector3.MoveTowards(transform.position, playerPosition, flyingSpeed * Time.deltaTime);
    }
}
