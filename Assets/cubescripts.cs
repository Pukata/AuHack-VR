using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubescripts : MonoBehaviour
{
    Vector3 lastPosition;
    float minimumMovement = .05f;
    NetworkView networkView;

    // Use this for initialization
    void Start()
    {
        networkView = GetComponent<NetworkView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Network.isServer)
        {
            Vector3 moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            float speed = 5;
            transform.Translate(speed * moveDir * Time.deltaTime);
            if (Vector3.Distance(transform.position, lastPosition) > minimumMovement)
            {
                lastPosition = transform.position;
                networkView.RPC("SetPosition", RPCMode.Others, transform.position);
            }
        }

    }

    [RPC]
    void SetPosition(Vector3 newPosition)
    {
        transform.position = newPosition;
    }
}
