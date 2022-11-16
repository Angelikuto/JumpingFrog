using DG.Tweening;
using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour

{
    Rigidbody rb;
    public float vitesse;

    private bool willjump;

    [SerializeField] int saut = 2;

    [SerializeField] DynamicJoystick joystick;

    private Vector3 slideDirection;

    [SerializeField] float slideSpeed = 2f;

    [SerializeField] float decceleration = 2;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        MoveForward();
    }

    void MoveForward()
    {
        transform.DOMoveZ(transform.position.z + 5, 1f).SetEase(Ease.Linear);
        transform.DOMoveY(transform.position.y + 3, 0.5f).SetEase(Ease.OutQuad);
        transform.DOMoveY(transform.position.y, 0.5f)
            .SetDelay(0.5f)
            .SetEase(Ease.InQuad)
            .OnComplete(MoveForward);


       
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(0, 0, vitesse) * Time.deltaTime);
        if (joystick.Direction.magnitude >0)
        {
            //willjump = true;

            slideDirection = new Vector3(joystick.Direction.x,0,0).normalized;
        }
        else
        {
           //slideSpeed = Mathf.Lerp(slideSpeed, 0, decceleration);
        }

    }

    private void FixedUpdate()
    {
        if (willjump == true)
        {
           rb.velocity = new Vector3(0, saut, 0);
            willjump = false;
            Debug.Log(willjump);
        }
        else
        {
            rb.velocity = new Vector3(0,0,0) ;
        }

        rb.velocity = slideDirection * slideSpeed;

    }

}
