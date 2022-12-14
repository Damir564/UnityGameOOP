using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOpen : MonoBehaviour
{
    // [SerializeField]
    // private GameObject scratch;
    [SerializeField]
    private Transform _startPoint;

    private bool _isEnteredEndTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(GameObject.FindObjectOfType<BE2_InstructionBase>());
    }
    
    public void StartPosition()
    {
        transform.position = _startPoint.position;
        transform.rotation = _startPoint.rotation;
    }

    public bool GetIsEnteredEndTrigger()
    {
        // Debug.Log("GetIsEnteredEndTrigger() returned: " + _isEnteredEndTrigger);
        return _isEnteredEndTrigger;
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag.Equals("Finish"))
        {
            _isEnteredEndTrigger = true;
            Debug.Log("TrigerEntered");
        }
    }
    void OnTriggerExit (Collider other)
    {
        if (other.tag.Equals("Finish"))
        {
            _isEnteredEndTrigger = false;
            Debug.Log("TrigerExit");
        }
    }
    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.E))
        // {
        //     scratch.SetActive(true);
        //     //scratch.GetComponent<Renderer>().enabled = true;
        // }
        // else if (Input.GetKey(KeyCode.Escape))
        // {
        //     scratch.SetActive(false);
        //     //scratch.GetComponent<Renderer>().enabled = false;
        // }
    }
}
