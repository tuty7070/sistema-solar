using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacao : MonoBehaviour
{
    public float rot;
    // Start is called before the first frame update
    void Start()
    {
      print("hello wrold");  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rot, 0);
    }
}
