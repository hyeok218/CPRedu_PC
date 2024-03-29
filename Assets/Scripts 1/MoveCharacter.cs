using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public GameObject Mycamera;
    private Vector3 goproject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.W)) {
            Vector3 project = Vector3.Project(Mycamera.transform.forward, Vector3.up);
            goproject = Mycamera.transform.forward - project;
            goproject.Normalize();
            transform.Translate(goproject * 3.0f * Time.deltaTime);
            
        }
        if (Input.GetKey (KeyCode.S)) {
            Vector3 project = Vector3.Project(Mycamera.transform.forward, Vector3.up);
            goproject = Mycamera.transform.forward - project;
            goproject.Normalize();
            transform.Translate(goproject * -3.0f * Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.A)) {
            transform.Translate(Mycamera.transform.right * -3.0f * Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.D)) {
            transform.Translate(Mycamera.transform.right * 3.0f * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            GetComponent<Rigidbody> ().AddForce (Vector3.up * 300);
        }




    }
}
