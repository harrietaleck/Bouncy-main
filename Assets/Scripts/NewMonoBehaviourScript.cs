using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    //variables
    //boolean
    //int
    //string
    //char
    //float
    //double
    //Datetime


    //Global variables

    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    /// t
    [SerializeField]

    public bool MyBool = false;

    float Maxsize = 1.0f;
    float Minsize = 1.0f;




    // Start is called once before the first execution of Update after the MonoBehaviour is created   
    private void Awake()
    {

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        //gameObject.transform.Scale = 1.0f;

        if(Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Hie");

        }
        if (MyBool)
        {

            //Rotate object using x axis 
            
            gameObject.transform.Rotate(new Vector3(-10.0f, -1.0f, 0.0f));
            gameObject .transform.localScale = Vector3.one;
        } 
    }
}


