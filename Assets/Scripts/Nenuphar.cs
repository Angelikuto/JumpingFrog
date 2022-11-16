using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nenuphar : MonoBehaviour
{
    [SerializeField] float limite = 0;
    [SerializeField] float spawn = 5;
    Rigidbody rb;
    public float vitesse = -1;
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, vitesse) * Time.deltaTime);

        if(transform.position.z <= limite)
        {

            float height = Random.Range(0f, 1.2f);
            transform.position = new Vector3(0, 0, spawn);

        }
    }
    /*private void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, vitesse);
    }*/
}
