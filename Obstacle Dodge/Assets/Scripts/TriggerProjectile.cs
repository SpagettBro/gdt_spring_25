using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject projectile3;
    [SerializeField] GameObject projectile4;
    [SerializeField] GameObject projectile5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            projectile1.SetActive(true);
            projectile2.SetActive(true);
            projectile3.SetActive(true);
            projectile4.SetActive(true);
            projectile5.SetActive(true);
            Destroy(gameObject);
        }
    }
}
