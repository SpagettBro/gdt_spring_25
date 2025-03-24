using System.Xml.Schema;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    
    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }

    //-------- Methods --------

    void PrintInstructions()
    {
        Debug.Log("Welcome");
        Debug.Log("Use arrows and WASD to move.");
        Debug.Log("Don't touch the blocks!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; 

        transform.Translate(xValue, yValue, zValue);
    }
}
