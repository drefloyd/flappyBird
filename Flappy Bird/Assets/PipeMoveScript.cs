using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float pipeSpeed;
    private float endOfScreen = -35;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipeSpeed) * Time.deltaTime;

        if (transform.position.x < endOfScreen)
        {
            Debug.Log("Pipe Deleted!");
            Destroy(gameObject);
        }
    }
}
