using UnityEngine;
using UnityEngine.UIElements;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float projectileSpeed = 1f;
    Vector3 playerPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveToPlayer();
    }

    void moveToPlayer(){
        transform.position = Vector3.MoveTowards(transform.position ,playerPosition, Time.deltaTime * projectileSpeed);
        if(transform.position == playerPosition){
            destroyYourself();
        }
    }

    void destroyYourself(){
        Destroy(gameObject);
    }
}
