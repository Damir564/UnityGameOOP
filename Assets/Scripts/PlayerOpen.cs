using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOpen : MonoBehaviour
{
    [SerializeField]
    private GameObject scratch;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GameObject.FindObjectOfType<BE2_InstructionBase>());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.E))
        {
            scratch.SetActive(true);
            //scratch.GetComponent<Renderer>().enabled = true;
        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            scratch.SetActive(false);
            //scratch.GetComponent<Renderer>().enabled = false;
        }
    }
}
