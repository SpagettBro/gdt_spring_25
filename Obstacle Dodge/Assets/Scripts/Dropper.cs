using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timer = 3f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        FallAfterTimer();
    }
    
    void FallAfterTimer()
    {
        if(Time.time > timer ){
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }
}
