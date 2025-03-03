using UnityEngine;

public class Portals : MonoBehaviour
{

    public Portals otherPortal;
    public bool isWorking = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isWorking)
        {

            otherPortal.isWorking = false;
            if (collision.gameObject.GetComponent<BallController>() != null)
            {

                collision.gameObject.transform.position = otherPortal.transform.position;   
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        isWorking = true ;  
    }
}