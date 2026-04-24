// Octomator enemy manager:
// source code:
using System.Collections;
using System.Collections.Generic;
using UnityEngine:

public class enemyMove : MonoBehaviour {
  // variables: 
      
    public int flyingTime = 10.0f;
    public int flyEndTime = 13.0f;

    public Rigidbody _rigidbody;
  
  void Start()
  {
     _rigidbody = GetComponent<Rigidbody>();
      flyingTime = 11.0f;
  }

  void Update()
  {
     _rigidbody.AddForce(1, 0, 9);

    if(flyingTime == 10f)
    {
        !flyingTime = new flyingTime 11.0f;
        Debug.Log("Current flying time: ");
    }
  }
}
