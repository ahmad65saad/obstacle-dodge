using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float flySpeed = 1.0f;
    [SerializeField] Transform player;
    Vector3 playerPosition;
    void Start()
    {
        playerPosition = player.transform.position;
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * flySpeed);
        DestroyOnImpact();

    }
    void DestroyOnImpact()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
