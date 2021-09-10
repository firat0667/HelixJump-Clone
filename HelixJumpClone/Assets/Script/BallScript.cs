using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public GameObject splashPrefab;
    private Gamemanager gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<Gamemanager>();
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f,-0.2f,0f), transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);
        rb.AddForce(Vector3.up * jumpForce);
        string metarialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Materia__name: " + metarialName);
        if(metarialName=="SafeColor (Instance)")
        {

        }
        else if(metarialName== "Yellow (Instance)")
        {
            gm.RestartGame();
            Debug.Log("Game Over");
        }
        else if (metarialName== "FinishColor (Instance)")
        {
            Debug.Log("NextLevel");
        }
    }
}
