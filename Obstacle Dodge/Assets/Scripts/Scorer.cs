using UnityEngine;

public class Scorer : MonoBehaviour
{
    int Hits = 0;
    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag != "Hit"){
            Hits++;
            other.gameObject.tag = "Hit";
        }
        Debug.Log("You have bumped into this many blocks: " + Hits);

    }
}
