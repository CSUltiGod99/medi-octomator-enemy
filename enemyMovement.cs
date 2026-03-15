// Octomator enemy manager:
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
    
    
       _rigidbody = GetRigidbody(); // Change this line its uses AddForce '_rigidbody.AddForce(0, 0, 9);
    }
  }
  
  void Animate()
  {

  }
  

}
