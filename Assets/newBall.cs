using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newBall : MonoBehaviour
{
    public ballPrefab ballprefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.RawButton.RIndexTrigger)) {
            ballPrefab ball = Instantiate<ballPrefab>(ballprefab, new Vector3(2f, 1.1f, -10f), Quaternion.identity);
        }
    }
}
