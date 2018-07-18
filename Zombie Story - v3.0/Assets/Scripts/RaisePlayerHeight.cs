using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaisePlayerHeight : MonoBehaviour {

    //private float defaultHeight = 0.0f;                 // the default heigh of the player when they are standing up on their feet
    private Vector3 standingHeight = new Vector3 (0,0,0); // Vector3 for the player's standing height
    public float damping = 5.0f;                          // variable to smooth the transition

    #region Raise Player's Height
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            standingHeight = new Vector3(other.transform.position.x, 0, other.transform.position.z);
            other.transform.position = Vector3.Lerp(transform.position, standingHeight, Time.deltaTime * damping);
        }
    }
    #endregion
}
