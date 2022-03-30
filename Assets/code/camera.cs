using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject mercurio;
    public GameObject venus;
    public GameObject terra;
    public GameObject marte;
    public GameObject jupiter;
    public GameObject saturno;
    public GameObject uranus;
    public GameObject netuno;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (indice == 0)
        {
            transform.position = mercurio.transform.position;
        }
        if (indice == 1)
        {
            transform.position = venus.transform.position;
        }
        if (indice == 2)
        {
            transform.position = terra.transform.position;
        }
        if (indice == 3)
        {
            transform.position = marte.transform.position;
        }
        if (indice == 4)
        {
            transform.position = jupiter.transform.position;
        }
        if (indice == 5)
        {
            transform.position = saturno.transform.position;
        }
        if (indice == 6)
        {
            transform.position = uranus.transform.position;
        }
        if (indice == 7)
        {
            transform.position = netuno.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            indice = indice - 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            indice = indice + 1;
        }
    }
}
